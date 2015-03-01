using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Drawing;
using System.Security.AccessControl;
using Image = System.Drawing.Image;
using PixelFormat = System.Drawing.Imaging.PixelFormat;

namespace MP3PlayerProject.ComponentControl
{
    /// <summary>
    /// Kod jest dość pogmatwany, ważne że, działa
    /// </summary>
    public partial class Bar : UserControl
    {
        private bool play;
        private DispatcherTimer timer;

        private int currentTimeMin;
        private int currentTimeSec;
        private int allTimeMin;
        private int allTimeSec;
        private Image fullBarImage;
        private Image emptyBarImage;

        public void SetTime(int pCurrentTimeMin,int pCurrentTimeSec,int pAllTimeMin,int pAllTimeSec)
        {
            currentTimeMin = pCurrentTimeMin;
            currentTimeSec = pCurrentTimeSec;
            allTimeMin = pAllTimeMin;
            allTimeSec = pAllTimeSec;
            CurrentTimeLabel.Content = currentTimeMin.ToString()+":"+currentTimeSec.ToString();
            LongOfSongLabel.Content = allTimeMin.ToString() + ":" + allTimeSec.ToString();
        }

        public void StartAnimation()
        {
            play = true;
            timer.Start();
        }

        public void StopAnimation()
        {
            timer.Stop();
        }
        public Bar()
        {
            InitializeComponent();
            if (System.ComponentModel.DesignerProperties.GetIsInDesignMode(this)) return;
            fullBarImage = Image.FromFile(@"../Assets/ControlImages/Bar/Bar_full.png");
            emptyBarImage = Image.FromFile(@"../Assets/ControlImages/Bar/Bar_empty.png");
            play = false;
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(0.05);
            timer.Tick += playAnimation;
        }

        /// <summary>
        /// Skleja odpowiednio pasek postępu
        /// </summary>
        private unsafe void SetBarImageCorrect()
        {
            Bitmap toRetBitmap = new Bitmap(fullBarImage.Width, fullBarImage.Height, fullBarImage.PixelFormat);
            Graphics g = Graphics.FromImage(toRetBitmap);
            float stosunek = (float)((float)(currentTimeMin * 60) + (float)(currentTimeSec) + pom) / (float)(allTimeMin * 60 + allTimeSec);
            g.DrawImageUnscaledAndClipped(emptyBarImage, new System.Drawing.Rectangle( 0, 0, fullBarImage.Width, fullBarImage.Height));            
            g.DrawImageUnscaledAndClipped(fullBarImage, new System.Drawing.Rectangle(0, 0, (int)((float)fullBarImage.Width * stosunek), fullBarImage.Height));
            BitmapImage helpImage = Bitmap2BitmapImage(toRetBitmap); 
            BarImg.Source = helpImage;
        }

        private int ile=0;
        public float pom = 0.0f;
        public void playAnimation(object obj, EventArgs ea)
        {
            //kod jest tak pogmatwany tu ponieważ nie udaje mi się ustawić prawidłowo punktu wobec którego następuje translacja, automatycznie jest to środek grida
            SetBarImageCorrect();
            int longOfBar = (int)KnobImg.Width;
            float x = (float)((float)(currentTimeMin*60) + (float)(currentTimeSec)+pom)/(float)(allTimeMin*60 + allTimeSec);
            float y;//pomocnicza
            if (x >= 0.5)
            {
                y = x - (float)0.5;
                y *= 2;
                KnobImg.RenderTransform = new TranslateTransform((BarImg.ActualWidth/2)*y, BarImg.ActualHeight / 15);
            }
            else if (x < 0.5)
            {
                y = (float) 0.5 - x;
                y *= 2;
                KnobImg.RenderTransform = new TranslateTransform(-(BarImg.ActualWidth / 2) * y, BarImg.ActualHeight / 15);
            }
            if (currentTimeSec < 10) CurrentTimeLabel.Content = currentTimeMin.ToString() + ":0" + currentTimeSec.ToString();
            else CurrentTimeLabel.Content = currentTimeMin.ToString() + ":" + currentTimeSec.ToString();
            if (currentTimeMin == allTimeMin && currentTimeSec == allTimeSec) {StopAnimation();play=false;}
            pom += 0.05f;
            if (pom >= 1.0f)
            {
                currentTimeSec++;
                pom -= 1.0f;
            }
            if (currentTimeSec == 60)
            {
                currentTimeMin++;
                currentTimeSec = 0;
            }

            // int x=
        }

        private void BarImg_SizeChanged(object sender, SizeChangedEventArgs e)
        {
           // KnobImg.RenderTransformOrigin=new Point(-e.NewSize.Width/2,e.NewSize.Height/2);
           // KnobImg.RenderTransform=new TranslateTransform(-e.NewSize.Width/4,e.NewSize.Height/15);
        }

        private void BarImg_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            double g=e.GetPosition(BarImg).X;
            double j = (g / BarImg.ActualWidth) * (float)(allTimeMin * 60 + allTimeSec);
            currentTimeMin = (int)j/60;
            //j = (int)j/60;
            currentTimeSec = (int) j%60;
            if(play==false)StartAnimation();
        }

        public int pom2 = 0;

        public bool mouseInGrid=true;

        public bool knobIsPressed = false;

        public void KnobImg_MouseMove(object sender, MouseEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
            {
                StopAnimation();
                double g = e.GetPosition(BarImg).X;
                if (g < 0||g>BarImg.ActualWidth) return;//zabezpieczenie by nie wyjechać knobem po za skalę
                double j = (g / BarImg.ActualWidth) * (float)(allTimeMin * 60 + allTimeSec);
                currentTimeMin = (int)j / 60;
                //j = (int)j/60;
                currentTimeSec = (int)j % 60;
                pom -= 0.05f;
                playAnimation(null,null);
                pom2 = 1;
                knobIsPressed = true;
            }
            else if (pom2 == 1&&play==true)
            {
                pom2 = 0;
                StartAnimation();
            }
        }

        public void KnobImg_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (pom2 == 1 && play == true)
            {
                pom2 = 0;
                StartAnimation();
            }
        }


        private Bitmap BitmapImage2Bitmap(BitmapImage bitmapImage)
        {
            using (MemoryStream outStream = new MemoryStream())
            {
                BitmapEncoder enc = new BmpBitmapEncoder();
                enc.Frames.Add(BitmapFrame.Create(bitmapImage));
                enc.Save(outStream);
                System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(outStream);

                return new Bitmap(bitmap);
            }
        }

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern bool DeleteObject(IntPtr hObject);

        private BitmapImage Bitmap2BitmapImage(Bitmap bitmap)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                bitmap.Save(stream, ImageFormat.Png); // Was .Bmp, but this did not show a transparent background.

                stream.Position = 0;
                BitmapImage result = new BitmapImage();
                result.BeginInit();
                // According to MSDN, "The default OnDemand cache option retains access to the stream until the image is needed."
                // Force the bitmap to load right now so we can dispose the stream.
                result.CacheOption = BitmapCacheOption.OnLoad;
                result.StreamSource = stream;
                result.EndInit();
                result.Freeze();
                return result;
            }
        }

        private void Grid_MouseLeave(object sender, MouseEventArgs e)
        {
            mouseInGrid = false;
            if (Mouse.LeftButton == MouseButtonState.Pressed)
            {
                knobIsPressed = true;
            }
        }

        private void Grid_MouseEnter(object sender, MouseEventArgs e)
        {
            mouseInGrid = true;
        }



    }
}
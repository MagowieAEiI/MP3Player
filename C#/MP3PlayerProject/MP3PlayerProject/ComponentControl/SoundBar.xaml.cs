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
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Image = System.Drawing.Image; 

namespace MP3PlayerProject.ComponentControl
{
    /// <summary>
    /// Interaction logic for SoundBar.xaml
    /// </summary>
    public partial class SoundBar : UserControl
    {
        private Image fullBarImage;
        private Image emptyBarImage;
        private int SoundLoudLevel=40;

        public void setSoundLoudLevel(int pSoundLoudLevel)
        {
            SoundLoudLevel = pSoundLoudLevel;
            SetBarImageCorrect();
        }
        public SoundBar()
        {
            InitializeComponent();
            if (System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))return ;
            emptyBarImage = Image.FromFile(@"../Assets/ControlImages/Bar/Bar_empty.png");
            fullBarImage = Image.FromFile(@"../Assets/ControlImages/Bar/Bar_full.png");
        }
        private void SetBarImageCorrect()
        {
            Bitmap toRetBitmap = new Bitmap(fullBarImage.Width, fullBarImage.Height, fullBarImage.PixelFormat);
            Graphics g = Graphics.FromImage(toRetBitmap);
            g.DrawImageUnscaledAndClipped(emptyBarImage, new System.Drawing.Rectangle(0, 0, fullBarImage.Width, fullBarImage.Height));
            g.DrawImageUnscaledAndClipped(fullBarImage, new System.Drawing.Rectangle(0, 0, (int)((float)fullBarImage.Width * (float)SoundLoudLevel/100.0f), fullBarImage.Height));
            BitmapImage helpImage = Bitmap2BitmapImage(toRetBitmap);
            BarImg.Source = helpImage;

            int longOfBar = (int)KnobImg.Width;
            float x = (float)SoundLoudLevel/100;
            float y;//pomocnicza
            if (x >= 0.5)
            {
                y = x - (float)0.5;
                y *= 2;
                KnobImg.RenderTransform = new TranslateTransform((BarImg.ActualWidth / 2) * y, BarImg.ActualHeight / 15);
            }
            else if (x < 0.5)
            {
                y = (float)0.5 - x;
                y *= 2;
                KnobImg.RenderTransform = new TranslateTransform(-(BarImg.ActualWidth / 2) * y, BarImg.ActualHeight / 15);
            }
        }

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

        private void KnobImg_OnLoaded(object sender, RoutedEventArgs e)
        {
            SetBarImageCorrect();
        }
    }
}

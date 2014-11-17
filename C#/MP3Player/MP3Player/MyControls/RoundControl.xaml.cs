using System;
using System.Collections.Generic;
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

namespace MP3Player.MyControls
{
    /// <summary>
    /// Interaction logic for RoundControl.xaml
    /// </summary>
    public partial class RoundControl : UserControl
    {
        public RoundControl()
        {
            InitializeComponent();
        }
        public static readonly DependencyProperty ImageSourceProperty =
    DependencyProperty.Register("ImageSource", typeof(ImageSource),
    typeof(RoundControl), new FrameworkPropertyMetadata(null));

        public ImageSource ImageSource
        {
            get { return GetValue(ImageSourceProperty) as ImageSource; }
            set { SetValue(ImageSourceProperty, value); }
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            //Img1 = new Image();
            //Img1.Source = new BitmapImage(new Uri(@"../MyControlsImages/prev.png", UriKind.Relative));
            string oldPath=Img1.Source.ToString();
            int war = oldPath.IndexOf(";component/") + ";component/".Length;
            string newPath="";//string z adresem do obrazka który ma być nadpisany
            for (int x = war; x < oldPath.Length-1;x++)
            {
                newPath += oldPath[x];
            }
            StringBuilder str = new StringBuilder(newPath);
            str[str.Length-3] = '2';
            str[str.Length-2]='.';
            str[str.Length-1]='p';
            //str[str.Length] = 'n';
           // SetValue(ImageSourceProperty, str);
            Img1.Source = new BitmapImage(new Uri("../"+str.ToString()+"ng", UriKind.Relative));
            //MessageBox.Show(str.ToString()+"ng");
        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            string oldPath = Img1.Source.ToString();
            int war = oldPath.IndexOf(";component/") + ";component/".Length;
            string newPath = "";//string z adresem do obrazka który ma być nadpisany
            for (int x = war; x < oldPath.Length - 1; x++)
            {
                newPath += oldPath[x];
            }
            StringBuilder str = new StringBuilder(newPath);
            str[str.Length - 4] = '.';
            str[str.Length - 3] = 'p';
            str[str.Length - 2] = 'n';
            str[str.Length-1] = 'g';
            // SetValue(ImageSourceProperty, str);
            Img1.Source = new BitmapImage(new Uri("../" + str.ToString(), UriKind.Relative));
            //MessageBox.Show(str.ToString()+"ng");
        }

    }
}

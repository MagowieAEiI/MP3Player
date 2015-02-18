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

namespace MP3PlayerProject.StandardControl
{
    public partial class TransparentButton : UserControl
    {

        public static readonly DependencyProperty ClickMethodProperty =
     DependencyProperty.Register("ClickMethod", typeof(ImageSource),
     typeof(TransparentButton), new FrameworkPropertyMetadata(null));

        public ImageSource ClickMethod
        {
            get { return GetValue(ImageSourceMouseOutProperty) as ImageSource; }
            set
            {
                SetValue(ImageSourceMouseOutProperty, value); SetValue(ImageSourceCurrentProperty, value);
                Img1.Source = ImageSourceCurrent;
            }
        }



        //Nasza właściwość która zawiera adres do obrazka gdy nie jest nad nim mysz
        public static readonly DependencyProperty ImageSourceMouseOutProperty =
     DependencyProperty.Register("ImageSourceMouseOut", typeof(ImageSource),
     typeof(TransparentButton), new FrameworkPropertyMetadata(null));

        public ImageSource ImageSourceMouseOut
        {
            get { return GetValue(ImageSourceMouseOutProperty) as ImageSource; }
            set { SetValue(ImageSourceMouseOutProperty, value); SetValue(ImageSourceCurrentProperty, value);
                Img1.Source = ImageSourceCurrent;
            }
        }
        //Nasza właściwość która zawiera adres do obrazka gdy jest nad nim mysz
        public static readonly DependencyProperty ImageSourceMouseInProperty =
     DependencyProperty.Register("ImageSourceMouseIn", typeof(ImageSource),
     typeof(TransparentButton), new FrameworkPropertyMetadata(null));

        public ImageSource ImageSourceMouseIn
        {
            get { return GetValue(ImageSourceMouseInProperty) as ImageSource; }
            set { SetValue(ImageSourceMouseInProperty, value); }
        }
        //Nasza właściwość która zawiera aktualnie wyświetlany obrazek
        public static readonly DependencyProperty ImageSourceCurrentProperty =
     DependencyProperty.Register("ImageSourceCurrent", typeof(ImageSource),
     typeof(TransparentButton), new FrameworkPropertyMetadata(null));

        public ImageSource ImageSourceCurrent
        {
            get { return GetValue(ImageSourceCurrentProperty) as ImageSource; }
            set { SetValue(ImageSourceCurrentProperty, value); }
        }

        public TransparentButton()
        {
            InitializeComponent();
        }

        private void Img1_MouseEnter(object sender, MouseEventArgs e)
        {
            ImageSourceCurrent = ImageSourceMouseIn;
            Img1.Source = ImageSourceCurrent;
        }

        private void Img1_MouseLeave(object sender, MouseEventArgs e)
        {
            ImageSourceCurrent = ImageSourceMouseOut;
            Img1.Source = ImageSourceCurrent;
        }

    }
}

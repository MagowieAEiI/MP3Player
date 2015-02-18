using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
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

namespace MP3PlayerProject.ComponentControl
{
    /// <summary>
    /// Interaction logic for StarPanel.xaml
    /// </summary>
    public partial class StarPanel : UserControl
    {
        public int starNumber;//jest to liczba gwiazdek jaką ma dana piosenka
        public StarPanel()
        {
            InitializeComponent();
            starNumber = 0;
            Grid_MouseLeave(null,null);
        }

        private void starMouseEnter(object sender, MouseEventArgs e)
        {
            //CzyscGwiazdki();
            if (sender.Equals(star0))
            {
                star0.ImageSourceCurrent = star0.ImageSourceMouseIn;
                star0.Img1.Source = star0.ImageSourceCurrent;

                star1.ImageSourceCurrent = star1.ImageSourceMouseOut;
                star1.Img1.Source = star1.ImageSourceCurrent;

                star2.ImageSourceCurrent = star2.ImageSourceMouseOut;
                star2.Img1.Source = star2.ImageSourceCurrent;

                star3.ImageSourceCurrent = star3.ImageSourceMouseOut;
                star3.Img1.Source = star3.ImageSourceCurrent;

                star4.ImageSourceCurrent = star4.ImageSourceMouseOut;
                star4.Img1.Source = star4.ImageSourceCurrent;
            }
            else if (sender.Equals(star1))
            {
                star0.ImageSourceCurrent = star0.ImageSourceMouseIn;
                star0.Img1.Source = star0.ImageSourceCurrent;

                star1.ImageSourceCurrent = star1.ImageSourceMouseIn;
                star1.Img1.Source = star1.ImageSourceCurrent;

                star2.ImageSourceCurrent = star2.ImageSourceMouseOut;
                star2.Img1.Source = star2.ImageSourceCurrent;

                star3.ImageSourceCurrent = star3.ImageSourceMouseOut;
                star3.Img1.Source = star3.ImageSourceCurrent;

                star4.ImageSourceCurrent = star4.ImageSourceMouseOut;
                star4.Img1.Source = star4.ImageSourceCurrent;
            }
            else if (sender.Equals(star2))
            {
                star0.ImageSourceCurrent = star0.ImageSourceMouseIn;
                star0.Img1.Source = star0.ImageSourceCurrent;

                star1.ImageSourceCurrent = star1.ImageSourceMouseIn;
                star1.Img1.Source = star1.ImageSourceCurrent;

                star2.ImageSourceCurrent = star2.ImageSourceMouseIn;
                star2.Img1.Source = star2.ImageSourceCurrent;

                star3.ImageSourceCurrent = star3.ImageSourceMouseOut;
                star3.Img1.Source = star3.ImageSourceCurrent;

                star4.ImageSourceCurrent = star4.ImageSourceMouseOut;
                star4.Img1.Source = star4.ImageSourceCurrent;
            }
            else if (sender.Equals(star3))
            {
                star0.ImageSourceCurrent = star0.ImageSourceMouseIn;
                star0.Img1.Source = star0.ImageSourceCurrent;

                star1.ImageSourceCurrent = star1.ImageSourceMouseIn;
                star1.Img1.Source = star1.ImageSourceCurrent;

                star2.ImageSourceCurrent = star2.ImageSourceMouseIn;
                star2.Img1.Source = star2.ImageSourceCurrent;

                star3.ImageSourceCurrent = star3.ImageSourceMouseIn;
                star3.Img1.Source = star3.ImageSourceCurrent;

                star4.ImageSourceCurrent = star4.ImageSourceMouseOut;
                star4.Img1.Source = star4.ImageSourceCurrent;
            }
            else if (sender.Equals(star4))
            {
                star0.ImageSourceCurrent = star0.ImageSourceMouseIn;
                star0.Img1.Source = star0.ImageSourceCurrent;

                star1.ImageSourceCurrent = star1.ImageSourceMouseIn;
                star1.Img1.Source = star1.ImageSourceCurrent;

                star2.ImageSourceCurrent = star2.ImageSourceMouseIn;
                star2.Img1.Source = star2.ImageSourceCurrent;

                star3.ImageSourceCurrent = star3.ImageSourceMouseIn;
                star3.Img1.Source = star3.ImageSourceCurrent;

                star4.ImageSourceCurrent = star4.ImageSourceMouseIn;
                star4.Img1.Source = star4.ImageSourceCurrent;
            }
        }

        private void starMouseLeave(object sender, MouseEventArgs e)
        {

        }


        private void CzyscGwiazdki()
        {
            star0.ImageSourceCurrent = star0.ImageSourceMouseOut;
            star0.Img1.Source = star0.ImageSourceCurrent;
            star1.ImageSourceCurrent = star1.ImageSourceMouseOut;
            star1.Img1.Source = star1.ImageSourceCurrent;
            star2.ImageSourceCurrent = star2.ImageSourceMouseOut;
            star2.Img1.Source = star2.ImageSourceCurrent;
            star3.ImageSourceCurrent = star3.ImageSourceMouseOut;
            star3.Img1.Source = star3.ImageSourceCurrent;
            star4.ImageSourceCurrent = star4.ImageSourceMouseOut;
            star4.Img1.Source = star4.ImageSourceCurrent;
        }
        private void Grid_MouseLeave(object sender, MouseEventArgs e)
        {
            CzyscGwiazdki();
            if (starNumber >= 1)
            {
                star0.ImageSourceCurrent = star0.ImageSourceMouseIn;
                star0.Img1.Source = star0.ImageSourceCurrent;
            }
            if (starNumber >= 2)
            {
                star1.ImageSourceCurrent = star1.ImageSourceMouseIn;
                star1.Img1.Source = star1.ImageSourceCurrent;
            }
            if (starNumber >= 3)
            {
                star2.ImageSourceCurrent = star2.ImageSourceMouseIn;
                star2.Img1.Source = star2.ImageSourceCurrent;
            }
            if (starNumber >= 4)
            {
                star3.ImageSourceCurrent = star3.ImageSourceMouseIn;
                star3.Img1.Source = star3.ImageSourceCurrent;
            }
            if (starNumber >= 5)
            {
                star4.ImageSourceCurrent = star4.ImageSourceMouseIn;
                star4.Img1.Source = star4.ImageSourceCurrent;
            }
        }

        private void starMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (sender.Equals(star0))
            {
                starNumber = 1;
            }
            else if (sender.Equals(star1))
            {
                starNumber = 2;
            }
            else if (sender.Equals(star2))
            {
                starNumber = 3;  
            }
            else if (sender.Equals(star3))
            {
                starNumber = 4;
            }
            else if (sender.Equals(star4))
            {
                starNumber = 5;
            }
        }

        private void star1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void star0_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

    }
}

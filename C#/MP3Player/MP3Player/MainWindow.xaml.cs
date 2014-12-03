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

namespace MP3Player
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public int WindowHeight
        {
            set { WindowHeight = value; }
            get { return (int)(GlobalValue.screenHeight*0.5); }
        }

        public int WindowWidth
        {
            set { WindowWidth = value; }
            get { return (int)(GlobalValue.screenWidth*0.5); }
        }

        public MainWindow()
        {
            DataContext = this;
            GlobalValue.screenWidth = (int) System.Windows.SystemParameters.PrimaryScreenWidth;
            GlobalValue.screenHeight = (int)System.Windows.SystemParameters.PrimaryScreenHeight;

        }

        private void SongInfo_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            this.MainCoverFlow.mouseWheelToTransform += (float)e.Delta;
            this.MainCoverFlow.WheelAnimation();
        }

        private void SongInfo_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            int gh = 45;
        }
    }
}

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

namespace MP3PlayerProject.ComponentControl
{
    /// <summary>
    /// Interaction logic for BottomPanel.xaml
    /// </summary>
    public partial class BottomPanel : UserControl
    {
        public BottomPanel()
        {
            InitializeComponent();
            if (System.ComponentModel.DesignerProperties.GetIsInDesignMode(this)) return;
        }

        private void UIElement_OnMouseUp(object sender, MouseButtonEventArgs e)
        {
            if (Bar.knobIsPressed&&Bar.mouseInGrid==false)
            {
                Bar.KnobImg_MouseUp(sender, e);
            }
        }

        private void UIElement_OnMouseLeave(object sender, MouseEventArgs e)
        {
            if (Bar.knobIsPressed&&Bar.mouseInGrid==false)
            {
                Bar.KnobImg_MouseUp(null, null);
            }
        }

        private void UIElement_OnMouseMove(object sender, MouseEventArgs e)
        {
            if (Bar.knobIsPressed&&Bar.mouseInGrid==false)
            {
                Bar.KnobImg_MouseMove(sender, e);
            }
        }

    }
}

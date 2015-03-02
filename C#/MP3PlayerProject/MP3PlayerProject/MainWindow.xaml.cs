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
using MP3PlayerProject.ComponentControl;

namespace MP3PlayerProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            if (System.ComponentModel.DesignerProperties.GetIsInDesignMode(this)) return;
            BottomPanel.Bar.SetTime(0, 20, 2, 20);
            BottomPanel.Bar.StartAnimation();
            Paragraph1.Inlines.Add( "The Beatles – zespół rockowy z Liverpoolu, istniejący od 1960 (jako The Quarrymen od 1957) do 1970. Zespół odnosił sukcesy w składzie: John Lennon, Paul McCartney, George Harrison, Ringo Starr. Autorstwo nazwy zespołu przypisuje się Lennonowi oraz Sutcliffe’owi, którzy w kwietniu 1960 zaproponowali ją McCartneyowi oraz Harrisonowi. Cztery miesiące później, w sierpniu, tuż przed wyjazdem do Hamburga na - jak się miało okazać - obfitujące w liczne ekscesy występy, do czwórki gitarzystów dołączył perkusista Best. Jednak najbardziej emblematycznym miejscem dla Beatlesów tego okresu był liverpoolski klub The Cavern. Zdając sobie sprawę ze swych miernych talentów muzycznych, Sutcliffe odszedł z zespołu na krótko przed swą przedwczesną śmiercią, która nastąpiła 10 kwietnia 1962. Cztery miesiące później – 16 sierpnia – za namową niezadowolonego z gry Besta producenta George’a Martina, grupa w kontrowersyjnych okolicznościach zwolniła perkusistę i zastąpiła go przyjacielem zespołu – Ringo Starrem. Zespół też za namową menedżera Briana Epsteina zmienił wizerunek z niegrzecznych chłopców w skórach na garnitury. Ten etap kariery kończy podpisanie kontraktu z EMI. Na koncertach The Beatles zaczyna dochodzić do scen zbiorowej histerii. Zjawisko to nazwano Beatlemanią. Swój pierwszy album Please Please Me Beatlesi nagrali 11 lutego 1963. Kompozycja Lennona, również zatytułowana Please Please Me, stała się pierwszym hitem zespołu.");
            // Mouse.AddMouseUpHandler(null,new MouseButtonEventHandler(Function));
            //Control.MouseLeftButtonUpEvent
            //BottomPanel.ControlPanel.SoundBar.setSoundLoudLevel(40);
            //BarComponent.SetTime(0,20,2,20);
            //BarComponent.StartAnimation();
        }

        static void Function(object sender, MouseButtonEventArgs e)
        {
            
        }


        private void MainWindow_OnStateChanged(object sender, EventArgs e)
        {

            if (this.WindowState == WindowState.Maximized) ColumnDefinition1.Width = new GridLength((double)Window.Width * (1.0d / 12.0d));
        }
        
        /*
        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            Window.Height =  Window.Width/2;
            Label1.Content = System.Convert.ToString(Window.Height)+" "+ System.Convert.ToString(Window.Width);

        }*/
        public bool pom=false;
        private void MainWindow_OnSizeChanged(object sender, SizeChangedEventArgs e)
        {
            //dzięki dwóm poniższym linijką pasek ładnie się skurcza i powiększa
            BottomPanel.Bar.pom -= 0.05f;
            BottomPanel.Bar.playAnimation(null,null);
            pom = true;
        }

    }
}

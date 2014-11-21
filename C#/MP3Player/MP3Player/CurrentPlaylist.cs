using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
namespace MP3Player
{
    //zrobic singleton!
    class CurrentPlaylist
    {
        public List<BitmapImage> coverflows; 
        public CurrentPlaylist()
        {
            coverflows= new List<BitmapImage>();
            coverflows.Add(new BitmapImage(new Uri(@"SampleAlbumCover/80945949.png", UriKind.Relative)));
            coverflows.Add(new BitmapImage(new Uri(@"SampleAlbumCover/88057565.png",UriKind.Relative)));
            coverflows.Add(new BitmapImage(new Uri(@"SampleAlbumCover/88059849.png", UriKind.Relative)));
            coverflows.Add(new BitmapImage(new Uri(@"SampleAlbumCover/88059875.png", UriKind.Relative)));
            coverflows.Add(new BitmapImage(new Uri(@"SampleAlbumCover/88060027.png", UriKind.Relative)));
            coverflows.Add(new BitmapImage(new Uri(@"SampleAlbumCover/94104541.png", UriKind.Relative)));
            coverflows.Add(new BitmapImage(new Uri(@"SampleAlbumCover/101738621.png", UriKind.Relative)));

        }
    }
}

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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MP3Player.MyControls
{
    /// <summary>
    /// Interaction logic for CoverFlow.xaml
    /// </summary>
    public partial class CoverFlow : UserControl
    {
        public float mouseWheelToTransform = 0.0f;
        private ModelVisual3D[] modeleOkladek;
        private GeometryModel3D[]geometryModels;
        public CoverFlow()
        {
            InitializeComponent();
            CurrentPlaylist.addSampleSong();//w kolejnej wersji do poprawy architektura
            Initialize3D();
        }
        public int WindowHeight
        {
            set { WindowHeight = value; }
            get { return 1000; }
        }

        public int WindowWidth
        {
            set { WindowWidth = value; }
            get { return (int)(GlobalValue.screenWidth*0.5); }
        }
        public void Initialize3D()
        {
            modeleOkladek= new ModelVisual3D[3];
            geometryModels= new GeometryModel3D[3];
            for(int y=0;y<3;y++){modeleOkladek[y]=new ModelVisual3D();geometryModels[y]=new GeometryModel3D();}

            var p0 = new Point3D(-1, -1, 0);
            var p1 = new Point3D(1, -1, 0);
            var p2 = new Point3D(1, 1, 0);
            var p3 = new Point3D(-1, 1, 0);

            var mesh = new MeshGeometry3D();
            mesh.Positions.Add(p0);
            mesh.Positions.Add(p1);
            mesh.Positions.Add(p2);
            mesh.Positions.Add(p3);

            var normal = CalculateNormal(p0, p1, p2);
            mesh.TriangleIndices.Add(0);
            mesh.TriangleIndices.Add(1);
            mesh.TriangleIndices.Add(2);
            mesh.Normals.Add(normal);

            normal = CalculateNormal(p2, p3, p0);
            mesh.TriangleIndices.Add(2);
            mesh.TriangleIndices.Add(3);
            mesh.TriangleIndices.Add(0);
            mesh.Normals.Add(normal);

            var q0 = new Point(0, 0);
            var q1 = new Point(1, 0);
            var q2 = new Point(1, 1);
            var q3 = new Point(0, 1);

            mesh.TextureCoordinates.Add(q3);
            mesh.TextureCoordinates.Add(q2);
            mesh.TextureCoordinates.Add(q1);

            mesh.TextureCoordinates.Add(q0);
            mesh.TextureCoordinates.Add(q1);
            mesh.TextureCoordinates.Add(q2);

            ImageSource imSrc1 = CurrentPlaylist.coverflows[CurrentPlaylist.actualSongIndex] ;
            ImageSource imSrc2 = CurrentPlaylist.coverflows[CurrentPlaylist.actualSongIndex-1];
            ImageSource imSrc3 = CurrentPlaylist.coverflows[CurrentPlaylist.actualSongIndex - 2];

            try
            {
                geometryModels[0]=new GeometryModel3D(mesh, new DiffuseMaterial(new ImageBrush(imSrc1)));
                modeleOkladek[0].Content = geometryModels[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           // viewPort.Children.Add(modeleOkladek[0]);//pierwsza pozycja
            var transform1 = new TranslateTransform3D();
            transform1.OffsetZ = -0.7;
            transform1.OffsetX = -0.7;
            transform1.OffsetY = 0.5;
            ModelVisual3D modelTransformed1= new ModelVisual3D();
            geometryModels[1] = new GeometryModel3D(mesh, new DiffuseMaterial(new ImageBrush(imSrc2)));
            modelTransformed1.Content = geometryModels[1];
            modelTransformed1.Transform = transform1;
           // viewPort.Children.Add(modelTransformed1);

            var transform2 = new TranslateTransform3D();
            ModelVisual3D modelTransformed2 = new ModelVisual3D();
            geometryModels[2] = new GeometryModel3D(mesh, new DiffuseMaterial(new ImageBrush(imSrc3)));
            modelTransformed2.Content = geometryModels[2];
            transform2.OffsetZ = -0.7*2;
            transform2.OffsetX = -0.7*2;
            transform2.OffsetY = 0.5*2; 
            modelTransformed2.Transform = transform2;
           // viewPort.Children.Add(modelTransformed2);
            var sdf = new GeometryModel3D();
            DiffuseMaterial mat1 = (DiffuseMaterial)geometryModels[0].Material;
           // SolidColorBrush br1 = (SolidColorBrush)mat1.Brush;
            mat1.Brush.Opacity = 1;

            //br1.Opacity = 0.3;
            modeleOkladek[0].Content = geometryModels[0];
            //viewPort.Children.Add(modeleOkladek[0]);

            DiffuseMaterial mat2 = (DiffuseMaterial)geometryModels[1].Material;
           // SolidColorBrush br2 = (SolidColorBrush)mat2.Brush;
            mat2.Brush.Opacity = 0.5;
            geometryModels[1].Transform = transform1;
           // br2.Opacity = 0.3;
            modeleOkladek[1].Content = geometryModels[1];
            //viewPort.Children.Add(modeleOkladek[1]);

            DiffuseMaterial mat3 = (DiffuseMaterial)geometryModels[2].Material;
           // SolidColorBrush br3 = (SolidColorBrush)mat3.Brush;
            mat3.Brush.Opacity = 0.25;
            geometryModels[2].Transform = transform2;
            //br3.Opacity = 0.3;
            modeleOkladek[2].Content = geometryModels[2];
            viewPort.Children.Add(modeleOkladek[2]);
            viewPort.Children.Add(modeleOkladek[1]);
            viewPort.Children.Add(modeleOkladek[0]);
        }

        public void WheelAnimation()//wywoływane gdy poruszamy rolką
        {
            if (mouseWheelToTransform >= 360)
            {
                mouseWheelToTransform = 0;
                CurrentPlaylist.actualSongIndex += 1;//cofamy do nastepnej piosenki
            }
            else if (mouseWheelToTransform <= -360)
            {
                mouseWheelToTransform = 0;
                CurrentPlaylist.actualSongIndex += -1;//cofamy do poprzedniej piosenki
            }
        }
        private Vector3D CalculateNormal(Point3D p0, Point3D p1, Point3D p2)
        {
            var v0 = new Vector3D(p1.X - p0.X, p1.Y - p0.Y, p1.Z - p0.Z);
            var v1 = new Vector3D(p2.X - p1.X, p2.Y - p1.Y, p2.Z - p1.Z);
            return Vector3D.CrossProduct(v0, v1);
        }  
    }
}

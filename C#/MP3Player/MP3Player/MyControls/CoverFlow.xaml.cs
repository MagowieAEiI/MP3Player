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
        private CurrentPlaylist currentPlaylist;
        private  Model3DGroup modelGroup;  
        public CoverFlow()
        {
            InitializeComponent();
            currentPlaylist = new CurrentPlaylist();//w kolejnej wersji do poprawy architektura
            Initialize3D();
        }
        public void Initialize3D()
        {
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

            ImageSource imSrc = currentPlaylist.coverflows[0] ;
            modelGroup = new Model3DGroup();
            try
            {
                modelGroup.Children.Add(new GeometryModel3D(mesh, new DiffuseMaterial(new ImageBrush(imSrc))));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            visualModel.Content = modelGroup;
            //Content = modelGroup;  
            // models = modelGroup;
        }

        private Vector3D CalculateNormal(Point3D p0, Point3D p1, Point3D p2)
        {
            var v0 = new Vector3D(p1.X - p0.X, p1.Y - p0.Y, p1.Z - p0.Z);
            var v1 = new Vector3D(p2.X - p1.X, p2.Y - p1.Y, p2.Z - p1.Z);
            return Vector3D.CrossProduct(v0, v1);
        }  
    }
}

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

namespace tic_tac_toe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Image[,] imageCells = new Image[3,3];  
        public MainWindow()
        {
            InitializeComponent();

            imageCells[0,0] = cell_0_0;
            imageCells[0,1] = cell_0_1;
            imageCells[0,2] = cell_0_2;
            imageCells[1,0] = cell_1_0;
            imageCells[1,1] = cell_1_1;
            imageCells[1,2] = cell_1_2;
            imageCells[2,0] = cell_2_0;
            imageCells[2,1] = cell_2_1;
            imageCells[2,2] = cell_2_2;

            DrawX(0, 0);
            DrawO(0, 1);
            DrawBlank(1, 0);
        }

        // This function draws x.png into the image cell cell_i_j
        private void DrawX(int i, int j)
        {
            System.Reflection.Assembly executingAssembly = System.Reflection.Assembly.GetExecutingAssembly();

            string[] s = executingAssembly.GetManifestResourceNames();

            // Getting bytes for image "x.png" from the executingAssembly. 
            System.IO.Stream stream = executingAssembly.GetManifestResourceStream("tic_tac_toe.images.x.png");
            byte[] b = new byte[stream.Length];
            stream.Read(b, 0, (int)stream.Length);
            // b now contains the raw bytes for the image x.png. 

            var img = new BitmapImage();

            using (var mem = new System.IO.MemoryStream(b))
            {
                mem.Position = 0;
                img.BeginInit();
                img.CreateOptions = BitmapCreateOptions.PreservePixelFormat;
                img.CacheOption = BitmapCacheOption.OnLoad;
                img.UriSource = null;
                img.StreamSource = mem;
                img.EndInit();
            }
            img.Freeze();
            imageCells[i, j].Source = img;
        }

        private void DrawO(int i, int j)
        {
            System.Reflection.Assembly executingAssembly = System.Reflection.Assembly.GetExecutingAssembly();

            string[] s = executingAssembly.GetManifestResourceNames();

            // Getting bytes for image "o.png" from the executingAssembly.
            System.IO.Stream stream = executingAssembly.GetManifestResourceStream("tic_tac_toe.images.o.png");
            byte[] b = new byte[stream.Length];
            stream.Read(b, 0, (int)stream.Length);

            var img = new BitmapImage();

            using (var mem = new System.IO.MemoryStream(b))
            {
                mem.Position = 0;
                img.BeginInit();
                img.CreateOptions = BitmapCreateOptions.PreservePixelFormat;
                img.CacheOption = BitmapCacheOption.OnLoad;
                img.UriSource = null;
                img.StreamSource = mem;
                img.EndInit();
            }
            img.Freeze();
            imageCells[i, j].Source = img;
        }

        private void DrawBlank(int i, int j)
        {
            System.Reflection.Assembly executingAssembly = System.Reflection.Assembly.GetExecutingAssembly();

            string[] s = executingAssembly.GetManifestResourceNames();

            // Getting bytes for image "blank.png" from the executingAssembly.
            System.IO.Stream stream = executingAssembly.GetManifestResourceStream("tic_tac_toe.images.blank.png");
            byte[] b = new byte[stream.Length];
            stream.Read(b, 0, (int)stream.Length);

            var img = new BitmapImage();

            using (var mem = new System.IO.MemoryStream(b))
            {
                mem.Position = 0;
                img.BeginInit();
                img.CreateOptions = BitmapCreateOptions.PreservePixelFormat;
                img.CacheOption = BitmapCacheOption.OnLoad;
                img.UriSource = null;
                img.StreamSource = mem;
                img.EndInit();
            }
            img.Freeze();
            imageCells[i, j].Source = img;
        }
    }
}

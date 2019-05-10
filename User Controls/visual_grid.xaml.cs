﻿using System;
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

namespace tic_tac_toe.User_Controls
{
    /// <summary>
    /// Interaction logic for visual_grid.xaml
    /// </summary>
    public partial class visual_grid : UserControl
    {
        Image[,] imageCells = new Image[3, 3];
        public visual_grid()
        {
            InitializeComponent();

            imageCells[0, 0] = cell_0_0;
            imageCells[0, 1] = cell_0_1;
            imageCells[0, 2] = cell_0_2;
            imageCells[1, 0] = cell_1_0;
            imageCells[1, 1] = cell_1_1;
            imageCells[1, 2] = cell_1_2;
            imageCells[2, 0] = cell_2_0;
            imageCells[2, 1] = cell_2_1;
            imageCells[2, 2] = cell_2_2;

        }

        public void DrawX(int i, int j)
        {
            System.Reflection.Assembly executingAssembly = System.Reflection.Assembly.GetExecutingAssembly();

            string[] s = executingAssembly.GetManifestResourceNames();

            System.IO.Stream stream = executingAssembly.GetManifestResourceStream("tic_tac_toe.images.x.png");
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

        public void DrawO(int i, int j)
        {
            System.Reflection.Assembly executingAssembly = System.Reflection.Assembly.GetExecutingAssembly();

            string[] s = executingAssembly.GetManifestResourceNames();

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

        public void DrawBlank(int i, int j)
        {
            System.Reflection.Assembly executingAssembly = System.Reflection.Assembly.GetExecutingAssembly();

            string[] s = executingAssembly.GetManifestResourceNames();

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
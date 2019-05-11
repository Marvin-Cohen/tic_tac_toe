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

namespace tic_tac_toe.User_Controls
{
    /// <summary>
    /// Interaction logic for victory_screen.xaml
    /// </summary>
    public partial class victory_screen : UserControl
    {
        public victory_screen(string winningTeam)
        {
            InitializeComponent();

            // Value of winningTeam is expected to be "x" or "o". Otherwise, the game is a draw.

            if (winningTeam == "x" || winningTeam == "X")
            {
                ShowWinTeamX();
            }
            else if (winningTeam == "o" || winningTeam == "O")
            {
                ShowWinTeamO();
            }
            else
            {
                ShowDraw();
            }

        }

        public void ShowWinTeamX()
        {
            System.Reflection.Assembly executingAssembly = System.Reflection.Assembly.GetExecutingAssembly();

            string[] s = executingAssembly.GetManifestResourceNames();

            System.IO.Stream stream = executingAssembly.GetManifestResourceStream("tic_tac_toe.images.congratsX.jpg");
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
            VictoryMessage.Source = img;
        }

        public void ShowWinTeamO()
        {
            System.Reflection.Assembly executingAssembly = System.Reflection.Assembly.GetExecutingAssembly();

            string[] s = executingAssembly.GetManifestResourceNames();

            System.IO.Stream stream = executingAssembly.GetManifestResourceStream("tic_tac_toe.images.congratsO.jpg");
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
            VictoryMessage.Source = img;
        }

        public void ShowDraw()
        {
            System.Reflection.Assembly executingAssembly = System.Reflection.Assembly.GetExecutingAssembly();

            string[] s = executingAssembly.GetManifestResourceNames();

            System.IO.Stream stream = executingAssembly.GetManifestResourceStream("tic_tac_toe.images.drawXO.jpg");
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
            VictoryMessage.Source = img;
        }

        private void VictoryMessage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            visual_grid vg = new visual_grid();
            this.Content = vg;
        }
    }
}

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
    /// Interaction logic for welcome.xaml
    /// </summary>
    public partial class welcome : UserControl
    {
        public welcome()
        {
            InitializeComponent();
            ShowWelcomeScreen();
        }

        public void ShowWelcomeScreen()
        {
            System.Reflection.Assembly executingAssembly = System.Reflection.Assembly.GetExecutingAssembly();

            string[] s = executingAssembly.GetManifestResourceNames();

            System.IO.Stream stream = executingAssembly.GetManifestResourceStream("tic_tac_toe.images.welcome.jpg");
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
            Welcome.Source = img;
        }

        private void Welcome_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            visual_grid vg = new visual_grid();
            this.Content = vg;
        }
    }
}

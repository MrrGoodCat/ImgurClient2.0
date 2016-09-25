using ImgurClient.ImgurServise;
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

namespace ImgurClient
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int imageIngex = 0;

        public MainWindow()
        {
            InitializeComponent();
            IImgurService ImgService = new ImgurServiceClient();
            WebBrowser.Navigate(ImgService.DoWork());
        }

        public void OpenImage(string path)
        {
            WebBrowser.Navigate(path);       
        }

        private void buttonNext_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

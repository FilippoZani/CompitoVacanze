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

namespace Compito_Vacanze_TPS
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly Uri uriPesce1 = new Uri("Boomerang.png", UriKind.Relative);
        readonly Uri uriPesce2 = new Uri("FISH.png", UriKind.Relative);
        readonly Uri uriPesce3 = new Uri("Peeper.png", UriKind.Relative);
        double inizioPesce1;
        double inizioPesce2;
        double inizioPesce3;
        Random r;
        static int podio;

        public MainWindow()
        {
            InitializeComponent();
            ImageSource imgPesce1 = new BitmapImage(uriPesce1);
            ImageSource imgPesce2 = new BitmapImage(uriPesce2);
            ImageSource imgPesce3 = new BitmapImage(uriPesce3);
            inizioPesce1 = 49;
            inizioPesce2 = 49;
            inizioPesce3 = 49;
            podio = 0;
        }
    }
}

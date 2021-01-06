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
using System.Threading;

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
            ImageSource imggPesce1 = new BitmapImage(uriPesce1);
            ImageSource imggPesce2 = new BitmapImage(uriPesce2);
            ImageSource imggPesce3 = new BitmapImage(uriPesce3);
            r = new Random();
            inizioPesce1 = 49;
            inizioPesce2 = 49;
            inizioPesce3 = 49;
            podio = 0;
            imgPesce1.Source = imggPesce1;
            imgPesce2.Source = imggPesce2;
            imgPesce3.Source = imggPesce3;
            Thread t1 = new Thread(new ThreadStart(Pesce1));
            Thread t2 = new Thread(new ThreadStart(Pesce2));
            Thread t3 = new Thread(new ThreadStart(Pesce3));
            t1.Start();
            t2.Start();
            t3.Start();
        }

        public void Pesce1()
        {
            int sleepingTime = r.Next(30, 81);
            while (inizioPesce1 < 620)
            {
                inizioPesce1 += 1;

                Thread.Sleep(TimeSpan.FromMilliseconds(sleepingTime));

                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    imgPesce1.Margin = new Thickness(inizioPesce1, 26, 0, 0);
                }));
            }

            if (inizioPesce1 >= 620)
            {
                Classifica(0);
            }

        }

        public void Pesce2()
        {
            int sleepingTime = r.Next(30, 81);
            while (inizioPesce2 < 620)
            {
                inizioPesce2 += 1;

                Thread.Sleep(TimeSpan.FromMilliseconds(sleepingTime));

                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    imgPesce2.Margin = new Thickness(inizioPesce2, 146, 0, 0);
                }));
            }

            if (inizioPesce2 >= 620)
            {
                Classifica(1);
            }

        }

        public void Pesce3()
        {
            int sleepingTime = r.Next(30, 81);
            while (inizioPesce3 < 620)
            {
                inizioPesce3 += 1;

                Thread.Sleep(TimeSpan.FromMilliseconds(sleepingTime));

                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    imgPesce3.Margin = new Thickness(inizioPesce3, 264, 0, 0);
                }));
            }

            if (inizioPesce3 >= 620)
            {
                Classifica(2);
            }

        }

        public void Classifica(int i)
        {

            if (i == 0)
            {
                if (podio == 0)
                {
                    podio++;
                    MessageBox.Show("Il boomerang arriva primo");
                }
                else if (podio == 1)
                {
                    podio++;
                    MessageBox.Show("Il boomerang arriva secondo");
                }
                else if (podio == 2)
                {
                    podio++;
                    MessageBox.Show("Il boomerang arriva terzo");
                }

            }
            else if (i == 1)
            {
                if (podio == 0)
                {
                    podio++;
                    MessageBox.Show("Il bladderfish arriva primo");
                }
                else if (podio == 1)
                {
                    podio++;
                    MessageBox.Show("Il bladderfish arriva secondo");
                }
                else if (podio == 2)
                {
                    podio++;
                    MessageBox.Show("Il bladderfish arriva terzo");
                }

            }
            else if (i == 2)
            {
                if (podio == 0)
                {
                    podio++;
                    MessageBox.Show("Il Peeper arriva primo");
                }
                else if (podio == 1)
                {
                    podio++;
                    MessageBox.Show("Il Peeper arriva secondo");
                }
                else if (podio == 2)
                {
                    podio++;
                    MessageBox.Show("Il Peeper arriva terzo");
                }

            }

        }
    }
}

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

namespace ProyectoFinal
{
    /// <summary>
    /// Lógica de interacción para Ciencias.xaml
    /// </summary>
    public partial class Ciencias : Page
    {
        public Ciencias()
        {
            InitializeComponent();
            Application.Current.MainWindow.Height = 550;
        }

        private void quimica_Click(object sender, RoutedEventArgs e)
        {
        }

        private void matematicas_Click(object sender, RoutedEventArgs e)
        {
            Uri next = new Uri("CMTema1.xaml", UriKind.Relative);
            this.NavigationService.Navigate(next);
        }

        private void fisica_Click(object sender, RoutedEventArgs e)
        {
            Uri next = new Uri("CFTema1.xaml", UriKind.Relative);
            this.NavigationService.Navigate(next);
        }

        private void biologia_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

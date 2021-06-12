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
    /// Lógica de interacción para Letras.xaml
    /// </summary>
    public partial class Letras : Page
    {
        public Letras()
        {
            InitializeComponent();
            Application.Current.MainWindow.Height = 550;
        }

        private void lengua_Click(object sender, RoutedEventArgs e)
        {
            Uri next = new Uri("LLTema1.xaml", UriKind.Relative);
            this.NavigationService.Navigate(next);
        }

        private void historia_Click(object sender, RoutedEventArgs e)
        {
            Uri next = new Uri("LHTema1.xaml", UriKind.Relative);
            this.NavigationService.Navigate(next);
        }

        private void griego_Click(object sender, RoutedEventArgs e)
        {

        }

        private void latin_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

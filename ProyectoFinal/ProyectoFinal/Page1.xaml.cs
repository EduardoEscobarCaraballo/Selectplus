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
    /// Lógica de interacción para Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
            Application.Current.MainWindow.Height = 484.5;
        }
        private void letras_Click(object sender, RoutedEventArgs e)
        {
            Uri next = new Uri("Letras.xaml", UriKind.Relative);
            this.NavigationService.Navigate(next);
        }
        private void ciencias_Click(object sender, RoutedEventArgs e)
        {
            Uri next = new Uri("Ciencias.xaml", UriKind.Relative);
            this.NavigationService.Navigate(next);
        }
    }
}

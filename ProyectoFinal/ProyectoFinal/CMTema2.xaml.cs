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
    /// Lógica de interacción para CMTema2.xaml
    /// </summary>
    public partial class CMTema2 : Page
    {
        public CMTema2()
        {
            InitializeComponent();
            Application.Current.MainWindow.Height = 550;
        }

        private void Anterior_Click(object sender, RoutedEventArgs e)
        {
            NavigationService back = NavigationService.GetNavigationService(this);
            back.Navigate(new Uri("CMTema1.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Siguiente_Click(object sender, RoutedEventArgs e)
        {
            NavigationService next = NavigationService.GetNavigationService(this);
            next.Navigate(new Uri("CMTema3.xaml", UriKind.RelativeOrAbsolute));
        }

        private void teoria_Click(object sender, RoutedEventArgs e)
        {
            CMTeoria2 w = new CMTeoria2();
            w.Show();
        }

        private void puntuacion_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ejercicios_Click(object sender, RoutedEventArgs e)
        {
            CMEjercicios2 w = new CMEjercicios2();
            w.Show();
        }
    }
}

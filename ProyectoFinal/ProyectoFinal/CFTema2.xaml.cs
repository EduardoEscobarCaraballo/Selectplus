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
    /// Lógica de interacción para CFTema2.xaml
    /// </summary>
    public partial class CFTema2 : Page
    {
        public CFTema2()
        {
            InitializeComponent();
            Application.Current.MainWindow.Height = 550;
        }

        private void teoria_Click(object sender, RoutedEventArgs e)
        {
            CFTeoria2 w = new CFTeoria2();
            w.Show();
        }

        private void puntuacion_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ejercicios_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Anterior_Click(object sender, RoutedEventArgs e)
        {
            NavigationService back = NavigationService.GetNavigationService(this);
            back.Navigate(new Uri("CFTema1.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Siguiente_Click(object sender, RoutedEventArgs e)
        {
            NavigationService next = NavigationService.GetNavigationService(this);
            next.Navigate(new Uri("CFTema3.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}

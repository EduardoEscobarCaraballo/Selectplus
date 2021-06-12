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
    /// Lógica de interacción para CMTema1.xaml
    /// </summary>
    public partial class CMTema1 : Page
    {
        public CMTema1()
        {
            InitializeComponent();
            Application.Current.MainWindow.Height = 550;
        }
        private void teoria_Click(object sender, RoutedEventArgs e)
        {
            CMTeoria1 w = new CMTeoria1();
            w.Show();
        }
        private void ejercicios_Click(object sender, RoutedEventArgs e)
        {
            CMEjercicios1 w = new CMEjercicios1();
            w.Show();
        }
        private void puntuacion_Click(object sender, RoutedEventArgs e)
        {
        }
        private void Siguiente_Click(object sender, RoutedEventArgs e)
        {
            NavigationService next = NavigationService.GetNavigationService(this);
            next.Navigate(new Uri("CMTema2.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}

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
    /// Lógica de interacción para LLTema1.xaml
    /// </summary>
    public partial class LLTema1 : Page
    {
        public LLTema1()
        {
            InitializeComponent();
            Application.Current.MainWindow.Height = 550;
        }

        private void teoria_Click(object sender, RoutedEventArgs e)
        {
            LLTeoria1 w = new LLTeoria1();
            w.Show();
        }

        private void Siguiente_Click(object sender, RoutedEventArgs e)
        {
            NavigationService next = NavigationService.GetNavigationService(this);
            next.Navigate(new Uri("LLTema2.xaml", UriKind.RelativeOrAbsolute));
        }

        private void puntuacion_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ejercicios_Click(object sender, RoutedEventArgs e)
        {
            LLEjercicios1 w = new LLEjercicios1();
            w.Show();
        }
    }
}

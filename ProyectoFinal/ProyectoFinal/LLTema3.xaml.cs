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
    /// Lógica de interacción para LLTema3.xaml
    /// </summary>
    public partial class LLTema3 : Page
    {
        public LLTema3()
        {
            InitializeComponent();
            Application.Current.MainWindow.Height = 550;
        }

        private void Anterior_Click(object sender, RoutedEventArgs e)
        {
            NavigationService back = NavigationService.GetNavigationService(this);
            back.Navigate(new Uri("LLTema2.xaml", UriKind.RelativeOrAbsolute));
        }

        private void teoria_Click(object sender, RoutedEventArgs e)
        {
            LLTeoria3 w = new LLTeoria3();
            w.Show();
        }

        private void puntuacion_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ejercicios_Click(object sender, RoutedEventArgs e)
        {
            LLEjercicios3 w = new LLEjercicios3();
            w.Show();
        }
    }
}

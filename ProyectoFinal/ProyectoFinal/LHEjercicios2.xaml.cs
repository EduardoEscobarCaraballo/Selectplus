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
using System.Windows.Shapes;

namespace ProyectoFinal
{
    /// <summary>
    /// Lógica de interacción para LHEjercicios2.xaml
    /// </summary>
    public partial class LHEjercicios2 : Window
    {
        public LHEjercicios2()
        {
            InitializeComponent();
        }

        private void p_Click(object sender, RoutedEventArgs e)
        {
            if (contenido.Text != "1837")
            {
                correcto.Visibility = Visibility.Hidden;
                incorrecto.Visibility = Visibility.Visible;
            }

            if (contenido.Text == "1837")
            {
                incorrecto.Visibility = Visibility.Hidden;
                correcto.Visibility = Visibility.Visible;
            }
        }

        private void p1_Click(object sender, RoutedEventArgs e)
        {
            if (contenido1.Text != "O'Donell")
            {
                correcto1.Visibility = Visibility.Hidden;
                incorrecto1.Visibility = Visibility.Visible;
            }

            if (contenido1.Text == "O'Donell")
            {
                incorrecto1.Visibility = Visibility.Hidden;
                correcto1.Visibility = Visibility.Visible;
            }
        }
        private void p2_Click(object sender, RoutedEventArgs e)
        {
            if (contenido2.Text != "1844")
            {
                correcto2.Visibility = Visibility.Hidden;
                incorrecto2.Visibility = Visibility.Visible;
            }

            if (contenido2.Text == "1844")
            {
                incorrecto2.Visibility = Visibility.Hidden;
                correcto2.Visibility = Visibility.Visible;
            }
        }
        private void p3_Click(object sender, RoutedEventArgs e)
        {
            if (contenido3.Text != "Manifiesto de Manzanares")
            {
                correcto3.Visibility = Visibility.Hidden;
                incorrecto3.Visibility = Visibility.Visible;
            }

            if (contenido3.Text == "Manifiesto de Manzanares")
            {
                incorrecto3.Visibility = Visibility.Hidden;
                correcto3.Visibility = Visibility.Visible;
            }
        }

        private void Siguiente_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}

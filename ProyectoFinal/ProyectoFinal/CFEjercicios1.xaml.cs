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
    /// Lógica de interacción para CFEjercicios1.xaml
    /// </summary>
    public partial class CFEjercicios1 : Window
    {
        public CFEjercicios1()
        {
            InitializeComponent();
        }
        private void p_Click(object sender, RoutedEventArgs e)
        {
            if (contenido.Text != "2,662 x 10^7 m")
            {
                correcto.Visibility = Visibility.Hidden;
                incorrecto.Visibility = Visibility.Visible;
            }

            if (contenido.Text == "2,662 x 10^7 m")
            {
                incorrecto.Visibility = Visibility.Hidden;
                correcto.Visibility = Visibility.Visible;
            }
        }

        private void p1_Click(object sender, RoutedEventArgs e)
        {
            if (contenido1.Text != "72820,25 s")
            {
                correcto1.Visibility = Visibility.Hidden;
                incorrecto1.Visibility = Visibility.Visible;
            }

            if (contenido1.Text == "72820,25 s")
            {
                incorrecto1.Visibility = Visibility.Hidden;
                correcto1.Visibility = Visibility.Visible;
            }
        }
        private void p2_Click(object sender, RoutedEventArgs e)
        {
            if (contenido2.Text != "-10^8 J")
            {
                correcto2.Visibility = Visibility.Hidden;
                incorrecto2.Visibility = Visibility.Visible;
            }

            if (contenido2.Text == "-10^8 J")
            {
                incorrecto2.Visibility = Visibility.Hidden;
                correcto2.Visibility = Visibility.Visible;
            }
        }
    }
}

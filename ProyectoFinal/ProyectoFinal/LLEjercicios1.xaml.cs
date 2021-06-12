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
    /// Lógica de interacción para LLEjercicios1.xaml
    /// </summary>
    public partial class LLEjercicios1 : Window
    {
        public LLEjercicios1()
        {
            InitializeComponent();
        }

        private void p_Click(object sender, RoutedEventArgs e)
        {
            if (contenido.Text != "Ruben Darío")
            {
                correcto.Visibility = Visibility.Hidden;
                incorrecto.Visibility = Visibility.Visible;
            }

            if (contenido.Text == "Ruben Darío")
            {
                incorrecto.Visibility = Visibility.Hidden;
                correcto.Visibility = Visibility.Visible;
            }
        }

        private void p1_Click(object sender, RoutedEventArgs e)
        {
            if (contenido1.Text != "Generación del 27")
            {
                correcto1.Visibility = Visibility.Hidden;
                incorrecto1.Visibility = Visibility.Visible;
            }

            if (contenido1.Text == "Generación del 27")
            {
                incorrecto1.Visibility = Visibility.Hidden;
                correcto1.Visibility = Visibility.Visible;
            }
        }
        private void p2_Click(object sender, RoutedEventArgs e)
        {
            if (contenido2.Text != "Ocnos" || contenido2.Text != "Variaciones sobre el tema mexicano")
            {
                correcto2.Visibility = Visibility.Hidden;
                incorrecto2.Visibility = Visibility.Visible;
            }

            if (contenido2.Text == "Ocnos" || contenido2.Text == "Variaciones sobre el tema mexicano")
            {
                incorrecto2.Visibility = Visibility.Hidden;
                correcto2.Visibility = Visibility.Visible;
            }
        }
        private void p3_Click(object sender, RoutedEventArgs e)
        {
            if (contenido3.Text != "Sombra del Paraíso")
            {
                correcto3.Visibility = Visibility.Hidden;
                incorrecto3.Visibility = Visibility.Visible;
            }

            if (contenido3.Text == "Sombra del Paraíso")
            {
                incorrecto3.Visibility = Visibility.Hidden;
                correcto3.Visibility = Visibility.Visible;
            }
        }
    }
}

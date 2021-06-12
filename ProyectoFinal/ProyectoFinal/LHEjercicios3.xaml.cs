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
    /// Lógica de interacción para LHEjercicios3.xaml
    /// </summary>
    public partial class LHEjercicios3 : Window
    {
        public LHEjercicios3()
        {
            InitializeComponent();
        }

        private void p_Click(object sender, RoutedEventArgs e)
        {
            if (contenido.Text != "Desamortización de Mendizábal")
            {
                correcto.Visibility = Visibility.Hidden;
                incorrecto.Visibility = Visibility.Visible;
            }

            if (contenido.Text == "Desamortización de Mendizábal")
            {
                incorrecto.Visibility = Visibility.Hidden;
                correcto.Visibility = Visibility.Visible;
            }
        }

        private void p1_Click(object sender, RoutedEventArgs e)
        {
            if (contenido1.Text != "Desamortización de Madoz")
            {
                correcto1.Visibility = Visibility.Hidden;
                incorrecto1.Visibility = Visibility.Visible;
            }

            if (contenido1.Text == "Desamortización de Madoz")
            {
                incorrecto1.Visibility = Visibility.Hidden;
                correcto1.Visibility = Visibility.Visible;
            }
        }
        private void p2_Click(object sender, RoutedEventArgs e)
        {
            if (contenido2.Text != "1835")
            {
                correcto2.Visibility = Visibility.Hidden;
                incorrecto2.Visibility = Visibility.Visible;
            }

            if (contenido2.Text == "1835")
            {
                incorrecto2.Visibility = Visibility.Hidden;
                correcto2.Visibility = Visibility.Visible;
            }
        }
        private void p3_Click(object sender, RoutedEventArgs e)
        {
            if (contenido3.Text != "1 de mayo de 1855")
            {
                correcto3.Visibility = Visibility.Hidden;
                incorrecto3.Visibility = Visibility.Visible;
            }

            if (contenido3.Text == "1 de mayo de 1855")
            {
                incorrecto3.Visibility = Visibility.Hidden;
                correcto3.Visibility = Visibility.Visible;
            }
        }
    }
}
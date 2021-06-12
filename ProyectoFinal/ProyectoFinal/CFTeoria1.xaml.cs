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
    /// Lógica de interacción para CFTeoria1.xaml
    /// </summary>
    public partial class CFTeoria1 : Window
    {
        public CFTeoria1()
        {
            InitializeComponent();
            Application.Current.MainWindow.Height = 930;

            pdfWebViewer.Navigate(new Uri("about:blank"));
            pdfWebViewer.Navigate(@"C:\Users\EDUARDO\Downloads\fisicainteraccion.pdf");
        }
    }
}

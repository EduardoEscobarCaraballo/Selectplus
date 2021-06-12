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
using System.Drawing;
using Spire.Pdf;
using Spire.Pdf.Graphics;
using System.IO;
using System.Drawing.Imaging;
using System.Collections;

namespace ProyectoFinal
{
    /// <summary>
    /// Lógica de interacción para CMTeoria1.xaml
    /// </summary>
    public partial class CMTeoria1 : Window
    {
        public CMTeoria1()
        {
            InitializeComponent();
            Application.Current.MainWindow.Height = 930;

            pdfWebViewer.Navigate(new Uri("about:blank"));
            pdfWebViewer.Navigate(@"C:\Users\EDUARDO\Downloads\Matrices.pdf");
        }



        private void Grid_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {

        }
    }
}
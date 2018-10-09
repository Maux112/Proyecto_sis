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

namespace Bazar2
{
    /// <summary>
    /// Lógica de interacción para ABML.xaml
    /// </summary>
    public partial class ABML : Window
    {
        public ABML()
        {
            InitializeComponent();
        }

        private void Agregar_Click(object sender, RoutedEventArgs e)
        {
            Agregar a = new Agregar();
            a.Show();
            this.Close();
        }

        private void Eliminar_Click(object sender, RoutedEventArgs e)
        {
            Eliminar a = new Eliminar();
            a.Show();
            this.Close();
        }

        private void Modificar_Click(object sender, RoutedEventArgs e)
        {
            Modificar a = new Modificar();
            a.Show();
            this.Close();
        }
    }
}

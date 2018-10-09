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

namespace Bazar2._0
{
    /// <summary>
    /// Lógica de interacción para ABMproducto.xaml
    /// </summary>
    public partial class ABMproducto : Window
    {
        public ABMproducto()
        {
            InitializeComponent();
        }

        private void Agregar_Click(object sender, RoutedEventArgs e)
        {
            AgregarProducto a = new AgregarProducto();
            a.Show();
            this.Close();
        }

        private void Eliminar_Click(object sender, RoutedEventArgs e)
        {
            EliminarProducto a = new EliminarProducto();
            a.Show();
            this.Close();
        }

        private void Modificar_Click(object sender, RoutedEventArgs e)
        {
            ModificarProducto a = new ModificarProducto();
            a.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ABM a = new ABM();
            a.Show();
            this.Close();
        }
    }
}

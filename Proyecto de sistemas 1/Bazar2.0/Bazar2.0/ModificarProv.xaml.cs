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
    /// Lógica de interacción para ModificarProv.xaml
    /// </summary>
    public partial class ModificarProv : Window
    {
        public ModificarProv()
        {
            InitializeComponent();
            listaModificarProv.ItemsSource = claseAB.ListaProveedor();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int resultado;
            claseProveedor proveedorModificado = new claseProveedor();
            if (Nombretex.Text == "" || Teleftex.Text =="")
            {
                MessageBox.Show("Debe llenar todos los campos", "", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                proveedorModificado.CodProveedor = Codtex.Text;
                proveedorModificado.Nombre = Nombretex.Text;
                proveedorModificado.Telefono =Teleftex.Text;

                resultado = claseAB.ModificarProveedor(proveedorModificado.CodProveedor, proveedorModificado.Nombre, proveedorModificado.Telefono);
                if (resultado == 0)
                {
                    MessageBox.Show("No se pudo adicionar los datos.", "", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    MessageBox.Show("Modificacion exitosa.");
                    Codtex.Clear();
                    Nombretex.Clear();
                    Teleftex.Clear();
                    listaModificarProv.ItemsSource = claseAB.ListaProveedor();
                }
            }
        }

        private void listaModificarProv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                string nombre;
                claseProveedor Miproveedor = new claseProveedor();
                nombre = listaModificarProv.SelectedItem.ToString();
                // MessageBox.Show(nombre.ToString());
                Miproveedor = claseAB.BusquedaProveedor(nombre);
                // MessageBox.Show(Miproducto.Nombre.ToString());

                Nombretex.Text = Miproveedor.Nombre.ToString();
                Codtex.Text = Miproveedor.CodProveedor.ToString();
                Teleftex.Text = Miproveedor.Telefono.ToString();
               


            }
            catch
            {
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Codtex.Clear();
            Nombretex.Clear();
            Teleftex.Clear();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AMproveedor a = new AMproveedor();
            a.Show();
            this.Close();
        }
    }
}

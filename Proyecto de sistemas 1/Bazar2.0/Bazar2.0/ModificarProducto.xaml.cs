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
    /// Lógica de interacción para ModificarProducto.xaml
    /// </summary>
    public partial class ModificarProducto : Window
    {
        public ModificarProducto()
        {
            InitializeComponent();
            listaModificar.ItemsSource = claseABM.ListaProducto();
        }

        private void Modificar_Click(object sender, RoutedEventArgs e)
        {
            int resultado;
            claseProducto productoModificado = new claseProducto();
            if (nombretex.Text=="")
            {
                MessageBox.Show("Debe llenar todos los campos", "", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                productoModificado.CodProd = codtex.Text;
                productoModificado.Precio = decimal.Parse(preciotex.Text);
                productoModificado.CantidadEx = int.Parse(cantidadextex.Text);
                resultado = claseABM.ModificarProducto(productoModificado.CodProd, productoModificado.Precio, productoModificado.CantidadEx);
                if (resultado == 0)
                {
                    MessageBox.Show("No se pudo adicionar los datos.", "", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    MessageBox.Show("Modificacion exitosa.");
                        codtex.Clear();
                        nombretex.Clear();
                        preciotex.Clear();
                        cantidadmintex.Clear();
                        cantidadextex.Clear();
                        Caracteristicasx.Clear();

                    listaModificar.ItemsSource = claseABM.ListaProducto();
                }
            }
        }

        private void listaModificar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                string nombre;
                claseProducto Miproducto = new claseProducto();
                nombre = listaModificar.SelectedItem.ToString();
                // MessageBox.Show(nombre.ToString());
                Miproducto = claseABM.BusquedaProducto(nombre);
                // MessageBox.Show(Miproducto.Nombre.ToString());

                nombretex.Text = Miproducto.Nombre.ToString();
                codtex.Text = Miproducto.CodProd.ToString();
                preciotex.Text = Miproducto.Precio.ToString();
                cantidadextex.Text = Miproducto.CantidadEx.ToString();
                cantidadmintex.Text = Miproducto.CantidadMin.ToString();
                Caracteristicasx.Text = Miproducto.Caracteristicas.ToString();


            }
            catch
            {
            }
        }

        private void Atras_Click(object sender, RoutedEventArgs e)
        {
            ABMproducto a = new ABMproducto();
            a.Show();
            this.Close();
        }

        private void Cancelar_Click(object sender, RoutedEventArgs e)
        {
            codtex.Clear();
            nombretex.Clear();
            preciotex.Clear();
            cantidadmintex.Clear();
            cantidadextex.Clear();
            Caracteristicasx.Clear();
        }
    }
}

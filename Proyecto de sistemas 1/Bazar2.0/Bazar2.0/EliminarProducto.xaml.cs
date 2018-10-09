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
    /// Lógica de interacción para EliminarProducto.xaml
    /// </summary>
    public partial class EliminarProducto : Window
    {
        public EliminarProducto()
        {
            InitializeComponent();
            listaEliminar.ItemsSource = claseABM.ListaProducto();
        }

        private void Eliminar_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult res;
            res = MessageBox.Show("¿Desaea eliminar el Producto?", "", MessageBoxButton.YesNo, MessageBoxImage.Information);
            if (res == MessageBoxResult.Yes)
            {
                int resultado;
                claseProducto productoEliminado = new claseProducto();
                if (nombretex.Text == "")
                {
                    MessageBox.Show("Debe llenar el campo de nombre", "", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    productoEliminado.CodProd = codtex.Text;
                    resultado = claseABM.EliminarProducto(productoEliminado.CodProd);
                    if (resultado == 0)
                    {
                        MessageBox.Show("No se pudo eliminar los datos.", "", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    else
                    {
                        MessageBox.Show("El registro a sido eliminado");
                        listaEliminar.SelectedIndex = 0;

                        codtex.Clear();
                        nombretex.Clear();
                        preciotex.Clear();
                        cantidadmintex.Clear();
                        cantidadextex.Clear();
                        Caracteristicasx.Clear();
                        listaEliminar.ItemsSource = claseABM.ListaProducto();

                    }
                }

                //
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

        private void listaEliminar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                string nombre;
                claseProducto Miproducto = new claseProducto();
                nombre = listaEliminar.SelectedItem.ToString();
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
    }
}

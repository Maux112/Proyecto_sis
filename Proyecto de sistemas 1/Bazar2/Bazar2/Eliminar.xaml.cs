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
    /// Lógica de interacción para Eliminar.xaml
    /// </summary>
    public partial class Eliminar : Window
    {
        public Eliminar()
        {
            InitializeComponent();
            listaElimnar.ItemsSource = claseABML.ListaProducto();
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                string nombre;
                claseProducto Miproducto = new claseProducto();
                nombre = listaElimnar.SelectedItem.ToString();
               // MessageBox.Show(nombre.ToString());
                Miproducto = claseABML.BusquedaProducto(nombre);
               // MessageBox.Show(Miproducto.Nombre.ToString());

                nombretex.Text = Miproducto.Nombre.ToString();
                codtex.Text = Miproducto.CodProd.ToString();
                preciotex.Text = Miproducto.Precio.ToString();
                cantidatex.Text = Miproducto.Cantidad.ToString();
                destex.Text = Miproducto.Descripcion.ToString();
                marcatex.Text = Miproducto.Marca.ToString();

               
            }
            catch { 
            }


        }

        private void Eliminar_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult res;
            res = MessageBox.Show("¿Desaea eliminar el Producto?", "", MessageBoxButton.YesNo, MessageBoxImage.Information);
            if (res == MessageBoxResult.Yes)
            {
                int resultado;
                claseProducto productoEliminado = new claseProducto();
                if (nombretex.Text=="")
                {
                    MessageBox.Show("Debe llenar el campo de nombre", "", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    productoEliminado.CodProd = codtex.Text;
                    resultado = claseABML.EliminarProducto(productoEliminado.CodProd);
                    if (resultado == 0)
                    {
                        MessageBox.Show("No se pudo eliminar los datos.", "", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    else
                    {
                        MessageBox.Show("El registro a sido eliminado");
                        listaElimnar.SelectedIndex = 0;

                        codtex.Clear();
                        nombretex.Clear();
                        preciotex.Clear();
                        cantidatex.Clear();
                        destex.Clear();
                        marcatex.Clear();
                        listaElimnar.ItemsSource = claseABML.ListaProducto();
                   
                    }
                }

                //
            }
        }

        private void atras_Click(object sender, RoutedEventArgs e)
        {
            ABML a = new ABML();
            a.Show();
            this.Close();
        }

        private void cancelar_Click(object sender, RoutedEventArgs e)
        {
            codtex.Clear();
            nombretex.Clear();
            preciotex.Clear();
            cantidatex.Clear();
            destex.Clear();
            marcatex.Clear();
        }
    }
}

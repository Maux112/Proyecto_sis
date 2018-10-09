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
    /// Lógica de interacción para AgregarProducto.xaml
    /// </summary>
    public partial class AgregarProducto : Window
    {
        public AgregarProducto()
        {
            InitializeComponent();
            listaAgregar.ItemsSource = claseABM.ListaProducto();
        }

        private void Guardar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int resultado;
                claseProducto productoAgregado = new claseProducto();
                if (codtex.Text == "" || nombretex.Text == "" || preciotex.Text == "" || cantidadmintex.Text == "" || Caracteristicasx.Text == "")
                {
                    MessageBox.Show("Debe llenar todos los campos", "", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    productoAgregado.CodProd = codtex.Text;
                    productoAgregado.Nombre = nombretex.Text;
                    productoAgregado.Precio = decimal.Parse(preciotex.Text);
                    productoAgregado.CantidadMin = int.Parse(cantidadmintex.Text);
                    productoAgregado.CantidadEx = 0;
                    productoAgregado.Caracteristicas = Caracteristicasx.Text;


                    resultado = claseABM.AdicionarProducto(productoAgregado);
                    if (resultado == 0)
                    {
                        MessageBox.Show("No se pudo adicionar los datos.", "", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    else
                    {
                        MessageBox.Show("Adición exitosa.");
                        codtex.Clear();
                        nombretex.Clear();
                        preciotex.Clear();
                        cantidadmintex.Clear();
                        Caracteristicasx.Clear();
                        listaAgregar.ItemsSource = claseABM.ListaProducto();


                    }

                }
            }
            catch (FormatException error)
            {
                MessageBox.Show("Ingrse numeros solamente:" + error.Message);

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
            Caracteristicasx.Clear();
        }

        private void codtex_LostFocus(object sender, RoutedEventArgs e)
        {
            claseProducto prod = new claseProducto();

            prod = claseABM.BusquedaProducto2(codtex.Text);

            nombretex.Text = prod.Nombre;
            preciotex.Text = prod.Precio.ToString();
            cantidadmintex.Text = prod.CantidadMin.ToString();
            Caracteristicasx.Text = prod.Caracteristicas;
        }

        private void listaAgregar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void codtex_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}

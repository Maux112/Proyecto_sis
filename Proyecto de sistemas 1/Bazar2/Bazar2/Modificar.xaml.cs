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
    /// Lógica de interacción para Modificar.xaml
    /// </summary>
    public partial class Modificar : Window
    {
        public Modificar()
        {
            InitializeComponent();
            listaModificar.ItemsSource = claseABML.ListaProducto();
        }

        private void modificar_Click(object sender, RoutedEventArgs e)
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
                productoModificado.Cantidad = int.Parse(cantidatex.Text);
                resultado = claseABML.ModificarProducto(productoModificado.CodProd, productoModificado.Precio, productoModificado.Cantidad);
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
                    cantidatex.Clear();
                    destex.Clear();
                    marcatex.Clear();

                    listaModificar.ItemsSource = claseABML.ListaProducto();
                }
            }
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                string nombre;
                claseProducto Miproducto = new claseProducto();
                nombre = listaModificar.SelectedItem.ToString();
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
            catch
            {
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

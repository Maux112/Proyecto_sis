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
    /// Lógica de interacción para Agregar.xaml
    /// </summary>
    public partial class Agregar : Window
    {
        public Agregar()
        {
            InitializeComponent();
            listaAgregar.ItemsSource = claseABML.ListaProducto();
        }

        private void Guardar_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {
                int resultado;
                claseProducto productoAgregado = new claseProducto();
                if ( codtex.Text == "" || nombretex.Text == "" || preciotex.Text == ""||cantidatex.Text== "" ||destex.Text == "" || marcatex.Text == "")
                {
                    MessageBox.Show("Debe llenar todos los campos", "", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    productoAgregado.CodProd=codtex.Text;
                    productoAgregado.Nombre=nombretex.Text;
                    productoAgregado.Precio=decimal.Parse(preciotex.Text);
                    productoAgregado.Cantidad=int.Parse(cantidatex.Text);
                    productoAgregado.Descripcion=destex.Text;
                    productoAgregado.Marca=marcatex.Text;

                    
                    resultado = claseABML.AdicionarProducto(productoAgregado);
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
                        cantidatex.Clear();
                        destex.Clear();
                        marcatex.Clear();
                        listaAgregar.ItemsSource = claseABML.ListaProducto();

                        
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
            ABML a = new ABML();
            a.Show();
            this.Close();
        }

        private void Cancelar_Click(object sender, RoutedEventArgs e)
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

    

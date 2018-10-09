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
    /// Lógica de interacción para AgregarProv.xaml
    /// </summary>
    public partial class AgregarProv : Window
    {
        public AgregarProv()
        {
            InitializeComponent();
            listaAgregarProv.ItemsSource = claseAB.ListaProveedor();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int resultado;
                claseProveedor proveedorAgregado = new claseProveedor();
                if (Codtex.Text == "" || Nombretex.Text == "" || Teleftex.Text == "")
                {
                    MessageBox.Show("Debe llenar todos los campos", "", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    proveedorAgregado.CodProveedor = Codtex.Text;
                    proveedorAgregado.Nombre = Nombretex.Text;
                    proveedorAgregado.Telefono = Teleftex.Text;



                    resultado = claseAB.AdicionarProveedor(proveedorAgregado);
                    if (resultado == 0)
                    {
                        MessageBox.Show("No se pudo adicionar los datos.", "", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    else
                    {
                        MessageBox.Show("Adición exitosa.");
                        Codtex.Clear();
                        Nombretex.Clear();
                        Teleftex.Clear();
                        listaAgregarProv.ItemsSource = claseAB.ListaProveedor();


                    }

                }
            }
            catch (FormatException error)
            {
                MessageBox.Show("Ingrse las carecteristicas Correspondientes:" + error.Message);

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

        private void listaAgregarProv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Codtex_LostFocus(object sender, RoutedEventArgs e)
        {
            claseProveedor prov = new claseProveedor();

            prov = claseAB.BusquedaProveedor2(Codtex.Text);

            Nombretex.Text = prov.Nombre;
            Teleftex.Text= prov.Telefono;

        }
    }
}

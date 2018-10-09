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
    /// Lógica de interacción para UsrPersona.xaml
    /// </summary>
    public partial class UsrPersona : Window
    {
        public UsrPersona()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int resultado, resultado1;
                clasePersona personaAgregada = new clasePersona();
                claseUsuario usuarioAgregado = new claseUsuario();
                if (citext.Text==""||nomtext.Text==""||paternotext.Text==""||maternotext.Text==""||directext.Text==""||Telefontext.Text==""||usrtext.Text ==""||clave.Password=="")
                {
                    MessageBox.Show("Debe llenar todos los campos", "", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    personaAgregada.CodPer = citext.Text;
                    personaAgregada.Nombre = nomtext.Text;
                    personaAgregada.Paterno = paternotext.Text;
                    personaAgregada.Materno = maternotext.Text;
                    personaAgregada.Direccion=directext.Text;
                    personaAgregada.Telefono = Telefontext.Text;
                    usuarioAgregado.CodPer = citext.Text;
                    usuarioAgregado.Usuario = usrtext.Text;
                    usuarioAgregado.Clave = clave.Password;



                    resultado = claseABMUsrPer.AdicionarPersona(personaAgregada);
                    resultado1 = claseABMUsrPer.AdicionarUsr(usuarioAgregado);
                    if (resultado == 0 || resultado1==0)
                    {
                        MessageBox.Show("No se pudo adicionar los datos.", "", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    else
                    {
                        MessageBox.Show("Registro exitoso.");
                        citext.Clear();
                        nomtext.Clear();
                        paternotext.Clear();
                        maternotext.Clear();
                        directext.Clear();
                        Telefontext.Clear();
                        usrtext.Clear();
                        clave.Clear();
                        MainWindow a = new MainWindow();
                        a.Show();
                        this.Close();
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
            citext.Clear();
            nomtext.Clear();
            paternotext.Clear();
            maternotext.Clear();
            directext.Clear();
            Telefontext.Clear();
            usrtext.Clear();
            clave.Clear();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainWindow A = new MainWindow();
            A.Show();
            this.Close();
        }
    }
}

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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Bazar2._0
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            claseUsuario usuario = new claseUsuario();
            usuario.Usuario = usrtext.Text;
            usuario.Clave = password.Password;
            int res = claseABMUsrPer.VerificarUsu(usuario.Usuario, usuario.Clave);
            if (res == 0)
            {
                MessageBox.Show("TUS DATOS SON ERRONEOS");
                usrtext.Clear();
                password.Clear();
            }
            else
            {
                MessageBox.Show("TUS DATOS SON CORRECTOS");
                ABM a = new ABM();
                a.Show();
                this.Close();
            }
        }

        private void ingresar_Copy_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            UsrPersona a = new UsrPersona();
            a.Show();
            this.Close();
        }
    }
}

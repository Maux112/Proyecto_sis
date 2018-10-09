using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;//para conectarse a sql

namespace Bazar2._0
{
    class claseAB
    {
        //ADICIONAR proveedor
        public static int AdicionarProveedor(claseProveedor proveedor)
        {

            int retorno = 0;
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format(@"insert into Proveedor values('{0}','{1}','{2}')", proveedor.CodProveedor, proveedor.Nombre, proveedor.Telefono), conexion);
                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }

        //MODIFICAR proveedor
        public static int ModificarProveedor(string codigo, string nombre, string tel)//LE MANDAMOS PARAMETROS
        {
            int retorno = 0;
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format(@"update Proveedor set telefono='{2}' where codproveedor='{0}'  update Proveedor set nombre='{1}' where codproveedor='{0}'", codigo, nombre, tel), conexion);
                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }
        //para la listbox
        public static claseProveedor BusquedaProveedor(string nom)
        {
            claseProveedor proveedor = new claseProveedor();
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                SqlCommand Consulta = new SqlCommand(string.Format(@"select codproveedor,Nombre,telefono from Proveedor where Nombre='{0}'", nom), conexion);
                SqlDataReader Lectura = Consulta.ExecuteReader();
                while (Lectura.Read())
                {
                    proveedor.CodProveedor = Lectura.GetString(0);
                    proveedor.Nombre = Lectura.GetString(1);
                    proveedor.Telefono = Lectura.GetString(2);
                }
                conexion.Close();
                return proveedor;
            }

        }
        //listar
        public static List<string> ListaProveedor()
        {
            List<string> ListaProveedor = new List<string>();
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                SqlCommand Consulta = new SqlCommand(string.Format(@"select Nombre from Proveedor order by(Nombre)"), conexion);
                SqlDataReader Lectura = Consulta.ExecuteReader();
                while (Lectura.Read())
                {
                    string nombreProveedor;
                    nombreProveedor = Lectura.GetString(0);
                    ListaProveedor.Add(nombreProveedor);
                }
                conexion.Close();
                return ListaProveedor;
            }
        }

        public static claseProveedor BusquedaProveedor2(string cod)
        {
            claseProveedor proveedor = new claseProveedor();
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                SqlCommand Consulta = new SqlCommand(string.Format(@"select Codproveedor,Nombre,Telefono from Proveedor where Codproveedor='{0}'", cod), conexion);
                SqlDataReader Lectura = Consulta.ExecuteReader();
                while (Lectura.Read())
                {
                    proveedor.CodProveedor = Lectura.GetString(0);
                    proveedor.Nombre = Lectura.GetString(1);
                    proveedor.Telefono = Lectura.GetString(2);

                }
                conexion.Close();
                return proveedor;
            }
        }
    }
}

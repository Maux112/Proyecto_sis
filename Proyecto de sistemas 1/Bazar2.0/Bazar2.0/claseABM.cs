using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;//para conectarse a sql

namespace Bazar2._0
{
    class claseABM
    {

        //ADICIONAR
        public static int AdicionarProducto(claseProducto producto)
        {

            int retorno = 0;
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format(@"insert into Producto values('{0}','{1}','{2}','{3}','{4}','{5}')", producto.CodProd, producto.Nombre, producto.Precio, producto.CantidadEx, producto.CantidadMin, producto.Caracteristicas), conexion);
                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }
        //ELIMINAR
        public static int EliminarProducto(string cod)//LE MANDAMOS PARAMETROS
        {
            int retorno = 0;
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format(@"Delete from Producto where CodProd='{0}'", cod), conexion);
                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }

        //MODIFICAR
        public static int ModificarProducto(string codigo, decimal precio, int cantidad)//LE MANDAMOS PARAMETROS
        {
            int retorno = 0;
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format(@"update Producto set cantidadmax='{2}' where codprod='{0}'  update Producto set precio='{1}' where codprod='{0}'", codigo, precio, cantidad), conexion);
                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }
        //para la listbox
        public static claseProducto BusquedaProducto(string nom)
        {
            claseProducto producto1 = new claseProducto();
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                SqlCommand Consulta = new SqlCommand(string.Format(@"select CodProd,Nombre,Precio,Cantidadmin,Cantidadmax,caracteristicas from Producto where Nombre='{0}'", nom), conexion);
                SqlDataReader Lectura = Consulta.ExecuteReader();
                while (Lectura.Read())
                {
                    producto1.CodProd = Lectura.GetString(0);
                    producto1.Nombre = Lectura.GetString(1);
                    producto1.Precio = Lectura.GetDecimal(2);
                    producto1.CantidadMin = Lectura.GetInt32(3);
                    producto1.CantidadEx = Lectura.GetInt32(4);
                    producto1.Caracteristicas = Lectura.GetString(5);


                }
                conexion.Close();
                return producto1;
            }

        }
        //listar
        public static List<string> ListaProducto()
        {
            List<string> ListaProducto = new List<string>();
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                SqlCommand Consulta = new SqlCommand(string.Format(@"select nombre from Producto order by(nombre)"), conexion);
                SqlDataReader Lectura = Consulta.ExecuteReader();
                while (Lectura.Read())
                {
                    string nombreProductos;
                    nombreProductos = Lectura.GetString(0);
                    ListaProducto.Add(nombreProductos);
                }
                conexion.Close();
                return ListaProducto;
            }
        }

        public static claseProducto BusquedaProducto2(string cod)
        {
            claseProducto producto1 = new claseProducto();
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                SqlCommand Consulta = new SqlCommand(string.Format(@"select CodProd,Nombre,Precio,Cantidadmin,Cantidadmax,caracteristicas from Producto where CodProd='{0}'", cod), conexion);
                SqlDataReader Lectura = Consulta.ExecuteReader();
                while (Lectura.Read())
                {
                    producto1.CodProd = Lectura.GetString(0);
                    producto1.Nombre = Lectura.GetString(1);
                    producto1.Precio = Lectura.GetDecimal(2);
                    producto1.CantidadMin = Lectura.GetInt32(3);
                    producto1.CantidadEx = Lectura.GetInt32(4);
                    producto1.Caracteristicas = Lectura.GetString(5);


                }
                conexion.Close();
                return producto1;
            }

        }
    }
}

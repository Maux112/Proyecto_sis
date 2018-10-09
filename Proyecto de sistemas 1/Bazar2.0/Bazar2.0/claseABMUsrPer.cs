using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;//para conectarse a sql

namespace Bazar2._0
{
    class claseABMUsrPer
    {
        //Para usr y password
        public static int VerificarUsu(string usu,string clave)
        {
            int retorno = 0;
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format(@"select * from Usuario where Usuario = '{0}' and clave = '{1}'", usu,clave), conexion);
                SqlDataReader Lectura = comando.ExecuteReader();
                while (Lectura.Read())
                {
                    retorno = 1;
                }
            }
            return retorno;
        }
        //ADICIONAR
        public static int AdicionarPersona(clasePersona persona)
        {

            int retorno = 0;
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format(@"insert into persona values('{0}','{1}','{2}','{3}','{4}','{5}')",persona.CodPer,persona.Nombre,persona.Paterno,persona.Materno,persona.Direccion,persona.Telefono), conexion);
                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }
        //ADICIONARUSUARIO
        public static int AdicionarUsr( claseUsuario usu)
        {

            int retorno = 0;
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format(@"insert  into usuario values('{2}','{1}','{0}')",  usu.CodPer, usu.Clave, usu.Usuario), conexion);
                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }




    }
}

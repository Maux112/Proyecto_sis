﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;//para conectarse a sql

namespace Bazar2._0
{
    class Conexion
    {
        public static SqlConnection ObtenerConexion()
        {
            //declaramos la variable conexion 
            SqlConnection Conexion = new SqlConnection("Data Source=A305-07;Initial Catalog=Bazar;Integrated Security=True");
            Conexion.Open();
            return Conexion;
        }
    }
}

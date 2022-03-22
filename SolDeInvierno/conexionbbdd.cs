using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace SolDeInvierno
{
   public class conexionbbdd
    {

       public static SqlConnection obtenerConexion()
        {
            string cadena = "data source=PC-OSVALDO;Initial Catalog=Sol_De_Invierno; user id=sa;password=pandamola14";
            SqlConnection conn=new SqlConnection(cadena);
            conn.Open();

            return conn;
        }
     
    }
}

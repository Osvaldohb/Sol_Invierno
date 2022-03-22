using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SolDeInvierno
{
    public class ProductosDAL
    {
        public static int Agregar(Productos pProducto)
        {
            int retorno = 0;
           using(SqlConnection conn =conexionbbdd.obtenerConexion())
            {
                SqlCommand sqlCommand = new SqlCommand(String.Format("Insert  Productos (Nombre,Categoria,Color,Tamaño,Precio) values('{0}','{1}','{2}','{3}','{4}')",
               pProducto.Name, pProducto.catego, pProducto.color, pProducto.tama, pProducto.precio), conn);


                retorno = sqlCommand.ExecuteNonQuery();
            }
           return retorno;    
        }


        public static List<Productos>   BuscarProducto(int pId)
        {
            List<Productos> pList = new List<Productos>();
            using (SqlConnection conexion = conexionbbdd.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select Id, Nombre,Categoria,Color,Tamaño,Precio from Productos where Id like '{0}'", pId), conexion);
                SqlDataReader reader = comando.ExecuteReader();
                float cd = 0;
                while(reader.Read())
                {
                    Productos producto = new Productos();
                    producto.Id = reader.GetInt32(0);
                    producto.Name = reader.GetString(1);
                    producto.catego = reader.GetString(2);
                    producto.color = reader.GetString(3);
                    producto.tama = reader.GetString(4);
                    cd=float.Parse (reader.GetValue(5).ToString());
                    producto.precio =cd;
                    pList.Add(producto);

                }

                conexion.Close();
                return pList;
            }
        }

    }
}

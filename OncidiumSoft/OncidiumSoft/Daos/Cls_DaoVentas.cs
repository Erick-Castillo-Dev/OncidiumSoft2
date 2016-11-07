using MySql.Data.MySqlClient;
using OncidiumSoft.Conexxion_Datos;
using OncidiumSoft.Objetos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace OncidiumSoft.Daos
{
    class Cls_DaoVentas
    {
        /// <summary>
        /// Objeto de la conexion a la base de datos
        /// </summary>
        Conexion c = new Conexion();
        /// <summary>
        /// Obtener el folio de la venta
        /// </summary>
        /// <returns></returns>
        public int folio()
        {
            try
            {

                string sql;
                MySqlCommand cm = new MySqlCommand();
                MySqlDataReader dr;
                c.Conectar();
                sql = "select max(idVentas) as maximo from ventas";
                cm.CommandText = sql;
                cm.CommandType = CommandType.Text;
                cm.Connection = c.cConexion;
                dr = cm.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    int s = dr.GetInt32("maximo");
                    c.Cerrar();
                    return s+1;
                }
                else
                {
                    c.Cerrar();
                    return 0;
                }

            }
            catch (MySqlException e)
            {
                return 0;
                c.Cerrar();
            }
            return 0;
        }

        public Image cargarimagen(byte[] sd)
        {
            using (var stream = new MemoryStream(sd))
            {
                Image img = Image.FromStream(stream);
                return img;
            }
        }

        public bool venta(List<Cls_DatosVenta> lis, int folio)
        {
            MySqlTransaction tr = null;
            MySqlDataReader dr = null;
            int s = 0;
            bool q = false;

            try
            {
                c.Conectar();
                tr = c.cConexion.BeginTransaction();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = c.cConexion;
                cmd.Transaction = tr;
                cmd.Parameters.AddWithValue("@id", folio);
                cmd.Parameters.AddWithValue("@fecha", DateTime.Now.ToString("yyyy-MM-dd"));
                cmd.CommandText = "insert into ventas (Fecha,idEmpleado) values (@fecha,@id)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "select idVenta from ventas order by idVenta desc";
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    s = dr.GetInt32("idVenta");
                }
                dr.Close();
                for (int i = 0; i < lis.Count; i++)
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@idVenta", s);
                    cmd.Parameters.AddWithValue("@idProducto", lis.ElementAt(i).ID);
                    cmd.Parameters.AddWithValue("@Cantidad", lis.ElementAt(i).Cantidad);
                    cmd.Parameters.AddWithValue("@Precio", lis.ElementAt(i).Precio_Unitario);
                    cmd.CommandText = "insert into detalles_ventas (idProductos,idVentas,Cantidad,Precio) values (@idVenta,@idProducto,@Cantidad,@Precio);";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "update productos set Cantidad = Cantidad - @Cantidad where idProductos = @idProducto;";
                    cmd.ExecuteNonQuery();
                }
                tr.Commit();
                q = true;
                c.Cerrar();
            }
            catch (MySqlException ex)
            {
                tr.Rollback();
                q = false;
                c.Cerrar();
            }

            return q;
        }

    }
}

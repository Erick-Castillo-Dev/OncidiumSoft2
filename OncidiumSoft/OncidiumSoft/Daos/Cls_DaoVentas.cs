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
        /// <summary>
        /// Metodo para cargar la imagen de la base de datos
        /// </summary>
        /// <param name="sd"></param>
        /// <returns></returns>
        public Image cargarimagen(byte[] sd)
        {
            using (var stream = new MemoryStream(sd))
            {
                Image img = Image.FromStream(stream);
                return img;
            }
        }
        /// <summary>
        /// Metodo de la transacion para hacer la venta
        /// </summary>
        /// <param name="lis"></param>
        /// <param name="total"></param>
        /// <param name="descuento"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool venta(List<Cls_DatosVenta> lis,int total,int descuento,int id)
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
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@total",total);
                cmd.Parameters.AddWithValue("@subtotal", (total-descuento));
                cmd.Parameters.AddWithValue("@descuento", descuento);
                cmd.Parameters.AddWithValue("@fecha", DateTime.Now.ToString("yyyy-MM-dd"));
                cmd.CommandText = "INSERT INTO ventas (SubTotal,Total,Fecha_Realizar,Fecha_Entregar,Tipo,Descuento,idUsuarios,Entregado)VALUES(@subtotal,@total,@fecha,@fecha,'Venta',@descuento,@id,1)";
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
                    cmd.CommandText = "INSERT INTO detalles_ventas (idProductos,idVentas,Cantidad,Precio)VALUES(@idProducto,@idVenta,@Cantidad,@Precio)";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "update Productos set Cantidad = Cantidad - @Cantidad where idProductos = @idProducto;";
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

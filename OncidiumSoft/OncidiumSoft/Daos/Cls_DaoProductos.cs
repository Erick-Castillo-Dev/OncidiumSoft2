using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OncidiumSoft.Daos;
using OncidiumSoft.Objetos;
using OncidiumSoft.Conexxion_Datos;
using MySql.Data.MySqlClient;
using System.Data;

namespace OncidiumSoft.Daos
{
    class Cls_DaoProductos
    {
        /// <summary>
        /// Objeto para hacer la conexion a la base de datos
        /// </summary>
        Conexion c = new Conexion();
        /// <summary>
        /// Metodo para buscar un producto en la base de datos 
        /// que devuelve un objeto de producto para su uso
        /// puede buscar por id o por nombre del producto
        /// </summary>
        /// <param name="proDu"></param>
        /// <returns></returns>
        public Cls_Productos BuscarProducto(Cls_Productos proDu)
        {
            try
            {
                Cls_Productos pro = new Cls_Productos();
                string sql = "";
                MySqlCommand cm = new MySqlCommand();
                MySqlDataReader dr;
                c.Conectar();
                if(proDu.NombreProducto == null){
                    cm.Parameters.AddWithValue("@idProductos", proDu.idProductoss);
                    sql = "SELECT * FROM productos WHERE idProductos = @idProductos";
                }else{
                    cm.Parameters.AddWithValue("@Nombre", proDu.NombreProducto);
                    sql = "SELECT * FROM productos WHERE Nombre = @Nombre";
                }
                cm.CommandText = sql;
                cm.CommandType = CommandType.Text;
                cm.Connection = c.cConexion;
                dr = cm.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    pro.idProductoss = dr.GetInt32("idProductos");
                    pro.NombreProducto = dr.GetString("Nombre");
                    pro.PrecioalCliente = dr.GetDouble("Precio_Cliente");
                    pro.TipoProducto = dr.GetString("Tipo");
                    pro.CantidadProducto = dr.GetInt32("Cantidad");
                    //pro.imgenProducto = buscarimg(pro.idProductoss);
                    pro.iddeProvedores = dr.GetInt32("idProvedores");
                    pro.Precio_costo = dr.GetDouble("Precio_Costo");
                    pro.Disponibilidad = dr.GetBoolean("Disponible");
                    pro.AjusteProducto = dr.GetBoolean("Ajuste");

                    c.Cerrar();
                    pro.imgenProducto = buscarimg(pro.idProductoss);
                    return pro;
                }
                else
                {
                    c.Cerrar();
                    return null;
                }
            }catch(MySqlException e){
                c.Cerrar();
                return null;
            }
            return null;

        }

        public byte[] buscarimg(int id)
        {
            try
            {
                c.Conectar();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = c.cConexion;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.CommandText = "select img from productos where idProductos = @id";
                byte[] imgArr = (byte[])cmd.ExecuteScalar();
                imgArr = (byte[])cmd.ExecuteScalar();
                c.Cerrar();
                return imgArr;
            }catch(Exception e){
                return null;
            }
        }
    }
}

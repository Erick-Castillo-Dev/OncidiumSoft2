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
                    pro.imgenProducto = dr.GetString("img");
                    pro.iddeProvedores = dr.GetInt32("idProvedores");
                    pro.Precio_costo = dr.GetDouble("Precio_Costo");
                    pro.Disponibilidad = dr.GetBoolean("Disponible");
                    pro.AjusteProducto = dr.GetBoolean("Ajuste");

                    c.Cerrar();
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


        /// <summary>
        /// Objeto para la conexion a la base de datos
        /// </summary>wsa
        public MySqlConnection cConexion = new MySqlConnection();
        /// <summary>
        /// Objecto para acceder a la conexion de la db.
        /// </summary>
        Conexion conexionDB = new Conexion();
        /// <summary>
        /// Metodo de llenado de productos que contiene la base de datos.
        /// </summary>
        /// <returns></returns>
        public DataSet llenar()
        {
            conexionDB.Conectar();
            MySqlDataAdapter muestreo = new MySqlDataAdapter("select*from productos", conexionDB.cConexion);
            DataSet productos = new DataSet();
            muestreo.Fill(productos, "productos");
            return productos;
        }


        /// <summary>
        /// Agrega el nuevo producto a la db.
        /// </summary>
        /// <param name="objProductos"></param>
        public void AgregarProducto(Objetos.Cls_Productos objProductos)
        {
            string sql;
            MySqlCommand cm;
            conexionDB.Conectar();
            
            cm = new MySqlCommand();
            cm.Parameters.AddWithValue("@idProductos", objProductos.idProductoss);
            cm.Parameters.AddWithValue("@Nombre", objProductos.NombreProducto);
            cm.Parameters.AddWithValue("@Precio_Cliente", objProductos.PrecioalCliente);
            cm.Parameters.AddWithValue("@Tipo", objProductos.TipoProducto);
            cm.Parameters.AddWithValue("@Cantidad", objProductos.CantidadProducto);
            cm.Parameters.AddWithValue("@img", objProductos.imgenProducto);
            cm.Parameters.AddWithValue("@idProvedores", objProductos.iddeProvedores);
            cm.Parameters.AddWithValue("@Precio_Costo", objProductos.Precio_costo);
            cm.Parameters.AddWithValue("@Disponible", objProductos.Disponibilidad);
            cm.Parameters.AddWithValue("@Ajuste", objProductos.AjusteProducto);


            sql = "INSERT INTO productos(idProductoss, NombreProducto, PrecioalCliente, TipoProducto, CantidadProducto, imgenProducto, iddeProvedores, Precio_costo, Disponibilidad,AjusteProducto) VALUES (@idProductos, @Nombre, @Precio_Cliente, @Tipo, @Cantidad, @img, @idProvedores, @Precio_Costo, @Disponible, @Ajuste)";
            cm.CommandText = sql;
            cm.CommandType = System.Data.CommandType.Text;
            cm.Connection = cConexion;
            cm.ExecuteNonQuery();
            conexionDB.Cerrar();

        }

    }
}

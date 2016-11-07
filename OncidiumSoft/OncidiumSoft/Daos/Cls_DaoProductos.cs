using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using OncidiumSoft.Conexxion_Datos;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace OncidiumSoft.Daos
{
    class Cls_DaoProductos
    {

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

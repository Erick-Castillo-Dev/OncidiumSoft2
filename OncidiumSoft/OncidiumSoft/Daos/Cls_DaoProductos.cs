using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using OncidiumSoft.Conexxion_Datos;
using OncidiumSoft.Daos;
using OncidiumSoft.Objetos;

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

        public int idProvedores(string nom)
        {
            int list = 0;

            try
            {
                string sql = "";
                MySqlCommand cm = new MySqlCommand();
                MySqlDataReader dr;
                c.Conectar();
                cm.Parameters.AddWithValue("@nombre", nom);
                sql = "SELECT idProvedores FROM provedores where Nombre = @nombre";
                cm.CommandText = sql;
                cm.CommandType = CommandType.Text;
                cm.Connection = c.cConexion;
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    list = dr.GetInt32("idProvedores");
                }
                c.Cerrar();
            }
            catch (MySqlException e)
            {
                c.Cerrar();
            }

            return list;
        }

        public string nombreProvedor(int id)
        {
            string list= "";

            try
            {
                string sql = "";
                MySqlCommand cm = new MySqlCommand();
                MySqlDataReader dr;
                c.Conectar();
                cm.Parameters.AddWithValue("@id",id);
                sql = "SELECT Nombre FROM provedores where idProvedores = @id";
                cm.CommandText = sql;
                cm.CommandType = CommandType.Text;
                cm.Connection = c.cConexion;
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    list = dr.GetString("Nombre");
                }
                c.Cerrar();
            }
            catch (MySqlException e)
            {
                c.Cerrar();
            }

            return list;
        }

        public List<string> listaProvedores()
        {
            List<string> list = new List<string>();

            try
            {
                string sql = "";
                MySqlCommand cm = new MySqlCommand();
                MySqlDataReader dr;
                c.Conectar();
                sql = "SELECT Nombre FROM provedores;";
                cm.CommandText = sql;
                cm.CommandType = CommandType.Text;
                cm.Connection = c.cConexion;
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    list.Add(dr.GetString("Nombre"));
                }
                c.Cerrar();
            }
            catch (MySqlException e)
            {
                c.Cerrar();
            }

            return list;
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

        public DataSet llenar()
        {
            c.Conectar();
            MySqlDataAdapter muestreo = new MySqlDataAdapter("select*from productos", c.cConexion);
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
            try
            {
                string sql;
                MySqlCommand cm;
                c.Conectar();

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
                cm.Connection = c.cConexion;
                cm.ExecuteNonQuery();
                c.Cerrar();
            }catch(MySqlException e){
                c.Cerrar();
            }
        }

    }
}

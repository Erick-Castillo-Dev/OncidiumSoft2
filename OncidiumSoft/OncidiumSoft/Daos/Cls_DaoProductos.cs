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
        /// <summary>
        /// Metodo para selecionar el id de los provedores por el nombre
        /// </summary>
        /// <param name="nom"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Metodo para selecionar el nombre de los provedores por id del provedor
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Metodo para selecionar el nombre de los provedores de la db 
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Metodo para buscar la imagen del producto por id 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Metodo para eliminar productos por id en la db
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool eliminarProducto(int id)
        {
            bool q = false;
            try
            {
                c.Conectar();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = c.cConexion;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.CommandText = "DELETE FROM productos WHERE idProductos = @id";
                cmd.ExecuteNonQuery();
                q = true;
                c.Cerrar();
            }
            catch (MySqlException e)
            {
                c.Cerrar();
                return q;
            }
            return q;
        }
        /// <summary>
        /// Metodo para enlistar los productos de la db
        /// </summary>
        /// <returns></returns>
        public List<Cls_Productos> llenar()
        {
            List<Cls_Productos> list = new List<Cls_Productos>();
            try
            {
                string sql = "";
                MySqlCommand cm = new MySqlCommand();
                MySqlDataReader dr;
                c.Conectar();
                sql = "select * from productos";
                cm.CommandText = sql;
                cm.CommandType = CommandType.Text;
                cm.Connection = c.cConexion;
                dr = cm.ExecuteReader();
                while (dr.Read()) {
                    Cls_Productos p = new Cls_Productos();
                    p.idProductoss = dr.GetInt32("idProductos");
                    p.NombreProducto = dr.GetString("Nombre");
                    p.PrecioalCliente = dr.GetDouble("Precio_Cliente");
                    p.TipoProducto = dr.GetString("Tipo");
                    p.CantidadProducto = dr.GetInt32("Cantidad");
                    p.iddeProvedores = dr.GetInt32("idProvedores");
                    p.Precio_costo = dr.GetDouble("Precio_Costo");
                    p.Disponibilidad = dr.GetBoolean("Disponible");
                    p.AjusteProducto = dr.GetBoolean("Ajuste");
                    list.Add(p);
                }
                c.Cerrar();
                for (int i = 0; i < list.Count;i++ )
                {
                    list.ElementAt(i).imgenProducto = buscarimg(list.ElementAt(i).idProductoss);
                }
                return list;

            }
            catch (MySqlException e)
            {
                c.Cerrar();
                return null;
            }
            return null;
        }
        /// <summary>
        /// Metodo que enlista los productos por el nombre de la db
        /// </summary>
        /// <param name="producto"></param>
        /// <returns></returns>
        public List<Cls_Productos> buscar(string producto)
        {
            List<Cls_Productos> list = new List<Cls_Productos>();
            try
            {
                string sql = "";
                MySqlCommand cm = new MySqlCommand();
                MySqlDataReader dr;
                c.Conectar();
                sql = "select * from productos where Nombre LIKE '"+producto+"%'";
                cm.CommandText = sql;
                cm.CommandType = CommandType.Text;
                cm.Connection = c.cConexion;
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    Cls_Productos p = new Cls_Productos();
                    p.idProductoss = dr.GetInt32("idProductos");
                    p.NombreProducto = dr.GetString("Nombre");
                    p.PrecioalCliente = dr.GetDouble("Precio_Cliente");
                    p.TipoProducto = dr.GetString("Tipo");
                    p.CantidadProducto = dr.GetInt32("Cantidad");
                    p.iddeProvedores = dr.GetInt32("idProvedores");
                    p.Precio_costo = dr.GetDouble("Precio_Costo");
                    p.Disponibilidad = dr.GetBoolean("Disponible");
                    p.AjusteProducto = dr.GetBoolean("Ajuste");
                    list.Add(p);
                }
                c.Cerrar();
                for (int i = 0; i < list.Count; i++)
                {
                    list.ElementAt(i).imgenProducto = buscarimg(list.ElementAt(i).idProductoss);
                }
                return list;
            }
            catch (MySqlException e)
            {
                c.Cerrar();
                return null;
            }
            return null;
        }
        /// <summary>
        /// Metodo que actualiza los productos
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool editar(Cls_Productos p)
        {
            bool q = false;
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                c.Conectar();
                cmd.Connection = c.cConexion;
                cmd.Parameters.AddWithValue("@id", p.idProductoss);
                cmd.Parameters.AddWithValue("@Nombre", p.NombreProducto);
                cmd.Parameters.AddWithValue("@Precio_Cliente", p.PrecioalCliente);
                cmd.Parameters.AddWithValue("@Tipo", p.TipoProducto);
                cmd.Parameters.AddWithValue("@Cantidad", p.CantidadProducto);
                cmd.Parameters.AddWithValue("@img", p.imgenProducto);
                cmd.Parameters.AddWithValue("@idProvedores", p.iddeProvedores);
                cmd.Parameters.AddWithValue("@Precio_Costo", p.Precio_costo);
                cmd.Parameters.AddWithValue("@Disponible", p.Disponibilidad);
                cmd.Parameters.AddWithValue("@Ajuste", p.AjusteProducto);
                cmd.CommandText = "UPDATE productos SET Nombre = @Nombre,Precio_Cliente = @Precio_Cliente,Tipo = @Tipo,Cantidad = @Cantidad,img = @img,"+
                                    "idProvedores = @idProvedores,Precio_Costo = @Precio_Costo,Disponible = @Disponible,Ajuste = @Ajuste where idProductos = @id ";
                cmd.ExecuteNonQuery();
                q = true;
                c.Cerrar();
            }
            catch (MySqlException e)
            {
                c.Cerrar();
                q = false;
            }
            return q;
        }
        /// <summary>
        /// Metodo que agregar productos a la db
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool AgregarProducto(Cls_Productos p)
        {
            bool q = false;
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                c.Conectar();
                cmd.Connection = c.cConexion;
                cmd.Parameters.AddWithValue("@Nombre", p.NombreProducto);
                cmd.Parameters.AddWithValue("@Precio_Cliente", p.PrecioalCliente);
                cmd.Parameters.AddWithValue("@Tipo", p.TipoProducto);
                cmd.Parameters.AddWithValue("@Cantidad", p.CantidadProducto);
                cmd.Parameters.AddWithValue("@img", p.imgenProducto);
                cmd.Parameters.AddWithValue("@idProvedores", p.iddeProvedores);
                cmd.Parameters.AddWithValue("@Precio_Costo", p.Precio_costo);
                cmd.Parameters.AddWithValue("@Disponible", p.Disponibilidad);
                cmd.Parameters.AddWithValue("@Ajuste", p.AjusteProducto);
                cmd.CommandText = "INSERT INTO productos(Nombre,Precio_Cliente,Tipo,Cantidad,img,idProvedores,Precio_Costo,Disponible,Ajuste)"
                                    + "VALUES(@Nombre,@Precio_Cliente,@Tipo,@Cantidad,@img,@idProvedores,@Precio_Costo,@Disponible,@Ajuste)";
                cmd.ExecuteNonQuery();
                q = true;
                c.Cerrar();
            }
            catch (MySqlException e)
            {
                c.Cerrar();
                q = false;
            }
            return q;
        }

    }
}

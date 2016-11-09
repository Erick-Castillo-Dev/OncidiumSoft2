using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OncidiumSoft.Conexxion_Datos;
using OncidiumSoft.Daos;
using OncidiumSoft.Objetos;
using MySql.Data.MySqlClient;
using System.Data;

namespace OncidiumSoft.Daos
{
    class Cls_DaoPedidos
    {
        /// <summary>
        /// Objeto de la conexion a la base de datos
        /// </summary>
        Conexion c = new Conexion();
        /// <summary>
        /// Metodo para llenar el data grid con los pedidos
        /// </summary>
        /// <returns></returns>
        public List<Cls_DatosPedidos> cargardatos()
        {
            try
            {
                List<Cls_DatosPedidos> x = new List<Cls_DatosPedidos>();
                string sql = "";
                MySqlCommand cm = new MySqlCommand();
                MySqlDataReader dr;
                c.Conectar();
                cm.Parameters.AddWithValue("@tipo", "Pedido");
                sql = "select * from ventas where Tipo = @tipo";
                cm.CommandText = sql;
                cm.CommandType = CommandType.Text;
                cm.Connection = c.cConexion;
                dr = cm.ExecuteReader();
                while(dr.Read()){
                    Cls_DatosPedidos cls = new Cls_DatosPedidos();
                    cls.ID = dr.GetInt32("idVentas");
                    cls.Cliente = dr.GetString("Cliente");
                    if (dr.GetBoolean("Entrega_Domicilio"))
                    {
                        cls.Entrega_a_Domicilio = "SI";
                    }else{
                        cls.Entrega_a_Domicilio = "NO";
                    }
                    if ((dr.GetDouble("Anticipo") - dr.GetDouble("Total")) == 0)
                    {
                        cls.Pagado = "SI";
                    }
                    else
                    {
                        cls.Pagado = "NO";
                    }
                    cls.Fecha = dr.GetDateTime("Fecha_Entregar");
                    x.Add(cls);
                }
                c.Cerrar();
                return x;

            }
            catch (MySqlException e)
            {
                c.Cerrar();
                return null;
            }
            return null;
        }

        public List<Cls_DatosVenta> buscarPro(int id)
        {
            try
            {
                List<Cls_DatosVenta> x = new List<Cls_DatosVenta>();
                string sql = "";
                MySqlCommand cm = new MySqlCommand();
                MySqlDataReader dr;
                c.Conectar();
                cm.Parameters.AddWithValue("@id", id);
                sql = "select p.Nombre, d.Cantidad, p.Tipo, d.Precio, p.idProductos from productos p join detalles_ventas d on p.idProductos = d.idProductos where d.idVentas = @id";
                cm.CommandText = sql;
                cm.CommandType = CommandType.Text;
                cm.Connection = c.cConexion;
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    Cls_DatosVenta cls = new Cls_DatosVenta();
                    cls.ID = dr.GetInt32("idProductos");
                    cls.Producto = dr.GetString("Nombre");
                    cls.Cantidad = dr.GetInt32("Cantidad");
                    cls.Tipo = dr.GetString("Tipo");
                    cls.Precio_Unitario = dr.GetDouble("Precio");
                    cls.Sub_Total = cls.Precio_Unitario * cls.Cantidad;
                    x.Add(cls);
                }
                c.Cerrar();
                return x;

            }
            catch (MySqlException e)
            {
                c.Cerrar();
                return null;
            }
            return null;
        }

        public Cls_Ventas obtenerPedido(int id)
        {
            try
            {
                Cls_Ventas cls = new Cls_Ventas();
                string sql = "";
                MySqlCommand cm = new MySqlCommand();
                MySqlDataReader dr;
                c.Conectar();
                cm.Parameters.AddWithValue("@tipo", "Pedido");
                cm.Parameters.AddWithValue("@id",id);
                sql = "select * from ventas where Tipo = @tipo and idVentas = @id";
                cm.CommandText = sql;
                cm.CommandType = CommandType.Text;
                cm.Connection = c.cConexion;
                dr = cm.ExecuteReader();
                if (dr.Read())
                {
                    cls.idVenta = dr.GetInt32("idVentas");
                    cls.cliente = dr.GetString("Cliente");
                    cls.domicilio = dr.GetString("Domicilio");
                    cls.descripcion = dr.GetString("Descripcion");
                    cls.anticipo = dr.GetFloat("Anticipo");
                    cls.subTotal = dr.GetFloat("SubTotal");
                    cls.total = dr.GetFloat("Total");
                    cls.telefono = dr.GetString("Telefono");
                    cls.fecha_Realizar = dr.GetDateTime("Fecha_Realizar");
                    cls.fecha_Entrega = dr.GetDateTime("Fecha_Entregar");
                    cls.entrega = dr.GetBoolean("Entrega_Domicilio");
                    cls.tipo = dr.GetString("Tipo");
                    cls.descuento = dr.GetInt32("Descuento");
                    cls.idUsuario = dr.GetInt32("idUsuarios");
                    cls.entregado = dr.GetBoolean("Entregado");
                    
                }
                c.Cerrar();
                return cls;

            }
            catch (MySqlException e)
            {
                c.Cerrar();
                return null;
            }
            return null;
        }

        public List<Cls_DatosPedidos> buscar(string cliente)
        {
            try
            {
                List<Cls_DatosPedidos> x = new List<Cls_DatosPedidos>();
                string sql = "";
                MySqlCommand cm = new MySqlCommand();
                MySqlDataReader dr;
                c.Conectar();
                cm.Parameters.AddWithValue("@tipo", "Pedido");
                cm.Parameters.AddWithValue("@buscar",cliente);
                sql = "select * from ventas where Tipo = @tipo and Cliente LIKE '"+cliente+"%'";
                cm.CommandText = sql;
                cm.CommandType = CommandType.Text;
                cm.Connection = c.cConexion;
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    Cls_DatosPedidos cls = new Cls_DatosPedidos();
                    cls.Cliente = dr.GetString("Cliente");
                    if (dr.GetBoolean("Entrega_Domicilio"))
                    {
                        cls.Entrega_a_Domicilio = "SI";
                    }
                    else
                    {
                        cls.Entrega_a_Domicilio = "NO";
                    }
                    if ((dr.GetDouble("Anticipo") - dr.GetDouble("Total")) == 0)
                    {
                        cls.Pagado = "SI";
                    }
                    else
                    {
                        cls.Pagado = "NO";
                    }
                    cls.Fecha = dr.GetDateTime("Fecha_Entregar");
                    x.Add(cls);
                }
                c.Cerrar();
                return x;

            }
            catch (MySqlException e)
            {
                c.Cerrar();
                return null;
            }
            return null;
        }

    }
}

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
        /// <summary>
        /// Metodo para obtener los datos de los productos 
        /// </summary>
         /// <param name="id"></param>
        /// <returns></returns>

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
        /// <summary>
        /// Metodo para obtener los pedidos.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Metodo para buscar los datos de un pedido por cliente
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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
                    cls.ID = dr.GetInt32("idVentas");
                    cls.Cliente = dr.GetString("Cliente");
                    if (dr.GetBoolean("Entrega_Domicilio"))
                    {
                        cls.Entrega_a_Domicilio = "SI";
                    }
                    else
                    {
                        cls.Entrega_a_Domicilio = "NO";
                    }
                    if ((dr.GetDouble("Anticipo") - dr.GetDouble("Total")) == 0)// se hace la evaluacion si esta pagado o no
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
        /// <summary>
        /// Metodo para eliminar un pedido de la lista
        /// </summary>
        /// <param name="idVenta"></param>
        /// <returns></returns>
        public bool eliminarPedido(int idVenta)
        {
            MySqlTransaction tr = null;
            bool q = false;
            try
            {
                c.Conectar();
                tr = c.cConexion.BeginTransaction();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = c.cConexion;
                cmd.Transaction = tr;
                cmd.Parameters.AddWithValue("@idVenta", idVenta);
                cmd.CommandText = "DELETE FROM detalles_ventas WHERE idVentas = @idVenta";
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idVenta", idVenta);
                cmd.CommandText = "DELETE FROM ventas WHERE idVentas = @idVenta";
                cmd.ExecuteNonQuery();
                tr.Commit();
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
        /// Metodo para insertar el pedido en la base de datos 
        /// </summary>
        
        ///  <param name="lis"></param>
        ///  <param name="v"></param>
        /// <returns></returns>
        public bool Pedido(List<Cls_DatosVenta> lis, Cls_Ventas v)
        {
            v.idVenta = new Cls_DaoVentas().folio();
            MySqlTransaction tr = null;
            bool q = false;
            try
            {
                c.Conectar();
                tr = c.cConexion.BeginTransaction();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = c.cConexion;
                cmd.Transaction = tr;
                cmd.Parameters.AddWithValue("@idVenta", v.idVenta);
                cmd.Parameters.AddWithValue("@cliente", v.cliente);
                cmd.Parameters.AddWithValue("@domicilio", v.domicilio);
                cmd.Parameters.AddWithValue("@descripcion", v.descripcion);
                cmd.Parameters.AddWithValue("@anticipo", v.anticipo);
                cmd.Parameters.AddWithValue("@subtotal", v.subTotal);
                cmd.Parameters.AddWithValue("@total", v.total);
                cmd.Parameters.AddWithValue("@fecha_Realizar", v.fecha_Realizar.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@fecha_Entrega", v.fecha_Entrega.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@entrega", v.entrega);
                cmd.Parameters.AddWithValue("@tipo", "Pedido");
                cmd.Parameters.AddWithValue("@descuento", v.descuento);
                cmd.Parameters.AddWithValue("@idUsuario", v.idUsuario);
                cmd.Parameters.AddWithValue("@entregado", v.entregado);
                cmd.Parameters.AddWithValue("@telefono", v.telefono);
                cmd.CommandText = "INSERT INTO ventas(idVentas,Cliente,Domicilio,Descripcion,Anticipo,SubTotal,"+
                                    "Total,Fecha_Realizar,Fecha_Entregar,Entrega_Domicilio,Tipo,Descuento,idUsuarios,Entregado,Telefono)"+
                                    "VALUES(@idVenta,@cliente,@domicilio,@descripcion,@anticipo,@subtotal," +
                                    "@total,@fecha_Realizar,@fecha_Entrega,@entrega,@tipo,@descuento," +
                                    "@idUsuario,@entregado,@telefono)";
                cmd.ExecuteNonQuery();
                for (int i = 0; i < lis.Count; i++)
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@idVenta", v.idVenta);
                    cmd.Parameters.AddWithValue("@idProducto", lis.ElementAt(i).ID);
                    cmd.Parameters.AddWithValue("@Cantidad", lis.ElementAt(i).Cantidad);
                    cmd.Parameters.AddWithValue("@Precio", lis.ElementAt(i).Precio_Unitario);
                    cmd.CommandText = "INSERT INTO detalles_ventas (idProductos,idVentas,Cantidad,Precio)VALUES(@idProducto,@idVenta,@Cantidad,@Precio)";
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

        /// <summary>
        /// Metodo para la actualizacion de un pedido
        /// </summary>
        ///  <param name="lis"></param>
        ///  <param name="v"></param>
        /// <returns></returns>
        public bool ActualizarPedido(List<Cls_DatosVenta> lis, Cls_Ventas v)
        {
            List<Cls_DatosVenta> l = buscarPro(v.idVenta);
            MySqlTransaction tr = null;
            bool q = false;
            try
            {
                c.Conectar();
                tr = c.cConexion.BeginTransaction();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = c.cConexion;
                cmd.Transaction = tr;
                cmd.Parameters.AddWithValue("@idVenta",v.idVenta);
                cmd.Parameters.AddWithValue("@cliente", v.cliente);
                cmd.Parameters.AddWithValue("@domicilio", v.domicilio);
                cmd.Parameters.AddWithValue("@descripcion", v.descripcion);
                cmd.Parameters.AddWithValue("@anticipo", v.anticipo);
                cmd.Parameters.AddWithValue("@subtotal", v.subTotal);
                cmd.Parameters.AddWithValue("@total", v.total);
                cmd.Parameters.AddWithValue("@fecha_Realizar", v.fecha_Realizar);
                cmd.Parameters.AddWithValue("@fecha_Entrega", v.fecha_Entrega);
                cmd.Parameters.AddWithValue("@entrega", v.entrega);
                cmd.Parameters.AddWithValue("@tipo", v.tipo);
                cmd.Parameters.AddWithValue("@descuento", v.descuento);
                cmd.Parameters.AddWithValue("@idUsuario", v.idUsuario);
                cmd.Parameters.AddWithValue("@entregado", v.entregado);
                cmd.Parameters.AddWithValue("@telefono", v.telefono);
                cmd.CommandText = "UPDATE ventas SET idVentas = @idVenta, Cliente = @cliente, Domicilio = @domicilio, Descripcion = @descripcion, Anticipo = @anticipo, SubTotal = @subtotal, Total = @total, Fecha_Realizar = @fecha_Realizar, Fecha_Entregar = @fecha_Entrega, Entrega_Domicilio = @entrega, Tipo = @tipo, Descuento = @descuento, idUsuarios = @idUsuario,Entregado = @entregado, Telefono = @telefono WHERE idVentas = @idVenta";
                cmd.ExecuteNonQuery();


                if(l.Count == lis.Count){// aqui se actualiza la parte en  la tabal detalles de venta
                    for (int i = 0; i < lis.Count;i++ )
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@idVenta", v.idVenta);
                        cmd.Parameters.AddWithValue("@idProducto", lis.ElementAt(i).ID);
                        cmd.Parameters.AddWithValue("@Cantidad", lis.ElementAt(i).Cantidad);
                        cmd.Parameters.AddWithValue("@Precio", lis.ElementAt(i).Precio_Unitario);
                        cmd.CommandText = "UPDATE detalles_ventas SET idProductos = @idProducto, idVentas = @idVenta, Cantidad = @Cantidad, Precio = @Precio WHERE idProductos = @idProducto AND idVentas = @idVenta";
                        cmd.ExecuteNonQuery();
                    }
                }
                else if (l.Count < lis.Count)
                {
                    bool x = false;
                    for (int i = 0; i < lis.Count; i++)
                    {
                        x = false;
                        for (int j = 0; j < l.Count; j++)//se realiza el ciclo para enlistar los elementos
                        {
                            if (lis.ElementAt(i).ID == l.ElementAt(j).ID)
                            {
                                x = true;
                                break;
                            }
                        }
                        if(x){
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@idVenta", v.idVenta);
                            cmd.Parameters.AddWithValue("@idProducto", lis.ElementAt(i).ID);
                            cmd.Parameters.AddWithValue("@Cantidad", lis.ElementAt(i).Cantidad);
                            cmd.Parameters.AddWithValue("@Precio", lis.ElementAt(i).Precio_Unitario);
                            cmd.CommandText = "UPDATE detalles_ventas SET idProductos = @idProducto, idVentas = @idVenta, Cantidad = @Cantidad, Precio = @Precio WHERE idProductos = @idProducto AND idVentas = @idVenta";
                            cmd.ExecuteNonQuery();
                        }
                        else
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@idVenta", v.idVenta);
                            cmd.Parameters.AddWithValue("@idProducto", lis.ElementAt(i).ID);
                            cmd.Parameters.AddWithValue("@Cantidad", lis.ElementAt(i).Cantidad);
                            cmd.Parameters.AddWithValue("@Precio", lis.ElementAt(i).Precio_Unitario);
                            cmd.CommandText = "INSERT INTO detalles_ventas (idProductos,idVentas,Cantidad,Precio)VALUES(@idProducto,@idVenta,@Cantidad,@Precio)";
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                else if (l.Count > lis.Count)
                {
                    bool x = false;
                    for (int i = 0; i < l.Count; i++)
                    {
                        x = false;
                        for (int j = 0; j < lis.Count; j++)
                        {
                            if (lis.ElementAt(j).ID == l.ElementAt(i).ID)
                            {
                                x = true;
                                break;
                            }
                        }
                        if (x)
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@idVenta", v.idVenta);
                            cmd.Parameters.AddWithValue("@idProducto", l.ElementAt(i).ID);
                            cmd.Parameters.AddWithValue("@Cantidad", l.ElementAt(i).Cantidad);
                            cmd.Parameters.AddWithValue("@Precio", l.ElementAt(i).Precio_Unitario);
                            cmd.CommandText = "UPDATE detalles_ventas SET idProductos = @idProducto, idVentas = @idVenta, Cantidad = @Cantidad, Precio = @Precio WHERE idProductos = @idProducto AND idVentas = @idVenta";
                            cmd.ExecuteNonQuery();
                        }
                        else
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@idVenta", v.idVenta);
                            cmd.Parameters.AddWithValue("@idProducto", l.ElementAt(i).ID);
                            cmd.CommandText = "DELETE FROM detalles_ventas WHERE idProductos = @idProducto AND idVentas = @idVenta";
                            cmd.ExecuteNonQuery();
                        }
                    }
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

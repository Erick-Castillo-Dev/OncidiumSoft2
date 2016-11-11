using OncidiumSoft.Conexxion_Datos;
using OncidiumSoft.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using OncidiumSoft.Formularios;

namespace OncidiumSoft.Daos
{
    class Cls_DaoAjusteInventario
    {
        /// <summary>
        /// Objeto para obtener la conexion a la base de datos
        /// </summary>
        Conexion objC = new Conexion();
        /// <summary>
        /// Obtiene los productos de acuerdo a su respectivo nombre
        /// </summary>
        /// <returns></returns>
        public List<string> obtenerProducto()
        {
            List<string> res = new List<string>();
            MySqlCommand cm = new MySqlCommand();
            objC.Conectar();
            MySqlDataReader dr;
            cm.CommandText = "SELECT Nombre FROM productos";
            cm.CommandType = CommandType.Text;
            cm.Connection = objC.cConexion;
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                res.Add(dr.GetString("Nombre"));
            }
            objC.Cerrar();
            return res;
        }

        /// <summary>
        /// Metodo para verificar si el producto existe en la base de datos
        /// </summary>
        /// <param name="producto"></param>
        /// <returns></returns>
        public bool Existe(string producto)
        {
            MySqlCommand cm = new MySqlCommand();
            objC.Conectar();
            MySqlDataReader dr;
            cm.Parameters.AddWithValue("@NOMBRE", producto);
            cm.CommandText = "select Nombre from productos where Nombre = @NOMBRE";
            cm.CommandType = CommandType.Text;
            cm.Connection = objC.cConexion;
            dr = cm.ExecuteReader();

            if (dr.HasRows)
            {
                objC.Cerrar();
                return true;
            }
            else
            {
                objC.Cerrar();
                return false;
            }
        }

        /// <summary>
        /// Metodo para vaciar los datos del producto segun su nombre
        /// </summary>
        /// <param name="producto"></param>
        /// <returns></returns>
        public Cls_Productos Vaciar(string producto)
        {
            Cls_Productos p = new Cls_Productos();
            MySqlCommand cm = new MySqlCommand();
            objC.Conectar();
            MySqlDataReader dr;
            cm.Parameters.AddWithValue("@pro",producto);
            cm.CommandText = "select * from productos where Nombre = @pro";
            cm.CommandType = CommandType.Text;
            cm.Connection = objC.cConexion;
            dr = cm.ExecuteReader();

            while (dr.Read())
            {
                
                p.NombreProducto = dr.GetString(1);
                p.CantidadProducto = dr.GetInt32(4);
                p.Precio_costo = dr.GetDouble(7);
                p.PrecioalCliente = dr.GetDouble(2);
                
                //int s =
                p.Disponibilidad = dr.GetBoolean("Disponible");
                p.AjusteProducto = dr.GetBoolean("Ajuste");

            }
            objC.Cerrar();
            return p;
        }

        /*public decimal obtenerPrecio(decimal Precio)
        {
            decimal res=0;
            MySqlCommand cm = new MySqlCommand();
            objC.Conectar();
            MySqlDataReader dr;
            cm.Parameters.AddWithValue("@PRECIO", Precio);
            cm.CommandText = "SELECT Precio_Costo FROM productos WHERE Nombre = @PRECIO";
            cm.CommandType = CommandType.Text;
            cm.Connection = objC.cConexion;
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                res = dr.GetDecimal("Precio_Costo");
            }
            objC.Cerrar();
            return res;
        }*/

        /// <summary>
        /// Lista que mostrara los atributos de los productos
        /// </summary>
        /// <returns></returns>
        public List<Cls_AjusteInventario> Mostrar()
        {
            List<Cls_AjusteInventario> lstProductos = new List<Cls_AjusteInventario>();
            MySqlCommand cm = new MySqlCommand();
            objC.Conectar();
            MySqlDataReader dr;
            cm.CommandText = "select * from productos;";
            cm.CommandType = CommandType.Text;
            cm.Connection = objC.cConexion;
            dr = cm.ExecuteReader();

            while (dr.Read())
            {
                Cls_AjusteInventario objA = new Cls_AjusteInventario();

                objA.Nombre = dr.GetString(0);
                objA.Cantidad = dr.GetInt32(1);
                objA.PrecioCosto = dr.GetDouble(2);
                objA.PrecioCliente = dr.GetDouble(3);
                objA.Estado = dr.GetBoolean(4);
                objA.TipoAjuste = dr.GetBoolean(5);

                lstProductos.Add(objA);
            }
            objC.Cerrar();
            return lstProductos;
        }

        /// <summary>
        /// Metodo que permitira modificar los atributos en la tabla de productos
        /// </summary>
        /// <param name="objInv"></param>
        public void ModificarInventario(Cls_AjusteInventario objInv)
        {
            MySqlCommand cm = new MySqlCommand();
            objC.Conectar();
            MySqlDataReader dr;
            cm.Parameters.AddWithValue("@NOMBRE", objInv.Nombre);
            cm.Parameters.AddWithValue("@CANTIDAD", objInv.Cantidad);
            cm.Parameters.AddWithValue("@PRECIOCOSTO", objInv.PrecioCosto);
            cm.Parameters.AddWithValue("@PRECIOCLIENTE", objInv.PrecioCliente);
            cm.Parameters.AddWithValue("@ESTADO", objInv.Estado);
            cm.Parameters.AddWithValue("@TIPOAJUSTE", objInv.TipoAjuste);

            cm.CommandText = "UPDATE productos set "
            + "Nombre = @NOMBRE, Cantidad = @CANTIDAD, Precio_Costo = @PRECIOCOSTO, "
            + "Precio_Cliente = @PRECIOCLIENTE, Disponible = @ESTADO, "
            + "Ajuste = @TIPOAJUSTE "
            + "where Nombre = @NOMBRE";

            cm.CommandType = CommandType.Text;
            cm.Connection = objC.cConexion;
            dr = cm.ExecuteReader();
            objC.Cerrar();
        }
    }
}

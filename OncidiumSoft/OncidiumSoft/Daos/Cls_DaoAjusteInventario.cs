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
        Conexion objC = new Conexion();
        FrmAjusteInventario objA = new FrmAjusteInventario();
        public string obtenerIDProducto(string Producto)
        {
            string res = "";
            MySqlCommand cm = new MySqlCommand();
            objC.Conectar();
            MySqlDataReader dr;
            cm.CommandText = "SELECT idProductos FROM productos WHERE Nombre = '" + Producto + "';";
            cm.CommandType = CommandType.Text;
            cm.Connection = objC.cConexion;
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                res = dr.GetString("idProductos");
            }
            objC.Cerrar();
            return res;
        }
        public string obtenerTipo(string Tipo)
        {
            FrmAjusteInventario objA = new FrmAjusteInventario();
            string res = "";
            MySqlCommand cm = new MySqlCommand();
            objC.Conectar();
            MySqlDataReader dr;
            cm.CommandText = "SELECT Tipo FROM productos WHERE Nombre = '" + Tipo + "';";
            cm.CommandType = CommandType.Text;
            cm.Connection = objC.cConexion;
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                res = dr.GetString("Tipo");
            }
            objC.Cerrar();
            return res;
        }
        public string obtenerIDProveedor(string Proveedor)
        {
            FrmAjusteInventario objA = new FrmAjusteInventario();
            string res = "";
            MySqlCommand cm = new MySqlCommand();
            objC.Conectar();
            MySqlDataReader dr;
            cm.CommandText = "SELECT idProvedores FROM productos WHERE Nombre = '" + Proveedor + "';";
            cm.CommandType = CommandType.Text;
            cm.Connection = objC.cConexion;
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                res = dr.GetString("idProvedores");
            }
            objC.Cerrar();
            return res;
        }
        public bool Disponible(string producto)
        {
            string sql;
            MySqlCommand cm = new MySqlCommand();
            objC.Conectar();
            MySqlDataReader dr;
            sql = "SELECT Disponible FROM productos WHERE Nombre = '" + producto + "';";
            cm.CommandType = CommandType.Text;
            cm.Connection = objC.cConexion;
            dr = cm.ExecuteReader();
            if (sql.Equals('1'))
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
        public bool Ajuste(string producto)
        {
            string sql;
            MySqlCommand cm = new MySqlCommand();
            objC.Conectar();
            MySqlDataReader dr;
            sql = "SELECT Ajuste FROM productos WHERE Nombre = '" + producto + "';";
            cm.CommandType = CommandType.Text;
            cm.Connection = objC.cConexion;
            dr = cm.ExecuteReader();
            if (sql.Equals('1'))
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
        public void AgregarAjuste(Cls_AjusteInventario objAjuste)
        {
            string sql;
            MySqlCommand cm;
            objC.Conectar();

            cm = new MySqlCommand();
            cm.Parameters.AddWithValue("@NOMBRE", objAjuste.Nombre);
            cm.Parameters.AddWithValue("@CANTIDAD", objAjuste.Cantidad);
            cm.Parameters.AddWithValue("@PRECIOCOSTO", objAjuste.PrecioCosto);
            cm.Parameters.AddWithValue("@PRECIOCLIENTE", objAjuste.PrecioCliente);
            cm.Parameters.AddWithValue("@TIPOAJUSTE", objAjuste.TipoAjuste);

            //sql = "INSERT INTO productos(Nombre, Precio_Cliente, Cantidad, Precio_Costo, Ajuste) VALUES (@NOMBRE, @PRECIOCLIENTE, @CANTIDAD, @PRECIOCOSTO, @TIPOAJUSTE)";
            //int idProducto = Convert.ToInt32(objDAjuste.obtenerIDProducto(cboProducto.Text));
            sql = "UPDATE productos set "
                + "Nombre = @NOMBRE, Precio_Cliente = @PRECIOCLIENTE, "
                + "Tipo = " + obtenerTipo(objA.cboProducto.Text)
                + "Cantidad = @CANTIDAD, img = '', "
                + "idProvedores = " + Convert.ToInt32(obtenerIDProveedor(objA.cboProducto.Text))
                + "Precio_Costo = @PRECIOCOSTO, "
                + "Disponible = " + Disponible(objA.cboEstado.Text)
                + "Ajuste = " + Ajuste(objA.cboAjuste.Text)
                + "WHERE idProductos = '" + Convert.ToInt32(obtenerIDProducto(objA.cboProducto.Text)) + "'";
            cm.CommandText = sql;
            cm.CommandType = CommandType.Text;
            cm.Connection = objC.cConexion;
            cm.ExecuteNonQuery();
            objC.Cerrar();
        }
    }
}

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
            cm.Parameters.AddWithValue("@ESTADO", objAjuste.Estado);
            cm.Parameters.AddWithValue("@TIPOAJUSTE", objAjuste.TipoAjuste);

            sql = "UPDATE productos set "
                + "Nombre = @NOMBRE, Precio_Cliente = @PRECIOCLIENTE, Cantidad = @CANTIDAD, Precio_Costo = @PRECIOCOSTO, "
                + "Disponible = @ESTADO, Ajuste = @TIPOAJUSTE WHERE idProductos = '" + Convert.ToInt32(obtenerIDProducto(objA.cboProducto.Text)) + "'";
            cm.CommandText = sql;
            cm.CommandType = CommandType.Text;
            cm.Connection = objC.cConexion;
            cm.ExecuteNonQuery();
            objC.Cerrar();
        }
    }
}

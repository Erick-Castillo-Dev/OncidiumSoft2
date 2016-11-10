using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OncidiumSoft.Conexxion_Datos;
using OncidiumSoft.Objetos;
using MySql.Data.MySqlClient;
using System.Data;

namespace OncidiumSoft.Daos
{
    class Cls_DaoCompra
    {
        Conexion c = new Conexion();

        public string Provedor(int r)
        {
            try
            {

                string sql;
                MySqlCommand cm = new MySqlCommand();
                MySqlDataReader dr;
                c.Conectar();
                cm.Parameters.AddWithValue("@id",r);
                sql = "select Nombre from provedores where idProvedores = @id";
                cm.CommandText = sql;
                cm.CommandType = CommandType.Text;
                cm.Connection = c.cConexion;
                dr = cm.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    string s = dr.GetString("Nombre");
                    c.Cerrar();
                    return s;
                }
                else
                {
                    c.Cerrar();
                    return "";
                }

            }
            catch (MySqlException e)
            {
                return "";
                c.Cerrar();
            }
            return "";
        }

        public bool compra(List<Cls_DatosCompra> l)
        {
            bool s = false;
            try
            {
                string sql = "";
                MySqlCommand cm = new MySqlCommand();
                c.Conectar();
                cm.Connection = c.cConexion;
                for (int i = 0; i < l.Count;i++ )
                {
                    cm.Parameters.Clear();
                    cm.Parameters.AddWithValue("@idPro",l.ElementAt(i).ID);
                    cm.Parameters.AddWithValue("@cantidad",l.ElementAt(i).Cantidad);
                    cm.CommandText = "UPDATE productos SET Cantidad = Cantidad + @cantidad WHERE idProductos = @idPro";
                    cm.ExecuteNonQuery();
                }
                s = true;
                c.Cerrar();
            }catch(MySqlException e){
                c.Cerrar();
                return s;
            }
            return s;
        }

    }
}

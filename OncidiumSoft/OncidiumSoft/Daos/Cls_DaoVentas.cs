using MySql.Data.MySqlClient;
using OncidiumSoft.Conexxion_Datos;
using OncidiumSoft.Objetos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OncidiumSoft.Daos
{
    class Cls_DaoVentas
    {
        /// <summary>
        /// Objeto de la conexion a la base de datos
        /// </summary>
        Conexion c = new Conexion();
        /// <summary>
        /// Obtener el folio de la venta
        /// </summary>
        /// <returns></returns>
        public int folio()
        {
            try
            {

                string sql;
                MySqlCommand cm = new MySqlCommand();
                MySqlDataReader dr;
                c.Conectar();
                sql = "select max(idVentas) as maximo from ventas";
                cm.CommandText = sql;
                cm.CommandType = CommandType.Text;
                cm.Connection = c.cConexion;
                dr = cm.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    int s = dr.GetInt32("maximo");
                    c.Cerrar();
                    return s+1;
                }
                else
                {
                    c.Cerrar();
                    return 0;
                }

            }
            catch (MySqlException e)
            {
                return 0;
                c.Cerrar();
            }
            return 0;
        }

    }
}

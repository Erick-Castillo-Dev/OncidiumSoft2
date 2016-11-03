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
    class Cls_DaoContabilidad
    {
        Conexion objC = new Conexion();
        public string obtenerVenta()
        {
            string res="";
            MySqlCommand cm = new MySqlCommand();
            objC.Conectar();
            MySqlDataReader dr;
            cm.CommandText = "SELECT sum(Total) as TOTAL FROM ventas WHERE (date_format(Fecha_Realizar, '%m') = month(now())" +
                            "AND date_format(Fecha_Realizar, '%Y') = year(now()) AND DAY(Fecha_Realizar) BETWEEN '01' AND NOW())";
            cm.CommandType = CommandType.Text;
            cm.Connection = objC.cConexion;
            dr = cm.ExecuteReader();
            while(dr.Read())
            {
                res = dr.GetString("TOTAL");
            }
            objC.Cerrar();
            return res;
        }

        
        
    }
}

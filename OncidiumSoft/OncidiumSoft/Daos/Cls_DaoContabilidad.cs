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

        public void AgregarContabilidad(Cls_Contabilidad objContabilidad)
        {
            string sql;
            MySqlCommand cm;
            objC.Conectar();

            cm = new MySqlCommand();
            cm.Parameters.AddWithValue("@IDCONTABILIDAD", objContabilidad.idContabilidad);
            cm.Parameters.AddWithValue("@FECHAINICIO", objContabilidad.FechaInicio);
            cm.Parameters.AddWithValue("@FECHAFIN", objContabilidad.FechaFin);
            cm.Parameters.AddWithValue("@GANANCIA", objContabilidad.Ganancia_Perdida);

            sql = "INSERT INTO contabilidad(idContabilidad, Fecha_Inicio, Fecha_Fin, Ganancia_Perdida) VALUES (@IDCONTABILIDAD, @FECHAINICIO, @FECHAFIN, @GANANCIA)";
            cm.CommandText = sql;
            cm.CommandType = CommandType.Text;
            cm.Connection = objC.cConexion;
            cm.ExecuteNonQuery();
            objC.Cerrar();
        }

        public List<Cls_Contabilidad> getContabilidad()
        {
            List<Cls_Contabilidad> lstContabilidad = new List<Cls_Contabilidad>();
            string sql;
            MySqlCommand cm = new MySqlCommand();
            MySqlDataReader dr;
            objC.Conectar();
            sql = "SELECT * FROM contabilidad";
            cm.CommandText = sql;
            cm.CommandType = CommandType.Text;
            cm.Connection = objC.cConexion;
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                Cls_Contabilidad objContabilidad = new Cls_Contabilidad();
                objContabilidad.idContabilidad = dr.GetInt32(0);
                objContabilidad.FechaInicio = dr.GetDateTime(1);
                objContabilidad.FechaFin = dr.GetDateTime(2);
                objContabilidad.Ganancia_Perdida = dr.GetDouble(3);
                lstContabilidad.Add(objContabilidad);
            }
            objC.Cerrar();
            return lstContabilidad;
        }
    }
}

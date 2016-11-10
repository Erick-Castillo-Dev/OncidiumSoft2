using MySql.Data.MySqlClient;
using OncidiumSoft.Conexxion_Datos;
using OncidiumSoft.Formularios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OncidiumSoft.Daos
{
    class Cls_DaoProvedores
    {

        /// <summary>
        /// Objecto para acceder a la conexion de la db.
        /// </summary>
        Conexion conexionDB = new Conexion();
        /// <summary>
        /// Metodo de llenado de provedores que contiene la base de datos.
        /// </summary>
        /// <returns></returns>
        public DataSet llenar()
        {
            conexionDB.Conectar();
            MySqlDataAdapter muestreo = new MySqlDataAdapter("select*from provedores", conexionDB.cConexion);
            DataSet provedores = new DataSet();
            muestreo.Fill(provedores, "provedores");
            return provedores;
        }
        /// <summary>
        /// Elimina un provedor con el id
        /// </summary>
        /// <param name="u"></param>
        public void EliminarProvedor(Cls_Provedores u)
        {
            string sql;
            MySqlCommand cm;
            conexionDB.Conectar();

            cm = new MySqlCommand();
            cm.Parameters.AddWithValue("@idProvedores", u.iddeProvedores);
            sql = "DELETE FROM provedores WHERE idProvedores = @idProvedores";
            cm.CommandText = sql;
            cm.CommandType = CommandType.Text; ;
            cm.Connection = conexionDB.cConexion;
            cm.ExecuteNonQuery();
            conexionDB.Cerrar();
        }
        /// <summary>
        /// Agrega provedores a la db
        /// </summary>
        /// <param name="p"></param>
        public void AgregarProvedor(Cls_Provedores p)
        {
            string sql;
            MySqlCommand cm;
            conexionDB.Conectar();
            cm = new MySqlCommand();
            //cm.Parameters.AddWithValue("@idProvedores", p.iddeProvedores);
            cm.Parameters.AddWithValue("@Nombre", p.NombreProvedor);
            cm.Parameters.AddWithValue("@Direccion", p.DireccionProvedor);
            cm.Parameters.AddWithValue("@Telefono", p.TelefonoProvedor);
            cm.Parameters.AddWithValue("@Empresa", p.EmpresadeProvedor);
            sql = "INSERT INTO provedores (Nombre,Direccion,Telefono,Empresa)  VALUES (@Nombre,@Direccion,@Telefono,@Empresa)";
            cm.CommandText = sql;
            cm.CommandType = CommandType.Text;
            cm.Connection = conexionDB.cConexion;
            cm.ExecuteNonQuery();
            conexionDB.Cerrar();
        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OncidiumSoft.Conexxion_Datos
{
    class Conexion
    {
        /// <summary>
        /// Objeto para la conexion a la base de datos
        /// </summary>
        public MySqlConnection cConexion = new MySqlConnection();

        /// <summary>
        /// Metodo para conectarse a la base de datos
        /// </summary>
        public void Conectar()
        {
            string strCadenaConexion;
            strCadenaConexion = "SERVER=" + "localhost" + ";PORT=3306" + ";DATABASE=" + "vivero" + ";UID=" + "root" + ";PWD=" + "root";
            cConexion.ConnectionString = strCadenaConexion;
            cConexion.Open();
        }
        /// <summary>
        /// Metodo para cerrar la conexion a la base de datos
        /// </summary>
        public void Cerrar()
        {
            cConexion.Close();
        }
    }
}

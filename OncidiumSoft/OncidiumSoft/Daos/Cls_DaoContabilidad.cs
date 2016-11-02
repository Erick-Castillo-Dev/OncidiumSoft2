using OncidiumSoft.Conexxion_Datos;
using OncidiumSoft.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace OncidiumSoft.Daos
{
    class Cls_DaoContabilidad
    {
        /// <summary>
        /// Creación del objeto para obtener la conexion
        /// </summary>
        Conexion objConexion = new Conexion();
        public void conectar()
        {
            objConexion.Conectar();
        }

    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OncidiumSoft.Objetos
{
    class Cls_Usuarios
    {
        /// <summary>
        /// Creacion de los atributos para los usuarios
        /// </summary>
        private int _idUsuario;
        private string _nombre;
        private string _direccion;
        private string _telefono;
        private string _usuario;
        private string _contrasena;
        private string _puesto;
        /// <summary>
        /// Conexion a db
        /// </summary>
        /// <returns></returns>
        public static MySqlConnection Conexion()
        {
            //conexion para que funcione checar con por que no me acepta la principal
            MySqlConnection conectar = new MySqlConnection("SERVER=" + "localhost" + ";PORT=3306" + ";DATABASE=" + "vivero" + ";UID=" + "root" + ";PWD=" + "root");

            conectar.Open();
            return conectar;
        }
        /// <summary>
        /// Getter y setter del id
        /// </summary>
        public int idUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }
        /// <summary>
        /// Getter y setter del nombre
        /// </summary>
        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        /// <summary>
        /// Getter y setter de la direcion
        /// </summary>
        public string direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }
        /// <summary>
        /// Getter y setter del telefono
        /// </summary>
        public string telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
        /// <summary>
        /// Getter y setter del usuario
        /// </summary>
        public string usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }
        /// <summary>
        /// Getter y setter de la contrasena
        /// </summary>
        public string contrasena
        {
            get { return _contrasena; }
            set { _contrasena = value; }
        }
        /// <summary>
        /// Gettr y setter del puesto
        /// </summary>
        public string puesto
        {
            get { return _puesto; }
            set { _puesto = value; }
        }

    }
}

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
        /// Variables para la manipulacion de los usuarios.
        /// </summary>
        private int idUsuarios;
        private string Nombre;
        private string Direccion;
        private string Telefono;
        private string Usuario;
        private string Contrasena;
        private string Puesto;
        /// <summary>
        /// Getter y setter del id del usuario.
        /// </summary>
        public int iddeUsuario
        {
            get
            {
                return idUsuarios;
            }
            set
            {
                idUsuarios = value;
            }
        }
        /// <summary>
        /// Getter y setter del nombre del usuario.
        /// </summary>
        public string nombreUasuario
        {
            get
            {
                return Nombre;
            }
            set
            {
                Nombre = value;
            }
        }
        /// <summary>
        /// Getter y setter de la direccion del usuario
        /// </summary>
        public string direccionUsuario
        {
            get
            {
                return Direccion;
            }
            set
            {
                Direccion = value;
            }
        }
        /// <summary>
        /// Getter y setter del telefono del usuario
        /// </summary>
        public string telefonoUsuario
        {
            get
            {
                return Telefono;
            }
            set
            {
                Telefono = value;
            }
        }
        /// <summary>
        /// Getter y setter de la Nombre de usuario
        /// </summary>
        public string cuentaUsuario
        {
            get
            {
                return Usuario;
            }
            set
            {
                Usuario = value;
            }
        }

        /// <summary>
        /// Getter y setter de la contrasena del usuario
        /// </summary>
        public string contrasenadeUsuario
        {
            get
            {
                return Contrasena;
            }
            set
            {
                Contrasena = value;
            }

        }
        /// <summary>
        /// Getter y setter del puesto del usuario.
        /// </summary>
        public string puestodeUsuario
        {
            get
            {
                return Puesto;
            }
            set
            {
                Puesto = value;
            }

            
        }
    }
}

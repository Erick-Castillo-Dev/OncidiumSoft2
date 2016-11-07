using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OncidiumSoft.Objetos
{
    class Cls_Usuarios
    {

        private int _idUsuario;
        private string _nombre;
        private string _direccion;
        private string _telefono;
        private string _usuario;
        private string _contrasena;
        private string _puesto;

        public int idUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }

        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        public string telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        public string usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }

        public string contrasena
        {
            get { return _contrasena; }
            set { _contrasena = value; }
        }

        public string puesto
        {
            get { return _puesto; }
            set { _puesto = value; }
        }

    }
}

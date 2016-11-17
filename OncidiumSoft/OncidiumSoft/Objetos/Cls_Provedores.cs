using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OncidiumSoft.Objetos
{
    class Cls_Provedores
    {
        /// <summary>
        /// Variables para provedores
        /// </summary>
        private int idProvedores;
        private string Nombre;
        private string Direccion;
        private string Telefono;
        private string Empresa;
        /// <summary>
        /// Getter y setter para el id 
        /// </summary>
        public int iddeProvedores
        {
            get { return idProvedores; }
            set { idProvedores = value; }
        }

        /// <summary>
        /// Getter y setter del nombre provedor
        /// </summary>
        public string NombreProvedor
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        /// <summary>
        /// Getter y setter de la direccion provedor
        /// </summary>
        public string DireccionProvedor
        {
            get { return Direccion; }
            set { Direccion = value; }
        }
        /// <summary>
        /// Getter y setter del telefono
        /// </summary>
        public string TelefonoProvedor
        {
            get { return Telefono; }
            set { Telefono = value; }
        }
        /// <summary>
        /// Getter y setter de la empresa
        /// </summary>
        public string EmpresadeProvedor
        {
            get { return Empresa; }
            set { Empresa = value; }
        }
    }
}

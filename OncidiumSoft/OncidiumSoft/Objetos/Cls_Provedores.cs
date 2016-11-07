using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OncidiumSoft.Objetos
{
    class Cls_Provedores
    {
        /// <summary>
        /// Definicion de las variables de provedores.
        /// </summary>
        private int idProvedores;
        private string Nombre;
        private string Direccion;
        private string Telefono;
        private string Empresa;
      /// <summary>
      /// Getter y setter para manipular el id del provedor.
      /// </summary>
        public int idProvedor
        {
            get
            {
                return idProvedores;
            }
            set
            {
                idProvedores = value;
            }
        }
        /// <summary>
        /// Getter y setter para manipular el nombre del provedor.
        /// </summary>
        public string NombreProvedor
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
        /// Getter y setter para la direccion del provedor.
        /// </summary>
        public string DireccionProvedor
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
        /// Getter y setter del telefono del provedor.
        /// </summary>
        public string TelefonoProvedor
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
        /// Getter y setter de la empresa a la empresa a la que pertenece.
        /// </summary>
        public string NombreEmpresa
        {
            get
            {
                return Empresa;
            }
            set
            {
                Empresa = value;
            }
        }
    }
}

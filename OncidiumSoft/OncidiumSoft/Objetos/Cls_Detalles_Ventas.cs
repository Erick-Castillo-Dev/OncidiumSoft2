using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OncidiumSoft.Objetos
{
    class Cls_Detalles_Ventas
    {
        /// <summary>
        /// Creación de los atributos para los detalles de venta
        /// </summary>
        private int _idProducto;
        private int _idVentas;
        private int _Canridad;
        private float _Precio;

        /// <summary>
        /// Getters y setters del id de detalle de venta
        /// </summary>
        public int idProducto
        {
            get { return _idProducto; }
            set { _idProducto = value; }
        }
        /// <summary>
        /// Getter y setter de ID vebta
        /// </summary>
        public int idVentas
        {
            get { return _idVentas; }
            set { _idVentas = value; }
        }
        /// <summary>
        /// Getter y  setter de la cantidad
        /// </summary>
        public int Canridad
        {
            get { return _Canridad; }
            set { _Canridad = value; }
        }
        /// <summary>
        /// Getter y setter del precio
        /// </summary>
        public float Precio
        {
            get { return _Precio; }
            set { _Precio = value; }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OncidiumSoft.Objetos
{
    class Cls_Detalles_Ventas
    {

        private int _idProducto;
        private int _idVentas;
        private int _Canridad;
        private float _Precio;

        public int idProducto
        {
            get { return _idProducto; }
            set { _idProducto = value; }
        }

        public int idVentas
        {
            get { return _idVentas; }
            set { _idVentas = value; }
        }

        public int Canridad
        {
            get { return _Canridad; }
            set { _Canridad = value; }
        }

        public float Precio
        {
            get { return _Precio; }
            set { _Precio = value; }
        }

    }
}

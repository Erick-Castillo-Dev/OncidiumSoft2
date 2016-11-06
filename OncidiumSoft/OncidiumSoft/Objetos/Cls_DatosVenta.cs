using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OncidiumSoft.Objetos
{
    class Cls_DatosVenta
    {

        private int _ID;
        private string _Producto;
        private int _Cantidad;
        private string _Tipo;
        private double _Precio_Unitario;
        private double _Sub_Total;

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public string Producto
        {
            get { return _Producto; }
            set { _Producto = value; }
        }

        public int Cantidad
        {
            get { return _Cantidad; }
            set { _Cantidad = value; }
        }

        public string Tipo
        {
            get { return _Tipo; }
            set { _Tipo = value; }
        }

        public double Precio_Unitario
        {
            get { return _Precio_Unitario; }
            set { _Precio_Unitario = value; }
        }

        public double Sub_Total
        {
            get { return _Sub_Total; }
            set { _Sub_Total = value; }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OncidiumSoft.Objetos
{
    class Cls_DatosVenta
    {
        /// <summary>
        /// Creación de los atributos para Datos venta
        /// </summary>
        private int _ID;
        private string _Producto;
        private int _Cantidad;
        private string _Tipo;
        private double _Precio_Unitario;
        private double _Sub_Total;
        /// <summary>
        /// Getters y setter de id
        /// </summary>
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        /// <summary>
        /// Getter y setter del producto
        /// </summary>
        public string Producto
        {
            get { return _Producto; }
            set { _Producto = value; }
        }
        /// <summary>
        /// Getter y setter de cantidad
        /// </summary>
        public int Cantidad
        {
            get { return _Cantidad; }
            set { _Cantidad = value; }
        }
        /// <summary>
        /// Getter y setter del tipo
        /// </summary>
        public string Tipo
        {
            get { return _Tipo; }
            set { _Tipo = value; }
        }
        /// <summary>
        /// Getter setter del precio unitario
        /// </summary>
        public double Precio_Unitario
        {
            get { return _Precio_Unitario; }
            set { _Precio_Unitario = value; }
        }
       /// <summary>
       /// Getter y setter del sub total
       /// </summary>
        public double Sub_Total
        {
            get { return _Sub_Total; }
            set { _Sub_Total = value; }
        }

    }
}

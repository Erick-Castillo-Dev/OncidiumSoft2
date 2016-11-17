using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OncidiumSoft.Objetos
{
    class Cls_Compra
    {
        /// <summary>
        /// Creación de los atributos para el ajuste del inventario
        /// </summary>
        private int _idProducto;
        private string _producto;
        private string _tipo;
       
        private int _cantidad;
        private float _precio;
        private float _total;
        private DateTime _fecha_compra;
        private DateTime _fecha_Entrega;
       
        private string _empleado;
        
        /// <summary>
        /// Getters y setters de la id del producto
        /// </summary>

        public int idproducto
        {
            get { return _idProducto; }
            set { _idProducto = value; }
        }
        /// <summary>
        /// Getter ys etter del producto
        /// </summary>
        public string Producto
        {
            get { return _producto; }
            set { _producto = value; }
        }
        /// <summary>
        /// Getter y setter del tipo
        /// </summary>
        public string tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
        /// <summary>
        /// Getter y setter de la cantidad
        /// </summary>
        public int cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }
        /// <summary>
        /// Getter y setter del precio
        /// </summary>
        public float precio
        {
            get { return _precio; }
            set { _precio = value; }
        }
        /// <summary>
        /// Getter ys setter del total
        /// </summary>
        public float total
        {
            get { return _total; }
            set { _total = value; }
        }
        /// <summary>
        /// Getter y setter del empleado
        /// </summary>
        public string empleado
        {
            get { return _empleado; }
            set { _empleado = value; }
        }

        /// <summary>
        /// Getter y setter de la fecha compra
        /// </summary>
        public DateTime fecha_compra
        {
            get { return _fecha_compra; }
            set { _fecha_compra = value; }
        }
        /// <summary>
        /// Getter y setter de la fecha entrega
        /// </summary>
        public DateTime fecha_Entrega
        {
            get { return _fecha_Entrega; }
            set { _fecha_Entrega = value; }
        }

    }
}

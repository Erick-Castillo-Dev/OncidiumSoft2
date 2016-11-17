using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OncidiumSoft.Objetos
{
    class Cls_Ventas
    {
        /// <summary>
        /// Creacion de los atributos para ventas
        /// </summary>
        private int _idVenta;
        private string _cliente;
        private string _domicilio;
        private string _descripcion;
        private float _anticipo;
        private float _subTotal;
        private float _total;
        private DateTime _fecha_Realizar;
        private DateTime _fecha_Entrega;
        private bool _entrega;
        private string _tipo;
        private int _descuento;
        private int _idUsuario;
        private bool _entregado;
        private string _telefono;
        /// <summary>
        /// Getter y setter del id de venta
        /// </summary>
        public int idVenta
        {
            get { return _idVenta; }
            set { _idVenta = value; }
        }
        /// <summary>
        /// Getter y setter del cliente
        /// </summary>
        public string cliente
        {
            get { return _cliente; }
            set { _cliente = value; }
        }
        /// <summary>
        /// Getter y setter del domicilio
        /// </summary>
        public string domicilio
        {
            get { return _domicilio; }
            set { _domicilio = value; }
        }
        /// <summary>
        /// Getter y setter de la descripcion
        /// </summary>
        public string descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
        /// <summary>
        /// Getter y setter del anticipo
        /// </summary>
        public float anticipo
        {
            get { return _anticipo; }
            set { _anticipo = value; }
        }
        /// <summary>
        /// Getter y setter del subtotal
        /// </summary>
        public float subTotal
        {
            get { return _subTotal; }
            set { _subTotal = value; }
        }
        /// <summary>
        /// Getter y setter del total
        /// </summary>
        public float total
        {
            get { return _total; }
            set { _total = value; }
        }
        /// <summary>
        /// Getter y setter de la fecha
        /// </summary>
        public DateTime fecha_Realizar
        {
            get { return _fecha_Realizar; }
            set { _fecha_Realizar = value; }
        }
        /// <summary>
        /// Getter y setter de la fecha de entrega
        /// </summary>
        public DateTime fecha_Entrega
        {
            get { return _fecha_Entrega; }
            set { _fecha_Entrega = value; }
        }
        /// <summary>
        /// Getter y setter de la entrega
        /// </summary>
        public bool entrega
        {
            get { return _entrega; }
            set { _entrega = value; }
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
        /// Getter y setter del descuento
        /// </summary>
        public int descuento
        {
            get { return _descuento; }
            set { _descuento = value; }
        }
        /// <summary>
        /// Getter y setter del id del usuario
        /// </summary>
        public int idUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }
        /// <summary>
        /// Getter y setter de entregado
        /// </summary>
        public bool entregado
        {
            get { return _entregado; }
            set { _entregado = value; }
        }
        /// <summary>
        /// Getter y setter de telefono
        /// </summary>
        public string telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

    }
}

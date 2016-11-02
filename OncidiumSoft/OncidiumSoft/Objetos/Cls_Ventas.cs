using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OncidiumSoft.Objetos
{
    class Cls_Ventas
    {

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

        public int idVenta
        {
            get { return _idVenta; }
            set { _idVenta = value; }
        }

        public string cliente
        {
            get { return _cliente; }
            set { _cliente = value; }
        }

        public string domicilio
        {
            get { return _domicilio; }
            set { _domicilio = value; }
        }

        public string descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public float anticipo
        {
            get { return _anticipo; }
            set { _anticipo = value; }
        }

        public float subTotal
        {
            get { return _subTotal; }
            set { _subTotal = value; }
        }

        public float total
        {
            get { return _total; }
            set { _total = value; }
        }

        public DateTime fecha_Realizar
        {
            get { return _fecha_Realizar; }
            set { _fecha_Realizar = value; }
        }

        public DateTime fecha_Entrega
        {
            get { return _fecha_Entrega; }
            set { _fecha_Entrega = value; }
        }

        public bool entrega
        {
            get { return _entrega; }
            set { _entrega = value; }
        }

        public string tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        public int descuento
        {
            get { return _descuento; }
            set { _descuento = value; }
        }

        public int idUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }

        public bool entregado
        {
            get { return _entregado; }
            set { _entregado = value; }
        }

    }
}

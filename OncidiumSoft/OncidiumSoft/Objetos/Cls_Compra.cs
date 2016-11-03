using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OncidiumSoft.Objetos
{
    class Cls_Compra
    {
        private int _idProducto;
        private string _producto;
        private string _tipo;
       
        private int _cantidad;
        private float _precio;
        private float _total;
        private DateTime _fecha_compra;
        private DateTime _fecha_Entrega;
       
        private string _empleado;
        
        

        public int idproducto
        {
            get { return _idProducto; }
            set { _idProducto = value; }
        }

        public string Producto
        {
            get { return _producto; }
            set { _producto = value; }
        }
        public string tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
        public int cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }
        public float precio
        {
            get { return _precio; }
            set { _precio = value; }
        }
        public float total
        {
            get { return _total; }
            set { _total = value; }
        }
        public string empleado
        {
            get { return _empleado; }
            set { _empleado = value; }
        }
        public DateTime fecha_compra
        {
            get { return _fecha_compra; }
            set { _fecha_compra = value; }
        }

        public DateTime fecha_Entrega
        {
            get { return _fecha_Entrega; }
            set { _fecha_Entrega = value; }
        }

    }
}

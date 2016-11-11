using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OncidiumSoft.Objetos
{
    class Cls_AjusteInventario
    {
        /// <summary>
        /// Creación de los atributos para el ajuste del inventario
        /// </summary>
        private string pNombre;
        private int pCantidad;
        private double pPrecioCosto;
        private double pPrecioCliente;
        private bool pEstado;
        private bool pTipoAjuste;

        /// <summary>
        /// Getters y setters del ajuste de inventario
        /// </summary>
        public string Nombre
        {
            get
            {
                return pNombre;
            }
            set
            {
                pNombre = value;
            }
        }
        public int Cantidad
        {
            get
            {
                return pCantidad;
            }
            set
            {
                pCantidad = value;
            }
        }
        public double PrecioCosto
        {
            get
            {
                return pPrecioCosto;
            }
            set
            {
                pPrecioCosto = value;
            }
        }
        public double PrecioCliente
        {
            get
            {
                return pPrecioCliente;
            }
            set
            {
                pPrecioCliente = value;
            }
        }
        public bool Estado
        {
            get
            {
                return pEstado;
            }
            set
            {
                pEstado = value;
            }
        }
        public bool TipoAjuste
        {
            get
            {
                return pTipoAjuste;
            }
            set
            {
                pTipoAjuste = value;
            }
        }
    }
}

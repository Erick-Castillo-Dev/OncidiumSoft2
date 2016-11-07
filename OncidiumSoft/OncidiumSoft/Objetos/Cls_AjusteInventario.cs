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
        private decimal pPrecioCosto;
        private decimal pPrecioCliente;
        private string pEstado;
        private string pTipoAjuste;

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
        public decimal PrecioCosto
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
        public decimal PrecioCliente
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
        public string Estado
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
        public string TipoAjuste
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

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
        /// Getters y setters del nombre
        /// </summary>
        /// 
        
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


        /// <summary>
        /// getter y setter de la cantidad
        /// </summary>
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
        /// <summary>
        /// Getter y setter del precio costo
        /// </summary>
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
        /// <summary>
        /// Getter y setter del precio cliente
        /// </summary>
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
        /// <summary>
        /// Getter y setter del estado
        /// </summary>
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
        /// <summary>
        /// Getter y setter del tipo ajuste
        /// </summary>
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

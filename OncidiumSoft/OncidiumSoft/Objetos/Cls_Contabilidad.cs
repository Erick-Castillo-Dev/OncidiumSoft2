using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OncidiumSoft.Objetos
{
    class Cls_Contabilidad
    {
        /// <summary>
        /// Creación de los atributos para la contabilidad
        /// </summary>
        private int pidContabilidad;
        private DateTime pFechaInicio;
        private DateTime pFechaFin;
        private double pGanancia_Perdida;

        /// <summary>
        /// Getters y setters del idcontabilidad
        /// </summary>
        public int idContabilidad
        {
            get
            {
                return pidContabilidad;
            }
            set
            {
                pidContabilidad = value;
            }
        }
        /// <summary>
        /// Getter y setter de la fecha inicio
        /// </summary>
        public DateTime FechaInicio
        {
            get
            {
                return pFechaInicio;
            }
            set
            {
                pFechaInicio = value;
            }
        }
        /// <summary>
        /// Gettter y setter de la Fecha inicial
        /// </summary>
        public DateTime FechaFin
        {
            get
            {
                return pFechaFin;
            }
            set
            {
                pFechaFin = value;
            }
        }
        /// <summary>
        /// Getter y setter de la ganacioa perdida
        /// </summary>
        public double Ganancia_Perdida
        {
            get
            {
                return pGanancia_Perdida;
            }
            set
            {
                pGanancia_Perdida = value;
            }
        }
    }
}

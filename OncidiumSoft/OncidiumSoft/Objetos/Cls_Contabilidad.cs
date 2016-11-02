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
        /// Getters y setters de contabilidad
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

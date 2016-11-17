using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OncidiumSoft.Objetos
{
    class Cls_DatosPedidos
    {
        /// <summary>
        /// Creación de los atributos para los pedidos
        /// </summary>
        private DateTime _Fecha;
        private string _Cliente;
        private string _Entrega_a_Domicilio;
        private string _Pagado;
        private int _ID;

        /// <summary>
        /// Getters y setters del id
        /// </summary>
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        
        /// <summary>
        /// Getter y setter de pagado
        /// </summary>
        public string Pagado
        {
            get { return _Pagado; }
            set { _Pagado = value; }
        }
        
        /// <summary>
        /// Getter y setter de la entrega domicilio
        /// </summary>
        public string Entrega_a_Domicilio
        {
            get { return _Entrega_a_Domicilio; }
            set { _Entrega_a_Domicilio = value; }
        }
        /// <summary>
        /// Getter y setter de Cliente
        /// </summary>

        public string Cliente
        {
            get { return _Cliente; }
            set { _Cliente = value; }
        }
        
        /// <summary>
        /// Getter y setter de fecha
        /// </summary>
        public DateTime Fecha
        {
            get { return _Fecha; }
            set { _Fecha = value; }
        }
        


    }
}

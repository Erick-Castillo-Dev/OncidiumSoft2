using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OncidiumSoft.Objetos
{
    class Cls_DatosPedidos
    {

        private DateTime _Fecha;
        private string _Cliente;
        private string _Entrega_a_Domicilio;
        private string _Pagado;
        private int _ID;

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        

        public string Pagado
        {
            get { return _Pagado; }
            set { _Pagado = value; }
        }
        

        public string Entrega_a_Domicilio
        {
            get { return _Entrega_a_Domicilio; }
            set { _Entrega_a_Domicilio = value; }
        }
        

        public string Cliente
        {
            get { return _Cliente; }
            set { _Cliente = value; }
        }
        

        public DateTime Fecha
        {
            get { return _Fecha; }
            set { _Fecha = value; }
        }
        


    }
}

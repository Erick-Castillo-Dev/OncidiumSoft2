using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OncidiumSoft.Objetos
{
    class Cls_Productos
    { 
        /// <summary>
        /// Definicion de las variables para la manipulación de la tabla.
        /// </summary>
        private int idProductos;
        private string Nombre;
        private double Precio_Cliente;
        private string Tipo;
        private int Catidad;
        private byte[] img;
        private int idProvedores;//esta es llave foranea
        private double Precio_Costo;
        private bool Disponible;//checar el tipo de dato de la base de datos
        private bool Ajuste;//checar el tipo de dato de la base de datos

        /// <summary>
        /// Getter y setter del id de los productos.
        /// </summary>
        public int idProductoss
        {
            get
            {
                return idProductos;
            }
            set
            {
                idProductos = value;
            }
        }
        /// <summary>
        /// Getter y setter del nombre del producto
        /// </summary>
            public string NombreProducto
            {
            get
            {
                return Nombre;
            }
            set
            {
                Nombre = value;
            }
            }
        /// <summary>
        /// Getter y setter del precio al cliente.
        /// </summary>
            public double PrecioalCliente
            {
                get
                {
                    return Precio_Cliente;
                }
                set
                {
                    Precio_Cliente = value;
                }
            }
        /// <summary>
        /// Getter y setter del tipo del producto
        /// </summary>
            public string TipoProducto
            {
                get
                {
                    return Tipo;
                }
                set
                {
                    Tipo = value;
                }
            }
        /// <summary>
        /// Getter y setter de la cantidad del producto.
        /// </summary>
            public int CantidadProducto
            {
                get
                {
                    return Catidad;
                }
                set
                {
                    Catidad = value;
                }
            }
        /// <summary>
        /// Getter y setter  de la imagen del producto.
        /// </summary>
            public byte[] imgenProducto
            {
                get
                {
                    return img;
                }
                set
                {
                    img = value;
                }
            }
        /// <summary>
        /// Getter y setter del precio costo del producto
        /// </summary>
            public double Precio_costo
            {
                get
                {
                    return Precio_Costo;
                }
                set
                {
                    Precio_Costo = value;
                }
            }
        /// <summary>
        /// Getter y setter de la disponibilidad del producto
        /// </summary>
         public bool Disponibilidad
            {
                get
                {
                    return Disponible;
                }
                set
                {
                    Disponible = value;
                }
            }
        /// <summary>
        /// Getter y setter de los ajustes de los productos
        /// </summary>
         public bool AjusteProducto
         {
             get
             {
                 return Ajuste;
             }
             set
             {
                 Ajuste = value;
             }
         }  
        //Este getter y setter es llave foranea de la tabla de provedores
                /// <summary>
        /// Getter y setter del id de los proveedores
        /// </summary>
            public int iddeProvedores
            {
                get
                {
                    return idProvedores;
                }
                set
                {
                    idProvedores = value;
                }
            }
    }
}

using OncidiumSoft.Daos;
using OncidiumSoft.Objetos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OncidiumSoft.Formularios
{
    public partial class FrmAgregarProductos : Form
    {
        public FrmAgregarProductos()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Guarda el nuevo producto registrado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Objecto de ubicacion de getters y Setters
            Cls_Productos objProductos = new Cls_Productos();
            

            // lectura de datos y captura de los mismos.
            objProductos.idProductoss = Convert.ToInt32(txtid.Text);
            objProductos.NombreProducto = txtNombre.Text;
            objProductos.PrecioalCliente = Convert.ToDouble(txtpreciocliente.Text);
            objProductos.TipoProducto = cboxTipo.Text;
            objProductos.CantidadProducto = Convert.ToInt32(txtCantidad.Text);
          ///  objProductos.imgenProducto = txtImagen.Text;
            objProductos.iddeProvedores = Convert.ToInt32(txtidProvedor.Text);
            objProductos.Precio_costo = Convert.ToDouble(txtpreciocliente.Text);
            ///objProductos.Disponibilidad = cBoxDiponible.Text;//checar este
          ///  objProductos.AjusteProducto = cBoxAjuste.Text;

            //agregacion con el objecto
            Cls_DaoProductos datosProductos = new Cls_DaoProductos();
            //envio al objecto que agrega
            datosProductos.AgregarProducto(objProductos);
            //mensaje de confirmacion.
            MessageBox.Show("Producto registrado", "Informacion");
            




















            MessageBox.Show("Producto registrado","CONFIRMACION!!");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

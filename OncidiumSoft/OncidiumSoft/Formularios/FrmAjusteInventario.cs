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
    public partial class FrmAjusteInventario : Form
    {
        public FrmAjusteInventario()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Objeto para acceder a los metodos necesarios para el ajuste de inventario
        /// </summary>
        Cls_DaoAjusteInventario objA = new Cls_DaoAjusteInventario();
        /// <summary>
        /// Objeto para la clase ajuste de inventario
        /// </summary>
        Cls_AjusteInventario obj = new Cls_AjusteInventario();

        /// <summary>
        /// Método modificar el inventario
        /// </summary>
        public void Modificar()
        {
            objA.ModificarInventario(obj);
            MessageBox.Show("Registro satisfactorio", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Método para alterar los campos modificados por el usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(cboProducto.Text == "" || txtCantidad.Text == "" || txtPrecioCosto.Text == "" || txtPrecioCliente.Text == "" || cboEstado.Text == "" || cboAjuste.Text == "")
            {
                MessageBox.Show("Existen campos vacios");
            }else
            {
                try
                {
                    obj.Nombre = cboProducto.Text;
                    obj.Cantidad = Convert.ToInt32(txtCantidad.Text);
                    obj.PrecioCosto = double.Parse(txtPrecioCosto.Text);
                    obj.PrecioCliente = double.Parse(txtPrecioCliente.Text);

                    if(cboEstado.Text == "Disponible"){
                        obj.Estado = true;
                    }
                    else
                    {
                        obj.Estado = false;
                    }

                    if (cboAjuste.Text == "Alta")
                    {
                        obj.TipoAjuste = true;
                    }
                    else
                    {
                        obj.TipoAjuste = false;
                    }

                    if (MessageBox.Show("¿Estas seguro que deseas modificar el producto?", "*** AVISO ***", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Modificar();

                        txtCantidad.Clear();
                        txtPrecioCosto.Clear();
                        txtPrecioCliente.Clear();
                        cboEstado.Text = "";
                        cboAjuste.Text = "";

                        cboAjuste.Focus();
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show("Asegurese de ingresar el formato correcto");
                    if(txtPrecioCosto.Text != "")
                    {
                        txtPrecioCosto.Clear();
                    }else if(txtPrecioCliente.Text != "")
                    {
                        txtPrecioCliente.Clear();
                    }
                }
                
                
            }
        }

        /// <summary>
        /// Cancela el ajuste del inventario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        /// <summary>
        /// Método que solo permite numeros en el textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsNumber(e.KeyChar) == false) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
            else
                e.Handled = false;
        }

        /// <summary>
        /// Método que se lanza al ingresar al formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAjusteInventario_Load(object sender, EventArgs e)
        {
            txtCantidad.Enabled = false;
            txtPrecioCosto.Enabled = false;
            txtPrecioCliente.Enabled = false;
            cboEstado.Enabled = false;
            cboAjuste.Enabled = false;
            cboProducto.DataSource = objA.obtenerProducto();
        }

        /// <summary>
        /// Variable necesario para saber si el producto existe en la base de datos
        /// </summary>
        bool existe;

        /// <summary>
        /// Método keypress para el combo de productos que verificara si existe el producto para acceder a sus atributos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((int)e.KeyChar == (int)Keys.Enter){
                existe = objA.Existe(cboProducto.Text);

                if(existe == false)
                {
                    MessageBox.Show("El producto no existe");
                    cboProducto.Enabled = true;
                    txtCantidad.Enabled = false;
                    txtPrecioCosto.Enabled = false;
                    txtPrecioCliente.Enabled = false;
                    cboEstado.Enabled = false;
                    cboAjuste.Enabled = false;

                    cboProducto.Focus();
                }else
                {
                    cboProducto.Enabled = true;
                    txtCantidad.Enabled = true;
                    txtPrecioCosto.Enabled = true;
                    txtPrecioCliente.Enabled = true;
                    cboEstado.Enabled = true;
                    cboAjuste.Enabled = true;

                    Cls_Productos datos = objA.Vaciar(cboProducto.Text);

                    cboProducto.Text = datos.NombreProducto;
                    txtCantidad.Text = datos.CantidadProducto.ToString();
                    txtPrecioCosto.Text = datos.Precio_costo.ToString();
                    txtPrecioCliente.Text = datos.PrecioalCliente.ToString();

                    if (datos.Disponibilidad)
                    {
                        cboEstado.Text = "Disponible";
                    }else
                    {
                        cboEstado.Text = "No disponible";
                    }
                    if (datos.AjusteProducto)
                    {
                        cboAjuste.Text = "Alta";
                    }else
                    {
                        cboAjuste.Text = "Baja";
                    }

                    cboProducto.Focus();
                }
            }
        }

        /// <summary>
        /// Método keypress para el precio de costo a dos decimales
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPrecioCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }

            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < txtPrecioCosto.Text.Length; i++)
            {
                if (txtPrecioCosto.Text[i] == ',')
                    IsDec = true;

                if (IsDec && nroDec++ >= 2)
                {
                    e.Handled = true;
                    return;
                }
            }

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else if (e.KeyChar == ',')
                e.Handled = (IsDec) ? true : false;
            else
                e.Handled = true;
        }

        /// <summary>
        /// Método keypress para el precio de costo a dos decimales
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPrecioCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }

            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < txtPrecioCliente.Text.Length; i++)
            {
                if (txtPrecioCliente.Text[i] == ',')
                    IsDec = true;

                if (IsDec && nroDec++ >= 2)
                {
                    e.Handled = true;
                    return;
                }
            }

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else if (e.KeyChar == ',')
                e.Handled = (IsDec) ? true : false;
            else
                e.Handled = true;
        }
    }
}

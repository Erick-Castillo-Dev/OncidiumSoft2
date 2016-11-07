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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Cls_DaoAjusteInventario objDAjuste = new Cls_DaoAjusteInventario();
            if (cboProducto.Text != string.Empty && txtCantidad.Text != string.Empty && txtPrecioCosto.Text != string.Empty &&
                txtPrecioCliente.Text != string.Empty && cboEstado.Text != string.Empty && cboAjuste.Text != string.Empty)
            {
                Cls_AjusteInventario ajuste = new Cls_AjusteInventario();
                ajuste.Nombre = cboProducto.Text;
                ajuste.Cantidad = Convert.ToInt32(txtCantidad.Text);
                ajuste.PrecioCosto = Convert.ToDecimal(txtPrecioCosto.Text);
                ajuste.PrecioCliente = Convert.ToDecimal(txtPrecioCliente.Text);
                if(cboEstado.Text.Equals("Disponible"))
                {
                    ajuste.Estado = "1";
                }else
                {
                    ajuste.Estado = "0";
                }
                if (cboAjuste.Text.Equals("Alta"))
                {
                    ajuste.TipoAjuste = "1";
                }
                else
                {
                    ajuste.TipoAjuste = "0";
                }
                objDAjuste.AgregarAjuste(ajuste);
            }
            else
            {
                MessageBox.Show("Hay campos vacíos");
            }
        }
    }
}

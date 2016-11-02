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
    public partial class FrmContabilidad : Form
    {
        public FrmContabilidad()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Creación de variables requeridas
        /// </summary>
        double Inversion;

        /// <summary>
        /// Creación de los objetos de las clases de contabilidad
        /// </summary>
        Cls_DaoContabilidad objDCont = new Cls_DaoContabilidad();
        Cls_Contabilidad objCont = new Cls_Contabilidad();

        /// <summary>
        /// Método del formulario principal de contabilidad
        /// </summary>
        private void FrmContabilidad_Load(object sender, EventArgs e)
        {
            lblFechaA.Text = DateTime.Now.ToLongDateString();
        }

        /// <summary>
        /// Método para el boton gastos generales
        /// </summary>
        private void GastosGenerales_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmGastosEspecificos().Show();
        }

        /// <summary>
        /// Método para el boton cancelar
        /// </summary>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtGastosGenerales.Clear();
            txtSalarios.Clear();
            txtGastosGenerales.Enabled = false;
            lblInversionT.Text = "0.00";
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmHistorialContabilidades().Show();
        }

        /// <summary>
        /// Método key press dentro del textbox de salarios
        /// </summary>
        private void txtSalarios_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsNumber(e.KeyChar) == false) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            else
                e.Handled = false;
        }

        private void btnCalcularInversion_Click(object sender, EventArgs e)
        {
            Inversion = double.Parse(txtGastosGenerales.Text) + double.Parse(txtSalarios.Text);
            lblInversionT.Text = Inversion.ToString();
        }
    }
}

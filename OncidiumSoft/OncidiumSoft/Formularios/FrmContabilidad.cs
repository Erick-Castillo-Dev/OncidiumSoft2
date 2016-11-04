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
        /// 
        int con;
        double Inversion, ganancia;

        /// <summary>
        /// Creación de los objetos de las clases de contabilidad
        /// </summary>
        Cls_DaoContabilidad objDCont = new Cls_DaoContabilidad();
        Cls_Contabilidad objCont = new Cls_Contabilidad();
        FrmHistorialContabilidades objHistorial = new FrmHistorialContabilidades();

        /// <summary>
        /// Método para agregar contabilidad
        /// </summary>
        public void Agregar()
        {
            objCont.idContabilidad = con;
            objCont.FechaInicio = Convert.ToDateTime(lblFechaIni.Text);
            objCont.FechaFin = Convert.ToDateTime(lblFechaA.Text);
            objCont.Ganancia_Perdida = Convert.ToDouble(lblGananciaT.Text);
            objDCont.AgregarContabilidad(objCont);
            MessageBox.Show("Contabilidad registrada", "Insertar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con += 1;
        }

        /// <summary>
        /// Método del formulario principal de contabilidad
        /// </summary>
        private void FrmContabilidad_Load(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now;
            int mes = DateTime.Now.Month; 
            int anio = DateTime.Now.Year;
            lblFechaA.Text = DateTime.Now.ToShortDateString();
            lblFechaIni.Text = fecha.ToString("01/" + mes + "/" + anio);
            lblVentasT.Text = objDCont.obtenerVenta();
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
            lblGananciaT.Text = "0.00";
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

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ganancia = double.Parse(lblVentasT.Text) - double.Parse(lblInversionT.Text);
            lblGananciaT.Text = ganancia.ToString();
            Agregar();
        }
    }
}

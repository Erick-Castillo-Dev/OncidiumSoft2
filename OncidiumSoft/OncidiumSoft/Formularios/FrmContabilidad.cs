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
        /// Variables que manejaran la inversion y la ganancia calculada
        /// </summary>
        int con;
        double Inversion, ganancia;

        /// <summary>
        /// Creacion del objeto que permitira acceder a los métodos necesarios para la aplicar a la contabilidad
        /// </summary>
        Cls_DaoContabilidad objDCont = new Cls_DaoContabilidad();
        /// <summary>
        /// Objeto de la clase de contabilidad
        /// </summary>
        Cls_Contabilidad objCont = new Cls_Contabilidad();
        /// <summary>
        /// Objeto del formulario del historial
        /// </summary>
        FrmHistorialContabilidades objHistorial = new FrmHistorialContabilidades();

        /// <summary>
        /// Método para registrar la contabilidad
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
        /// Método que se carga al abrir el formulario principal de contabilidad
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// Método para acceder al formulario de gastos específicos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GastosGenerales_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmGastosEspecificos().Show();
        }

        /// <summary>
        /// Método correspondiente para el botón cancelar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtGastosGenerales.Clear();
            txtSalarios.Clear();
            txtGastosGenerales.Enabled = false;
            lblInversionT.Text = "0.00";
            lblGananciaT.Text = "0.00";
        }

        /// <summary>
        /// Método para acceder al formulario del historial
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHistorial_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmHistorialContabilidades().Show();
        }

        /// <summary>
        /// Método keypress que permite validar el campo de salarios a solo dos decimales
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSalarios_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }

            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < txtSalarios.Text.Length; i++)
            {
                if (txtSalarios.Text[i] == ',')
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
        /// Método para calcular la inversión total
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalcularInversion_Click(object sender, EventArgs e)
        {
            if (txtGastosGenerales.Text != string.Empty && txtSalarios.Text != string.Empty)
            {
                Inversion = double.Parse(txtGastosGenerales.Text) + double.Parse(txtSalarios.Text);
                lblInversionT.Text = Inversion.ToString();
            }
            else
            {
                MessageBox.Show("Hay campos vacíos");
            }
            
        }

        /// <summary>
        /// Método para calcular la ganancia o pérdida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtGastosGenerales.Text != string.Empty && txtSalarios.Text != string.Empty)
            {
                    ganancia = double.Parse(lblVentasT.Text) - double.Parse(lblInversionT.Text);
                    lblGananciaT.Text = ganancia.ToString();
                    Agregar();
            }
            else
            {
                MessageBox.Show("Hay campos vacíos");
            }
        }

        /// <summary>
        /// Método requerido para el textbox de salarios para ir haciendo la suma de los gastos generales con los salarios
        /// al momento de ir escribiendo la cantidad de salarios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSalarios_TextChanged(object sender, EventArgs e)
        {
            if (txtGastosGenerales.Text != string.Empty && txtSalarios.Text != string.Empty)
            {
                try
                {
                    Inversion = double.Parse(txtGastosGenerales.Text) + double.Parse(txtSalarios.Text);
                    lblInversionT.Text = Inversion.ToString();
                }catch(Exception ex)
                {
                    MessageBox.Show("Introduzca el formato correcto para los salarios");
                }
                
            }
            else
            {
                MessageBox.Show("Hay campos vacíos");
                txtSalarios.Clear();
            }
        }

        /// <summary>
        /// Método keypress para el textbox de gastos generales para admitir solo dos decimales
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtGastosGenerales_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }

            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < txtGastosGenerales.Text.Length; i++)
            {
                if (txtGastosGenerales.Text[i] == ',')
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

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
    public partial class frmCalendario : Form
    {
        public frmCalendario()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Evento que Solicita el formulario de reporte
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGenerar_Click(object sender, EventArgs e)
        {    //Objeto del Form frmMostrarReporteDiario
            frmMostrarReporteDiario mostrar = new frmMostrarReporteDiario();
            //Se envia la fecha al metodo que recibe un DateTime
            mostrar.Fecha = dtpFecha.Value;
            mostrar.Show();
        }

        private void frmCalendario_Load(object sender, EventArgs e)
        {

        }
    }
}

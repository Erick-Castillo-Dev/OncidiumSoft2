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
    public partial class frmPorSemana : Form
    {
        public frmPorSemana()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    
        /// <summary>
        /// Evento que muestra el reporte en un nuevo form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            //Objeto del formulario frmMostrarReporteSemana
            frmMostrarReporteSemana jiji = new frmMostrarReporteSemana();
            jiji.Show();
        }

        private void frmPorSemana_Load(object sender, EventArgs e)
        {
           
        
        }
        /// <summary>
        /// Evento que carga la fecha en el componente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            //Se obtiene la fecha del DateTimePicker
            De.Text = dtpFecha.Value.Date.ToShortDateString();
            //Aqui se hace la resta de los 7 dias de una semana
            Semana.Text = dtpFecha.Value.AddDays(-7).ToShortDateString();
        }
        /// <summary>
        /// Evento para validar la semana selecionada de reporte
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGenerar_Click_1(object sender, EventArgs e)
        {
            frmMostrarReporteSemana mostrar = new frmMostrarReporteSemana();
            //Se envia la fecha al metodo que recibe un DateTime
            mostrar.Fecha = dtpFecha.Value;
            mostrar.Show();
        }
    }
}

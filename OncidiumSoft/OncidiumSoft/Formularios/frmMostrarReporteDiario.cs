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
    public partial class frmMostrarReporteDiario : Form
    {
        public frmMostrarReporteDiario()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Evento que carga el reporte al iniciar el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMostrarReporteDiario_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            // Esta línea de código carga datos en la tabla 'dataSetPrincipal.DataTable' Puede moverla o quitarla según sea necesario.
            this.dataTableTableAdapter.Fill(this.dataSetPrincipal.DataTable, Fecha);
            
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Metodo que recibe una varieble tipo DateTime la cual sirve para el procedimiento almacenado
        /// </summary>
           public DateTime Fecha { get; set; }
    }

        

     
}

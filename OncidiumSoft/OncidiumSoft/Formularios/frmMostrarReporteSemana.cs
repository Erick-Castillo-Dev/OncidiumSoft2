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
    public partial class frmMostrarReporteSemana : Form
    {
        public frmMostrarReporteSemana()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Evento que carga el reporte al iniciar el Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMostrarReporteSemana_Load(object sender, EventArgs e)
        {

           
            // Esta línea de código carga datos en la tabla 'dataSetPrincipal.DataTable2' Puede moverla o quitarla según sea necesario.
            this.dataTable2TableAdapter.Fill(this.dataSetPrincipal.DataTable2,Fecha);
            this.reportViewer1.RefreshReport();

      
        }

        /// <summary>
        /// Metodo que recibe una varieble tipo DateTime la cual sirve para el procedimiento almacenado
        /// </summary>
        public DateTime Fecha { get; set; }
        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}

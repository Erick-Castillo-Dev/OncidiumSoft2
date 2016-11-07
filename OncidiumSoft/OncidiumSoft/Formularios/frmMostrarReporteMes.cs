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
    public partial class frmMostrarReporteMes : Form
    {
        public frmMostrarReporteMes()
        {
            InitializeComponent();
        }

        private void frmMostrarReporteMes_Load(object sender, EventArgs e)
        {
            // Esta línea de código carga datos en la tabla 'dataSetPrincipal.DataTable1' Puede moverla o quitarla según sea necesario.
            this.dataTable1TableAdapter.Fill(this.dataSetPrincipal.DataTable1, Mes);
            this.reportViewer1.RefreshReport();
        }
        /// <summary>
        /// Metodo que recibe un int el cual sirve para el procedimiento almacenado
        /// </summary>
        public Int64 Mes { get; set; }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}

using Microsoft.Reporting.WinForms;
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
    public partial class frmMostrarReporte : Form
    {
        public frmMostrarReporte()
        {
            InitializeComponent();
        }

        private void frmMostrarReporte_Load(object sender, EventArgs e)
        {
            
        this.dataTableTableAdapter.Fill(this.dataSetPrincipal.DataTable, Fecha);
        this.reportViewer1.RefreshReport();
      
        }

        public DateTime Fecha { get; set; }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void dataTableBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMostrarReporte
            // 
            this.ClientSize = new System.Drawing.Size(287, 261);
            this.Name = "frmMostrarReporte";
            this.ResumeLayout(false);

        }


     

    }
}

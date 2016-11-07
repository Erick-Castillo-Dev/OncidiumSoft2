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

            this.dataTable1TableAdapter.Fill(this.dataSetPrincipal.DataTable1, Mes);
            this.reportViewer1.RefreshReport();
        }

        public Int64 Mes { get; set; }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}

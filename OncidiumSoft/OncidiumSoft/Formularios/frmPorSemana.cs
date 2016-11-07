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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            frmMostrarReporteSemana jiji = new frmMostrarReporteSemana();
            jiji.Show();
        }

        private void frmPorSemana_Load(object sender, EventArgs e)
        {
            //Se obtiene la fecha actual
            label2.Text = DateTime.Now.ToShortDateString();
            //Aqui se hace la resta de los 7 dias de una semana
            label3.Text = DateTime.Today.AddDays(-7).ToShortDateString();
        
        }
    }
}

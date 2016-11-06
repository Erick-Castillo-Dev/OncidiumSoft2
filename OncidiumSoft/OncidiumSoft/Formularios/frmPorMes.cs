using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OncidiumSoft.Formularios
{
    public partial class frmPorMes : Form
    {
        public frmPorMes()
        {
            InitializeComponent();
            String[] Meses = CultureInfo.CurrentCulture.DateTimeFormat.MonthNames;
            comboBox1.Items.AddRange(Meses);
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            frmMostrarReporteMes mostrar = new frmMostrarReporteMes();
            mostrar.Mes = comboBox1.SelectedIndex+1;
            mostrar.Show();
        }
    }
}

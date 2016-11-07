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
        /// <summary>
        /// El arreglo Meses se utiliza para ingresa automaticamente los meses
        /// del año en el combobox
        /// </summary>
        public frmPorMes()
        {
            InitializeComponent();
            String[] Meses = CultureInfo.CurrentCulture.DateTimeFormat.MonthNames;
            comboBox1.Items.AddRange(Meses);
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            frmMostrarReporteMes mostrar = new frmMostrarReporteMes();
            // //Se envia el mes al metodo que recibe un int, se suma 1 porque el indice del combo empieza en 0
            mostrar.Mes = comboBox1.SelectedIndex+1;
            mostrar.Show();
        }
    }
}

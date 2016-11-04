using OncidiumSoft.Conexxion_Datos;
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
    public partial class frmCompras : Form
    {
        public frmCompras()
        {
            InitializeComponent();
        }

        private void btnRealizar_Click(object sender, EventArgs e)
        {
            Conexion conect = new Conexion();
            conect.Conectar();
            MessageBox.Show("si se conecto");
        }
    }
}

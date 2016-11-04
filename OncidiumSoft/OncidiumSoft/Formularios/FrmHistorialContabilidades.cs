using OncidiumSoft.Daos;
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
    public partial class FrmHistorialContabilidades : Form
    {
        public FrmHistorialContabilidades()
        {
            InitializeComponent();
        }

        public void VerContabilidad()
        {
            Cls_DaoContabilidad objDCont = new Cls_DaoContabilidad();
            dgvContabilidad.DataSource = objDCont.getContabilidad();
        }

        private void FrmHistorialContabilidades_Load(object sender, EventArgs e)
        {
            VerContabilidad();
        }
    }
}

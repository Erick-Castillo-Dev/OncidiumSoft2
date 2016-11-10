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

        /// <summary>
        /// Método para ver la contabilidad realizada
        /// </summary>
        public void VerContabilidad()
        {
            Cls_DaoContabilidad objDCont = new Cls_DaoContabilidad();
            dgvContabilidad.DataSource = objDCont.getContabilidad();
        }

        /// <summary>
        /// Método que se ejecuta al abrir el formulario mostrando la contabilidad correspondiente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmHistorialContabilidades_Load(object sender, EventArgs e)
        {
            VerContabilidad();
        }

        /// <summary>
        /// Método para la funcionalidad del botón aceptar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        /// <summary>
        /// Método para la funcionalidad del botón regresar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmContabilidad().Show();
        }
    }
}

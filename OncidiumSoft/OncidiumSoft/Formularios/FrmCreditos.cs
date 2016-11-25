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
    public partial class FrmCreditos : Form
    {
        public FrmCreditos()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Metodo donde esta lo que hara cuando en timmer acabe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
        /// <summary>
        /// Metodo que se ejecuta al cargar el formulario e inicia el timmer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCreditos_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}

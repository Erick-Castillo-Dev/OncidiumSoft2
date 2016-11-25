using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace OncidiumSoft.Formularios
{
    public partial class FrmCargar : Form
    {
        public FrmCargar()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Variables de control de carga
        /// </summary>
        public bool si = false;
        int tiempo = 50;
        public string s;
        /// <summary>
        /// Metodo que carga el formulario y ejecuta las intrucciones para cada caso dependiendo de las variables de control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCargar_Load(object sender, EventArgs e)
        {
            if(si){
                tiempo = 30;
            }
            this.BackColor = Color.ForestGreen;
            this.TransparencyKey = BackColor;
            circularProgressBar1.BackColor = BackColor;
            circularProgressBar1.Value = 0;
            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 100;

            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(tiempo);
                circularProgressBar1.Value = i;
                circularProgressBar1.Update();
            }
            if(si){
                this.Opacity = 0;
                FrmPrincipal p = new FrmPrincipal();
                p.idUsuario2.Text = s;
                p.Show();
            }
            else
            {
                this.Opacity = 0;
                new FrmLogin().Show();
            }
        }
    }
}

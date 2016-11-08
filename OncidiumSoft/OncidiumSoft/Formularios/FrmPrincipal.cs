using OncidiumSoft.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OncidiumSoft
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void VentasDia_Click(object sender, EventArgs e)
        {
            frmCalendario obj = new frmCalendario();
            obj.Show();

        }

        private void Productos_Click(object sender, EventArgs e)
        {
            FrmProductos llamProductos = new FrmProductos();
            llamProductos.Show();
        }

        private void Ventas1_Click(object sender, EventArgs e)
        {
            
        }

        private void Ventas1_Click_1(object sender, EventArgs e)
        {
            FrmVenta llamarVentas = new FrmVenta();
            llamarVentas.id = int.Parse(idUsuario2.Text.ToString());
            llamarVentas.Show();
        }

        private void ventasPorMesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPorMes obj = new frmPorMes();
            obj.Show();
        }

        private void VentasFecha_Click(object sender, EventArgs e)
        {
            frmPorSemana jaja = new frmPorSemana();
            jaja.Show();
        }
        /// <summary>
        /// Llamada al Formularios de  Usuarios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Usuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios objU = new FrmUsuarios();
            objU.Show();
        }

        private void realizarContabilidad_Click(object sender, EventArgs e)
        {
            FrmContabilidad objC = new FrmContabilidad();
            objC.Show();
        }

        private void realizarAjuste_Click(object sender, EventArgs e)
        {
            FrmAjusteInventario objA = new FrmAjusteInventario();
            objA.Show();
        }
    }
}

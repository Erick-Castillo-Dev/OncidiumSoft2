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
using OncidiumSoft.Daos;
using OncidiumSoft.Objetos;

namespace OncidiumSoft
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Evento para mandar llamar a frmCalendario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VentasDia_Click(object sender, EventArgs e)
        {
            frmCalendario obj = new frmCalendario();
            obj.Show();

        }
        /// <summary>
        /// Evento para mandar llamar a FrmProductos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Productos_Click(object sender, EventArgs e)
        {
            FrmProductos llamProductos = new FrmProductos();
            llamProductos.Show();
        }

        private void Ventas1_Click(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Evento para mandar llamar a FrmVenta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ventas1_Click_1(object sender, EventArgs e)
        {
            FrmVenta llamarVentas = new FrmVenta();
            llamarVentas.id = int.Parse(idUsuario2.Text.ToString());
            llamarVentas.Show();
        }
        /// <summary>
        /// Evento para mandar llamar a frmPorMes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ventasPorMesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPorMes obj = new frmPorMes();
            obj.Show();
        }
        /// <summary>
        /// Evento para mandar llamar a frmPorSemana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Evento para mandar llamar a FrmContabilidad
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void realizarContabilidad_Click(object sender, EventArgs e)
        {
            FrmContabilidad objC = new FrmContabilidad();
            objC.Show();
        }
        /// <summary>
        /// Evento para mandar llamar a FrmAjusteInventario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void realizarAjuste_Click(object sender, EventArgs e)
        {
            FrmAjusteInventario objA = new FrmAjusteInventario();
            objA.Show();
        }
        /// <summary>
        /// Evento para mandar llamar a frmListPedidos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListPedidos f = new frmListPedidos();
            f.idu = int.Parse(idUsuario2.Text.ToString());
            f.Show();
        }
        /// <summary>
        /// Evento para mandar llamar a frmCompras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void compraDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCompras f = new frmCompras();
            f.Show();
        }
        /// <summary>
        /// Evento para mandar llamar a FrmProvedores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Provedores_Click(object sender, EventArgs e)
        {
            FrmProvedores p = new FrmProvedores();
            p.Show();
        }
        /// <summary>
        /// Evento que carga el Formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            Cls_DaoUsuarios s = new Cls_DaoUsuarios();
            Cls_Usuarios u = new Cls_Usuarios();
            u.idUsuario = int.Parse(idUsuario2.Text.ToString());
            string d = s.administrador(u);
            if (d != "Administrador")
            {
                Administrar.Visible = false;
                Reportes.Visible = false;
                contabilidadToolStripMenuItem.Visible = false;
                inventarioToolStripMenuItem.Visible = false;
            }
                
        }
        /// <summary>
        /// Evento que cierra la ventana Pricipal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Llamada al formulario de administrador de provedores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       /* private void Provedores_Click(object sender, EventArgs e)
        {
            //Objeto para acceder a la clase del formulario
            FrmProvedores LLamaProvedores = new FrmProvedores();
            LLamaProvedores.Show();
        }*/
    }
}

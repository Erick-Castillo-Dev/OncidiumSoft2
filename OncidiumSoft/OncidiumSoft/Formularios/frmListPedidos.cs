using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OncidiumSoft.Formularios;
using OncidiumSoft.Daos;
using OncidiumSoft.Objetos;

namespace OncidiumSoft.Formularios
{
    public partial class frmListPedidos : Form
    {
        public frmListPedidos()
        {
            InitializeComponent();
        }
      /// <summary>
      /// Objeto de la lista de pedidos
      /// </summary>
        List<Cls_DatosPedidos> lista = new List<Cls_DatosPedidos>();
        /// <summary>
        /// objetos de Dao pedidos
        /// </summary>
        Cls_DaoPedidos pDao = new Cls_DaoPedidos();
        /// <summary>
        /// Variable entera global para los pedidos
        /// </summary>
        public int idu;
        /// <summary>
        /// cargar pedidos al cargar la ventana
        /// </summary>
        private void frmListPedidos_Load(object sender, EventArgs e)
        {
            lista = pDao.cargardatos();
            dgvListapedidos.DataSource = lista;
        }
        /// <summary>
        /// Metodo para buscar un pedido por nombre y filtrar
        /// </summary>
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if(txtBuscar.Text == ""){
                lista = pDao.cargardatos();
                dgvListapedidos.DataSource = lista;
            }
            else
            {
                dgvListapedidos.DataSource = pDao.buscar(txtBuscar.Text.ToString());
            }
        }
        /// <summary>
        /// permite hacer un nuevo pedido
        /// </summary>

        private void btnRealizar_Click(object sender, EventArgs e)
        {
            frmPedidos f = new frmPedidos();
            f.editar = false;
            f.id = -1;
            f.idu = idu;
            f.Show();
            this.Hide();
        }
        /// <summary>
        /// Metodo para eliminar los pedidos
        /// </summary>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 selectedRowCount = dgvListapedidos.Rows.GetRowCount(DataGridViewElementStates.Selected);
                if (selectedRowCount > 0)
                {
                    if (selectedRowCount == 1)
                    {
                        frmPedidos f = new frmPedidos();
                        f.editar = true;
                        f.id = int.Parse(dgvListapedidos.Rows[dgvListapedidos.CurrentCellAddress.Y].Cells["ID"].Value.ToString());
                        this.Hide();
                        f.Show();
                    }
                    else
                    {
                        MessageBox.Show("Selecione solo un registro para editar");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error consulta al Administrador");
            }

            
        }
        /// <summary>
        /// Evento para eliminar un pedido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desas eliminar", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Int32 selectedRowCount = dgvListapedidos.Rows.GetRowCount(DataGridViewElementStates.Selected);
                    if (selectedRowCount > 0)
                    {
                        if (selectedRowCount == 1)
                        {
                            bool m = pDao.eliminarPedido(int.Parse(dgvListapedidos.Rows[dgvListapedidos.CurrentCellAddress.Y].Cells["ID"].Value.ToString()));
                            if (m)
                            {
                                MessageBox.Show("Pedido eliminado");
                                lista = pDao.cargardatos();
                                dgvListapedidos.DataSource = lista;
                            }
                            else
                            {
                                MessageBox.Show("No se pudo eliminar el pedido");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Selecione solo un registro para editar");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error consulta al Administrador");
                }
            }
        }
        /// <summary>
        /// Evento que cierra la ventana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

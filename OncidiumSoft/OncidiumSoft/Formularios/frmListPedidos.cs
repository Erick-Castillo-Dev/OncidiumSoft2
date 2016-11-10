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
        List<Cls_DatosPedidos> lista = new List<Cls_DatosPedidos>();
        Cls_DaoPedidos pDao = new Cls_DaoPedidos();
        public int idu;

        private void frmListPedidos_Load(object sender, EventArgs e)
        {
            lista = pDao.cargardatos();
            dgvListapedidos.DataSource = lista;
        }

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

        private void btnRealizar_Click(object sender, EventArgs e)
        {
            frmPedidos f = new frmPedidos();
            f.editar = false;
            f.id = -1;
            f.idu = idu;
            f.Show();
        }

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
    }
}

using OncidiumSoft.Conexxion_Datos;
using OncidiumSoft.Daos;
using OncidiumSoft.Objetos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OncidiumSoft.Objetos;
using OncidiumSoft.Daos;
using OncidiumSoft.Formularios;

namespace OncidiumSoft.Formularios
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        Cls_Usuarios u = new Cls_Usuarios();
        List<Cls_Usuarios> lista = new List<Cls_Usuarios>();
        Cls_DaoUsuarios uDao = new Cls_DaoUsuarios();

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            lista = uDao.llenar();
            dgvUsuarios.DataSource = lista;
            dgvUsuarios.Columns["Contrasena"].Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarUsuario f = new FrmAgregarUsuario();
            f.Show();
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 selectedRowCount = dgvUsuarios.Rows.GetRowCount(DataGridViewElementStates.Selected);
                if (selectedRowCount > 0)
                {
                    if (selectedRowCount == 1)
                    {
                        FrmAgregarProductos f = new FrmAgregarProductos();
                        f.editar = true;
                        f.id = int.Parse(dgvUsuarios.Rows[dgvUsuarios.CurrentCellAddress.Y].Cells["idUsuarios"].Value.ToString());
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desas eliminar", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Int32 selectedRowCount = dgvUsuarios.Rows.GetRowCount(DataGridViewElementStates.Selected);
                    if (selectedRowCount > 0)
                    {
                        if (selectedRowCount == 1)
                        {
                            bool m = uDao.eliminar(int.Parse(dgvUsuarios.Rows[dgvUsuarios.CurrentCellAddress.Y].Cells["idUsuarios"].Value.ToString()));
                            if (m)
                            {
                                MessageBox.Show("Usuario eliminado");
                                lista = uDao.llenar();
                                dgvUsuarios.DataSource = lista;
                                dgvUsuarios.Columns["Contrasena"].Visible = false;
                            }
                            else
                            {
                                MessageBox.Show("No se pudo eliminar el usuario");
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

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                lista = uDao.llenar();
                dgvUsuarios.DataSource = lista;
            }
            else
            {
                dgvUsuarios.DataSource = uDao.buscar(txtBuscar.Text.ToString());
            }
        }
        
    }
}

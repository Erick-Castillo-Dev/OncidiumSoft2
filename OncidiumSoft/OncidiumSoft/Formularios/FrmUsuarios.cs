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
        /// <summary>
        /// Objeto de la clase Cls_Usuarios
        /// </summary>
        Cls_Usuarios u = new Cls_Usuarios();
        /// <summary>
        /// Objeto de la lista de Usuarios
        /// </summary>
        List<Cls_Usuarios> lista = new List<Cls_Usuarios>();
        /// <summary>
        /// Objeto de la clase Cls_DaoUsuarios
        /// </summary>
        Cls_DaoUsuarios uDao = new Cls_DaoUsuarios();
        /// <summary>
        /// Evento que carga la lista en la tabla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            lista = uDao.llenar();
            dgvUsuarios.DataSource = lista;
            dgvUsuarios.Columns["Contrasena"].Visible = false;
        }
        /// <summary>
        /// Evento que cierra la ventana usuarios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Evento que manda llamar a el form FrmAgregarUsuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarUsuario f = new FrmAgregarUsuario();
            f.Show();
            this.Close();
        }
        /// <summary>
        /// Evento que manda llamar al FrmAgregarUsuario para modificarlo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 selectedRowCount = dgvUsuarios.Rows.GetRowCount(DataGridViewElementStates.Selected);
                if (selectedRowCount > 0)
                {
                    if (selectedRowCount == 1)
                    {
                        FrmAgregarUsuario f = new FrmAgregarUsuario();
                        f.editar = true;
                        f.id = int.Parse(dgvUsuarios.Rows[dgvUsuarios.CurrentCellAddress.Y].Cells["idUsuario"].Value.ToString());
                        this.Close();
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
        /// Evento para eliminar un usuario selecionado en la tabla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Evento que busca los usuarios por filtrado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

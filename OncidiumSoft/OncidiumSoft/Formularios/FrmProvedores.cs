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

namespace OncidiumSoft.Formularios
{
    public partial class FrmProvedores : Form
    {
        public FrmProvedores()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Objeto de la clase Cls_Provedores
        /// </summary>
        Cls_Provedores p = new Cls_Provedores();
        /// <summary>
        /// Objeto de la clase Cls_DaoProvedores
        /// </summary>
        Cls_DaoProvedores pDao = new Cls_DaoProvedores();
        /// <summary>
        /// Objeto de la lista de provedores
        /// </summary>
        List<Cls_Provedores> lista = new List<Cls_Provedores>();
        /// <summary>
        /// Evento que elimina profedores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desas eliminar", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Int32 selectedRowCount = dgvProvedores.Rows.GetRowCount(DataGridViewElementStates.Selected);
                    if (selectedRowCount > 0)
                    {
                        if (selectedRowCount == 1)
                        {
                            bool m = pDao.eliminarProvedor(int.Parse(dgvProvedores.Rows[dgvProvedores.CurrentCellAddress.Y].Cells["iddeProvedores"].Value.ToString()));
                            if (m)
                            {
                                MessageBox.Show("Provedor eliminado eliminado");
                                lista = pDao.llenar();
                                dgvProvedores.DataSource = lista;
                            }
                            else
                            {
                                MessageBox.Show("No se pudo eliminar el provedor");
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
        /// Evento que manda Llamar a FrmAgregarProvedor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarProvedor a = new FrmAgregarProvedor();
            this.Close();
            a.Show();
        }
        /// <summary>
        /// Evento que modifica  el provedor selecionado en la tabla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 selectedRowCount = dgvProvedores.Rows.GetRowCount(DataGridViewElementStates.Selected);
                if (selectedRowCount > 0)
                {
                    if (selectedRowCount == 1)
                    {
                        FrmAgregarProvedor f = new FrmAgregarProvedor();
                        f.editar = true;
                        f.id = int.Parse(dgvProvedores.Rows[dgvProvedores.CurrentCellAddress.Y].Cells["iddeProvedores"].Value.ToString());
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
        /// Evento que ciera la ventana de provedores 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Evento que carga los dato de la tabla al inicio de la ejecucion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmProvedores_Load(object sender, EventArgs e)
        {
            lista = pDao.llenar();
            dgvProvedores.DataSource = lista;
        }
        /// <summary>
        /// Evento que busca los provedores por filtrado 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                lista = pDao.llenar();
                dgvProvedores.DataSource = lista;
            }
            else
            {
                dgvProvedores.DataSource = pDao.buscar(txtBuscar.Text.ToString());
            }
        }

        private void dgvProvedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
    }


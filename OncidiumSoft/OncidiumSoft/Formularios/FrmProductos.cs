using MySql.Data.MySqlClient;
using OncidiumSoft.Conexxion_Datos;
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
using OncidiumSoft.Formularios;
using OncidiumSoft.Objetos;

namespace OncidiumSoft.Formularios
{
    public partial class FrmProductos : Form
    {
        /// <summary>
        /// Inicializa los componentes del formulario
        /// </summary>
        public FrmProductos()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Objeto de la clase Cls_DaoProductos
        /// </summary>
          Cls_DaoProductos pDao = new Cls_DaoProductos();
        /// <summary>
          /// Objeto de la clase Cls_Productos
        /// </summary>
          Cls_Productos p = new Cls_Productos();
        /// <summary>
        /// Objeto de la lista de productos
        /// </summary>
          List<Cls_Productos> lista = new List<Cls_Productos>(); 

        /// <summary>
        /// Evento que carga  la lista al inicioar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmProductos_Load(object sender, EventArgs e)
        {
            lista = pDao.llenar();
            dgVProductos.DataSource = lista; 
        }
        /// <summary>
        /// Llamada al formulario de nuevo registro.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
           FrmAgregarProductos agregar = new FrmAgregarProductos();
            this.Hide();
            agregar.Show();
        }
        /// <summary>
        /// Evento que modifica los productos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 selectedRowCount = dgVProductos.Rows.GetRowCount(DataGridViewElementStates.Selected);
                if (selectedRowCount > 0)
                {
                    if (selectedRowCount == 1)
                    {
                        FrmAgregarProductos f = new FrmAgregarProductos();
                        f.editar = true;
                        f.id = int.Parse(dgVProductos.Rows[dgVProductos.CurrentCellAddress.Y].Cells["idProductoss"].Value.ToString());
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
        /// Evento que elimina algun producto.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desas eliminar", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Int32 selectedRowCount = dgVProductos.Rows.GetRowCount(DataGridViewElementStates.Selected);
                    if (selectedRowCount > 0)
                    {
                        if (selectedRowCount == 1)
                        {
                            bool m = pDao.eliminarProducto(int.Parse(dgVProductos.Rows[dgVProductos.CurrentCellAddress.Y].Cells["idProductoss"].Value.ToString()));
                            if (m)
                            {
                                MessageBox.Show("Producto eliminado");
                                lista = pDao.llenar();
                                dgVProductos.DataSource = lista;
                            }
                            else
                            {
                                MessageBox.Show("No se pudo eliminar el producto");
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
        /// Evento ques cierra el formulario actual y nos envia al principal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Evento que busca el produto con un filtrado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                lista = pDao.llenar();
                dgVProductos.DataSource = lista; 
            }
            else
            {
                dgVProductos.DataSource = pDao.buscar(txtBuscar.Text.ToString());
            }
        }
       
    }
}

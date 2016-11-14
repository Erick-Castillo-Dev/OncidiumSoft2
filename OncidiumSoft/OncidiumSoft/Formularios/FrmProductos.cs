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
        /// Objecto para acceder a la conexion de la clase conexion
        /// </summary>
          Conexion conexionDB = new Conexion();
       /// <summary>
       /// Cargamos los datos de la tabla productos en el datagridView.
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>

          Cls_DaoProductos pDao = new Cls_DaoProductos();
          Cls_Productos p = new Cls_Productos();
          List<Cls_Productos> lista = new List<Cls_Productos>(); 


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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FrmAgregarProductos agregar = new FrmAgregarProductos();
            this.Hide();
            agregar.id = 1;
            agregar.editar = true;
            agregar.Show();
        }

       

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
                            bool m = pDao.eliminarProducto(int.Parse(dgVProductos.Rows[dgVProductos.CurrentCellAddress.Y].Cells["ID"].Value.ToString()));
                            if (m)
                            {
                                MessageBox.Show("Pedido eliminado");
                                lista = pDao.llenar();
                                dgVProductos.DataSource = lista;
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
        /// Cierra el formulario actual y nos envia al principal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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

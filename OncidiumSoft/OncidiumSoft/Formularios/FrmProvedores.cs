using OncidiumSoft.Conexxion_Datos;
using OncidiumSoft.Daos;
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
        /// Objecto para acceder a la conexion de la clase conexion
        /// </summary>
        Conexion conexionDB = new Conexion();
        /// <summary>
        /// objecto para acceder a los metodos de los provedores
        /// </summary>
        Cls_DaoProvedores DaoProvedores = new Cls_DaoProvedores();
        /// <summary>
        /// Objecto para acceder a los getters y setters de la clase provedores
        /// </summary>
        Cls_Provedores  ObjProvedores= new Cls_Provedores();
       
        /// <summary>
        /// Metodo que carga la lista de Provedores el en datagridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmProvedores_Load(object sender, EventArgs e)
        {
           
            cargarprovedores();

        }
        /// <summary>
        /// Carga los datos en el gridview
        /// </summary>
        public void cargarprovedores(){
            
            dgvProvedores.DataSource = DaoProvedores.llenar();
            dgvProvedores.DataMember = "provedores";
            conexionDB.Cerrar();
        }
        private void dgvProvedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /// <summary>
        /// Cierra el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// ELimina un provedor por id
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
          try
           {
                ObjProvedores.iddeProvedores = int.Parse(dgvProvedores.Rows[dgvProvedores.SelectedRows[0].Index].Cells[0].Value.ToString());
                if (MessageBox.Show("Estas seguro que desas eliminar", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DaoProvedores.EliminarProvedor(ObjProvedores);
                    cargarprovedores();
                }
            }
            catch (Exception ex)
          {
            MessageBox.Show("Seleciona un registro completo");
            }
        }
        /// <summary>
        /// Llama al formulario para agreagr un nuevo provedor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
           /* FrmAgregarProvedor AgreProve = new FrmAgregarProvedor();
            this.Close();
            AgreProve.Show();*/
        }
        }
    }


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
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Objecto para acceder a la conexion de la clase conexion
        /// </summary>
        Conexion conexionDB = new Conexion();

        /// <summary>
        /// Objecto para acceder a los metodos de la clase usuarios
        /// </summary>
        Cls_DaoUsuarios DaoUsuario = new Cls_DaoUsuarios();
        /// <summary>
        /// objeto para acceder a los getter y setters de la clase usuarios
        /// </summary>
        Cls_Usuarios ObjUsuarios = new Cls_Usuarios();
        /// <summary>
        /// Carga los datos en el gridview
        /// </summary>
        public void cargarUsuarios()
        {
            dgvUsuarios.DataSource = DaoUsuario.llenar();
            dgvUsuarios.DataMember = "usuarios";
            conexionDB.Cerrar();
        }
        /// <summary>
        /// Metodo que carga la lista de usuarios el en datagridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmUsuarios_Load(object sender, EventArgs e)
        {

            cargarUsuarios();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Cierre del formulario de Usuarios.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Evento que realizara la buqueda medianye filtrado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            try
           {
                ObjUsuarios.idUsuario = int.Parse(dgvUsuarios.Rows[dgvUsuarios.SelectedRows[0].Index].Cells[0].Value.ToString());
                if (MessageBox.Show("Estas seguro que desas eliminar", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DaoUsuario.EliminarUsuario(ObjUsuarios);
                    cargarUsuarios();
                }
            }
            catch (Exception ex)
          {
            MessageBox.Show("Seleciona un registro completo");
            }
        }
    }
}

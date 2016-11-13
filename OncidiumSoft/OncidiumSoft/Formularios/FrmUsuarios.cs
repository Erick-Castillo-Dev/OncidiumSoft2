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
        /// Lista para la busqueda
        /// </summary>
        List<Cls_Usuarios> listaUsuarios = new List<Cls_Usuarios>();
        
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
            //Objecto de los getter y setters            ObjUsuarios

            //Objecto para los metodos              DaoUsuario
            //seleccion del reglon a modificar
            ObjUsuarios.idUsuario = Convert.ToInt32(this.dgvUsuarios.CurrentRow.Cells[0].Value.ToString());
            DaoUsuario.buscarUsuario(ref ObjUsuarios);

            FrmAgregarUsuario LlamadaUsuarios = new FrmAgregarUsuario();

            LlamadaUsuarios.txtNombre.Text = Convert.ToString(ObjUsuarios.nombre);
            LlamadaUsuarios.txtDireccion.Text = Convert.ToString(ObjUsuarios.direccion);
            LlamadaUsuarios.txtTel.Text = Convert.ToString(ObjUsuarios.telefono);
           // LlamadaUsuarios.txtUsuario = Convert.ToString(ObjUsuarios.usuario);
            //LlamadaUsuarios.txtContrasena = ObjUsuarios.contrasena;
            //LlamadaUsuarios.cboxPuesto = ObjUsuarios.puesto;

            LlamadaUsuarios.Show();
            this.Close();
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
        /// Evento que realizara la buqueda mediante filtrado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = Cls_DaoUsuarios.Buscar(txtBuscar.Text);
            
        }
        /// <summary>
        /// Elimina un usuario selecionado en el View.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Llamada al formulario de agregar usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            FrmAgregarUsuario LlamUsuarios = new FrmAgregarUsuario();
            this.Close();
            LlamUsuarios.Show();
        }

        
    }
}

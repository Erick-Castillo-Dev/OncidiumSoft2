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
    public partial class FrmAgregarUsuario : Form
    {
        public FrmAgregarUsuario()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Llamada al formulario de usuarios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FrmUsuarios LlamUsuarios = new FrmUsuarios();
            this.Close();
            LlamUsuarios.Show();

        }
        /// <summary>
        /// Objeto pra Acceder a los getter y setter de los usuarios
        /// </summary>
        Cls_Usuarios ObjUsuarios = new Cls_Usuarios();

        /// <summary>
        /// Objecto para acceder a los metodos de la clase usuarios.
        /// </summary>
        Cls_DaoUsuarios DaosUsuario = new Cls_DaoUsuarios();
        /// <summary>
        /// Guarda un nuevo usuario en la tabla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ObjUsuarios.nombre = txtNombre.Text;
            ObjUsuarios.direccion = txtDireccion.Text;
            ObjUsuarios.telefono = txtTel.Text;
            ObjUsuarios.usuario = txtUsuario.Text;
            ObjUsuarios.contrasena= txtContrasena.Text;
            ObjUsuarios.puesto = cboxPuesto.Text;
            DaosUsuario.AgregarUsuario(ObjUsuarios);
            FrmUsuarios LlamUsuarios = new FrmUsuarios();
            this.Close();
            LlamUsuarios.Show();

        }
        /// <summary>
        /// Validar solo letras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        /// <summary>
        /// Valida solo numeros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void FrmAgregarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}

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
    }
}

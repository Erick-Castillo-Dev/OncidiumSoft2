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
        /// Variable booleana para editar usuarios
        /// </summary>
        public bool editar = false;
        /// <summary>
        /// Variable entera para el id del usuario
        /// </summary>
        public int id;
        /// <summary>
        /// Objeto para acceder a los getter y setters de la clase CLs_Usuarios
        /// </summary>
        Cls_Usuarios u = new Cls_Usuarios();
        /// <summary>
        /// Objeto para acceder a los metodos de la clase CLS_DaoUsuarios
        /// </summary>
        Cls_DaoUsuarios uDao = new Cls_DaoUsuarios();
        /// <summary>
        /// Evento que carga el formulario al inicialo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAgregarUsuario_Load(object sender, EventArgs e)
        {
            if(editar){
                u = uDao.obtenerUsuario(id);
                txtNombre.Text = u.nombre;
                txtDireccion.Text = u.direccion;
                txtUsuario.Text = u.usuario;
                txtTel.Text = u.telefono;
                cboxPuesto.Text = u.puesto;
                btnAceptar.Text = "Actualizar";
                label1.Text = "Editar Usuario";
            }
        }
        /// <summary>
        /// Evento que limpia los componentes de FRM
        /// </summary>
        public void limpiar()
        {
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtUsuario.Text = "";
            txtTel.Text = "";
            cboxPuesto.Text = "";
            txtContrasena.Text = "";
        }
        /// <summary>
        /// Evento que confirma la actualizacion y agregacion de un usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtTel.Text.ToString().Length == 10)
            {
                if (editar)
                {
                    u.nombre = txtNombre.Text;
                    u.direccion = txtDireccion.Text;
                    u.usuario = txtUsuario.Text;
                    u.telefono = txtTel.Text;
                    u.contrasena = txtContrasena.Text;
                    u.puesto = cboxPuesto.Text;
                    bool s = uDao.editar(u);
                    if (s)
                    {
                        MessageBox.Show("Se actualizo el Usuario");
                        limpiar();
                        this.Close();
                        new FrmUsuarios().Show();
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar");
                    }
                }
                else
                {
                    u.nombre = txtNombre.Text;
                    u.direccion = txtDireccion.Text;
                    u.usuario = txtUsuario.Text;
                    u.telefono = txtTel.Text;
                    u.contrasena = txtContrasena.Text;
                    u.puesto = cboxPuesto.Text;
                    bool s = uDao.agregar(u);
                    if (s)
                    {
                        MessageBox.Show("Se agrego el Usuario");
                        limpiar();
                        this.Close();
                        new FrmUsuarios().Show();
                    }
                    else
                    {
                        MessageBox.Show("Error al guardar");
                    }
                }
            }
        }
        /// <summary>
        /// Evento que valida que solo ingresen numeros
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

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmUsuarios().Show();
        }
        
    }
}

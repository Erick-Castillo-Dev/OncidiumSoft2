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

        bool editar = false;
        int id;

        Cls_Usuarios u = new Cls_Usuarios();
        Cls_DaoUsuarios uDao = new Cls_DaoUsuarios();

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
            }
        }

        public void limpiar()
        {
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtUsuario.Text = "";
            txtTel.Text = "";
            cboxPuesto.Text = "";
            txtContrasena.Text = "";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(editar){
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
                }
                else
                {
                    MessageBox.Show("Error al guardar");
                }
            }
        }
        
    }
}

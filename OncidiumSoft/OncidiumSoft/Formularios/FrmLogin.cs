using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OncidiumSoft.Objetos;
using OncidiumSoft.Daos;

namespace OncidiumSoft.Formularios
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Metodo para validar los datos del formulario para el login 
        /// y la entrada al sistema
        /// </summary>
        /// <returns></returns>
        public bool validarDatos()
        {
            if (txtPassword.Equals("") && txtUsuario.Equals(""))
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Metodo para cancelar y salir del sistema
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
        /// <summary>
        /// Metodo para aceptar y mandar una peticion para el acceso al sistema
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(validarDatos()){
                Cls_Usuarios obj = new Cls_Usuarios();
                Cls_DaoUsuarios dao = new Cls_DaoUsuarios();
                obj.usuario = txtUsuario.Text;
                obj.contrasena = txtPassword.Text;
                if(dao.entrar(obj)){
                    this.Hide();
                    FrmCargar frm = new FrmCargar();
                    frm.s = "" + dao.idUsuario(obj);
                    frm.si = true;
                    frm.Show();
                }else{
                    MessageBox.Show("Usuario y/o contraseña no son correctos");
                }
            }else{
                MessageBox.Show("Llena todos los campos");
            }
        }
    }
}

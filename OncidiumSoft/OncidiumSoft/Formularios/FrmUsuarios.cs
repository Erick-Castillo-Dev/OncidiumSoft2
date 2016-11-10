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
        /// Metodo que carga la lista de usuarios el en datagridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            Cls_DaoUsuarios obj = new Cls_DaoUsuarios();
            dgvUsuarios.DataSource = obj.llenar();
            dgvUsuarios.DataMember = "usuarios";
            conexionDB.Cerrar();
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
    }
}

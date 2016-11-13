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
        
        private void FrmProductos_Load(object sender, EventArgs e)
        {
            Cls_DaoProductos obj = new Cls_DaoProductos();
            dgVProductos.DataSource = obj.llenar();
            dgVProductos.DataMember = "productos";
            conexionDB.Cerrar();
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




        private void dgVProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       
    }
}

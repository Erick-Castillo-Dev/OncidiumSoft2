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

namespace OncidiumSoft.Formularios
{
    public partial class FrmProductos : Form
    {
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
            conexionDB.Conectar();
            MySqlDataAdapter muestreo = new MySqlDataAdapter("select*from productos", conexionDB.cConexion);
            DataSet productos = new DataSet();
            muestreo.Fill(productos, "productos");
            dgVProductos.DataSource = productos;
            dgVProductos.DataMember = "productos";
            MessageBox.Show("Conexion generada con exito");
            conexionDB.Cerrar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            conexionDB.Conectar();
            MessageBox.Show("Conexion Exitosa");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //cerrando la conexion.
            conexionDB.Cerrar();
        }
    }
}

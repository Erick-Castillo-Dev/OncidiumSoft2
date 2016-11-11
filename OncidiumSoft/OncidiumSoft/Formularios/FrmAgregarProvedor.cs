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
    public partial class FrmAgregarProvedor : Form
    {
        public FrmAgregarProvedor()
        {
            InitializeComponent();
        }
        Cls_DaoProvedores DAoProvedor = new Cls_DaoProvedores();
        /// <summary>
        /// Objecto delos getters y setter de la clase provedores
        /// </summary>
        Cls_Provedores ObjProvedores = new Cls_Provedores();
        /// <summary>
        /// Objecto para acceder al catalogo de provedores
        /// </summary>
        FrmProvedores LlamProvedores = new FrmProvedores();
        /// <summary>
        /// Cierra la ventana actual y nos regresa a el catalogo de provedores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            LlamProvedores.Show();
        }
        /// <summary>
        /// Agraga Provedores a la tabla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {

            //ObjProvedores.iddeProvedores = Convert.ToInt32(txtId.Text);
            ObjProvedores.NombreProvedor = txtNombre.Text;
            ObjProvedores.DireccionProvedor = txtDireccion.Text;
            ObjProvedores.TelefonoProvedor = txtTelefono.Text;
            ObjProvedores.EmpresadeProvedor = txtEmpresa.Text;
            DAoProvedor.AgregarProvedor(ObjProvedores);
            this.Close();
           
            new FrmProvedores().Show();


            
        }
    }
}

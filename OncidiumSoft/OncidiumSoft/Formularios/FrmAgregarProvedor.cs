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
using OncidiumSoft.Objetos;

namespace OncidiumSoft.Formularios
{
    public partial class FrmAgregarProvedor : Form
    {
        public FrmAgregarProvedor()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Variable booleana para editar los provedores
        /// </summary>
        public bool editar = false;
        /// <summary>
        /// Variable entera para el id de provedores
        /// </summary>
        public int id;
        /// <summary>
        /// Objeto pra acceder a la clase ClsProvedores con los getters y setters
        /// </summary>
        Cls_Provedores p = new Cls_Provedores();
        /// <summary>
        /// Objecto para acceder a los metodos de la clase Cls_Daoprovedores
        /// </summary>
        Cls_DaoProvedores pDao = new Cls_DaoProvedores();
        /// <summary>
        /// Evento que carga el fomulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAgregarProvedor_Load(object sender, EventArgs e)
        {
            if(editar){
                p = pDao.obtenerProvedor(id);
                txtNombre.Text = p.NombreProvedor;
                txtDireccion.Text = p.DireccionProvedor;
                txtEmpresa.Text = p.EmpresadeProvedor;
                txtTelefono.Text = p.TelefonoProvedor;
                btnAceptar.Text = "Actualizar";
            }
        }
        /// <summary>
        /// Evento que limpia el contenido del FRM
        /// </summary>
        public void limpiar()
        {
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtEmpresa.Text = "";
            txtTelefono.Text = "";
        }
        /// <summary>
        /// Evento que Confirma la agregacion del provedor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (editar)
            {
               p.NombreProvedor = txtNombre.Text;
               p.DireccionProvedor = txtDireccion.Text;
               p.EmpresadeProvedor = txtEmpresa.Text;
               p.TelefonoProvedor = txtTelefono.Text;
               bool s = pDao.editar(p);
                if(s){
                    MessageBox.Show("Se actualizo el provedor");
                    limpiar();
                    this.Close();
                    new FrmProvedores().Show();
                }
                else
                {
                    MessageBox.Show("Error al actualizar");
                }
            }
            else
            {
                p.NombreProvedor = txtNombre.Text.ToString();
                p.DireccionProvedor = txtDireccion.Text.ToString();
                p.EmpresadeProvedor = txtEmpresa.Text.ToString();
                p.TelefonoProvedor = txtTelefono.Text.ToString();
                bool s = pDao.agregar(p);
                if (s)
                {
                    MessageBox.Show("Se agrego el provedor");
                    limpiar();
                    this.Close();
                    new FrmProvedores().Show();
                }
                else
                {
                    MessageBox.Show("Error al guardar");
                }
            }
        }
        /// <summary>
        /// Evento que cancela la operacion en el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FrmProvedores f = new FrmProvedores();
            f.Show();
            this.Close();
        }
        /// <summary>
        /// Evento que valida que el ingreso sean solo numeros.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        
        
    }
}

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

        public bool editar = false;
        public int id;

        Cls_Provedores p = new Cls_Provedores();
        Cls_DaoProvedores pDao = new Cls_DaoProvedores();

        private void FrmAgregarProvedor_Load(object sender, EventArgs e)
        {
            p = pDao.obtenerProvedor(id);
            if(editar){
                txtNombre.Text = p.NombreProvedor;
                txtDireccion.Text = p.DireccionProvedor;
                txtEmpresa.Text = p.EmpresadeProvedor;
                txtTelefono.Text = p.TelefonoProvedor;
                btnAceptar.Text = "Actualizar";
            }
        }

        public void limpiar()
        {
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtEmpresa.Text = "";
            txtTelefono.Text = "";
        }

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
                }
                else
                {
                    MessageBox.Show("Error al actualizar");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FrmProvedores f = new FrmProvedores();
            f.Show();
            this.Close();
        }
        
        
    }
}

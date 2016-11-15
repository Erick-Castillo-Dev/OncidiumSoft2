using OncidiumSoft.Daos;
using OncidiumSoft.Objetos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OncidiumSoft.Formularios;

namespace OncidiumSoft.Formularios
{
    public partial class FrmAgregarProductos : Form
    {
        public FrmAgregarProductos()
        {
            InitializeComponent();
        }

        public bool editar = false;
        public int id;
        Cls_Productos p = new Cls_Productos();
        Cls_DaoProductos pDao = new Cls_DaoProductos();
        Cls_DaoVentas vDao = new Cls_DaoVentas();
        Image m;

        private void btnImg_Click(object sender, EventArgs e)
        {

            OpenFileDialog BuscarImagen = new OpenFileDialog(); 
            BuscarImagen.Filter = "Archivos de Imagen|*.png";
            BuscarImagen.FileName = "";
            BuscarImagen.Title = "Titulo del Dialogo";
            BuscarImagen.InitialDirectory = "C:\\"; 
            if (BuscarImagen.ShowDialog() == DialogResult.OK)
            {
                String Direccion = BuscarImagen.FileName;

                m = Image.FromFile(Direccion);
                ptImg.Image = m;
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(editar){
                Cls_Productos c = new Cls_Productos();
                c.idProductoss = id;
                c.NombreProducto = txtNombre.Text.ToString();
                c.PrecioalCliente = double.Parse(txtpreciocliente.Text.ToString());
                c.CantidadProducto = int.Parse(txtCantidad.Text.ToString());
                c.Precio_costo = double.Parse(txtPrecioCosto.Text.ToString());
                c.AjusteProducto = false;
                c.Disponibilidad = true;
                c.iddeProvedores = pDao.idProvedores(cobProvedor.Text.ToString());
                c.TipoProducto = cboxTipo.Text.ToString();
                MemoryStream ms = new MemoryStream();
                m.Save(ms, ImageFormat.Png);
                byte[] imgArr = ms.ToArray();
                c.imgenProducto = imgArr;
                pDao.editar(c);
            }
            else
            {
                Cls_Productos c = new Cls_Productos();
                c.NombreProducto = txtNombre.Text.ToString();
                c.PrecioalCliente = double.Parse(txtpreciocliente.Text.ToString());
                c.CantidadProducto = int.Parse(txtCantidad.Text.ToString());
                c.Precio_costo = double.Parse(txtPrecioCosto.Text.ToString());
                c.AjusteProducto = false;
                c.Disponibilidad = true;
                c.iddeProvedores = pDao.idProvedores(cobProvedor.Text.ToString());
                c.TipoProducto = cboxTipo.Text.ToString();
                MemoryStream ms = new MemoryStream();
                m.Save(ms, ImageFormat.Png);
                byte[] imgArr = ms.ToArray();
                c.imgenProducto = imgArr;
                pDao.AgregarProducto(c);
            }
        }

        private void FrmAgregarProductos_Load(object sender, EventArgs e)
        {
            cobProvedor.DataSource = pDao.listaProvedores();
            Cls_Productos cp = new Cls_Productos();
            if(editar){
                cp.idProductoss = id;
                p = pDao.BuscarProducto(cp);
                txtNombre.Text = p.NombreProducto;
                txtpreciocliente.Text = p.PrecioalCliente.ToString();
                txtPrecioCosto.Text = p.Precio_costo.ToString();
                txtCantidad.Text = p.CantidadProducto.ToString();
                cboxTipo.Text = p.TipoProducto;
                cobProvedor.Text = pDao.nombreProvedor(p.iddeProvedores);
                ptImg.Image = vDao.cargarimagen(p.imgenProducto);
                btnGuardar.Text = "Actualizar";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmProductos f = new FrmProductos();
            f.Show();
        }

        private void txtpreciocliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }

            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < txtpreciocliente.Text.Length; i++)
            {
                if (txtpreciocliente.Text[i] == ',')
                    IsDec = true;

                if (IsDec && nroDec++ >= 2)
                {
                    e.Handled = true;
                    return;
                }
            }

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else if (e.KeyChar == ',')
                e.Handled = (IsDec) ? true : false;
            else
                e.Handled = true;
        }

        private void txtPrecioCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }

            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < txtPrecioCosto.Text.Length; i++)
            {
                if (txtPrecioCosto.Text[i] == ',')
                    IsDec = true;

                if (IsDec && nroDec++ >= 2)
                {
                    e.Handled = true;
                    return;
                }
            }

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else if (e.KeyChar == ',')
                e.Handled = (IsDec) ? true : false;
            else
                e.Handled = true;
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
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

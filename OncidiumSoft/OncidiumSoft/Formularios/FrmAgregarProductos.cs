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
        /// <summary>
        /// Variable boolean para editar productos
        /// </summary>
        public bool editar = false;
        /// <summary>
        /// Variable entera para el id del producto
        /// </summary>
        public int id;
        /// <summary>
        /// Objecto de la clase CLSProductos para acceder a los getters y setter de ella.
        /// </summary>
        Cls_Productos p = new Cls_Productos();
        /// <summary>
        /// Objecto para acceder a los metodos de la clase Cls_DaoProductos
        /// </summary>
        Cls_DaoProductos pDao = new Cls_DaoProductos();
        /// <summary>
        /// Objecto para la clase CLs_DaoVentas para acceder a sus metodos
        /// </summary>
        Cls_DaoVentas vDao = new Cls_DaoVentas();
        /// <summary>
        /// Tipo imagen para almacenar la del producto
        /// </summary>
        Image m;
        /// <summary>
        /// Evento para La busqueda de la imagen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Evento para guardar el producto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text != "" && txtNombre.Text != "" && txtpreciocliente.Text != "" && txtPrecioCosto.Text != "" && cboxTipo.Text != "" && cobProvedor.Text != "")
            {
                if (editar)
                {
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
                    bool ps = pDao.editar(c);
                    if (ps)
                    {
                        MessageBox.Show("Se edito el producto");
                        new FrmProductos().Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error no se pudo editar el producto");
                    }
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
                    bool ps = pDao.AgregarProducto(c);
                    if (ps)
                    {
                        MessageBox.Show("Se agrego el producto");
                        new FrmProductos().Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error no se pudo editar el producto");
                    }
                }
            }
            else
            {
                MessageBox.Show("Llene todos los campos");
            }
        }
        /// <summary>
        /// Evento que carga los componentes en el formulario al iniciar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                m = vDao.cargarimagen(p.imgenProducto);
                btnGuardar.Text = "Actualizar";
                label1.Text = "Modificar Productos";
            }
        }
        /// <summary>
        /// Evento que cancela la operacion en este formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmProductos f = new FrmProductos();
            f.Show();
        }
        /// <summary>
        /// Evento para validar la longitud y el tipo de entrada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// evento para validar la longitud y el tipo de dato de entrada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Evento para valida que solo acepte numeros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

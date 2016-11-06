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
using OncidiumSoft.Objetos;
using System.Threading;

namespace OncidiumSoft.Formularios
{
    public partial class FrmVenta : Form
    {
        public FrmVenta()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Variable para el id del usuario
        /// </summary>
        public int id=0;
        /// <summary>
        /// Objeto de clase dao para acceder a los metodos de la venta
        /// </summary>
        Cls_DaoVentas vDao = new Cls_DaoVentas();
        /// <summary>
        /// Objeto de la clase productos
        /// </summary>
        Cls_Productos pro = new Cls_Productos();
        /// <summary>
        /// Objeto de clase dao de productos para acerder a los metodos
        /// para obtener informacion de los poductos
        /// </summary>
        Cls_DaoProductos proDao = new Cls_DaoProductos();
        /// <summary>
        /// Lista de objetos de productos para el llenado del datagridview
        /// </summary>
        List<Cls_DatosVenta> lista = new List<Cls_DatosVenta>();
        /// <summary>
        /// Variable global para el total
        /// </summary>
        double total = 0;
        /// <summary>
        /// Metodo para reiniciar los datos del formulario cuando se termina 
        /// una venta o se inicia una venta
        /// </summary>
        public void reiniciar()
        {
            dgvProductos.DataSource = null;
            txtPago.Text = "0";
            lblTotal.Text = "Total:  $ " + 0;
            lblDescuento.Text = "Descuento Aplicado al Total $ " + 0;
            lblCambio.Text = "Cambio: $ " + 0;
            lblFecha.Text = "Fecha de venta: " + DateTime.Now.ToString("yyyy/MM/dd");
            txtCantidad.Text = "1";
            total = 0;
        }
        /// <summary>
        /// Metodo que se ejecuta al cargar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmVenta_Load(object sender, EventArgs e)
        {
            reiniciar();
            FrmPrincipal f = new FrmPrincipal();
            Cls_Usuarios c = new Cls_Usuarios();
            c.idUsuario = id;
            txtEmpleado.Text = new Cls_DaoUsuarios().NombreUsuario(c);
            txtIdVenta.Text = "" + vDao.folio();
        }

        public void limpiar()
        {
            txtCantidad.Text = "1";
            txtIdProducto.Text = "";
            txtPrecio.Text = "";
            txtProducto.Text = "";
            txtTipo.Text = "";
        }

        private void txtIdProducto_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                try
                {
                    Cls_Productos p = new Cls_Productos();
                    p.idProductoss = int.Parse(txtIdProducto.Text.ToString());
                    pro = proDao.BuscarProducto(p);
                    txtTipo.Text = pro.TipoProducto.ToString();
                    txtPrecio.Text = pro.PrecioalCliente.ToString();
                    txtProducto.Text = pro.NombreProducto.ToString();
                    Thread.Sleep(50);
                    limpiar();
                    Cls_DatosVenta v = new Cls_DatosVenta();
                    v.ID = pro.idProductoss;
                    v.Producto = pro.NombreProducto;
                    v.Precio_Unitario = pro.PrecioalCliente;
                    v.Cantidad = int.Parse(txtCantidad.Text.ToString());
                    v.Sub_Total = v.Cantidad * v.Precio_Unitario;
                    v.Tipo = pro.TipoProducto;
                    total += v.Sub_Total;
                    lblTotal.Text = "Total:  $ " + total;
                    if(lista == null){
                        lista.Add(v);
                    }
                    else
                    {
                        bool s = false;
                        foreach(Cls_DatosVenta d in lista){
                            if(d.ID == v.ID){
                                d.Cantidad += v.Cantidad;
                                d.Sub_Total += v.Sub_Total;
                                s = true; 
                            }
                        }
                        if(!s){
                            lista.Add(v);
                        }
                    }

                    
                    dgvProductos.DataSource = null;
                    dgvProductos.DataSource = lista;
                    dgvProductos.Columns["Precio_Unitario"].DefaultCellStyle.Format = "C2";
                }catch(Exception ex){
                    MessageBox.Show("El producto no existe");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            reiniciar();
            limpiar();
            MessageBox.Show("Venta cancelada");
        }
    }
}

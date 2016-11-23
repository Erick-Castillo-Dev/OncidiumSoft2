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
            txtDescuento.Text = "0";
            lblCambio.Text = "Cambio: $ " + 0;
            lblSubtotal.Text = "SubTotal : $ ";
            lblFecha.Text = "Fecha de venta: " + DateTime.Now.ToString("yyyy/MM/dd");
            txtCantidad.Text = "1";
            txtDescuento.Text = "0";
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
        /// <summary>
        /// Metodo para limpiar todos los campos de texto del formulario
        /// </summary>
        public void limpiar()
        {
            txtCantidad.Text = "1";
            txtIdProducto.Text = "";
            txtPrecio.Text = "";
            txtProducto.Text = "";
            txtTipo.Text = "";
        }
        /// <summary>
        /// Metodo para el lector de codigo de barras para agregar los productos a la venta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtIdProducto_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                try
                {
                    Cls_Productos p = new Cls_Productos();
                    p.idProductoss = int.Parse(txtIdProducto.Text.ToString());
                    pro = proDao.BuscarProducto(p);
                    ptProducto.Image = vDao.cargarimagen(pro.imgenProducto);
                    txtTipo.Text = pro.TipoProducto.ToString();
                    txtPrecio.Text = pro.PrecioalCliente.ToString();
                    txtProducto.Text = pro.NombreProducto.ToString();
                    Thread.Sleep(50);
                    Cls_DatosVenta v = new Cls_DatosVenta();
                    v.ID = pro.idProductoss;
                    v.Producto = pro.NombreProducto;
                    v.Precio_Unitario = pro.PrecioalCliente;
                    v.Cantidad = int.Parse(txtCantidad.Text.ToString());
                    v.Sub_Total = v.Cantidad * v.Precio_Unitario;
                    v.Tipo = pro.TipoProducto;
                    total += v.Sub_Total;
                    lblTotal.Text = "Total:  $ " + (total - double.Parse(txtDescuento.Text.ToString()));
                    lblSubtotal.Text = "SubTotal : $ " + total;
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
                    dgvProductos.Columns["Precio_Unitario"].DefaultCellStyle.Format = "$ #,##0.00";
                    dgvProductos.Columns["Sub_Total"].DefaultCellStyle.Format = "$ #,##0.00";
                    limpiar();
                }catch(Exception ex){
                    MessageBox.Show("El producto no existe");
                }
            }
        }
        /// <summary>
        /// Cancelar la venta y dejar todo limpio para una nueva venta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas cancelar la venta?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                reiniciar();
                limpiar();
                lista.Clear();
                MessageBox.Show("Venta cancelada");
            }
        }
        /// <summary>
        /// Metodo para eliminar los productois eliminados del datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas eliminar el producto?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Int32 selectedRowCount = dgvProductos.Rows.GetRowCount(DataGridViewElementStates.Selected);
                    if (selectedRowCount > 0)
                    {
                        for (int i = 0; i < selectedRowCount; i++)
                        {
                            for (int j = 0; j < lista.Count; j++)
                            {
                                if (dgvProductos.Rows[dgvProductos.SelectedRows[i].Index].Cells["ID"].Value.ToString() == lista[j].ID.ToString())
                                {
                                    total -= lista.ElementAt(j).Sub_Total;
                                    lista.RemoveAt(j);
                                }
                            }
                        }
                        dgvProductos.DataSource = null;
                        dgvProductos.DataSource = lista;
                        lblTotal.Text = "Total:  $ " + (total - double.Parse(txtDescuento.Text.ToString()));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error consulta al Administrador");
                }
            }

        }
        /// <summary>
        /// Metodo para realizar la venta y limpiar todo para la siguiente venta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRealizar_Click(object sender, EventArgs e)
        {
            if(lista != null){
                bool s = vDao.venta(lista, total, int.Parse(txtDescuento.Text.ToString()), id);
                if (s)
                {
                    if (MessageBox.Show("¿Deseas realizar la venta?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (MessageBox.Show("¿Quiere imprimir el ticket?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int f = 0;
                            //Creamos una instancia d ela clase CrearTicket
                            Cls_CrearTicket ticket = new Cls_CrearTicket();

                            ticket.TextoCentro("Rustico´s Vivero");
                            ticket.TextoCentro("Carretera Puruandiro-Janamuato");
                            ticket.TextoCentro("Abasolo No. 388");
                            ticket.TextoExtremos("FECHA: " + DateTime.Now.ToShortDateString(), "HORA: " + DateTime.Now.ToShortTimeString());
                            ticket.textoDerecha("No. Ticket: " + txtIdVenta.Text.ToString());
                            ticket.lineasGuion();
                            ticket.TextoIzquierda("");
                            //Articulos a vender.
                            ticket.EncabezadoVenta();//NOMBRE DEL ARTICULO, CANT, PRECIO, IMPORTE
                            //agregar los productos
                            for (int i = 0; i < lista.Count; i++)
                            {
                                f += lista.ElementAt(i).Cantidad;
                                ticket.AgregarArticulo(lista.ElementAt(i).Producto, lista.ElementAt(i).Cantidad, decimal.Parse(lista.ElementAt(i).Precio_Unitario.ToString()), decimal.Parse(lista.ElementAt(i).Sub_Total.ToString()));
                            }
                            ticket.lineasGuion();
                            // Totales 
                            ticket.AgregarTotales("         SUBTOTAL......$", decimal.Parse(total.ToString()));
                            ticket.AgregarTotales("         TOTAL.........$", decimal.Parse(total.ToString()) - decimal.Parse(txtDescuento.Text.ToString()));
                            ticket.TextoIzquierda("");
                            ticket.AgregarTotales("         EFECTIVO......$", decimal.Parse(txtPago.Text.ToString()));
                            ticket.AgregarTotales("         CAMBIO........$", (decimal.Parse(total.ToString()) - decimal.Parse(txtDescuento.Text.ToString())) - decimal.Parse(txtPago.Text.ToString()));
                            ticket.lineasGuion();

                            //Texto final del Ticket.
                            ticket.TextoIzquierda("");
                            ticket.TextoIzquierda("ARTÍCULOS VENDIDOS: " + f);
                            ticket.TextoIzquierda("Lo atendio: " + txtEmpleado.Text.ToString());
                            ticket.TextoIzquierda("");
                            ticket.TextoCentro("¡GRACIAS POR SU COMPRA!");
                            ticket.CargarTicket();
                            ticket.ImprimirTicket("Microsoft XPS Document Writer");//Nombre de la impresora ticketera

                        }
                        else
                        {
                            MessageBox.Show("Venta realizada");
                        }

                        reiniciar();
                        limpiar();
                        lista.Clear();
                        dgvProductos.DataSource = null;
                    }
                }
                else
                {
                    MessageBox.Show("Error al hacer la venta");
                }
            }
            else
            {
                MessageBox.Show("Error debes llenar la venta para poderla realizar");
            }
        }
        /// <summary>
        /// Evento que valida que la entrada sea solo numeros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtIdProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Enter))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        /// <summary>
        /// Eventos que valida que la entrada solo sea numeros
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
        /// <summary>
        /// Evento que valida que la entrada sean solo numeros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Enter))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                lblTotal.Text = "Total:  $ " + (total - double.Parse(txtDescuento.Text.ToString()));
            }
        }
        /// <summary>
        /// Evento que valida que solo acepte numeros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Enter))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                lblCambio.Text = "Cambio: $ " + (double.Parse(txtPago.Text.ToString()) - (total - double.Parse(txtDescuento.Text.ToString())));
            }
        }

    }
}

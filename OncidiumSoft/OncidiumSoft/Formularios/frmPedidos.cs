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
    public partial class frmPedidos : Form
    {
        public frmPedidos()
        {
            InitializeComponent();
        }
        /// <summary>
        /// variables
        /// </summary>
        public bool editar = false;
        public int id = -1;
        public int idu = -1;
        /// <summary>
        /// objetos de pedidos
        /// </summary>
        Cls_DaoPedidos pDao = new Cls_DaoPedidos();
        /// <summary>
        /// objetos de datos ventas
        /// </summary>
        Cls_Ventas v = new Cls_Ventas();
        List<Cls_DatosVenta> dV = new List<Cls_DatosVenta>();
        /// <summary>
        /// objetos de Dao productos y de datos del producto
        /// </summary>
        Cls_Productos pro = new Cls_Productos();
        Cls_DaoProductos proDao = new Cls_DaoProductos();
        /// <summary>
        /// Metodo para indicar lo que debe tener las cajas al cargar
        /// </summary>

        private void frmPedidos_Load(object sender, EventArgs e)
        {
            limpiar();
            txtTotal.Text = "0";
            txtSubtotal.Text = "0";
            txtAnticipo.Text = "0";
            if(editar){
                btnRealizar.Text = "Actualizar";
                v = pDao.obtenerPedido(id);
                dV = pDao.buscarPro(id);

                dtRealizar.Value = v.fecha_Realizar;
                dtEntrega.Value = v.fecha_Entrega;
                txtNCliente.Text = v.cliente;
                txttelefono.Text = v.telefono;
                txtDomicilio.Text = v.domicilio;
                txtDescripcion.Text = v.descripcion;
                txtAnticipo.Text = v.anticipo.ToString();
                txtSubtotal.Text = v.subTotal.ToString();
                txtTotal.Text = v.total.ToString();
                dgvPedidos.DataSource = dV;
                dgvPedidos.Columns["Precio_Unitario"].DefaultCellStyle.Format = "$ #,##0.00";
                dgvPedidos.Columns["Sub_Total"].DefaultCellStyle.Format = "$ #,##0.00";
            }
        }
        /// <summary>
        ///limpiar cajas de texto para ingresar nuevo de la parte de productos
        /// </summary>
        public void limpiar()
        {
            txtTipo.Text = "";
            txtProducto.Text = "";
            txtIdProducto.Text = "";
            txtCantidaP.Text = "1";
        }
        /// <summary>
        /// Metodo para limpiar la parte del pedido
        /// </summary>

        public void limpiarTodo()
        {
            dtRealizar.Value = DateTime.Now;
            dtEntrega.Value = DateTime.Now;
            txtNCliente.Text = "";
            txttelefono.Text = "";
            txtDomicilio.Text = "";
            txtDescripcion.Text = "";
            txtAnticipo.Text = "0";
            txtSubtotal.Text = "0";
            txtTotal.Text = "0";
            dgvPedidos.DataSource = dV;
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
                    txtProducto.Text = pro.NombreProducto.ToString();
                    Thread.Sleep(50);
                    limpiar();
                    Cls_DatosVenta v = new Cls_DatosVenta();
                    v.ID = pro.idProductoss;
                    v.Producto = pro.NombreProducto;
                    v.Precio_Unitario = pro.PrecioalCliente;
                    v.Cantidad = int.Parse(txtCantidaP.Text.ToString());
                    v.Sub_Total = v.Cantidad * v.Precio_Unitario;
                    v.Tipo = pro.TipoProducto;
                    double k = double.Parse(txtTotal.Text.ToString()) + v.Sub_Total;
                    txtSubtotal.Text = k.ToString();
                    txtTotal.Text = (k - double.Parse(txtAnticipo.Text.ToString())).ToString();
                    if (dV == null)
                    {
                        dV.Add(v);
                    }
                    else
                    {
                        bool s = false;
                        foreach (Cls_DatosVenta d in dV)
                        {
                            if (d.ID == v.ID)
                            {
                                d.Cantidad += v.Cantidad;
                                d.Sub_Total += v.Sub_Total;
                                s = true;
                            }
                        }
                        if (!s)
                        {
                            dV.Add(v);
                        }
                    }

                    dgvPedidos.DataSource = null;
                    dgvPedidos.DataSource = dV;
                    dgvPedidos.Columns["Precio_Unitario"].DefaultCellStyle.Format = "$ #,##0.00";
                    dgvPedidos.Columns["Sub_Total"].DefaultCellStyle.Format = "$ #,##0.00";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El producto no existe");
                }
            }
        }

        public bool validar()
        {
            if(
                txtNCliente.Text == "" &&
                txttelefono.Text == "" &&
                txtDomicilio.Text == "" &&
                txtDescripcion.Text == "" &&
                txtAnticipo.Text == "" &&
                txtSubtotal.Text == "" &&
                txtTotal.Text == "" && dV.Count == 0
                ){
                return true;
            }
            return false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Metodo para realizar el pedido
        /// </summary>
        private void btnRealizar_Click(object sender, EventArgs e)
        {
            bool z = false;
            if(editar){
                v.fecha_Realizar = dtRealizar.Value;
                v.fecha_Entrega = dtEntrega.Value;
                v.cliente = txtNCliente.Text;
                v.telefono = txttelefono.Text;
                v.domicilio = txtDomicilio.Text;
                v.descripcion = txtDescripcion.Text;
                v.anticipo = float.Parse(txtAnticipo.Text.ToString());
                v.subTotal = float.Parse(txtSubtotal.Text.ToString());
                v.total = float.Parse(txtTotal.Text.ToString());
                z = pDao.ActualizarPedido(dV,v);
                if(z){
                    MessageBox.Show("Edicion realizada");
                }else{
                    MessageBox.Show("Error al editar");
                }
            }
            else
            {
                v.fecha_Realizar = dtRealizar.Value;
                v.fecha_Entrega = dtEntrega.Value;
                v.cliente = txtNCliente.Text;
                v.telefono = txttelefono.Text;
                v.domicilio = txtDomicilio.Text;
                v.descripcion = txtDescripcion.Text;
                v.anticipo = float.Parse(txtAnticipo.Text.ToString());
                v.subTotal = float.Parse(txtSubtotal.Text.ToString());
                v.total = float.Parse(txtTotal.Text.ToString());
                v.idUsuario = idu;
                z = pDao.Pedido(dV, v);
                if (z)
                {
                    MessageBox.Show("Edicion realizada");
                    limpiarTodo();
                    limpiar();
                }
                else
                {
                    MessageBox.Show("Error al editar");
                }
            }
        }
        /// <summary>
        /// Metodo del boton eliminar que permite eliminar un pedido
        /// </summary>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 selectedRowCount = dgvPedidos.Rows.GetRowCount(DataGridViewElementStates.Selected);
                if (selectedRowCount > 0)
                {
                    for (int i = 0; i < selectedRowCount; i++)
                    {
                        for (int j = 0; j < dV.Count; j++)
                        {
                            if (dgvPedidos.Rows[i].Cells["ID"].Value.ToString() == dV[j].ID.ToString())
                            {
                                dV.RemoveAt(j);
                            }
                        }
                    }
                    dgvPedidos.DataSource = null;
                    dgvPedidos.DataSource = dV;
                    dgvPedidos.Columns["Precio_Unitario"].DefaultCellStyle.Format = "$ #,##0.00";
                    dgvPedidos.Columns["Sub_Total"].DefaultCellStyle.Format = "$ #,##0.00";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error consulta al Administrador");
            }
        }
        /// <summary>
        /// Metodopara validaciones
        /// </summary>
        private void txtAnticipo_TextChanged(object sender, EventArgs e)
        {
            if(txtAnticipo.Text != ""){
            txtTotal.Text = (double.Parse(txtSubtotal.Text.ToString()) - double.Parse(txtAnticipo.Text.ToString())).ToString();
            }
        }

        private void txtAnticipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }

            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < txtAnticipo.Text.Length; i++)
            {
                if (txtAnticipo.Text[i] == ',')
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

        private void txtIdProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCantidaP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txttelefono_KeyPress(object sender, KeyPressEventArgs e)
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

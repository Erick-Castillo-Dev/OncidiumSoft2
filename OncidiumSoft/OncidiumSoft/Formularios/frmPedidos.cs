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

        public bool editar = false;
        public int id = -1;
        Cls_DaoPedidos pDao = new Cls_DaoPedidos();
        Cls_Ventas v = new Cls_Ventas();
        List<Cls_DatosVenta> dV = new List<Cls_DatosVenta>();
        Cls_Productos pro = new Cls_Productos();
        Cls_DaoProductos proDao = new Cls_DaoProductos();

        private void frmPedidos_Load(object sender, EventArgs e)
        {
            limpiar();
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
                dgvPedidos.Columns["Precio_Unitario"].DefaultCellStyle.Format = "$ #,##0.00";
                dgvPedidos.Columns["Sub_Total"].DefaultCellStyle.Format = "$ #,##0.00";
                dgvPedidos.DataSource = dV;
            }
        }

        public void limpiar()
        {
            txtTipo.Text = "";
            txtProducto.Text = "";
            txtIdProducto.Text = "";
            txtCantidaP.Text = "1";
        }

        private void txtIdProducto_KeyUp(object sender, KeyEventArgs e)
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
            }catch(Exception ex){
                MessageBox.Show("El producto no existe");
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
    }
}

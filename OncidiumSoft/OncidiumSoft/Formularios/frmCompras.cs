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
using OncidiumSoft.Daos;
using OncidiumSoft.Objetos;
using System.Threading;

namespace OncidiumSoft.Formularios
{
    public partial class frmCompras : Form
    {
        public frmCompras()
        {
            InitializeComponent();
        }

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
        List<Cls_DatosCompra> lista = new List<Cls_DatosCompra>();
        /// <summary>
        /// Variable global para el total
        /// </summary>
        double total = 0;
        Cls_DaoCompra cDao = new Cls_DaoCompra();

        private void btnRealizar_Click(object sender, EventArgs e)
        {
            Conexion conect = new Conexion();
            conect.Conectar();
            MessageBox.Show("si se conecto");
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
                    ptProducto.Image = vDao.cargarimagen(pro.imgenProducto);
                    txtTipo.Text = pro.TipoProducto.ToString();
                    txtPrecio.Text = pro.PrecioalCliente.ToString();
                    txtProducto.Text = pro.NombreProducto.ToString();
                    Thread.Sleep(50);
                    Cls_DatosCompra pd = new Cls_DatosCompra();
                    pd.ID = pro.idProductoss;
                    pd.Producto = pro.NombreProducto;
                    pd.Precio_Unitario = pro.PrecioalCliente;
                    pd.Cantidad = int.Parse(txtCan.Text.ToString());
                    pd.Sub_Total = pd.Cantidad * pd.Precio_Unitario;
                    pd.Tipo = pro.TipoProducto;
                    pd.Provedor = cDao.Provedor(pro.iddeProvedores);
                    total += pd.Sub_Total;
                    if (lista == null)
                    {
                        lista.Add(pd);
                    }
                    else
                    {
                        bool s = false;
                        foreach (Cls_DatosCompra d in lista)
                        {
                            if (d.ID == pd.ID)
                            {
                                d.Cantidad += pd.Cantidad;
                                d.Sub_Total += pd.Sub_Total;
                                s = true;
                            }
                        }
                        if (!s)
                        {
                            lista.Add(pd);
                        }
                    }

                    limpiar();
                    dgvCompra.DataSource = null;
                    dgvCompra.DataSource = lista;
                    dgvCompra.Columns["Precio_Unitario"].DefaultCellStyle.Format = "$ #,##0.00";
                    dgvCompra.Columns["Sub_Total"].DefaultCellStyle.Format = "$ #,##0.00";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El producto no existe");
                }
            }

        }

        public void limpiar()
        {
            txtCan.Text = "1";
            txtIdProducto.Text = "";
            txtPrecio.Text = "";
            txtProducto.Text = "";
            txtTipo.Text = "";
        }

        private void btnRealizar_Click_1(object sender, EventArgs e)
        {
            bool s = cDao.compra(lista);
            if(s){
                limpiar();
                dgvCompra.DataSource = null;
                lista.Clear();
                MessageBox.Show("Compra realizada");
            }else{
                MessageBox.Show("Error no se pudo hacer la compra");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
            lista.Clear();
            MessageBox.Show("Compra cancelada");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 selectedRowCount = dgvCompra.Rows.GetRowCount(DataGridViewElementStates.Selected);
                if (selectedRowCount > 0)
                {
                    for (int i = 0; i < selectedRowCount; i++)
                    {
                        for (int j = 0; j < lista.Count; j++)
                        {
                            if (dgvCompra.Rows[i].Cells["ID"].Value.ToString() == lista[j].ID.ToString())
                            {
                                lista.RemoveAt(j);
                            }
                        }
                    }
                    dgvCompra.DataSource = null;
                    dgvCompra.DataSource = lista;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error consulta al Administrador");
            }
        }

        private void txtIdProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar !=(char)Keys.Enter ))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }*/
        }

        private void frmCompras_Load(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}

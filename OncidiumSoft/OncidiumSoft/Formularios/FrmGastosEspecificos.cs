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
    public partial class FrmGastosEspecificos : Form
    {
        double sumaGastos=0;
        public FrmGastosEspecificos()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método para el boton cancelar gastos
        /// </summary>
        private void btnCancelarGastos_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmContabilidad().Show();
        }

        /// <summary>
        /// Método para el boton aceptar gastos
        /// </summary>
        private void btnAceptarGastos_Click(object sender, EventArgs e)
        {
            FrmContabilidad objCont = new FrmContabilidad();
            if (txtGastosFertilizantes.Text != string.Empty && txtGastosInsecticidas.Text != string.Empty && txtGastosGasolina.Text != string.Empty &&
                txtGastosAgua.Text != string.Empty && txtGastosLuz.Text != string.Empty && txtImprevistos.Text != string.Empty)
            {
                try
                {
                    sumaGastos = double.Parse(txtGastosFertilizantes.Text) + double.Parse(txtGastosInsecticidas.Text) + double.Parse(txtGastosGasolina.Text) +
                    double.Parse(txtGastosAgua.Text) + double.Parse(txtGastosLuz.Text) + double.Parse(txtImprevistos.Text);
                    String.Format("{0:####,##}", sumaGastos);
                    objCont.txtGastosGenerales.Text = sumaGastos.ToString();
                    this.Hide();
                    objCont.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Introduzca el formato correcto para los gastos");
                }
                
            }
            else if (txtGastosFertilizantes.Text == string.Empty && txtGastosInsecticidas.Text == string.Empty && txtGastosGasolina.Text == string.Empty &&
                txtGastosAgua.Text == string.Empty && txtGastosLuz.Text == string.Empty && txtImprevistos.Text == string.Empty)
            {
                MessageBox.Show("Es necesario llenar por lo menos un campo");
            }
            else
            {
                 if (MessageBox.Show("¿Estas seguro que no deseas agregar ningún otro gasto?", "*** AVISO ***", MessageBoxButtons.YesNo) == DialogResult.Yes)
                 {
                     if (txtGastosFertilizantes.Text != string.Empty)
                     {
                         sumaGastos += double.Parse(txtGastosFertilizantes.Text);
                     }
                     if (txtGastosInsecticidas.Text != string.Empty)
                     {
                         sumaGastos += double.Parse(txtGastosFertilizantes.Text);
                     }
                     if (txtGastosGasolina.Text != string.Empty)
                     {
                         sumaGastos += double.Parse(txtGastosFertilizantes.Text);
                     }
                     if (txtGastosAgua.Text != string.Empty)
                     {
                         sumaGastos += double.Parse(txtGastosFertilizantes.Text);
                     }
                     if (txtGastosLuz.Text != string.Empty)
                     {
                         sumaGastos += double.Parse(txtGastosFertilizantes.Text);
                     }
                     if (txtImprevistos.Text != string.Empty)
                     {
                         sumaGastos += double.Parse(txtGastosFertilizantes.Text);
                     }
                     String.Format("{0:####,##}", sumaGastos); 
                     objCont.txtGastosGenerales.Text = sumaGastos.ToString();
                     this.Hide();
                     objCont.Show();
                 }
            }
        }

        /// <summary>
        /// Método keypress para el textbox de gastos en fertilizantes
        /// </summary>
        private void txtGastosFertilizantes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsNumber(e.KeyChar) == false) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            else
                e.Handled = false;
        }

        /// <summary>
        /// Método keypress para el textbox de gastos en insecticidas
        /// </summary>
        private void txtGastosInsecticidas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsNumber(e.KeyChar) == false) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            else
                e.Handled = false;
        }

        /// <summary>
        /// Método keypress para el textbox de gastos en gasolina
        /// </summary>
        private void txtGastosGasolina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsNumber(e.KeyChar) == false) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            else
                e.Handled = false;
        }

        /// <summary>
        /// Método keypress para el textbox de gastos en agua
        /// </summary>
        private void txtGastosAgua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsNumber(e.KeyChar) == false) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            else
                e.Handled = false;
        }

        /// <summary>
        /// Método keypress para el textbox de gastos en luz
        /// </summary>
        private void txtGastosLuz_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsNumber(e.KeyChar) == false) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            else
                e.Handled = false;
        }

        /// <summary>
        /// Método keypress para el textbox de imprevistos
        /// </summary>
        private void txtImprevistos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsNumber(e.KeyChar) == false) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            else
                e.Handled = false;
        }
    }
}

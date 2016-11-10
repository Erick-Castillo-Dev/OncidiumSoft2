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
        /// Método para cancelar los gastos introducidos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelarGastos_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmContabilidad().Show();
        }

        /// <summary>
        /// Método para aceptar los gastos introducidos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    objCont.txtGastosGenerales.Text = sumaGastos.ToString();
                    this.Hide();
                    objCont.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Introduzca el formato correcto para los gastos");
                    txtGastosFertilizantes.Clear();
                    txtGastosInsecticidas.Clear();
                    txtGastosGasolina.Clear();
                    txtGastosAgua.Clear();
                    txtGastosLuz.Clear();
                    txtImprevistos.Clear();
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
                     try
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
                         objCont.txtGastosGenerales.Text = sumaGastos.ToString();
                         this.Hide();
                         objCont.Show();
                     }
                     catch(Exception ex)
                     {
                         MessageBox.Show("Introduzca el formato correcto para los gastos");
                         txtGastosFertilizantes.Clear();
                         txtGastosInsecticidas.Clear();
                         txtGastosGasolina.Clear();
                         txtGastosAgua.Clear();
                         txtGastosLuz.Clear();
                         txtImprevistos.Clear();
                     }
                     
                 }
            }
        }

        /// <summary>
        /// Método keypress que valida números a solo dos decimales
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtGastosFertilizantes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }

            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < txtGastosFertilizantes.Text.Length; i++)
            {
                if (txtGastosFertilizantes.Text[i] == ',')
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
        /// Método keypress que valida números a solo dos decimales
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtGastosInsecticidas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }

            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < txtGastosInsecticidas.Text.Length; i++)
            {
                if (txtGastosInsecticidas.Text[i] == ',')
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
        /// Método keypress que válida números a solo dos decimales
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtGastosGasolina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }

            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < txtGastosGasolina.Text.Length; i++)
            {
                if (txtGastosGasolina.Text[i] == ',')
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
        /// Método keypress que válida números a solo dos decimales
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtGastosAgua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }

            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < txtGastosAgua.Text.Length; i++)
            {
                if (txtGastosAgua.Text[i] == ',')
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
        /// Método keypress que válida números a solo dos decimales
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtGastosLuz_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }

            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < txtGastosLuz.Text.Length; i++)
            {
                if (txtGastosLuz.Text[i] == ',')
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
        /// Método keypress que válida solo números a dos decimales
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtImprevistos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }

            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < txtImprevistos.Text.Length; i++)
            {
                if (txtImprevistos.Text[i] == ',')
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
    }
}

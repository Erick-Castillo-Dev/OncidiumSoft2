namespace OncidiumSoft.Formularios
{
    partial class FrmContabilidad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalcularInversion = new System.Windows.Forms.Button();
            this.GastosGenerales = new System.Windows.Forms.Button();
            this.lblFechaA = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblInversionT = new System.Windows.Forms.Label();
            this.lblVentasT = new System.Windows.Forms.Label();
            this.txtGastosGenerales = new System.Windows.Forms.TextBox();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtSalarios = new System.Windows.Forms.TextBox();
            this.lblSalarios = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblGanancia = new System.Windows.Forms.Label();
            this.lblInversion = new System.Windows.Forms.Label();
            this.lblGastosGenerales = new System.Windows.Forms.Label();
            this.lblVentas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcularInversion
            // 
            this.btnCalcularInversion.Location = new System.Drawing.Point(335, 91);
            this.btnCalcularInversion.Name = "btnCalcularInversion";
            this.btnCalcularInversion.Size = new System.Drawing.Size(101, 23);
            this.btnCalcularInversion.TabIndex = 50;
            this.btnCalcularInversion.Text = "Calcular inversion";
            this.btnCalcularInversion.UseVisualStyleBackColor = true;
            this.btnCalcularInversion.Click += new System.EventHandler(this.btnCalcularInversion_Click);
            // 
            // GastosGenerales
            // 
            this.GastosGenerales.AccessibleName = "btnGastosGenerales";
            this.GastosGenerales.BackColor = System.Drawing.Color.Transparent;
            this.GastosGenerales.Location = new System.Drawing.Point(238, 61);
            this.GastosGenerales.Name = "GastosGenerales";
            this.GastosGenerales.Size = new System.Drawing.Size(20, 20);
            this.GastosGenerales.TabIndex = 49;
            this.GastosGenerales.UseVisualStyleBackColor = false;
            this.GastosGenerales.Click += new System.EventHandler(this.GastosGenerales_Click);
            // 
            // lblFechaA
            // 
            this.lblFechaA.AutoSize = true;
            this.lblFechaA.Location = new System.Drawing.Point(311, 29);
            this.lblFechaA.Name = "lblFechaA";
            this.lblFechaA.Size = new System.Drawing.Size(29, 13);
            this.lblFechaA.TabIndex = 48;
            this.lblFechaA.Text = "label";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "0.00";
            // 
            // lblInversionT
            // 
            this.lblInversionT.AutoSize = true;
            this.lblInversionT.Location = new System.Drawing.Point(120, 121);
            this.lblInversionT.Name = "lblInversionT";
            this.lblInversionT.Size = new System.Drawing.Size(28, 13);
            this.lblInversionT.TabIndex = 46;
            this.lblInversionT.Text = "0.00";
            // 
            // lblVentasT
            // 
            this.lblVentasT.AutoSize = true;
            this.lblVentasT.Location = new System.Drawing.Point(96, 29);
            this.lblVentasT.Name = "lblVentasT";
            this.lblVentasT.Size = new System.Drawing.Size(28, 13);
            this.lblVentasT.TabIndex = 45;
            this.lblVentasT.Text = "0.00";
            // 
            // txtGastosGenerales
            // 
            this.txtGastosGenerales.AccessibleName = "";
            this.txtGastosGenerales.Enabled = false;
            this.txtGastosGenerales.Location = new System.Drawing.Point(138, 61);
            this.txtGastosGenerales.Name = "txtGastosGenerales";
            this.txtGastosGenerales.Size = new System.Drawing.Size(100, 20);
            this.txtGastosGenerales.TabIndex = 44;
            // 
            // btnHistorial
            // 
            this.btnHistorial.Location = new System.Drawing.Point(323, 183);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(113, 28);
            this.btnHistorial.TabIndex = 43;
            this.btnHistorial.Text = "Ver historial";
            this.btnHistorial.UseVisualStyleBackColor = true;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(361, 139);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 42;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(262, 139);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 41;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // txtSalarios
            // 
            this.txtSalarios.Location = new System.Drawing.Point(335, 61);
            this.txtSalarios.MaxLength = 8;
            this.txtSalarios.Name = "txtSalarios";
            this.txtSalarios.Size = new System.Drawing.Size(100, 20);
            this.txtSalarios.TabIndex = 40;
            this.txtSalarios.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalarios_KeyPress);
            // 
            // lblSalarios
            // 
            this.lblSalarios.AutoSize = true;
            this.lblSalarios.Location = new System.Drawing.Point(270, 66);
            this.lblSalarios.Name = "lblSalarios";
            this.lblSalarios.Size = new System.Drawing.Size(59, 13);
            this.lblSalarios.TabIndex = 39;
            this.lblSalarios.Text = "Salarios:  $";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(270, 29);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 38;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblGanancia
            // 
            this.lblGanancia.AutoSize = true;
            this.lblGanancia.Location = new System.Drawing.Point(30, 169);
            this.lblGanancia.Name = "lblGanancia";
            this.lblGanancia.Size = new System.Drawing.Size(118, 13);
            this.lblGanancia.TabIndex = 37;
            this.lblGanancia.Text = "Ganancia o pérdida:   $";
            // 
            // lblInversion
            // 
            this.lblInversion.AutoSize = true;
            this.lblInversion.Location = new System.Drawing.Point(30, 121);
            this.lblInversion.Name = "lblInversion";
            this.lblInversion.Size = new System.Drawing.Size(94, 13);
            this.lblInversion.TabIndex = 36;
            this.lblInversion.Text = "Inversión total:    $";
            // 
            // lblGastosGenerales
            // 
            this.lblGastosGenerales.AutoSize = true;
            this.lblGastosGenerales.Location = new System.Drawing.Point(30, 66);
            this.lblGastosGenerales.Name = "lblGastosGenerales";
            this.lblGastosGenerales.Size = new System.Drawing.Size(108, 13);
            this.lblGastosGenerales.TabIndex = 35;
            this.lblGastosGenerales.Text = "Gastos en general:  $";
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.Location = new System.Drawing.Point(30, 29);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(70, 13);
            this.lblVentas.TabIndex = 34;
            this.lblVentas.Text = "Ventas:       $";
            // 
            // FrmContabilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 240);
            this.Controls.Add(this.btnCalcularInversion);
            this.Controls.Add(this.GastosGenerales);
            this.Controls.Add(this.lblFechaA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblInversionT);
            this.Controls.Add(this.lblVentasT);
            this.Controls.Add(this.txtGastosGenerales);
            this.Controls.Add(this.btnHistorial);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtSalarios);
            this.Controls.Add(this.lblSalarios);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblGanancia);
            this.Controls.Add(this.lblInversion);
            this.Controls.Add(this.lblGastosGenerales);
            this.Controls.Add(this.lblVentas);
            this.Name = "FrmContabilidad";
            this.Text = "FrmContabilidad";
            this.Load += new System.EventHandler(this.FrmContabilidad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcularInversion;
        private System.Windows.Forms.Button GastosGenerales;
        private System.Windows.Forms.Label lblFechaA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblInversionT;
        private System.Windows.Forms.Label lblVentasT;
        public System.Windows.Forms.TextBox txtGastosGenerales;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtSalarios;
        private System.Windows.Forms.Label lblSalarios;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblGanancia;
        private System.Windows.Forms.Label lblInversion;
        private System.Windows.Forms.Label lblGastosGenerales;
        private System.Windows.Forms.Label lblVentas;
    }
}
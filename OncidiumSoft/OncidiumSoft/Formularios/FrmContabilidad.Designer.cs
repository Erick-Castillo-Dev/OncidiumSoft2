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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContabilidad));
            this.GastosGenerales = new System.Windows.Forms.Button();
            this.lblFechaA = new System.Windows.Forms.Label();
            this.lblGananciaT = new System.Windows.Forms.Label();
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
            this.lblFechaIni = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // GastosGenerales
            // 
            this.GastosGenerales.AccessibleName = "btnGastosGenerales";
            this.GastosGenerales.BackColor = System.Drawing.Color.Transparent;
            this.GastosGenerales.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GastosGenerales.BackgroundImage")));
            this.GastosGenerales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.GastosGenerales.Location = new System.Drawing.Point(292, 163);
            this.GastosGenerales.Name = "GastosGenerales";
            this.GastosGenerales.Size = new System.Drawing.Size(22, 25);
            this.GastosGenerales.TabIndex = 49;
            this.GastosGenerales.UseVisualStyleBackColor = false;
            this.GastosGenerales.Click += new System.EventHandler(this.GastosGenerales_Click);
            // 
            // lblFechaA
            // 
            this.lblFechaA.AutoSize = true;
            this.lblFechaA.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaA.Font = new System.Drawing.Font("Rockwell", 12F);
            this.lblFechaA.Location = new System.Drawing.Point(402, 126);
            this.lblFechaA.Name = "lblFechaA";
            this.lblFechaA.Size = new System.Drawing.Size(45, 19);
            this.lblFechaA.TabIndex = 48;
            this.lblFechaA.Text = "label";
            // 
            // lblGananciaT
            // 
            this.lblGananciaT.AutoSize = true;
            this.lblGananciaT.BackColor = System.Drawing.Color.Transparent;
            this.lblGananciaT.Font = new System.Drawing.Font("Rockwell", 12F);
            this.lblGananciaT.Location = new System.Drawing.Point(212, 263);
            this.lblGananciaT.Name = "lblGananciaT";
            this.lblGananciaT.Size = new System.Drawing.Size(41, 19);
            this.lblGananciaT.TabIndex = 47;
            this.lblGananciaT.Text = "0,00";
            // 
            // lblInversionT
            // 
            this.lblInversionT.AutoSize = true;
            this.lblInversionT.BackColor = System.Drawing.Color.Transparent;
            this.lblInversionT.Font = new System.Drawing.Font("Rockwell", 12F);
            this.lblInversionT.Location = new System.Drawing.Point(168, 215);
            this.lblInversionT.Name = "lblInversionT";
            this.lblInversionT.Size = new System.Drawing.Size(41, 19);
            this.lblInversionT.TabIndex = 46;
            this.lblInversionT.Text = "0,00";
            // 
            // lblVentasT
            // 
            this.lblVentasT.AutoSize = true;
            this.lblVentasT.BackColor = System.Drawing.Color.Transparent;
            this.lblVentasT.Font = new System.Drawing.Font("Rockwell", 12F);
            this.lblVentasT.Location = new System.Drawing.Point(115, 127);
            this.lblVentasT.Name = "lblVentasT";
            this.lblVentasT.Size = new System.Drawing.Size(41, 19);
            this.lblVentasT.TabIndex = 45;
            this.lblVentasT.Text = "0.00";
            // 
            // txtGastosGenerales
            // 
            this.txtGastosGenerales.AccessibleName = "";
            this.txtGastosGenerales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGastosGenerales.Enabled = false;
            this.txtGastosGenerales.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.txtGastosGenerales.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtGastosGenerales.Location = new System.Drawing.Point(192, 164);
            this.txtGastosGenerales.Name = "txtGastosGenerales";
            this.txtGastosGenerales.Size = new System.Drawing.Size(100, 23);
            this.txtGastosGenerales.TabIndex = 44;
            this.txtGastosGenerales.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGastosGenerales_KeyPress);
            // 
            // btnHistorial
            // 
            this.btnHistorial.BackColor = System.Drawing.Color.ForestGreen;
            this.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHistorial.Font = new System.Drawing.Font("Rockwell", 12F);
            this.btnHistorial.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHistorial.Location = new System.Drawing.Point(412, 278);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(119, 33);
            this.btnHistorial.TabIndex = 43;
            this.btnHistorial.Text = "Ver historial";
            this.btnHistorial.UseVisualStyleBackColor = false;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Rockwell", 12F);
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.Location = new System.Drawing.Point(440, 236);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 33);
            this.btnCancelar.TabIndex = 42;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcular.Font = new System.Drawing.Font("Rockwell", 12F);
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCalcular.Location = new System.Drawing.Point(339, 236);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(92, 33);
            this.btnCalcular.TabIndex = 41;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtSalarios
            // 
            this.txtSalarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalarios.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.txtSalarios.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSalarios.Location = new System.Drawing.Point(432, 163);
            this.txtSalarios.MaxLength = 8;
            this.txtSalarios.Name = "txtSalarios";
            this.txtSalarios.Size = new System.Drawing.Size(100, 23);
            this.txtSalarios.TabIndex = 40;
            this.txtSalarios.TextChanged += new System.EventHandler(this.txtSalarios_TextChanged);
            this.txtSalarios.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalarios_KeyPress);
            // 
            // lblSalarios
            // 
            this.lblSalarios.AutoSize = true;
            this.lblSalarios.BackColor = System.Drawing.Color.Transparent;
            this.lblSalarios.Font = new System.Drawing.Font("Rockwell", 12F);
            this.lblSalarios.Location = new System.Drawing.Point(343, 166);
            this.lblSalarios.Name = "lblSalarios";
            this.lblSalarios.Size = new System.Drawing.Size(89, 19);
            this.lblSalarios.TabIndex = 39;
            this.lblSalarios.Text = "Salarios:  $";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Rockwell", 12F);
            this.lblFecha.Location = new System.Drawing.Point(343, 127);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(58, 19);
            this.lblFecha.TabIndex = 38;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblGanancia
            // 
            this.lblGanancia.AutoSize = true;
            this.lblGanancia.BackColor = System.Drawing.Color.Transparent;
            this.lblGanancia.Font = new System.Drawing.Font("Rockwell", 12F);
            this.lblGanancia.Location = new System.Drawing.Point(28, 263);
            this.lblGanancia.Name = "lblGanancia";
            this.lblGanancia.Size = new System.Drawing.Size(177, 19);
            this.lblGanancia.TabIndex = 37;
            this.lblGanancia.Text = "Ganancia o pérdida:  $";
            // 
            // lblInversion
            // 
            this.lblInversion.AutoSize = true;
            this.lblInversion.BackColor = System.Drawing.Color.Transparent;
            this.lblInversion.Font = new System.Drawing.Font("Rockwell", 12F);
            this.lblInversion.Location = new System.Drawing.Point(28, 215);
            this.lblInversion.Name = "lblInversion";
            this.lblInversion.Size = new System.Drawing.Size(135, 19);
            this.lblInversion.TabIndex = 36;
            this.lblInversion.Text = "Inversión total:  $";
            // 
            // lblGastosGenerales
            // 
            this.lblGastosGenerales.AutoSize = true;
            this.lblGastosGenerales.BackColor = System.Drawing.Color.Transparent;
            this.lblGastosGenerales.Font = new System.Drawing.Font("Rockwell", 12F);
            this.lblGastosGenerales.Location = new System.Drawing.Point(28, 169);
            this.lblGastosGenerales.Name = "lblGastosGenerales";
            this.lblGastosGenerales.Size = new System.Drawing.Size(164, 19);
            this.lblGastosGenerales.TabIndex = 35;
            this.lblGastosGenerales.Text = "Gastos en general:  $";
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.BackColor = System.Drawing.Color.Transparent;
            this.lblVentas.Font = new System.Drawing.Font("Rockwell", 12F);
            this.lblVentas.Location = new System.Drawing.Point(28, 127);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(81, 19);
            this.lblVentas.TabIndex = 34;
            this.lblVentas.Text = "Ventas:  $";
            // 
            // lblFechaIni
            // 
            this.lblFechaIni.AutoSize = true;
            this.lblFechaIni.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaIni.Font = new System.Drawing.Font("Rockwell", 12F);
            this.lblFechaIni.Location = new System.Drawing.Point(402, 107);
            this.lblFechaIni.Name = "lblFechaIni";
            this.lblFechaIni.Size = new System.Drawing.Size(45, 19);
            this.lblFechaIni.TabIndex = 51;
            this.lblFechaIni.Text = "label";
            this.lblFechaIni.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.ForestGreen;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(573, 67);
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.ForestGreen;
            this.pictureBox2.Location = new System.Drawing.Point(1, 336);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(573, 35);
            this.pictureBox2.TabIndex = 53;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.ForestGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(203, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 29);
            this.label1.TabIndex = 54;
            this.label1.Text = "Contabilidad";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.ForestGreen;
            this.pictureBox3.BackgroundImage = global::OncidiumSoft.Properties.Resources._12283043_773212156137905_384527972_n;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(435, 19);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(97, 67);
            this.pictureBox3.TabIndex = 55;
            this.pictureBox3.TabStop = false;
            // 
            // FrmContabilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 370);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblFechaIni);
            this.Controls.Add(this.GastosGenerales);
            this.Controls.Add(this.lblFechaA);
            this.Controls.Add(this.lblGananciaT);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GastosGenerales;
        private System.Windows.Forms.Label lblFechaA;
        private System.Windows.Forms.Label lblGananciaT;
        private System.Windows.Forms.Label lblInversionT;
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
        public System.Windows.Forms.Label lblVentasT;
        private System.Windows.Forms.Label lblFechaIni;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
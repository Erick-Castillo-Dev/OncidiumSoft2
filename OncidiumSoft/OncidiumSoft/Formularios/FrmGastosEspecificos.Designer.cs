namespace OncidiumSoft.Formularios
{
    partial class FrmGastosEspecificos
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
            this.btnCancelarGastos = new System.Windows.Forms.Button();
            this.btnAceptarGastos = new System.Windows.Forms.Button();
            this.txtImprevistos = new System.Windows.Forms.TextBox();
            this.lblGastosImprevistos = new System.Windows.Forms.Label();
            this.txtGastosLuz = new System.Windows.Forms.TextBox();
            this.lblGastosLuz = new System.Windows.Forms.Label();
            this.txtGastosAgua = new System.Windows.Forms.TextBox();
            this.lblGastosAgua = new System.Windows.Forms.Label();
            this.txtGastosGasolina = new System.Windows.Forms.TextBox();
            this.lblGastosGasolina = new System.Windows.Forms.Label();
            this.txtGastosInsecticidas = new System.Windows.Forms.TextBox();
            this.lblGastosInsecticidas = new System.Windows.Forms.Label();
            this.txtGastosFertilizantes = new System.Windows.Forms.TextBox();
            this.lblGastosFertilizantes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelarGastos
            // 
            this.btnCancelarGastos.Location = new System.Drawing.Point(65, 260);
            this.btnCancelarGastos.Name = "btnCancelarGastos";
            this.btnCancelarGastos.Size = new System.Drawing.Size(87, 23);
            this.btnCancelarGastos.TabIndex = 41;
            this.btnCancelarGastos.Text = "Cancelar";
            this.btnCancelarGastos.UseVisualStyleBackColor = true;
            this.btnCancelarGastos.Click += new System.EventHandler(this.btnCancelarGastos_Click);
            // 
            // btnAceptarGastos
            // 
            this.btnAceptarGastos.Location = new System.Drawing.Point(162, 260);
            this.btnAceptarGastos.Name = "btnAceptarGastos";
            this.btnAceptarGastos.Size = new System.Drawing.Size(86, 23);
            this.btnAceptarGastos.TabIndex = 40;
            this.btnAceptarGastos.Text = "Aceptar";
            this.btnAceptarGastos.UseVisualStyleBackColor = true;
            this.btnAceptarGastos.Click += new System.EventHandler(this.btnAceptarGastos_Click);
            // 
            // txtImprevistos
            // 
            this.txtImprevistos.Location = new System.Drawing.Point(149, 214);
            this.txtImprevistos.MaxLength = 8;
            this.txtImprevistos.Name = "txtImprevistos";
            this.txtImprevistos.Size = new System.Drawing.Size(100, 20);
            this.txtImprevistos.TabIndex = 39;
            this.txtImprevistos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImprevistos_KeyPress);
            // 
            // lblGastosImprevistos
            // 
            this.lblGastosImprevistos.AutoSize = true;
            this.lblGastosImprevistos.Location = new System.Drawing.Point(18, 218);
            this.lblGastosImprevistos.Name = "lblGastosImprevistos";
            this.lblGastosImprevistos.Size = new System.Drawing.Size(128, 13);
            this.lblGastosImprevistos.TabIndex = 38;
            this.lblGastosImprevistos.Text = "Gastos en imprevistos:   $";
            // 
            // txtGastosLuz
            // 
            this.txtGastosLuz.Location = new System.Drawing.Point(149, 175);
            this.txtGastosLuz.MaxLength = 8;
            this.txtGastosLuz.Name = "txtGastosLuz";
            this.txtGastosLuz.Size = new System.Drawing.Size(100, 20);
            this.txtGastosLuz.TabIndex = 37;
            this.txtGastosLuz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGastosLuz_KeyPress);
            // 
            // lblGastosLuz
            // 
            this.lblGastosLuz.AutoSize = true;
            this.lblGastosLuz.Location = new System.Drawing.Point(18, 179);
            this.lblGastosLuz.Name = "lblGastosLuz";
            this.lblGastosLuz.Size = new System.Drawing.Size(128, 13);
            this.lblGastosLuz.TabIndex = 36;
            this.lblGastosLuz.Text = "Gastos en luz:                $";
            // 
            // txtGastosAgua
            // 
            this.txtGastosAgua.Location = new System.Drawing.Point(149, 136);
            this.txtGastosAgua.MaxLength = 8;
            this.txtGastosAgua.Name = "txtGastosAgua";
            this.txtGastosAgua.Size = new System.Drawing.Size(100, 20);
            this.txtGastosAgua.TabIndex = 35;
            this.txtGastosAgua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGastosAgua_KeyPress);
            // 
            // lblGastosAgua
            // 
            this.lblGastosAgua.AutoSize = true;
            this.lblGastosAgua.Location = new System.Drawing.Point(18, 140);
            this.lblGastosAgua.Name = "lblGastosAgua";
            this.lblGastosAgua.Size = new System.Drawing.Size(127, 13);
            this.lblGastosAgua.TabIndex = 34;
            this.lblGastosAgua.Text = "Gastos en agua:            $";
            // 
            // txtGastosGasolina
            // 
            this.txtGastosGasolina.Location = new System.Drawing.Point(148, 97);
            this.txtGastosGasolina.MaxLength = 8;
            this.txtGastosGasolina.Name = "txtGastosGasolina";
            this.txtGastosGasolina.Size = new System.Drawing.Size(100, 20);
            this.txtGastosGasolina.TabIndex = 33;
            this.txtGastosGasolina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGastosGasolina_KeyPress);
            // 
            // lblGastosGasolina
            // 
            this.lblGastosGasolina.AutoSize = true;
            this.lblGastosGasolina.Location = new System.Drawing.Point(17, 101);
            this.lblGastosGasolina.Name = "lblGastosGasolina";
            this.lblGastosGasolina.Size = new System.Drawing.Size(127, 13);
            this.lblGastosGasolina.TabIndex = 32;
            this.lblGastosGasolina.Text = "Gastos en gasolina:       $";
            // 
            // txtGastosInsecticidas
            // 
            this.txtGastosInsecticidas.Location = new System.Drawing.Point(148, 58);
            this.txtGastosInsecticidas.MaxLength = 8;
            this.txtGastosInsecticidas.Name = "txtGastosInsecticidas";
            this.txtGastosInsecticidas.Size = new System.Drawing.Size(100, 20);
            this.txtGastosInsecticidas.TabIndex = 31;
            this.txtGastosInsecticidas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGastosInsecticidas_KeyPress);
            // 
            // lblGastosInsecticidas
            // 
            this.lblGastosInsecticidas.AutoSize = true;
            this.lblGastosInsecticidas.Location = new System.Drawing.Point(17, 62);
            this.lblGastosInsecticidas.Name = "lblGastosInsecticidas";
            this.lblGastosInsecticidas.Size = new System.Drawing.Size(128, 13);
            this.lblGastosInsecticidas.TabIndex = 30;
            this.lblGastosInsecticidas.Text = "Gastos en insecticidas:  $";
            // 
            // txtGastosFertilizantes
            // 
            this.txtGastosFertilizantes.Location = new System.Drawing.Point(148, 19);
            this.txtGastosFertilizantes.MaxLength = 8;
            this.txtGastosFertilizantes.Name = "txtGastosFertilizantes";
            this.txtGastosFertilizantes.Size = new System.Drawing.Size(100, 20);
            this.txtGastosFertilizantes.TabIndex = 29;
            this.txtGastosFertilizantes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGastosFertilizantes_KeyPress);
            // 
            // lblGastosFertilizantes
            // 
            this.lblGastosFertilizantes.AutoSize = true;
            this.lblGastosFertilizantes.Location = new System.Drawing.Point(17, 23);
            this.lblGastosFertilizantes.Name = "lblGastosFertilizantes";
            this.lblGastosFertilizantes.Size = new System.Drawing.Size(125, 13);
            this.lblGastosFertilizantes.TabIndex = 28;
            this.lblGastosFertilizantes.Text = "Gastos en fertilizantes:  $";
            // 
            // FrmGastosEspecificos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 303);
            this.Controls.Add(this.btnCancelarGastos);
            this.Controls.Add(this.btnAceptarGastos);
            this.Controls.Add(this.txtImprevistos);
            this.Controls.Add(this.lblGastosImprevistos);
            this.Controls.Add(this.txtGastosLuz);
            this.Controls.Add(this.lblGastosLuz);
            this.Controls.Add(this.txtGastosAgua);
            this.Controls.Add(this.lblGastosAgua);
            this.Controls.Add(this.txtGastosGasolina);
            this.Controls.Add(this.lblGastosGasolina);
            this.Controls.Add(this.txtGastosInsecticidas);
            this.Controls.Add(this.lblGastosInsecticidas);
            this.Controls.Add(this.txtGastosFertilizantes);
            this.Controls.Add(this.lblGastosFertilizantes);
            this.Name = "FrmGastosEspecificos";
            this.Text = "FrmGastosEspecificos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelarGastos;
        private System.Windows.Forms.Button btnAceptarGastos;
        public System.Windows.Forms.TextBox txtImprevistos;
        private System.Windows.Forms.Label lblGastosImprevistos;
        public System.Windows.Forms.TextBox txtGastosLuz;
        private System.Windows.Forms.Label lblGastosLuz;
        public System.Windows.Forms.TextBox txtGastosAgua;
        private System.Windows.Forms.Label lblGastosAgua;
        public System.Windows.Forms.TextBox txtGastosGasolina;
        private System.Windows.Forms.Label lblGastosGasolina;
        public System.Windows.Forms.TextBox txtGastosInsecticidas;
        private System.Windows.Forms.Label lblGastosInsecticidas;
        public System.Windows.Forms.TextBox txtGastosFertilizantes;
        private System.Windows.Forms.Label lblGastosFertilizantes;
    }
}
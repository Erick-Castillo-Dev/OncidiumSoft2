namespace OncidiumSoft.Formularios
{
    partial class FrmAjusteInventario
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cboAjuste = new System.Windows.Forms.ComboBox();
            this.lblTipoAjuste = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblPrecioCliente = new System.Windows.Forms.Label();
            this.txtPrecioCliente = new System.Windows.Forms.TextBox();
            this.lblPrecioCosto = new System.Windows.Forms.Label();
            this.txtPrecioCosto = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Rockwell", 12F);
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.Location = new System.Drawing.Point(224, 340);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(97, 33);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptar.Font = new System.Drawing.Font("Rockwell", 12F);
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAceptar.Location = new System.Drawing.Point(127, 340);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(91, 33);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // cboAjuste
            // 
            this.cboAjuste.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAjuste.FormattingEnabled = true;
            this.cboAjuste.Items.AddRange(new object[] {
            "Alta",
            "Baja"});
            this.cboAjuste.Location = new System.Drawing.Point(155, 295);
            this.cboAjuste.Name = "cboAjuste";
            this.cboAjuste.Size = new System.Drawing.Size(167, 21);
            this.cboAjuste.TabIndex = 6;
            // 
            // lblTipoAjuste
            // 
            this.lblTipoAjuste.AutoSize = true;
            this.lblTipoAjuste.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoAjuste.Font = new System.Drawing.Font("Rockwell", 12F);
            this.lblTipoAjuste.Location = new System.Drawing.Point(38, 295);
            this.lblTipoAjuste.Name = "lblTipoAjuste";
            this.lblTipoAjuste.Size = new System.Drawing.Size(113, 19);
            this.lblTipoAjuste.TabIndex = 41;
            this.lblTipoAjuste.Text = "Tipo de Ajuste";
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "Disponible",
            "No disponible"});
            this.cboEstado.Location = new System.Drawing.Point(155, 250);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(167, 21);
            this.cboEstado.TabIndex = 5;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Font = new System.Drawing.Font("Rockwell", 12F);
            this.lblEstado.Location = new System.Drawing.Point(39, 252);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(59, 19);
            this.lblEstado.TabIndex = 39;
            this.lblEstado.Text = "Estado";
            // 
            // lblPrecioCliente
            // 
            this.lblPrecioCliente.AutoSize = true;
            this.lblPrecioCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecioCliente.Font = new System.Drawing.Font("Rockwell", 12F);
            this.lblPrecioCliente.Location = new System.Drawing.Point(39, 210);
            this.lblPrecioCliente.Name = "lblPrecioCliente";
            this.lblPrecioCliente.Size = new System.Drawing.Size(111, 19);
            this.lblPrecioCliente.TabIndex = 38;
            this.lblPrecioCliente.Text = "Precio Cliente";
            // 
            // txtPrecioCliente
            // 
            this.txtPrecioCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecioCliente.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.txtPrecioCliente.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPrecioCliente.Location = new System.Drawing.Point(155, 209);
            this.txtPrecioCliente.Name = "txtPrecioCliente";
            this.txtPrecioCliente.Size = new System.Drawing.Size(167, 23);
            this.txtPrecioCliente.TabIndex = 4;
            this.txtPrecioCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioCliente_KeyPress);
            // 
            // lblPrecioCosto
            // 
            this.lblPrecioCosto.AutoSize = true;
            this.lblPrecioCosto.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecioCosto.Font = new System.Drawing.Font("Rockwell", 12F);
            this.lblPrecioCosto.Location = new System.Drawing.Point(39, 167);
            this.lblPrecioCosto.Name = "lblPrecioCosto";
            this.lblPrecioCosto.Size = new System.Drawing.Size(101, 19);
            this.lblPrecioCosto.TabIndex = 36;
            this.lblPrecioCosto.Text = "Precio Costo";
            // 
            // txtPrecioCosto
            // 
            this.txtPrecioCosto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecioCosto.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.txtPrecioCosto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPrecioCosto.Location = new System.Drawing.Point(154, 166);
            this.txtPrecioCosto.Name = "txtPrecioCosto";
            this.txtPrecioCosto.Size = new System.Drawing.Size(167, 23);
            this.txtPrecioCosto.TabIndex = 3;
            this.txtPrecioCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioCosto_KeyPress);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.Color.Transparent;
            this.lblCantidad.Font = new System.Drawing.Font("Rockwell", 12F);
            this.lblCantidad.Location = new System.Drawing.Point(38, 125);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(77, 19);
            this.lblCantidad.TabIndex = 34;
            this.lblCantidad.Text = "Cantidad";
            // 
            // cboProducto
            // 
            this.cboProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Location = new System.Drawing.Point(155, 82);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(167, 21);
            this.cboProducto.TabIndex = 1;
            this.cboProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboProducto_KeyPress);
            // 
            // txtCantidad
            // 
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidad.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCantidad.Location = new System.Drawing.Point(155, 124);
            this.txtCantidad.MaxLength = 3;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(167, 23);
            this.txtCantidad.TabIndex = 2;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.BackColor = System.Drawing.Color.Transparent;
            this.lblProducto.Font = new System.Drawing.Font("Rockwell", 12F);
            this.lblProducto.Location = new System.Drawing.Point(38, 84);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(75, 19);
            this.lblProducto.TabIndex = 31;
            this.lblProducto.Text = "Producto";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.ForestGreen;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(343, 53);
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.ForestGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 29);
            this.label1.TabIndex = 55;
            this.label1.Text = "Ajuste de inventario";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.ForestGreen;
            this.pictureBox3.BackgroundImage = global::OncidiumSoft.Properties.Resources._12283043_773212156137905_384527972_n;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(276, 26);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(49, 47);
            this.pictureBox3.TabIndex = 56;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.ForestGreen;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 386);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(343, 27);
            this.pictureBox2.TabIndex = 57;
            this.pictureBox2.TabStop = false;
            // 
            // FrmAjusteInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 413);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cboAjuste);
            this.Controls.Add(this.lblTipoAjuste);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblPrecioCliente);
            this.Controls.Add(this.txtPrecioCliente);
            this.Controls.Add(this.lblPrecioCosto);
            this.Controls.Add(this.txtPrecioCosto);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.cboProducto);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblProducto);
            this.Name = "FrmAjusteInventario";
            this.Text = "Ajuste de inventario";
            this.Load += new System.EventHandler(this.FrmAjusteInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblTipoAjuste;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblPrecioCliente;
        private System.Windows.Forms.TextBox txtPrecioCliente;
        private System.Windows.Forms.Label lblPrecioCosto;
        private System.Windows.Forms.TextBox txtPrecioCosto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblProducto;
        public System.Windows.Forms.ComboBox cboProducto;
        public System.Windows.Forms.ComboBox cboAjuste;
        public System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
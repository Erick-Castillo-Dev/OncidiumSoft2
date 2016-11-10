namespace OncidiumSoft.Formularios
{
    partial class frmCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompras));
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtCan = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblIdProducto = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.dgvCompra = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblNueva_Venta = new System.Windows.Forms.Label();
            this.ptProducto = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRealizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 13);
            this.label2.TabIndex = 89;
            this.label2.Text = "Venta de plantas de ornato, pasto y artesanias";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(319, 224);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(81, 20);
            this.txtTotal.TabIndex = 88;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 87;
            this.label4.Text = "Total: $";
            // 
            // txtProveedor
            // 
            this.txtProveedor.Enabled = false;
            this.txtProveedor.Location = new System.Drawing.Point(511, 220);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(116, 20);
            this.txtProveedor.TabIndex = 82;
            // 
            // txtTipo
            // 
            this.txtTipo.Enabled = false;
            this.txtTipo.Location = new System.Drawing.Point(106, 216);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(99, 20);
            this.txtTipo.TabIndex = 81;
            // 
            // txtCan
            // 
            this.txtCan.Location = new System.Drawing.Point(319, 173);
            this.txtCan.MaxLength = 4;
            this.txtCan.Name = "txtCan";
            this.txtCan.Size = new System.Drawing.Size(81, 20);
            this.txtCan.TabIndex = 80;
            this.txtCan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // txtProducto
            // 
            this.txtProducto.Enabled = false;
            this.txtProducto.Location = new System.Drawing.Point(105, 173);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(106, 20);
            this.txtProducto.TabIndex = 79;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(562, 169);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(64, 20);
            this.txtPrecio.TabIndex = 78;
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Location = new System.Drawing.Point(106, 132);
            this.txtIdProducto.MaxLength = 4;
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(44, 20);
            this.txtIdProducto.TabIndex = 77;
            this.txtIdProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdProducto_KeyPress);
            this.txtIdProducto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtIdProducto_KeyUp);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(12, 216);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 76;
            this.lblTipo.Text = "Tipo";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(234, 176);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 75;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(451, 223);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(50, 13);
            this.lblProveedor.TabIndex = 74;
            this.lblProveedor.Text = "Provedor";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(9, 176);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(90, 13);
            this.lblProducto.TabIndex = 73;
            this.lblProducto.Text = "Nombre Producto";
            // 
            // lblIdProducto
            // 
            this.lblIdProducto.AutoSize = true;
            this.lblIdProducto.Location = new System.Drawing.Point(12, 135);
            this.lblIdProducto.Name = "lblIdProducto";
            this.lblIdProducto.Size = new System.Drawing.Size(64, 13);
            this.lblIdProducto.TabIndex = 72;
            this.lblIdProducto.Text = "ID Producto";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(469, 176);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(46, 13);
            this.lblPrecio.TabIndex = 71;
            this.lblPrecio.Text = "Precio $";
            // 
            // dgvCompra
            // 
            this.dgvCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompra.Location = new System.Drawing.Point(12, 262);
            this.dgvCompra.Name = "dgvCompra";
            this.dgvCompra.Size = new System.Drawing.Size(733, 216);
            this.dgvCompra.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 13);
            this.label1.TabIndex = 67;
            this.label1.Text = "Calle Abasolo #234 Pruandiro, Michoacán";
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Location = new System.Drawing.Point(284, 26);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(108, 13);
            this.lblEmpresa.TabIndex = 66;
            this.lblEmpresa.Text = "RUSTICO´S VIVERO";
            // 
            // lblNueva_Venta
            // 
            this.lblNueva_Venta.AutoSize = true;
            this.lblNueva_Venta.Location = new System.Drawing.Point(512, 55);
            this.lblNueva_Venta.Name = "lblNueva_Venta";
            this.lblNueva_Venta.Size = new System.Drawing.Size(0, 13);
            this.lblNueva_Venta.TabIndex = 65;
            // 
            // ptProducto
            // 
            this.ptProducto.Location = new System.Drawing.Point(709, 55);
            this.ptProducto.Name = "ptProducto";
            this.ptProducto.Size = new System.Drawing.Size(199, 174);
            this.ptProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptProducto.TabIndex = 64;
            this.ptProducto.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // btnRealizar
            // 
            this.btnRealizar.Image = global::OncidiumSoft.Properties.Resources.apply;
            this.btnRealizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRealizar.Location = new System.Drawing.Point(751, 410);
            this.btnRealizar.Name = "btnRealizar";
            this.btnRealizar.Size = new System.Drawing.Size(157, 37);
            this.btnRealizar.TabIndex = 92;
            this.btnRealizar.Text = "Realizar Venta";
            this.btnRealizar.UseVisualStyleBackColor = true;
            this.btnRealizar.Click += new System.EventHandler(this.btnRealizar_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::OncidiumSoft.Properties.Resources.delete;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(751, 348);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(157, 41);
            this.btnEliminar.TabIndex = 91;
            this.btnEliminar.Text = "Eliminar producto";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.CausesValidation = false;
            this.btnCancelar.Image = global::OncidiumSoft.Properties.Resources.cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(751, 285);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(157, 37);
            this.btnCancelar.TabIndex = 90;
            this.btnCancelar.Text = "Cancelar Compra";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 518);
            this.Controls.Add(this.btnRealizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtProveedor);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtCan);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtIdProducto);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.lblIdProducto);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.dgvCompra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEmpresa);
            this.Controls.Add(this.lblNueva_Venta);
            this.Controls.Add(this.ptProducto);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmCompras";
            this.Text = "frmCompras";
            this.Load += new System.EventHandler(this.frmCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtCan;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblIdProducto;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.DataGridView dgvCompra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblNueva_Venta;
        private System.Windows.Forms.PictureBox ptProducto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRealizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
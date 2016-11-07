namespace OncidiumSoft.Formularios
{
    partial class FrmAgregarProductos
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
            this.lblAgregarProductos = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblPreciocliente = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblImagen = new System.Windows.Forms.Label();
            this.lblProvedor = new System.Windows.Forms.Label();
            this.lblPreciocosto = new System.Windows.Forms.Label();
            this.lblDiponible = new System.Windows.Forms.Label();
            this.lblAjuste = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtpreciocliente = new System.Windows.Forms.TextBox();
            this.txtidProvedor = new System.Windows.Forms.TextBox();
            this.txtPrecioCosto = new System.Windows.Forms.TextBox();
            this.txtImagen = new System.Windows.Forms.TextBox();
            this.cboxTipo = new System.Windows.Forms.ComboBox();
            this.cBoxDiponible = new System.Windows.Forms.ComboBox();
            this.cBoxAjuste = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblAgregarProductos
            // 
            this.lblAgregarProductos.AutoSize = true;
            this.lblAgregarProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarProductos.Location = new System.Drawing.Point(158, 19);
            this.lblAgregarProductos.Name = "lblAgregarProductos";
            this.lblAgregarProductos.Size = new System.Drawing.Size(266, 31);
            this.lblAgregarProductos.TabIndex = 2;
            this.lblAgregarProductos.Text = "Agregar Productos.";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(43, 72);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(64, 13);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "id Producto:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(43, 116);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(93, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre Producto:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(43, 245);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(98, 13);
            this.lblCantidad.TabIndex = 5;
            this.lblCantidad.Text = "Cantidad Producto:";
            // 
            // lblPreciocliente
            // 
            this.lblPreciocliente.AutoSize = true;
            this.lblPreciocliente.Location = new System.Drawing.Point(43, 160);
            this.lblPreciocliente.Name = "lblPreciocliente";
            this.lblPreciocliente.Size = new System.Drawing.Size(72, 13);
            this.lblPreciocliente.TabIndex = 6;
            this.lblPreciocliente.Text = "Precio Cliente";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(43, 209);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 13);
            this.lblTipo.TabIndex = 7;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Location = new System.Drawing.Point(43, 292);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(45, 13);
            this.lblImagen.TabIndex = 8;
            this.lblImagen.Text = "Imagen:";
            // 
            // lblProvedor
            // 
            this.lblProvedor.AutoSize = true;
            this.lblProvedor.Location = new System.Drawing.Point(43, 336);
            this.lblProvedor.Name = "lblProvedor";
            this.lblProvedor.Size = new System.Drawing.Size(64, 13);
            this.lblProvedor.TabIndex = 9;
            this.lblProvedor.Text = "id Provedor:";
            // 
            // lblPreciocosto
            // 
            this.lblPreciocosto.AutoSize = true;
            this.lblPreciocosto.Location = new System.Drawing.Point(43, 380);
            this.lblPreciocosto.Name = "lblPreciocosto";
            this.lblPreciocosto.Size = new System.Drawing.Size(67, 13);
            this.lblPreciocosto.TabIndex = 10;
            this.lblPreciocosto.Text = "Precio Costo";
            // 
            // lblDiponible
            // 
            this.lblDiponible.AutoSize = true;
            this.lblDiponible.Location = new System.Drawing.Point(43, 424);
            this.lblDiponible.Name = "lblDiponible";
            this.lblDiponible.Size = new System.Drawing.Size(59, 13);
            this.lblDiponible.TabIndex = 11;
            this.lblDiponible.Text = "Disponible:";
            // 
            // lblAjuste
            // 
            this.lblAjuste.AutoSize = true;
            this.lblAjuste.Location = new System.Drawing.Point(43, 468);
            this.lblAjuste.Name = "lblAjuste";
            this.lblAjuste.Size = new System.Drawing.Size(39, 13);
            this.lblAjuste.TabIndex = 12;
            this.lblAjuste.Text = "Ajuste:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(127, 508);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(226, 508);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(152, 69);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 15;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(152, 116);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 16;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(152, 245);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 17;
            // 
            // txtpreciocliente
            // 
            this.txtpreciocliente.Location = new System.Drawing.Point(152, 157);
            this.txtpreciocliente.Name = "txtpreciocliente";
            this.txtpreciocliente.Size = new System.Drawing.Size(100, 20);
            this.txtpreciocliente.TabIndex = 18;
            // 
            // txtidProvedor
            // 
            this.txtidProvedor.Location = new System.Drawing.Point(152, 336);
            this.txtidProvedor.Name = "txtidProvedor";
            this.txtidProvedor.Size = new System.Drawing.Size(100, 20);
            this.txtidProvedor.TabIndex = 19;
            // 
            // txtPrecioCosto
            // 
            this.txtPrecioCosto.Location = new System.Drawing.Point(152, 380);
            this.txtPrecioCosto.Name = "txtPrecioCosto";
            this.txtPrecioCosto.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioCosto.TabIndex = 20;
            // 
            // txtImagen
            // 
            this.txtImagen.Location = new System.Drawing.Point(152, 292);
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.Size = new System.Drawing.Size(100, 20);
            this.txtImagen.TabIndex = 21;
            // 
            // cboxTipo
            // 
            this.cboxTipo.FormattingEnabled = true;
            this.cboxTipo.Items.AddRange(new object[] {
            "plantas",
            "arbol",
            "insumo",
            "macetas",
            "artesanias",
            "decoracion"});
            this.cboxTipo.Location = new System.Drawing.Point(152, 201);
            this.cboxTipo.Name = "cboxTipo";
            this.cboxTipo.Size = new System.Drawing.Size(121, 21);
            this.cboxTipo.TabIndex = 22;
            this.cboxTipo.Text = "Plantas";
            // 
            // cBoxDiponible
            // 
            this.cBoxDiponible.FormattingEnabled = true;
            this.cBoxDiponible.Items.AddRange(new object[] {
            "true",
            "false"});
            this.cBoxDiponible.Location = new System.Drawing.Point(152, 416);
            this.cBoxDiponible.Name = "cBoxDiponible";
            this.cBoxDiponible.Size = new System.Drawing.Size(121, 21);
            this.cBoxDiponible.TabIndex = 23;
            this.cBoxDiponible.Text = "true";
            // 
            // cBoxAjuste
            // 
            this.cBoxAjuste.FormattingEnabled = true;
            this.cBoxAjuste.Items.AddRange(new object[] {
            "true",
            "false"});
            this.cBoxAjuste.Location = new System.Drawing.Point(152, 460);
            this.cBoxAjuste.Name = "cBoxAjuste";
            this.cBoxAjuste.Size = new System.Drawing.Size(121, 21);
            this.cBoxAjuste.TabIndex = 24;
            this.cBoxAjuste.Text = "true";
            // 
            // FrmAgregarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 543);
            this.Controls.Add(this.cBoxAjuste);
            this.Controls.Add(this.cBoxDiponible);
            this.Controls.Add(this.cboxTipo);
            this.Controls.Add(this.txtImagen);
            this.Controls.Add(this.txtPrecioCosto);
            this.Controls.Add(this.txtidProvedor);
            this.Controls.Add(this.txtpreciocliente);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblAjuste);
            this.Controls.Add(this.lblDiponible);
            this.Controls.Add(this.lblPreciocosto);
            this.Controls.Add(this.lblProvedor);
            this.Controls.Add(this.lblImagen);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblPreciocliente);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblAgregarProductos);
            this.Name = "FrmAgregarProductos";
            this.Text = "Agregar Productos.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAgregarProductos;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblPreciocliente;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.Label lblProvedor;
        private System.Windows.Forms.Label lblPreciocosto;
        private System.Windows.Forms.Label lblDiponible;
        private System.Windows.Forms.Label lblAjuste;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtpreciocliente;
        private System.Windows.Forms.TextBox txtidProvedor;
        private System.Windows.Forms.TextBox txtPrecioCosto;
        private System.Windows.Forms.TextBox txtImagen;
        private System.Windows.Forms.ComboBox cboxTipo;
        private System.Windows.Forms.ComboBox cBoxDiponible;
        private System.Windows.Forms.ComboBox cBoxAjuste;
    }
}
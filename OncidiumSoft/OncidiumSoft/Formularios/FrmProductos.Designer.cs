namespace OncidiumSoft.Formularios
{
    partial class FrmProductos
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
            this.dgVProductos = new System.Windows.Forms.DataGridView();
            this.lblProductos = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnPrincipal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgVProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgVProductos
            // 
            this.dgVProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVProductos.Location = new System.Drawing.Point(38, 127);
            this.dgVProductos.Name = "dgVProductos";
            this.dgVProductos.Size = new System.Drawing.Size(499, 265);
            this.dgVProductos.TabIndex = 0;
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductos.Location = new System.Drawing.Point(286, 50);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(395, 31);
            this.lblProductos.TabIndex = 1;
            this.lblProductos.Text = "Administración de Productos.";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(571, 142);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(123, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar Producto";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(571, 184);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(123, 23);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar  Producto";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(571, 232);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(123, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar Producto";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnPrincipal
            // 
            this.btnPrincipal.Location = new System.Drawing.Point(571, 351);
            this.btnPrincipal.Name = "btnPrincipal";
            this.btnPrincipal.Size = new System.Drawing.Size(123, 23);
            this.btnPrincipal.TabIndex = 5;
            this.btnPrincipal.Text = "Menú Principal";
            this.btnPrincipal.UseVisualStyleBackColor = true;
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 454);
            this.Controls.Add(this.btnPrincipal);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblProductos);
            this.Controls.Add(this.dgVProductos);
            this.Name = "FrmProductos";
            this.Text = "FrmProductos";
            ((System.ComponentModel.ISupportInitialize)(this.dgVProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgVProductos;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnPrincipal;
    }
}
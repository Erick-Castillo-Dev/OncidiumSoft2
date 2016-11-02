namespace OncidiumSoft.Formularios
{
    partial class FrmHistorialContabilidades
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
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dgvContabilidad = new System.Windows.Forms.DataGridView();
            this.NoContabilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ganancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContabilidad)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(284, 278);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(88, 23);
            this.btnRegresar.TabIndex = 10;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(383, 278);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(88, 23);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // dgvContabilidad
            // 
            this.dgvContabilidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContabilidad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NoContabilidad,
            this.Fecha,
            this.Ganancia});
            this.dgvContabilidad.Location = new System.Drawing.Point(15, 11);
            this.dgvContabilidad.Name = "dgvContabilidad";
            this.dgvContabilidad.Size = new System.Drawing.Size(456, 254);
            this.dgvContabilidad.TabIndex = 8;
            // 
            // NoContabilidad
            // 
            this.NoContabilidad.HeaderText = "No. contabilidad";
            this.NoContabilidad.Name = "NoContabilidad";
            this.NoContabilidad.Width = 137;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 138;
            // 
            // Ganancia
            // 
            this.Ganancia.HeaderText = "Ganancia o pérdida";
            this.Ganancia.Name = "Ganancia";
            this.Ganancia.Width = 138;
            // 
            // FrmHistorialContabilidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 312);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dgvContabilidad);
            this.Name = "FrmHistorialContabilidades";
            this.Text = "FrmHistorialContabilidades";
            ((System.ComponentModel.ISupportInitialize)(this.dgvContabilidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridView dgvContabilidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoContabilidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ganancia;
    }
}
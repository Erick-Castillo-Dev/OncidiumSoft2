namespace OncidiumSoft.Formularios
{
    partial class frmPorSemana
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
            this.label1 = new System.Windows.Forms.Label();
            this.Semana = new System.Windows.Forms.Label();
            this.De = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Día seleccionado";
            // 
            // Semana
            // 
            this.Semana.AutoSize = true;
            this.Semana.Location = new System.Drawing.Point(206, 50);
            this.Semana.Name = "Semana";
            this.Semana.Size = new System.Drawing.Size(0, 13);
            this.Semana.TabIndex = 7;
            // 
            // De
            // 
            this.De.AutoSize = true;
            this.De.Location = new System.Drawing.Point(32, 50);
            this.De.Name = "De";
            this.De.Size = new System.Drawing.Size(0, 13);
            this.De.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Hasta";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(78, 163);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(128, 57);
            this.btnGenerar.TabIndex = 12;
            this.btnGenerar.Text = "Generar Reporte";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click_1);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(26, 84);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(240, 20);
            this.dtpFecha.TabIndex = 11;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // frmPorSemana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 242);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.De);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Semana);
            this.Controls.Add(this.label1);
            this.Name = "frmPorSemana";
            this.Text = "frmPorSemana";
            this.Load += new System.EventHandler(this.frmPorSemana_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Semana;
        private System.Windows.Forms.Label De;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DateTimePicker dtpFecha;
    }
}
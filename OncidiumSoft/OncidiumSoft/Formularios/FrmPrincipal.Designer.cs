namespace OncidiumSoft
{
    partial class FrmPrincipal
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
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.Archivo = new System.Windows.Forms.ToolStripMenuItem();
            this.Salir = new System.Windows.Forms.ToolStripMenuItem();
            this.Ventas = new System.Windows.Forms.ToolStripMenuItem();
            this.Ventas1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Administrar = new System.Windows.Forms.ToolStripMenuItem();
            this.Usuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.Productos = new System.Windows.Forms.ToolStripMenuItem();
            this.Provedores = new System.Windows.Forms.ToolStripMenuItem();
            this.Reportes = new System.Windows.Forms.ToolStripMenuItem();
            this.VentasDia = new System.Windows.Forms.ToolStripMenuItem();
            this.VentasFecha = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasPorMesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idUsuario = new System.Windows.Forms.Label();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Archivo,
            this.Ventas,
            this.Administrar,
            this.Reportes});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(995, 24);
            this.menuPrincipal.TabIndex = 4;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // Archivo
            // 
            this.Archivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Salir});
            this.Archivo.Name = "Archivo";
            this.Archivo.Size = new System.Drawing.Size(60, 20);
            this.Archivo.Text = "Archivo";
            // 
            // Salir
            // 
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(96, 22);
            this.Salir.Text = "Salir";
            // 
            // Ventas
            // 
            this.Ventas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Ventas1});
            this.Ventas.Name = "Ventas";
            this.Ventas.Size = new System.Drawing.Size(54, 20);
            this.Ventas.Text = "Ventas";
            // 
            // Ventas1
            // 
            this.Ventas1.Name = "Ventas1";
            this.Ventas1.Size = new System.Drawing.Size(152, 22);
            this.Ventas1.Text = "Ventas";
            this.Ventas1.Click += new System.EventHandler(this.Ventas1_Click_1);
            // 
            // Administrar
            // 
            this.Administrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Usuarios,
            this.Productos,
            this.Provedores});
            this.Administrar.Name = "Administrar";
            this.Administrar.Size = new System.Drawing.Size(81, 20);
            this.Administrar.Text = "Administrar";
            // 
            // Usuarios
            // 
            this.Usuarios.Name = "Usuarios";
            this.Usuarios.Size = new System.Drawing.Size(133, 22);
            this.Usuarios.Text = "Usuarios";
            // 
            // Productos
            // 
            this.Productos.Name = "Productos";
            this.Productos.Size = new System.Drawing.Size(133, 22);
            this.Productos.Text = "Productos";
            this.Productos.Click += new System.EventHandler(this.Productos_Click);
            // 
            // Provedores
            // 
            this.Provedores.Name = "Provedores";
            this.Provedores.Size = new System.Drawing.Size(133, 22);
            this.Provedores.Text = "Provedores";
            // 
            // Reportes
            // 
            this.Reportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VentasDia,
            this.VentasFecha,
            this.ventasPorMesToolStripMenuItem});
            this.Reportes.Name = "Reportes";
            this.Reportes.Size = new System.Drawing.Size(65, 20);
            this.Reportes.Text = "Reportes";
            // 
            // VentasDia
            // 
            this.VentasDia.Name = "VentasDia";
            this.VentasDia.Size = new System.Drawing.Size(174, 22);
            this.VentasDia.Text = "Ventas del dia";
            this.VentasDia.Click += new System.EventHandler(this.VentasDia_Click);
            // 
            // VentasFecha
            // 
            this.VentasFecha.Name = "VentasFecha";
            this.VentasFecha.Size = new System.Drawing.Size(174, 22);
            this.VentasFecha.Text = "Ventas por semana";
            // 
            // ventasPorMesToolStripMenuItem
            // 
            this.ventasPorMesToolStripMenuItem.Name = "ventasPorMesToolStripMenuItem";
            this.ventasPorMesToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.ventasPorMesToolStripMenuItem.Text = "Ventas por mes";
            // 
            // idUsuario
            // 
            this.idUsuario.AutoSize = true;
            this.idUsuario.Location = new System.Drawing.Point(402, 214);
            this.idUsuario.Name = "idUsuario";
            this.idUsuario.Size = new System.Drawing.Size(0, 13);
            this.idUsuario.TabIndex = 5;
            this.idUsuario.Visible = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OncidiumSoft.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(995, 347);
            this.Controls.Add(this.idUsuario);
            this.Controls.Add(this.menuPrincipal);
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem Archivo;
        private System.Windows.Forms.ToolStripMenuItem Salir;
        private System.Windows.Forms.ToolStripMenuItem Ventas;
        private System.Windows.Forms.ToolStripMenuItem Ventas1;
        private System.Windows.Forms.ToolStripMenuItem Administrar;
        private System.Windows.Forms.ToolStripMenuItem Usuarios;
        private System.Windows.Forms.ToolStripMenuItem Productos;
        private System.Windows.Forms.ToolStripMenuItem Provedores;
        private System.Windows.Forms.ToolStripMenuItem Reportes;
        private System.Windows.Forms.ToolStripMenuItem VentasDia;
        private System.Windows.Forms.ToolStripMenuItem VentasFecha;
        private System.Windows.Forms.ToolStripMenuItem ventasPorMesToolStripMenuItem;
        public System.Windows.Forms.Label idUsuario;
    }
}


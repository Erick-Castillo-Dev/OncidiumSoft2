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
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compraDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Administrar = new System.Windows.Forms.ToolStripMenuItem();
            this.Usuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.Productos = new System.Windows.Forms.ToolStripMenuItem();
            this.Provedores = new System.Windows.Forms.ToolStripMenuItem();
            this.Reportes = new System.Windows.Forms.ToolStripMenuItem();
            this.VentasDia = new System.Windows.Forms.ToolStripMenuItem();
            this.VentasFecha = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasPorMesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contabilidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarContabilidad = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarAjuste = new System.Windows.Forms.ToolStripMenuItem();
            this.idUsuario2 = new System.Windows.Forms.Label();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Archivo,
            this.Ventas,
            this.Administrar,
            this.Reportes,
            this.contabilidadToolStripMenuItem,
            this.inventarioToolStripMenuItem});
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
            this.Salir.Size = new System.Drawing.Size(152, 22);
            this.Salir.Text = "Salir";
            // 
            // Ventas
            // 
            this.Ventas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Ventas1,
            this.pedidosToolStripMenuItem,
            this.compraDeProductosToolStripMenuItem});
            this.Ventas.Name = "Ventas";
            this.Ventas.Size = new System.Drawing.Size(54, 20);
            this.Ventas.Text = "Ventas";
            // 
            // Ventas1
            // 
            this.Ventas1.Name = "Ventas1";
            this.Ventas1.Size = new System.Drawing.Size(190, 22);
            this.Ventas1.Text = "Ventas";
            this.Ventas1.Click += new System.EventHandler(this.Ventas1_Click_1);
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            this.pedidosToolStripMenuItem.Click += new System.EventHandler(this.pedidosToolStripMenuItem_Click);
            // 
            // compraDeProductosToolStripMenuItem
            // 
            this.compraDeProductosToolStripMenuItem.Name = "compraDeProductosToolStripMenuItem";
            this.compraDeProductosToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.compraDeProductosToolStripMenuItem.Text = "Compra de productos";
            this.compraDeProductosToolStripMenuItem.Click += new System.EventHandler(this.compraDeProductosToolStripMenuItem_Click);
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
            this.Usuarios.Click += new System.EventHandler(this.Usuarios_Click);
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
            this.Provedores.Size = new System.Drawing.Size(152, 22);
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
            this.VentasFecha.Click += new System.EventHandler(this.VentasFecha_Click);
            // 
            // ventasPorMesToolStripMenuItem
            // 
            this.ventasPorMesToolStripMenuItem.Name = "ventasPorMesToolStripMenuItem";
            this.ventasPorMesToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.ventasPorMesToolStripMenuItem.Text = "Ventas por mes";
            this.ventasPorMesToolStripMenuItem.Click += new System.EventHandler(this.ventasPorMesToolStripMenuItem_Click);
            // 
            // contabilidadToolStripMenuItem
            // 
            this.contabilidadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realizarContabilidad});
            this.contabilidadToolStripMenuItem.Name = "contabilidadToolStripMenuItem";
            this.contabilidadToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.contabilidadToolStripMenuItem.Text = "Contabilidad";
            // 
            // realizarContabilidad
            // 
            this.realizarContabilidad.Name = "realizarContabilidad";
            this.realizarContabilidad.Size = new System.Drawing.Size(183, 22);
            this.realizarContabilidad.Text = "Realizar contabilidad";
            this.realizarContabilidad.Click += new System.EventHandler(this.realizarContabilidad_Click);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realizarAjuste});
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // realizarAjuste
            // 
            this.realizarAjuste.Name = "realizarAjuste";
            this.realizarAjuste.Size = new System.Drawing.Size(148, 22);
            this.realizarAjuste.Text = "Realizar ajuste";
            this.realizarAjuste.Click += new System.EventHandler(this.realizarAjuste_Click);
            // 
            // idUsuario2
            // 
            this.idUsuario2.AutoSize = true;
            this.idUsuario2.Location = new System.Drawing.Point(402, 214);
            this.idUsuario2.Name = "idUsuario2";
            this.idUsuario2.Size = new System.Drawing.Size(0, 13);
            this.idUsuario2.TabIndex = 5;
            this.idUsuario2.Visible = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OncidiumSoft.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(995, 347);
            this.Controls.Add(this.idUsuario2);
            this.Controls.Add(this.menuPrincipal);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        public System.Windows.Forms.Label idUsuario2;
        private System.Windows.Forms.ToolStripMenuItem contabilidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realizarContabilidad;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realizarAjuste;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compraDeProductosToolStripMenuItem;
    }
}


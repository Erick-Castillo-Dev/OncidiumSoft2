namespace OncidiumSoft.Formularios
{
    partial class frmMostrarReporte
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
            this.SuspendLayout();
            // 
            // frmMostrarReporte
            // 
            this.ClientSize = new System.Drawing.Size(363, 302);
            this.Name = "frmMostrarReporte";
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Objetos.DataSetPrincipal dataSetPrincipal;
        private Objetos.DataSetPrincipalTableAdapters.DataTableTableAdapter dataTableTableAdapter;
        private System.Windows.Forms.BindingSource dataTableBindingSource1;

    }
}
namespace SistemasGonzalez.UI.Reportes
{
    partial class ReportesProductos
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
            this.ReporteProductosreportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // ReporteProductosreportViewer
            // 
            this.ReporteProductosreportViewer.Location = new System.Drawing.Point(0, 2);
            this.ReporteProductosreportViewer.Name = "ReporteProductosreportViewer";
            this.ReporteProductosreportViewer.Size = new System.Drawing.Size(1122, 649);
            this.ReporteProductosreportViewer.TabIndex = 0;
            // 
            // ReportesProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 648);
            this.Controls.Add(this.ReporteProductosreportViewer);
            this.Name = "ReportesProductos";
            this.Text = "ReportesProductos";
            this.Load += new System.EventHandler(this.ReportesProductos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ReporteProductosreportViewer;
    }
}
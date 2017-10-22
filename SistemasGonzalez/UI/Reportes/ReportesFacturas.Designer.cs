namespace SistemasGonzalez.UI.Reportes
{
    partial class ReportesFacturas
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
            this.FacturareportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // FacturareportViewer
            // 
            this.FacturareportViewer.Location = new System.Drawing.Point(4, 2);
            this.FacturareportViewer.Name = "FacturareportViewer";
            this.FacturareportViewer.Size = new System.Drawing.Size(705, 527);
            this.FacturareportViewer.TabIndex = 0;
            // 
            // ReportesFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 532);
            this.Controls.Add(this.FacturareportViewer);
            this.Name = "ReportesFacturas";
            this.Text = "ReportesFacturas";
            this.Load += new System.EventHandler(this.ReportesFacturas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer FacturareportViewer;
    }
}
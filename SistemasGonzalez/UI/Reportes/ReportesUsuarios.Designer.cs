namespace SistemasGonzalez.UI.Reportes
{
    partial class ReportesUsuarios
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
            this.UsuariosreportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // UsuariosreportViewer
            // 
            this.UsuariosreportViewer.Location = new System.Drawing.Point(3, 1);
            this.UsuariosreportViewer.Name = "UsuariosreportViewer";
            this.UsuariosreportViewer.Size = new System.Drawing.Size(752, 458);
            this.UsuariosreportViewer.TabIndex = 0;
            // 
            // ReportesUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 489);
            this.Controls.Add(this.UsuariosreportViewer);
            this.Name = "ReportesUsuarios";
            this.Text = "ReportesUsuarios";
            this.Load += new System.EventHandler(this.ReportesUsuarios_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer UsuariosreportViewer;
    }
}
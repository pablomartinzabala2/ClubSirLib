namespace SistemaBase
{
    partial class FrmReporteSociocs
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.SocioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new SistemaBase.DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SocioTableAdapter = new SistemaBase.DataSet1TableAdapters.SocioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SocioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // SocioBindingSource
            // 
            this.SocioBindingSource.DataMember = "Socio";
            this.SocioBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SocioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaBase.Reporte.ReporteSocio2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(634, 527);
            this.reportViewer1.TabIndex = 0;
            // 
            // SocioTableAdapter
            // 
            this.SocioTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteSociocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 531);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporteSociocs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReporteSociocs";
            this.Load += new System.EventHandler(this.FrmReporteSociocs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SocioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SocioBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.SocioTableAdapter SocioTableAdapter;
    }
}
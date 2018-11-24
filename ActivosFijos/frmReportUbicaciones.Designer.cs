namespace ActivosFijos
{
    partial class frmReportUbicaciones
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ActivosFijosDataSet = new ActivosFijos.ActivosFijosDataSet();
            this.UbicacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UbicacionTableAdapter = new ActivosFijos.ActivosFijosDataSetTableAdapters.UbicacionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ActivosFijosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UbicacionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSUbicaciones";
            reportDataSource1.Value = this.UbicacionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ActivosFijos.ReportUbicaciones.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // ActivosFijosDataSet
            // 
            this.ActivosFijosDataSet.DataSetName = "ActivosFijosDataSet";
            this.ActivosFijosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // UbicacionBindingSource
            // 
            this.UbicacionBindingSource.DataMember = "Ubicacion";
            this.UbicacionBindingSource.DataSource = this.ActivosFijosDataSet;
            // 
            // UbicacionTableAdapter
            // 
            this.UbicacionTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportUbicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReportUbicaciones";
            this.Text = "frmReportUbicaciones";
            this.Load += new System.EventHandler(this.frmReportUbicaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ActivosFijosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UbicacionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource UbicacionBindingSource;
        private ActivosFijosDataSet ActivosFijosDataSet;
        private ActivosFijosDataSetTableAdapters.UbicacionTableAdapter UbicacionTableAdapter;
    }
}
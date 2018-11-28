namespace ActivosFijos
{
    partial class FrmReportActivos
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Activos_FijosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ActivosFijosDataSet = new ActivosFijos.ActivosFijosDataSet();
            this.DepartamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UbicacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Activos_FijosTableAdapter = new ActivosFijos.ActivosFijosDataSetTableAdapters.Activos_FijosTableAdapter();
            this.DepartamentoTableAdapter = new ActivosFijos.ActivosFijosDataSetTableAdapters.DepartamentoTableAdapter();
            this.UbicacionTableAdapter = new ActivosFijos.ActivosFijosDataSetTableAdapters.UbicacionTableAdapter();
            this.tipoActivoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipo_ActivoTableAdapter = new ActivosFijos.ActivosFijosDataSetTableAdapters.Tipo_ActivoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Activos_FijosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivosFijosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepartamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UbicacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoActivoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Activos_FijosBindingSource
            // 
            this.Activos_FijosBindingSource.DataMember = "Activos_Fijos";
            this.Activos_FijosBindingSource.DataSource = this.ActivosFijosDataSet;
            // 
            // ActivosFijosDataSet
            // 
            this.ActivosFijosDataSet.DataSetName = "ActivosFijosDataSet";
            this.ActivosFijosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DepartamentoBindingSource
            // 
            this.DepartamentoBindingSource.DataMember = "Departamento";
            this.DepartamentoBindingSource.DataSource = this.ActivosFijosDataSet;
            // 
            // UbicacionBindingSource
            // 
            this.UbicacionBindingSource.DataMember = "Ubicacion";
            this.UbicacionBindingSource.DataSource = this.ActivosFijosDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSActivosFijos";
            reportDataSource1.Value = this.Activos_FijosBindingSource;
            reportDataSource2.Name = "DSDepartamento";
            reportDataSource2.Value = this.DepartamentoBindingSource;
            reportDataSource3.Name = "DSUbicacion";
            reportDataSource3.Value = this.UbicacionBindingSource;
            reportDataSource4.Name = "DSTipoActivo";
            reportDataSource4.Value = this.tipoActivoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ActivosFijos.RprtActivo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // Activos_FijosTableAdapter
            // 
            this.Activos_FijosTableAdapter.ClearBeforeFill = true;
            // 
            // DepartamentoTableAdapter
            // 
            this.DepartamentoTableAdapter.ClearBeforeFill = true;
            // 
            // UbicacionTableAdapter
            // 
            this.UbicacionTableAdapter.ClearBeforeFill = true;
            // 
            // tipoActivoBindingSource
            // 
            this.tipoActivoBindingSource.DataMember = "Tipo_Activo";
            this.tipoActivoBindingSource.DataSource = this.ActivosFijosDataSet;
            // 
            // tipo_ActivoTableAdapter
            // 
            this.tipo_ActivoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReportActivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReportActivos";
            this.Text = "Reporte Activo Fijos";
            this.Load += new System.EventHandler(this.FrmActivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Activos_FijosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivosFijosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepartamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UbicacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoActivoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Activos_FijosBindingSource;
        private ActivosFijosDataSet ActivosFijosDataSet;
        private System.Windows.Forms.BindingSource DepartamentoBindingSource;
        private System.Windows.Forms.BindingSource UbicacionBindingSource;
        private ActivosFijosDataSetTableAdapters.Activos_FijosTableAdapter Activos_FijosTableAdapter;
        private ActivosFijosDataSetTableAdapters.DepartamentoTableAdapter DepartamentoTableAdapter;
        private ActivosFijosDataSetTableAdapters.UbicacionTableAdapter UbicacionTableAdapter;
        private System.Windows.Forms.BindingSource tipoActivoBindingSource;
        private ActivosFijosDataSetTableAdapters.Tipo_ActivoTableAdapter tipo_ActivoTableAdapter;
    }
}
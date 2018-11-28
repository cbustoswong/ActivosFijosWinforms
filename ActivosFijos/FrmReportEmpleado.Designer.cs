namespace ActivosFijos
{
    partial class FrmReportEmpleado
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ActivosFijosDataSet = new ActivosFijos.ActivosFijosDataSet();
            this.EmpleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EmpleadoTableAdapter = new ActivosFijos.ActivosFijosDataSetTableAdapters.EmpleadoTableAdapter();
            this.DepartamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DepartamentoTableAdapter = new ActivosFijos.ActivosFijosDataSetTableAdapters.DepartamentoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ActivosFijosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepartamentoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSEmpleados";
            reportDataSource1.Value = this.EmpleadoBindingSource;
            reportDataSource2.Name = "DSDepartamento";
            reportDataSource2.Value = this.DepartamentoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ActivosFijos.RprtEmpleados.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(995, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // ActivosFijosDataSet
            // 
            this.ActivosFijosDataSet.DataSetName = "ActivosFijosDataSet";
            this.ActivosFijosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EmpleadoBindingSource
            // 
            this.EmpleadoBindingSource.DataMember = "Empleado";
            this.EmpleadoBindingSource.DataSource = this.ActivosFijosDataSet;
            // 
            // EmpleadoTableAdapter
            // 
            this.EmpleadoTableAdapter.ClearBeforeFill = true;
            // 
            // DepartamentoBindingSource
            // 
            this.DepartamentoBindingSource.DataMember = "Departamento";
            this.DepartamentoBindingSource.DataSource = this.ActivosFijosDataSet;
            // 
            // DepartamentoTableAdapter
            // 
            this.DepartamentoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReportEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReportEmpleado";
            this.Text = "FrmReportEmpleado";
            this.Load += new System.EventHandler(this.FrmReportEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ActivosFijosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepartamentoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource EmpleadoBindingSource;
        private ActivosFijosDataSet ActivosFijosDataSet;
        private System.Windows.Forms.BindingSource DepartamentoBindingSource;
        private ActivosFijosDataSetTableAdapters.EmpleadoTableAdapter EmpleadoTableAdapter;
        private ActivosFijosDataSetTableAdapters.DepartamentoTableAdapter DepartamentoTableAdapter;
    }
}
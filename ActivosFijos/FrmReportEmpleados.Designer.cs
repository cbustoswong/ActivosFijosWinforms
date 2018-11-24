namespace ActivosFijos
{
    partial class FrmReportEmpleados
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
            this.EmpleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ActivosFijosDataSet = new ActivosFijos.ActivosFijosDataSet();
            this.EmpleadoTableAdapter = new ActivosFijos.ActivosFijosDataSetTableAdapters.EmpleadoTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.EmpleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivosFijosDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // EmpleadoBindingSource
            // 
            this.EmpleadoBindingSource.DataMember = "Empleado";
            this.EmpleadoBindingSource.DataSource = this.ActivosFijosDataSet;
            // 
            // ActivosFijosDataSet
            // 
            this.ActivosFijosDataSet.DataSetName = "ActivosFijosDataSet";
            this.ActivosFijosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EmpleadoTableAdapter
            // 
            this.EmpleadoTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSEmpleado";
            reportDataSource1.Value = this.EmpleadoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ActivosFijos.ReportEmpleado.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // FrmReportEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReportEmpleados";
            this.Text = "FrmReportEmpleados";
            this.Load += new System.EventHandler(this.FrmReportEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmpleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivosFijosDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource EmpleadoBindingSource;
        private ActivosFijosDataSet ActivosFijosDataSet;
        private ActivosFijosDataSetTableAdapters.EmpleadoTableAdapter EmpleadoTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}
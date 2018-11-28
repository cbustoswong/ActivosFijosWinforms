namespace ActivosFijos
{
    partial class FrmReportCalculo
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ActivosFijosDataSet = new ActivosFijos.ActivosFijosDataSet();
            this.Calculo_DepreciacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Calculo_DepreciacionTableAdapter = new ActivosFijos.ActivosFijosDataSetTableAdapters.Calculo_DepreciacionTableAdapter();
            this.Activos_FijosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Activos_FijosTableAdapter = new ActivosFijos.ActivosFijosDataSetTableAdapters.Activos_FijosTableAdapter();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblProgress = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ActivosFijosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Calculo_DepreciacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Activos_FijosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DSCalcDepre";
            reportDataSource3.Value = this.Calculo_DepreciacionBindingSource;
            reportDataSource4.Name = "DSActivoFijos";
            reportDataSource4.Value = this.Activos_FijosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ActivosFijos.RprtCalcDepr.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-2, 79);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(997, 373);
            this.reportViewer1.TabIndex = 0;
            // 
            // ActivosFijosDataSet
            // 
            this.ActivosFijosDataSet.DataSetName = "ActivosFijosDataSet";
            this.ActivosFijosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Calculo_DepreciacionBindingSource
            // 
            this.Calculo_DepreciacionBindingSource.DataMember = "Calculo_Depreciacion";
            this.Calculo_DepreciacionBindingSource.DataSource = this.ActivosFijosDataSet;
            // 
            // Calculo_DepreciacionTableAdapter
            // 
            this.Calculo_DepreciacionTableAdapter.ClearBeforeFill = true;
            // 
            // Activos_FijosBindingSource
            // 
            this.Activos_FijosBindingSource.DataMember = "Activos_Fijos";
            this.Activos_FijosBindingSource.DataSource = this.ActivosFijosDataSet;
            // 
            // Activos_FijosTableAdapter
            // 
            this.Activos_FijosTableAdapter.ClearBeforeFill = true;
            // 
            // cmbFilter
            // 
            this.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Items.AddRange(new object[] {
            "Fechas",
            "Valor en libro cero"});
            this.cmbFilter.Location = new System.Drawing.Point(102, 25);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(121, 24);
            this.cmbFilter.TabIndex = 1;
            this.cmbFilter.SelectedValueChanged += new System.EventHandler(this.cmbFilter_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Criterio";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(360, 12);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(200, 22);
            this.dtpDesde.TabIndex = 3;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(360, 51);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(200, 22);
            this.dtpHasta.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Desde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hasta";
            // 
            // btnExport
            // 
            this.btnExport.BackgroundImage = global::ActivosFijos.Properties.Resources.excel;
            this.btnExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Location = new System.Drawing.Point(900, 9);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(64, 64);
            this.btnExport.TabIndex = 7;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // bgWorker
            // 
            this.bgWorker.WorkerReportsProgress = true;
            this.bgWorker.WorkerSupportsCancellation = true;
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            this.bgWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorker_ProgressChanged);
            this.bgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_RunWorkerCompleted);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 458);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(781, 23);
            this.progressBar.TabIndex = 8;
            // 
            // lblProgress
            // 
            this.lblProgress.Location = new System.Drawing.Point(799, 458);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(196, 23);
            this.lblProgress.TabIndex = 9;
            this.lblProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmReportCalculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 484);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReportCalculo";
            this.Text = "Reporte Calculo Depreciacion";
            this.Load += new System.EventHandler(this.FrmReportCalculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ActivosFijosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Calculo_DepreciacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Activos_FijosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Calculo_DepreciacionBindingSource;
        private ActivosFijosDataSet ActivosFijosDataSet;
        private System.Windows.Forms.BindingSource Activos_FijosBindingSource;
        private ActivosFijosDataSetTableAdapters.Calculo_DepreciacionTableAdapter Calculo_DepreciacionTableAdapter;
        private ActivosFijosDataSetTableAdapters.Activos_FijosTableAdapter Activos_FijosTableAdapter;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExport;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblProgress;
    }
}
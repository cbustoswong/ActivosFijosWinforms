namespace ActivosFijos
{
    partial class frmParametros
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvParametros = new System.Windows.Forms.DataGridView();
            this.Ano_Proceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mes_Proceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deprec_Calculada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RNC_Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Met_Depreciacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cbxCriterio = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParametros)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvParametros);
            this.panel2.Location = new System.Drawing.Point(13, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(775, 368);
            this.panel2.TabIndex = 5;
            // 
            // dgvParametros
            // 
            this.dgvParametros.AllowUserToAddRows = false;
            this.dgvParametros.AllowUserToDeleteRows = false;
            this.dgvParametros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParametros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ano_Proceso,
            this.Mes_Proceso,
            this.Deprec_Calculada,
            this.RNC_Empresa,
            this.Met_Depreciacion});
            this.dgvParametros.Location = new System.Drawing.Point(0, 0);
            this.dgvParametros.Name = "dgvParametros";
            this.dgvParametros.ReadOnly = true;
            this.dgvParametros.Size = new System.Drawing.Size(775, 368);
            this.dgvParametros.TabIndex = 0;
            // 
            // Ano_Proceso
            // 
            this.Ano_Proceso.DataPropertyName = "Ano_Proceso";
            this.Ano_Proceso.HeaderText = "Año Proceso";
            this.Ano_Proceso.Name = "Ano_Proceso";
            this.Ano_Proceso.ReadOnly = true;
            this.Ano_Proceso.Visible = false;
            // 
            // Mes_Proceso
            // 
            this.Mes_Proceso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Mes_Proceso.DataPropertyName = "Mes_Proceso";
            this.Mes_Proceso.HeaderText = "Mes Proceso";
            this.Mes_Proceso.Name = "Mes_Proceso";
            this.Mes_Proceso.ReadOnly = true;
            // 
            // Deprec_Calculada
            // 
            this.Deprec_Calculada.DataPropertyName = "Deprec_Calculada";
            this.Deprec_Calculada.HeaderText = "Depreciacion calculada";
            this.Deprec_Calculada.Name = "Deprec_Calculada";
            this.Deprec_Calculada.ReadOnly = true;
            // 
            // RNC_Empresa
            // 
            this.RNC_Empresa.DataPropertyName = "RNC_Empresa";
            this.RNC_Empresa.HeaderText = "RNC";
            this.RNC_Empresa.Name = "RNC_Empresa";
            this.RNC_Empresa.ReadOnly = true;
            // 
            // Met_Depreciacion
            // 
            this.Met_Depreciacion.DataPropertyName = "Met_Depreciacion";
            this.Met_Depreciacion.HeaderText = "Metodo Depreciacion";
            this.Met_Depreciacion.Name = "Met_Depreciacion";
            this.Met_Depreciacion.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Controls.Add(this.cbxCriterio);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 50);
            this.panel1.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = global::ActivosFijos.Properties.Resources.plus;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(724, 0);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(48, 48);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = global::ActivosFijos.Properties.Resources.search;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(661, 0);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(48, 48);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(450, 16);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(161, 20);
            this.txtBuscar.TabIndex = 2;
            // 
            // cbxCriterio
            // 
            this.cbxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCriterio.FormattingEnabled = true;
            this.cbxCriterio.Items.AddRange(new object[] {
            "Año",
            "Depreciacion calculada"});
            this.cbxCriterio.Location = new System.Drawing.Point(48, 16);
            this.cbxCriterio.Name = "cbxCriterio";
            this.cbxCriterio.Size = new System.Drawing.Size(121, 21);
            this.cbxCriterio.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(404, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Buscar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Criterio";
            // 
            // frmParametros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmParametros";
            this.Text = "frmParametros";
            this.Load += new System.EventHandler(this.frmParametros_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParametros)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvParametros;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cbxCriterio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ano_Proceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mes_Proceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deprec_Calculada;
        private System.Windows.Forms.DataGridViewTextBoxColumn RNC_Empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Met_Depreciacion;
    }
}
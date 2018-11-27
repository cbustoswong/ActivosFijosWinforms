namespace ActivosFijos
{
    partial class frmActivosFijos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cbxCriterio = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvActivos = new System.Windows.Forms.DataGridView();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_Activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Dept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Ubicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_TipoActivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ubicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Depreciacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Controls.Add(this.cbxCriterio);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 50);
            this.panel1.TabIndex = 2;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = global::ActivosFijos.Properties.Resources.plus;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(725, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(48, 48);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = global::ActivosFijos.Properties.Resources.search;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(662, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(48, 48);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(454, 15);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(176, 20);
            this.txtBuscar.TabIndex = 2;
            // 
            // cbxCriterio
            // 
            this.cbxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCriterio.FormattingEnabled = true;
            this.cbxCriterio.Items.AddRange(new object[] {
            "Tipo",
            "Departamento",
            "Valor"});
            this.cbxCriterio.Location = new System.Drawing.Point(60, 16);
            this.cbxCriterio.Name = "cbxCriterio";
            this.cbxCriterio.Size = new System.Drawing.Size(121, 21);
            this.cbxCriterio.TabIndex = 1;
            this.cbxCriterio.SelectedValueChanged += new System.EventHandler(this.cbxCriterio_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(398, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Buscar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Criterio";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvActivos);
            this.panel2.Location = new System.Drawing.Point(13, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(775, 378);
            this.panel2.TabIndex = 3;
            // 
            // dgvActivos
            // 
            this.dgvActivos.AllowUserToAddRows = false;
            this.dgvActivos.AllowUserToDeleteRows = false;
            this.dgvActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descripcion,
            this.Codigo_Activo,
            this.Departamento,
            this.Id_Dept,
            this.Id_Ubicacion,
            this.Id_TipoActivo,
            this.Ubicacion,
            this.Tipo,
            this.Fecha,
            this.Valor,
            this.Depreciacion});
            this.dgvActivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvActivos.Location = new System.Drawing.Point(0, 0);
            this.dgvActivos.Name = "dgvActivos";
            this.dgvActivos.ReadOnly = true;
            this.dgvActivos.Size = new System.Drawing.Size(775, 378);
            this.dgvActivos.TabIndex = 0;
            this.dgvActivos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActivos_CellDoubleClick);
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Codigo_Activo
            // 
            this.Codigo_Activo.DataPropertyName = "Codigo_Activo";
            this.Codigo_Activo.HeaderText = "Codigo_Activo";
            this.Codigo_Activo.Name = "Codigo_Activo";
            this.Codigo_Activo.ReadOnly = true;
            this.Codigo_Activo.Visible = false;
            // 
            // Departamento
            // 
            this.Departamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Departamento.HeaderText = "Departamento";
            this.Departamento.Name = "Departamento";
            this.Departamento.ReadOnly = true;
            // 
            // Id_Dept
            // 
            this.Id_Dept.DataPropertyName = "Codigo_Departamento";
            this.Id_Dept.HeaderText = "Id_Departamento";
            this.Id_Dept.Name = "Id_Dept";
            this.Id_Dept.ReadOnly = true;
            this.Id_Dept.Visible = false;
            // 
            // Id_Ubicacion
            // 
            this.Id_Ubicacion.DataPropertyName = "Codigo_Ubicacion";
            this.Id_Ubicacion.HeaderText = "Id_Ubicacion";
            this.Id_Ubicacion.Name = "Id_Ubicacion";
            this.Id_Ubicacion.ReadOnly = true;
            this.Id_Ubicacion.Visible = false;
            // 
            // Id_TipoActivo
            // 
            this.Id_TipoActivo.DataPropertyName = "Codigo_TipoActivo";
            this.Id_TipoActivo.HeaderText = "Id_TipoActivo";
            this.Id_TipoActivo.Name = "Id_TipoActivo";
            this.Id_TipoActivo.ReadOnly = true;
            this.Id_TipoActivo.Visible = false;
            // 
            // Ubicacion
            // 
            this.Ubicacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ubicacion.HeaderText = "Ubicacion";
            this.Ubicacion.Name = "Ubicacion";
            this.Ubicacion.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Fecha.DataPropertyName = "Fecha_Registro";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Valor.DataPropertyName = "Valor_Compra";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // Depreciacion
            // 
            this.Depreciacion.HeaderText = "Depreciacion Acumulada";
            this.Depreciacion.Name = "Depreciacion";
            this.Depreciacion.ReadOnly = true;
            // 
            // frmActivosFijos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmActivosFijos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Activos Fijos";
            this.Activated += new System.EventHandler(this.frmActivosFijos_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmActivosFijos_FormClosing);
            this.Load += new System.EventHandler(this.frmActivosFijos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbxCriterio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvActivos;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Activo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Dept;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Ubicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_TipoActivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ubicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Depreciacion;
    }
}
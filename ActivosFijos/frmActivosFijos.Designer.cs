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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cbxCriterio = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvActivos = new System.Windows.Forms.DataGridView();
            this.CodigoBR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_Activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ubicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Depreciacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deprecia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnTransferir = new System.Windows.Forms.Button();
            this.BtnView = new System.Windows.Forms.Button();
            this.btnDepreciacion = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDown);
            this.panel1.Controls.Add(this.btnTransferir);
            this.panel1.Controls.Add(this.BtnView);
            this.panel1.Controls.Add(this.btnDepreciacion);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Controls.Add(this.cbxCriterio);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1119, 54);
            this.panel1.TabIndex = 2;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(293, 19);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(201, 21);
            this.txtBuscar.TabIndex = 2;
            // 
            // cbxCriterio
            // 
            this.cbxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCriterio.FormattingEnabled = true;
            this.cbxCriterio.Items.AddRange(new object[] {
            "Tipo",
            "Departamento",
            "Valor",
            "Fecha"});
            this.cbxCriterio.Location = new System.Drawing.Point(60, 17);
            this.cbxCriterio.Name = "cbxCriterio";
            this.cbxCriterio.Size = new System.Drawing.Size(160, 22);
            this.cbxCriterio.TabIndex = 1;
            this.cbxCriterio.SelectedValueChanged += new System.EventHandler(this.cbxCriterio_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(236, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Buscar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Criterio";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvActivos);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1119, 431);
            this.panel2.TabIndex = 3;
            // 
            // dgvActivos
            // 
            this.dgvActivos.AllowUserToAddRows = false;
            this.dgvActivos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvActivos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoBR,
            this.Descripcion,
            this.Codigo_Activo,
            this.Departamento,
            this.Ubicacion,
            this.Tipo,
            this.Fecha,
            this.Valor,
            this.Depreciacion,
            this.Deprecia});
            this.dgvActivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvActivos.Location = new System.Drawing.Point(0, 0);
            this.dgvActivos.Name = "dgvActivos";
            this.dgvActivos.ReadOnly = true;
            this.dgvActivos.Size = new System.Drawing.Size(1119, 431);
            this.dgvActivos.TabIndex = 0;
            this.dgvActivos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActivos_CellContentClick);
            this.dgvActivos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActivos_CellDoubleClick);
            // 
            // CodigoBR
            // 
            this.CodigoBR.DataPropertyName = "CodigoBR";
            this.CodigoBR.Frozen = true;
            this.CodigoBR.HeaderText = "Codigo";
            this.CodigoBR.Name = "CodigoBR";
            this.CodigoBR.ReadOnly = true;
            this.CodigoBR.Width = 150;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.Frozen = true;
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 180;
            // 
            // Codigo_Activo
            // 
            this.Codigo_Activo.DataPropertyName = "Codigo";
            this.Codigo_Activo.HeaderText = "Codigo_Activo";
            this.Codigo_Activo.Name = "Codigo_Activo";
            this.Codigo_Activo.ReadOnly = true;
            this.Codigo_Activo.Visible = false;
            this.Codigo_Activo.Width = 150;
            // 
            // Departamento
            // 
            this.Departamento.DataPropertyName = "Departamento";
            this.Departamento.HeaderText = "Departamento";
            this.Departamento.Name = "Departamento";
            this.Departamento.ReadOnly = true;
            this.Departamento.Width = 150;
            // 
            // Ubicacion
            // 
            this.Ubicacion.DataPropertyName = "Ubicacion";
            this.Ubicacion.HeaderText = "Ubicacion";
            this.Ubicacion.Name = "Ubicacion";
            this.Ubicacion.ReadOnly = true;
            this.Ubicacion.Width = 150;
            // 
            // Tipo
            // 
            this.Tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tipo.DataPropertyName = "TipoActivo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "FechaCompra";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 70;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "ValorCompra";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Width = 70;
            // 
            // Depreciacion
            // 
            this.Depreciacion.DataPropertyName = "Acumulado";
            this.Depreciacion.HeaderText = "Depreciacion Acumulada";
            this.Depreciacion.Name = "Depreciacion";
            this.Depreciacion.ReadOnly = true;
            this.Depreciacion.Width = 120;
            // 
            // Deprecia
            // 
            this.Deprecia.DataPropertyName = "Depreciar";
            this.Deprecia.HeaderText = "Depreciar";
            this.Deprecia.Name = "Deprecia";
            this.Deprecia.ReadOnly = true;
            this.Deprecia.Width = 60;
            // 
            // btnDown
            // 
            this.btnDown.BackgroundImage = global::ActivosFijos.Properties.Resources.down_arrow;
            this.btnDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDown.FlatAppearance.BorderSize = 0;
            this.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDown.Location = new System.Drawing.Point(766, 4);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(48, 47);
            this.btnDown.TabIndex = 9;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnTransferir
            // 
            this.btnTransferir.BackgroundImage = global::ActivosFijos.Properties.Resources.transfer;
            this.btnTransferir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTransferir.FlatAppearance.BorderSize = 0;
            this.btnTransferir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransferir.Location = new System.Drawing.Point(712, 4);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(48, 50);
            this.btnTransferir.TabIndex = 8;
            this.btnTransferir.UseVisualStyleBackColor = true;
            this.btnTransferir.Click += new System.EventHandler(this.btnTransferir_Click);
            // 
            // BtnView
            // 
            this.BtnView.BackgroundImage = global::ActivosFijos.Properties.Resources.view_original_volume_report__280874;
            this.BtnView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnView.FlatAppearance.BorderSize = 0;
            this.BtnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnView.Location = new System.Drawing.Point(886, 3);
            this.BtnView.Name = "BtnView";
            this.BtnView.Size = new System.Drawing.Size(48, 48);
            this.BtnView.TabIndex = 7;
            this.BtnView.UseVisualStyleBackColor = true;
            this.BtnView.Click += new System.EventHandler(this.BtnView_Click);
            // 
            // btnDepreciacion
            // 
            this.btnDepreciacion.BackgroundImage = global::ActivosFijos.Properties.Resources.hand_holding_usd;
            this.btnDepreciacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDepreciacion.FlatAppearance.BorderSize = 0;
            this.btnDepreciacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepreciacion.Location = new System.Drawing.Point(825, 3);
            this.btnDepreciacion.Name = "btnDepreciacion";
            this.btnDepreciacion.Size = new System.Drawing.Size(48, 45);
            this.btnDepreciacion.TabIndex = 3;
            this.btnDepreciacion.UseVisualStyleBackColor = true;
            this.btnDepreciacion.Click += new System.EventHandler(this.btnDepreciacion_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = global::ActivosFijos.Properties.Resources.plus;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(658, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(48, 50);
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
            this.btnBuscar.Location = new System.Drawing.Point(548, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(48, 46);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmActivosFijos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 485);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private System.Windows.Forms.Button btnDepreciacion;
        private System.Windows.Forms.Button BtnView;
        private System.Windows.Forms.Button btnTransferir;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoBR;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Activo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ubicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Depreciacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deprecia;
        private System.Windows.Forms.Button btnDown;
    }
}
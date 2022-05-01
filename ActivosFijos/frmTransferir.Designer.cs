namespace ActivosFijos
{
    partial class frmTransferir
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxDept = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxUbicacion = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.nudValor = new System.Windows.Forms.NumericUpDown();
            this.cbxProveedor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxResponsable = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chkDepreciar = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripción Activo";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(117, 50);
            this.txtDescripcion.MaxLength = 40;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(324, 20);
            this.txtDescripcion.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Departamento";
            // 
            // cbxDept
            // 
            this.cbxDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDept.FormattingEnabled = true;
            this.cbxDept.Location = new System.Drawing.Point(117, 134);
            this.cbxDept.Name = "cbxDept";
            this.cbxDept.Size = new System.Drawing.Size(248, 21);
            this.cbxDept.TabIndex = 4;
            this.cbxDept.SelectedValueChanged += new System.EventHandler(this.cbxDept_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ubicacion";
            // 
            // cbxUbicacion
            // 
            this.cbxUbicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUbicacion.FormattingEnabled = true;
            this.cbxUbicacion.Items.AddRange(new object[] {
            "Fisica",
            "Juridica"});
            this.cbxUbicacion.Location = new System.Drawing.Point(117, 107);
            this.cbxUbicacion.Name = "cbxUbicacion";
            this.cbxUbicacion.Size = new System.Drawing.Size(248, 21);
            this.cbxUbicacion.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Fecha de Compra";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tipo Activo";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::ActivosFijos.Properties.Resources.save;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(392, 256);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(48, 48);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cbxTipo
            // 
            this.cbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbxTipo.Location = new System.Drawing.Point(117, 165);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(324, 21);
            this.cbxTipo.TabIndex = 6;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(13, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(117, 17);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Transferencias";
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "MMMMdd, yyyy";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(117, 192);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(101, 20);
            this.dtpFecha.TabIndex = 7;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Valor de Compra";
            // 
            // nudValor
            // 
            this.nudValor.Location = new System.Drawing.Point(320, 194);
            this.nudValor.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudValor.Name = "nudValor";
            this.nudValor.Size = new System.Drawing.Size(120, 20);
            this.nudValor.TabIndex = 8;
            // 
            // cbxProveedor
            // 
            this.cbxProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProveedor.FormattingEnabled = true;
            this.cbxProveedor.Location = new System.Drawing.Point(117, 76);
            this.cbxProveedor.Name = "cbxProveedor";
            this.cbxProveedor.Size = new System.Drawing.Size(324, 21);
            this.cbxProveedor.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Proveedor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Responsable";
            // 
            // cbxResponsable
            // 
            this.cbxResponsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxResponsable.FormattingEnabled = true;
            this.cbxResponsable.Location = new System.Drawing.Point(117, 222);
            this.cbxResponsable.Name = "cbxResponsable";
            this.cbxResponsable.Size = new System.Drawing.Size(248, 21);
            this.cbxResponsable.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(379, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Depreciar";
            // 
            // chkDepreciar
            // 
            this.chkDepreciar.AutoSize = true;
            this.chkDepreciar.Location = new System.Drawing.Point(392, 137);
            this.chkDepreciar.Name = "chkDepreciar";
            this.chkDepreciar.Size = new System.Drawing.Size(15, 14);
            this.chkDepreciar.TabIndex = 5;
            this.chkDepreciar.TabStop = false;
            this.chkDepreciar.UseVisualStyleBackColor = true;
            // 
            // frmTransferir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 316);
            this.Controls.Add(this.chkDepreciar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbxResponsable);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbxProveedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudValor);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.cbxTipo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cbxUbicacion);
            this.Controls.Add(this.cbxDept);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTransferir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transferencias de Activos Fijos";
            this.Load += new System.EventHandler(this.frmActivosFijosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudValor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxDept;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxUbicacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudValor;
        private System.Windows.Forms.ComboBox cbxProveedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxResponsable;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkDepreciar;
    }
}
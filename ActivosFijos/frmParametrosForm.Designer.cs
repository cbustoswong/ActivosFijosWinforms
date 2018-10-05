namespace ActivosFijos
{
    partial class frmParametrosForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.chkDeprecCalculada = new System.Windows.Forms.CheckBox();
            this.txtRNC = new System.Windows.Forms.TextBox();
            this.dtpAnoMes = new System.Windows.Forms.DateTimePicker();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cbxMetDeprec = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "RNC Empresa:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Metodo Depreciacion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Depreciacion Calculada:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Año/Mes:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::ActivosFijos.Properties.Resources.save;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(253, 174);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(48, 48);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = global::ActivosFijos.Properties.Resources.delete;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(12, 174);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(48, 48);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // chkDeprecCalculada
            // 
            this.chkDeprecCalculada.AutoSize = true;
            this.chkDeprecCalculada.Location = new System.Drawing.Point(144, 73);
            this.chkDeprecCalculada.Name = "chkDeprecCalculada";
            this.chkDeprecCalculada.Size = new System.Drawing.Size(15, 14);
            this.chkDeprecCalculada.TabIndex = 2;
            this.chkDeprecCalculada.UseVisualStyleBackColor = true;
            // 
            // txtRNC
            // 
            this.txtRNC.Location = new System.Drawing.Point(143, 98);
            this.txtRNC.MaxLength = 9;
            this.txtRNC.Name = "txtRNC";
            this.txtRNC.Size = new System.Drawing.Size(121, 20);
            this.txtRNC.TabIndex = 3;
            // 
            // dtpAnoMes
            // 
            this.dtpAnoMes.CustomFormat = "MMMMdd, yyyy";
            this.dtpAnoMes.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAnoMes.Location = new System.Drawing.Point(143, 40);
            this.dtpAnoMes.Name = "dtpAnoMes";
            this.dtpAnoMes.Size = new System.Drawing.Size(158, 20);
            this.dtpAnoMes.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(168, 17);
            this.lblTitle.TabIndex = 34;
            this.lblTitle.Text = "Agregar un parametro";
            // 
            // cbxMetDeprec
            // 
            this.cbxMetDeprec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMetDeprec.FormattingEnabled = true;
            this.cbxMetDeprec.Items.AddRange(new object[] {
            "Linea Recta",
            "Digito de los años"});
            this.cbxMetDeprec.Location = new System.Drawing.Point(143, 125);
            this.cbxMetDeprec.Name = "cbxMetDeprec";
            this.cbxMetDeprec.Size = new System.Drawing.Size(121, 21);
            this.cbxMetDeprec.TabIndex = 4;
            // 
            // frmParametrosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 234);
            this.Controls.Add(this.cbxMetDeprec);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dtpAnoMes);
            this.Controls.Add(this.chkDeprecCalculada);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRNC);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmParametrosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Formulario de Parametros";
            this.Load += new System.EventHandler(this.frmParametrosForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkDeprecCalculada;
        private System.Windows.Forms.TextBox txtRNC;
        private System.Windows.Forms.DateTimePicker dtpAnoMes;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cbxMetDeprec;
    }
}
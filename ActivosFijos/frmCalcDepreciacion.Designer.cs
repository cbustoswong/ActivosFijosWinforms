namespace ActivosFijos
{
    partial class frmCalcDepreciacion
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
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.rbDigAnos = new System.Windows.Forms.RadioButton();
            this.rbLineaRecta = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdCalcular = new System.Windows.Forms.Button();
            this.nudAnosDep = new System.Windows.Forms.NumericUpDown();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnosDep)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvResultados
            // 
            this.dgvResultados.AllowUserToAddRows = false;
            this.dgvResultados.AllowUserToDeleteRows = false;
            this.dgvResultados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Location = new System.Drawing.Point(0, 126);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.ReadOnly = true;
            this.dgvResultados.Size = new System.Drawing.Size(644, 243);
            this.dgvResultados.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.dtpFecha);
            this.panel1.Controls.Add(this.rbDigAnos);
            this.panel1.Controls.Add(this.rbLineaRecta);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmdCalcular);
            this.panel1.Controls.Add(this.nudAnosDep);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 135);
            this.panel1.TabIndex = 2;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Location = new System.Drawing.Point(64, 44);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 7;
            // 
            // rbDigAnos
            // 
            this.rbDigAnos.AutoSize = true;
            this.rbDigAnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDigAnos.Location = new System.Drawing.Point(115, 79);
            this.rbDigAnos.Name = "rbDigAnos";
            this.rbDigAnos.Size = new System.Drawing.Size(90, 17);
            this.rbDigAnos.TabIndex = 6;
            this.rbDigAnos.Text = "Digito Años";
            this.rbDigAnos.UseVisualStyleBackColor = true;
            // 
            // rbLineaRecta
            // 
            this.rbLineaRecta.AutoSize = true;
            this.rbLineaRecta.Checked = true;
            this.rbLineaRecta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLineaRecta.Location = new System.Drawing.Point(15, 79);
            this.rbLineaRecta.Name = "rbLineaRecta";
            this.rbLineaRecta.Size = new System.Drawing.Size(94, 17);
            this.rbLineaRecta.TabIndex = 5;
            this.rbLineaRecta.TabStop = true;
            this.rbLineaRecta.Text = "Linea Recta";
            this.rbLineaRecta.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Meses Depreciacion:";
            // 
            // cmdCalcular
            // 
            this.cmdCalcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdCalcular.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.cmdCalcular.FlatAppearance.BorderSize = 2;
            this.cmdCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCalcular.Location = new System.Drawing.Point(315, 27);
            this.cmdCalcular.Name = "cmdCalcular";
            this.cmdCalcular.Size = new System.Drawing.Size(133, 52);
            this.cmdCalcular.TabIndex = 3;
            this.cmdCalcular.Text = "Calcular";
            this.cmdCalcular.UseVisualStyleBackColor = true;
            this.cmdCalcular.Click += new System.EventHandler(this.cmdCalcular_Click);
            // 
            // nudAnosDep
            // 
            this.nudAnosDep.Location = new System.Drawing.Point(140, 18);
            this.nudAnosDep.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudAnosDep.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAnosDep.Name = "nudAnosDep";
            this.nudAnosDep.Size = new System.Drawing.Size(61, 20);
            this.nudAnosDep.TabIndex = 2;
            this.nudAnosDep.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::ActivosFijos.Properties.Resources.save;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(466, 22);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(61, 57);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmCalcDepreciacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 369);
            this.Controls.Add(this.dgvResultados);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCalcDepreciacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Calculo de Depreciacion de Activos Fijos";
            this.Load += new System.EventHandler(this.frmCalcDepreciacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnosDep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbDigAnos;
        private System.Windows.Forms.RadioButton rbLineaRecta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdCalcular;
        private System.Windows.Forms.NumericUpDown nudAnosDep;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
    }
}
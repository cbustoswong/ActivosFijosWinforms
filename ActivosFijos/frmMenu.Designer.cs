namespace ActivosFijos
{
    partial class frmMenu
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
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnUbicacion = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnParametros = new System.Windows.Forms.Button();
            this.btnDepartamentos = new System.Windows.Forms.Button();
            this.btnActivos = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Menu";
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Image = global::ActivosFijos.Properties.Resources.icon;
            this.btnUsuarios.Location = new System.Drawing.Point(21, 318);
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(125, 182);
            this.btnUsuarios.TabIndex = 1;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            this.btnUsuarios.MouseEnter += new System.EventHandler(this.btnUsuarios_MouseEnter);
            this.btnUsuarios.MouseLeave += new System.EventHandler(this.btnUsuarios_MouseLeave);
            // 
            // btnUbicacion
            // 
            this.btnUbicacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUbicacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUbicacion.FlatAppearance.BorderSize = 0;
            this.btnUbicacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnUbicacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUbicacion.Image = global::ActivosFijos.Properties.Resources.location_marker;
            this.btnUbicacion.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUbicacion.Location = new System.Drawing.Point(21, 199);
            this.btnUbicacion.Margin = new System.Windows.Forms.Padding(2);
            this.btnUbicacion.Name = "btnUbicacion";
            this.btnUbicacion.Size = new System.Drawing.Size(104, 126);
            this.btnUbicacion.TabIndex = 1;
            this.btnUbicacion.Text = "Ubicaciones";
            this.btnUbicacion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUbicacion.UseVisualStyleBackColor = true;
            this.btnUbicacion.Click += new System.EventHandler(this.btnUbicacion_Click);
            this.btnUbicacion.MouseEnter += new System.EventHandler(this.btnUbicacion_MouseEnter);
            this.btnUbicacion.MouseLeave += new System.EventHandler(this.btnUbicacion_MouseLeave);
            // 
            // btnProveedores
            // 
            this.btnProveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProveedores.FlatAppearance.BorderSize = 0;
            this.btnProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedores.Image = global::ActivosFijos.Properties.Resources.truck;
            this.btnProveedores.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProveedores.Location = new System.Drawing.Point(287, 51);
            this.btnProveedores.Margin = new System.Windows.Forms.Padding(2);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(141, 114);
            this.btnProveedores.TabIndex = 1;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProveedores.UseVisualStyleBackColor = true;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            this.btnProveedores.MouseEnter += new System.EventHandler(this.btnProveedores_MouseEnter);
            this.btnProveedores.MouseLeave += new System.EventHandler(this.btnProveedores_MouseLeave);
            // 
            // btnParametros
            // 
            this.btnParametros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnParametros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnParametros.FlatAppearance.BorderSize = 0;
            this.btnParametros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnParametros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParametros.Image = global::ActivosFijos.Properties.Resources.format_list_bulleted;
            this.btnParametros.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnParametros.Location = new System.Drawing.Point(141, 211);
            this.btnParametros.Margin = new System.Windows.Forms.Padding(2);
            this.btnParametros.Name = "btnParametros";
            this.btnParametros.Size = new System.Drawing.Size(130, 114);
            this.btnParametros.TabIndex = 1;
            this.btnParametros.Text = "Parametros";
            this.btnParametros.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnParametros.UseVisualStyleBackColor = true;
            this.btnParametros.Click += new System.EventHandler(this.btnParametros_Click);
            this.btnParametros.MouseEnter += new System.EventHandler(this.btnParametros_MouseEnter);
            this.btnParametros.MouseLeave += new System.EventHandler(this.btnParametros_MouseLeave);
            // 
            // btnDepartamentos
            // 
            this.btnDepartamentos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDepartamentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDepartamentos.FlatAppearance.BorderSize = 0;
            this.btnDepartamentos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnDepartamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartamentos.Image = global::ActivosFijos.Properties.Resources.account_group;
            this.btnDepartamentos.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDepartamentos.Location = new System.Drawing.Point(141, 51);
            this.btnDepartamentos.Margin = new System.Windows.Forms.Padding(2);
            this.btnDepartamentos.Name = "btnDepartamentos";
            this.btnDepartamentos.Size = new System.Drawing.Size(130, 114);
            this.btnDepartamentos.TabIndex = 1;
            this.btnDepartamentos.Text = "Departamentos";
            this.btnDepartamentos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDepartamentos.UseVisualStyleBackColor = true;
            this.btnDepartamentos.Click += new System.EventHandler(this.btnDepartamentos_Click);
            this.btnDepartamentos.MouseEnter += new System.EventHandler(this.btnDepartamentos_MouseEnter);
            this.btnDepartamentos.MouseLeave += new System.EventHandler(this.btnDepartamentos_MouseLeave);
            // 
            // btnActivos
            // 
            this.btnActivos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnActivos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActivos.FlatAppearance.BorderSize = 0;
            this.btnActivos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnActivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivos.Image = global::ActivosFijos.Properties.Resources.file_invoice_dollar;
            this.btnActivos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnActivos.Location = new System.Drawing.Point(304, 199);
            this.btnActivos.Margin = new System.Windows.Forms.Padding(2);
            this.btnActivos.Name = "btnActivos";
            this.btnActivos.Size = new System.Drawing.Size(104, 126);
            this.btnActivos.TabIndex = 1;
            this.btnActivos.Text = "Activos Fijos";
            this.btnActivos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnActivos.UseVisualStyleBackColor = true;
            this.btnActivos.Click += new System.EventHandler(this.btnActivos_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Image = global::ActivosFijos.Properties.Resources.account;
            this.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmpleados.Location = new System.Drawing.Point(21, 51);
            this.btnEmpleados.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(104, 114);
            this.btnEmpleados.TabIndex = 1;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            this.btnEmpleados.MouseEnter += new System.EventHandler(this.btnEmpleados_MouseEnter);
            this.btnEmpleados.MouseLeave += new System.EventHandler(this.btnEmpleados_MouseLeave);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(451, 511);
            this.Controls.Add(this.btnUbicacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnProveedores);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnParametros);
            this.Controls.Add(this.btnDepartamentos);
            this.Controls.Add(this.btnActivos);
            this.Controls.Add(this.btnEmpleados);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Activos Fijos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMenu_FormClosed);
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnDepartamentos;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnUbicacion;
        private System.Windows.Forms.Button btnParametros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnActivos;
    }
}


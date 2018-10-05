namespace ActivosFijos
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.activosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeActivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnParametros = new System.Windows.Forms.Button();
            this.btnDepartamentos = new System.Windows.Forms.Button();
            this.btnUbicacion = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(597, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // activosToolStripMenuItem
            // 
            this.activosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadosToolStripMenuItem,
            this.registroDeActivosToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.parametrosToolStripMenuItem});
            this.activosToolStripMenuItem.Name = "activosToolStripMenuItem";
            this.activosToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.activosToolStripMenuItem.Text = "Mantenimiento";
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
            // 
            // registroDeActivosToolStripMenuItem
            // 
            this.registroDeActivosToolStripMenuItem.Name = "registroDeActivosToolStripMenuItem";
            this.registroDeActivosToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.registroDeActivosToolStripMenuItem.Text = "Activos Fijos";
            this.registroDeActivosToolStripMenuItem.Visible = false;
            this.registroDeActivosToolStripMenuItem.Click += new System.EventHandler(this.registroDeActivosToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // parametrosToolStripMenuItem
            // 
            this.parametrosToolStripMenuItem.Name = "parametrosToolStripMenuItem";
            this.parametrosToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.parametrosToolStripMenuItem.Text = "Parametros";
            this.parametrosToolStripMenuItem.Click += new System.EventHandler(this.parametrosToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click_1);
            // 
            // btnProveedores
            // 
            this.btnProveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProveedores.FlatAppearance.BorderSize = 0;
            this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedores.Image = global::ActivosFijos.Properties.Resources.truck;
            this.btnProveedores.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProveedores.Location = new System.Drawing.Point(381, 32);
            this.btnProveedores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(176, 140);
            this.btnProveedores.TabIndex = 1;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProveedores.UseVisualStyleBackColor = true;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnParametros
            // 
            this.btnParametros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnParametros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnParametros.FlatAppearance.BorderSize = 0;
            this.btnParametros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParametros.Image = global::ActivosFijos.Properties.Resources.format_list_bulleted;
            this.btnParametros.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnParametros.Location = new System.Drawing.Point(192, 201);
            this.btnParametros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnParametros.Name = "btnParametros";
            this.btnParametros.Size = new System.Drawing.Size(153, 140);
            this.btnParametros.TabIndex = 1;
            this.btnParametros.Text = "Parametros";
            this.btnParametros.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnParametros.UseVisualStyleBackColor = true;
            this.btnParametros.Click += new System.EventHandler(this.btnParametros_Click);
            // 
            // btnDepartamentos
            // 
            this.btnDepartamentos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDepartamentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDepartamentos.FlatAppearance.BorderSize = 0;
            this.btnDepartamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartamentos.Image = global::ActivosFijos.Properties.Resources.account_group;
            this.btnDepartamentos.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDepartamentos.Location = new System.Drawing.Point(192, 32);
            this.btnDepartamentos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDepartamentos.Name = "btnDepartamentos";
            this.btnDepartamentos.Size = new System.Drawing.Size(153, 140);
            this.btnDepartamentos.TabIndex = 1;
            this.btnDepartamentos.Text = "Departamentos";
            this.btnDepartamentos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDepartamentos.UseVisualStyleBackColor = true;
            // 
            // btnUbicacion
            // 
            this.btnUbicacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUbicacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUbicacion.FlatAppearance.BorderSize = 0;
            this.btnUbicacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUbicacion.Image = global::ActivosFijos.Properties.Resources.location_marker;
            this.btnUbicacion.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUbicacion.Location = new System.Drawing.Point(15, 201);
            this.btnUbicacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUbicacion.Name = "btnUbicacion";
            this.btnUbicacion.Size = new System.Drawing.Size(139, 155);
            this.btnUbicacion.TabIndex = 1;
            this.btnUbicacion.Text = "Ubicaciones";
            this.btnUbicacion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUbicacion.UseVisualStyleBackColor = true;
            this.btnUbicacion.Click += new System.EventHandler(this.btnUbicacion_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Image = global::ActivosFijos.Properties.Resources.account;
            this.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmpleados.Location = new System.Drawing.Point(15, 32);
            this.btnEmpleados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(139, 140);
            this.btnEmpleados.TabIndex = 1;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 369);
            this.Controls.Add(this.btnProveedores);
            this.Controls.Add(this.btnParametros);
            this.Controls.Add(this.btnDepartamentos);
            this.Controls.Add(this.btnUbicacion);
            this.Controls.Add(this.btnEmpleados);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Activos Fijos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem activosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeActivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parametrosToolStripMenuItem;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnDepartamentos;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnUbicacion;
        private System.Windows.Forms.Button btnParametros;
    }
}


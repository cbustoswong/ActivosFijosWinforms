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
            this.registroDeActivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeActivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculoDeDepreciacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activosToolStripMenuItem,
            this.utilidadesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(641, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // activosToolStripMenuItem
            // 
            this.activosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeActivosToolStripMenuItem,
            this.tiposDeActivosToolStripMenuItem,
            this.calculoDeDepreciacionToolStripMenuItem});
            this.activosToolStripMenuItem.Name = "activosToolStripMenuItem";
            this.activosToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.activosToolStripMenuItem.Text = "Activos";
            // 
            // registroDeActivosToolStripMenuItem
            // 
            this.registroDeActivosToolStripMenuItem.Name = "registroDeActivosToolStripMenuItem";
            this.registroDeActivosToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.registroDeActivosToolStripMenuItem.Text = "Registro de Activos";
            this.registroDeActivosToolStripMenuItem.Click += new System.EventHandler(this.registroDeActivosToolStripMenuItem_Click);
            // 
            // tiposDeActivosToolStripMenuItem
            // 
            this.tiposDeActivosToolStripMenuItem.Name = "tiposDeActivosToolStripMenuItem";
            this.tiposDeActivosToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.tiposDeActivosToolStripMenuItem.Text = "Tipos de Activos";
            // 
            // calculoDeDepreciacionToolStripMenuItem
            // 
            this.calculoDeDepreciacionToolStripMenuItem.Name = "calculoDeDepreciacionToolStripMenuItem";
            this.calculoDeDepreciacionToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.calculoDeDepreciacionToolStripMenuItem.Text = "Calculo de Depreciacion";
            // 
            // utilidadesToolStripMenuItem
            // 
            this.utilidadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.utilidadesToolStripMenuItem.Name = "utilidadesToolStripMenuItem";
            this.utilidadesToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.utilidadesToolStripMenuItem.Text = "Utilidades";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 279);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
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
        private System.Windows.Forms.ToolStripMenuItem tiposDeActivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculoDeDepreciacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}


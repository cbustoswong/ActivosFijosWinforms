using ActivosFijos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActivosFijos
{
    public partial class frmProveedores : Form
    {
        public frmMenu menu = null;

        public frmProveedores()
        {
            InitializeComponent();
            dgvProveedores.AutoGenerateColumns = false;
        }

        #region Eventos

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            cbxCriterio.SelectedIndex = 0;
            GetProveedores("");
        }

        private void frmProveedores_FormClosing(object sender, FormClosingEventArgs e)
        {
            menu.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            GetProveedores(txtBuscar.Text);
        }

        private void cbxCriterio_SelectedValueChanged(object sender, EventArgs e)
        {
            GetProveedores(txtBuscar.Text);
        }

        private void frmProveedores_Activated(object sender, EventArgs e)
        {
            GetProveedores(txtBuscar.Text);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmProveedoresForm frm = new frmProveedoresForm();
            frm.ShowDialog();
        }

        private void dgvProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmProveedoresForm frm = new frmProveedoresForm();
            var row = dgvProveedores.CurrentRow;

            frm.isEditing = true;
            frm.Id = (int)row.Cells["Id"].Value;
            frm.Nombre = row.Cells["Nombre"].Value.ToString();
            frm.Cedula_RNC = row.Cells["Cedula"].Value.ToString();
            frm.Tipo_Persona = row.Cells["Tipo"].Value.ToString();
            frm.FechaRegistro = DateTime.Parse(row.Cells["Fecha"].Value.ToString());
            frm.Estado = row.Cells["Estado"].Value.ToString();

            frm.ShowDialog();
        }

        #endregion

        #region Metodos
        private void GetProveedores(string search)
        {
            using (var db = new ActivosEntities())
            {
                try
                {
                    if (!(search.Trim().Length > 0))
                    {
                        if (cbxCriterio.Text.Equals("Tipo"))
                            dgvProveedores.DataSource = db.Proveedor.OrderBy(a => a.Tipo_Proveedor).ToList();
                      
                        else if (cbxCriterio.Text.Equals("Estado"))
                            dgvProveedores.DataSource = db.Proveedor.OrderBy(a => a.Estado).ToList();
                        //else
                        //    dgvProveedores.DataSource = db.Empleado.Include("Departamento").ToList();

                        return;
                    }

                    var Proveedores = db.Proveedor.Where(a => a.Nombre.Contains(search) || a.Cedula_RNC.Contains(search));

                    if (cbxCriterio.Text.Equals("Tipo"))
                        dgvProveedores.DataSource = Proveedores.OrderBy(a => a.Tipo_Proveedor).ToList();
                
                    else if (cbxCriterio.Text.Equals("Estado"))
                        dgvProveedores.DataSource = Proveedores.OrderBy(a => a.Estado).ToList();
                    else
                        dgvProveedores.DataSource = Proveedores.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }



        #endregion
    }
}

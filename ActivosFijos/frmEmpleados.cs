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
    public partial class frmEmpleados : Form
    {
        public frmMenu menu = null;

        public frmEmpleados()
        {
            InitializeComponent();
            dgvEmpleados.AutoGenerateColumns = false;
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            cbxCriterio.SelectedIndex = 0;
            GetEmpleados("");
            DeptName();
        }

        private void GetEmpleados(string search)
        {
            using (var db = new ActivosEntities())
            {
                try
                {
                    if (!(search.Trim().Length > 0))
                    {
                        if (cbxCriterio.Text.Equals("Apellido"))
                            dgvEmpleados.DataSource = db.Empleado.Include("Departamento").OrderBy(a => a.Apellido).ToList();
                        else if (cbxCriterio.Text.Equals("Tipo"))
                            dgvEmpleados.DataSource = db.Empleado.Include("Departamento").OrderBy(a => a.Tipo_Persona).ToList();
                        else if (cbxCriterio.Text.Equals("Departamento"))
                            dgvEmpleados.DataSource = db.Empleado.Include("Departamento").OrderBy(a => a.Codigo_Departamento).ToList();
                        else if (cbxCriterio.Text.Equals("Estado"))
                            dgvEmpleados.DataSource = db.Empleado.Include("Departamento").OrderBy(a => a.Estado).ToList();
                        else
                            dgvEmpleados.DataSource = db.Empleado.Include("Departamento").ToList();

                        return;
                    }

                    var empleados = db.Empleado.Include("Departamento")
                        .Where(a => a.Nombre.Contains(search) || a.Apellido.Contains(search) ||
                        a.Departamento.Nombre.Contains(search));

                    if (cbxCriterio.Text.Equals("Apellido"))
                        dgvEmpleados.DataSource = empleados.OrderBy(a => a.Apellido).ToList();
                    else if (cbxCriterio.Text.Equals("Tipo"))
                        dgvEmpleados.DataSource = empleados.OrderBy(a => a.Tipo_Persona).ToList();
                    else if (cbxCriterio.Text.Equals("Departamento"))
                        dgvEmpleados.DataSource = empleados.OrderBy(a => a.Codigo_Departamento).ToList();
                    else if (cbxCriterio.Text.Equals("Valor"))
                        dgvEmpleados.DataSource = empleados.OrderBy(a => a.Estado).ToList();
                    else
                        dgvEmpleados.DataSource = empleados.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DeptName()
        {
            foreach (DataGridViewRow item in dgvEmpleados.Rows)
            {
                int id = int.Parse(item.Cells["Id_Dept"].Value.ToString());

                using (ActivosEntities db = new ActivosEntities())
                {
                    string deptName = db.Departamento
                        .FirstOrDefault(d => d.Codigo_Departamento == id).Nombre;

                    item.Cells["Departamento"].Value = deptName;
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            GetEmpleados(txtBuscar.Text);
            DeptName();
        }

        private void cbxCriterio_SelectedValueChanged(object sender, EventArgs e)
        {
            GetEmpleados(txtBuscar.Text);
            DeptName();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmEmpleadosForm frm = new frmEmpleadosForm();
            frm.ShowDialog();
        }

        private void dgvEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmEmpleadosForm frm = new frmEmpleadosForm();
            var row = dgvEmpleados.CurrentRow;

            frm.isEditing = true;
            frm.Id = (int) row.Cells["Id"].Value;
            frm.Nombre = row.Cells["Nombre"].Value.ToString();
            frm.Apellido = row.Cells["Apellido"].Value.ToString();
            frm.Cedula = row.Cells["Cedula"].Value.ToString();
            frm.Departamento = row.Cells["Departamento"].Value.ToString();
            frm.Tipo_Persona = row.Cells["Tipo"].Value.ToString();
            frm.Fecha_Ingreso = DateTime.Parse(row.Cells["Fecha"].Value.ToString());
            frm.Estado = row.Cells["Estado"].Value.ToString();

            frm.ShowDialog();
        }

        private void frmEmpleados_Activated(object sender, EventArgs e)
        {
            GetEmpleados(txtBuscar.Text);
            DeptName();
        }

        private void frmEmpleados_FormClosing(object sender, FormClosingEventArgs e)
        {
            menu.Show();
        }
    }
}

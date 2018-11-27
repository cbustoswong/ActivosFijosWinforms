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
    public partial class frmActivosFijos : Form
    {
        public frmMenu menu = null;

        public frmActivosFijos()
        {
            InitializeComponent();
            dgvActivos.AutoGenerateColumns = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            GetActivos(txtBuscar.Text);
            ParseIds();
        }

        private void GetActivos(string search)
        {
            using (ActivosEntities db = new ActivosEntities())
            {
                if (!(search.Trim().Length > 0))
                {
                    if (cbxCriterio.Text.Equals("Tipo"))
                        dgvActivos.DataSource = db.Activos_Fijos.OrderBy(a => a.Tipo_Activo.Descripcion).ToList();
                    else if (cbxCriterio.Text.Equals("Departamento"))
                        dgvActivos.DataSource = db.Activos_Fijos.OrderBy(a => a.Departamento.Nombre).ToList();
                    else if (cbxCriterio.Text.Equals("Valor"))
                        dgvActivos.DataSource = db.Activos_Fijos.OrderBy(a => a.Valor_Compra).ToList();
                    else
                        dgvActivos.DataSource = db.Activos_Fijos.ToList();

                    return;
                }

                var activos = db.Activos_Fijos.Where(a => a.Descripcion.Contains(search) || a.Tipo_Activo.Descripcion.Contains(search)
                    || a.Departamento.Nombre.Contains(search) || a.Ubicacion.Descripcion.Contains(search));

                if (cbxCriterio.Text.Equals("Tipo"))
                    dgvActivos.DataSource = activos.OrderBy(a => a.Tipo_Activo.Descripcion).ToList();
                else if (cbxCriterio.Text.Equals("Departamento"))
                    dgvActivos.DataSource = activos.OrderBy(a => a.Departamento.Nombre).ToList();
                else if (cbxCriterio.Text.Equals("Valor"))
                    dgvActivos.DataSource = activos.OrderBy(a => a.Valor_Compra).ToList();
                else
                    dgvActivos.DataSource = activos.ToList();
            }
        }

        private void cbxCriterio_SelectedValueChanged(object sender, EventArgs e)
        {
            GetActivos("");
            ParseIds();
        }

        private void frmActivosFijos_Load(object sender, EventArgs e)
        {
            cbxCriterio.SelectedIndex = 0;
            GetActivos("");
            ParseIds();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmActivosFijosForm frm = new frmActivosFijosForm();
            frm.ShowDialog();
        }

        private void frmActivosFijos_FormClosing(object sender, FormClosingEventArgs e)
        {
            menu.Show();
        }

        private void dgvActivos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmActivosFijosForm frm = new frmActivosFijosForm();
            var row = dgvActivos.CurrentRow;

            frm.isEditing = true;
            frm.Id = (int)row.Cells["Codigo_Activo"].Value;
            frm.Descripcion = row.Cells["Descripcion"].Value.ToString();
            frm.Departamento = row.Cells["Departamento"].Value.ToString();
            frm.Ubicacion = row.Cells["Ubicacion"].Value.ToString();
            frm.Tipo = row.Cells["Tipo"].Value.ToString();
            frm.Fecha = DateTime.Parse(row.Cells["Fecha"].Value.ToString());
            frm.Valor = decimal.Parse(row.Cells["Valor"].Value.ToString());

            frm.ShowDialog();
        }

        private void ParseIds()
        {
            foreach (DataGridViewRow item in dgvActivos.Rows)
            {
                int deptId = int.Parse(item.Cells["Id_Dept"].Value.ToString());
                int ubicId = int.Parse(item.Cells["Id_Ubicacion"].Value.ToString());
                int tipoId = int.Parse(item.Cells["Id_TipoActivo"].Value.ToString());

                using (ActivosEntities db = new ActivosEntities())
                {
                    string deptName = db.Departamento
                        .FirstOrDefault(d => d.Codigo_Departamento == deptId).Nombre;
                    string ubicacion = db.Ubicacion.FirstOrDefault(u => u.Codigo_Ubicacion == ubicId).Descripcion;
                    string tipo = db.Tipo_Activo.FirstOrDefault(t => t.Codigo_TipoActivo == tipoId).Descripcion;

                    item.Cells["Departamento"].Value = deptName;
                    item.Cells["Ubicacion"].Value = ubicacion;
                    item.Cells["Tipo"].Value = tipo;
                }
            }
        }

        private void frmActivosFijos_Activated(object sender, EventArgs e)
        {
            GetActivos(txtBuscar.Text);
            ParseIds();
        }
    }
}

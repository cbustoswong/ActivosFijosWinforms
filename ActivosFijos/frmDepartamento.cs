using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ActivosFijos.Models;

namespace ActivosFijos
{
    public partial class frmDepartamento : Form
    {
        public frmDepartamento()
        {
            InitializeComponent();
            dgvDepartamento.AutoGenerateColumns = false;
        }

        private void GetDepartamento(string search)
        {
            using (var db = new ActivosEntities())
            {
                try
                {
                    if (!(search.Trim().Length > 0))
                    {
 
                            dgvDepartamento.DataSource = db.Departamento.ToList();

                        return;
                    }

                    var departamentos = db.Departamento.Where(a => a.Nombre.Contains(search));

                        dgvDepartamento.DataSource = departamentos.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void frmDepartamento_Load(object sender, EventArgs e)
        {
            GetDepartamento("");

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            GetDepartamento(txtBuscar.Text);
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmDepartamentoForm frm = new frmDepartamentoForm();
            frm.ShowDialog();
        }

        private void dgvDepartamento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmDepartamentoForm frm = new frmDepartamentoForm();
            var row = dgvDepartamento.CurrentRow;

            frm.isEditing = true;
            frm.Id = (int)row.Cells["Id"].Value;
            frm.Departamento = row.Cells["Nombre"].Value.ToString();

            frm.ShowDialog();
        }

        private void frmDepartamento_Activated(object sender, EventArgs e)
        {
            GetDepartamento(txtBuscar.Text);
        }
    }
}

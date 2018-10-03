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
                            dgvDepartamento.DataSource = db.Departamento.Include("Nombre").OrderBy(a => a.Nombre).ToList();
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void frmDepartamento_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            GetDepartamento(txtBuscar.Text);
        }
    }
}

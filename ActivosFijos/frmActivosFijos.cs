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
        public frmActivosFijos()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            GetActivos(txtBuscar.Text);
        }

        private void GetActivos(string search)
        {
            using (ActivosEntities db = new ActivosEntities())
            {
                if (!(search.Trim().Length > 0))
                {
                    if (cbxCriterio.Text.Equals("Tipo"))
                        dgvActivos.DataSource = db.Activos_Fijos.OrderBy(a => a.Tipo_Activo).ToList();
                    else if (cbxCriterio.Text.Equals("Departamento"))
                        dgvActivos.DataSource = db.Activos_Fijos.OrderBy(a => a.Departamento).ToList();
                    else if (cbxCriterio.Text.Equals("Valor"))
                        dgvActivos.DataSource = db.Activos_Fijos.OrderBy(a => a.Valor_Compra).ToList();
                    else
                        dgvActivos.DataSource = db.Activos_Fijos.ToList();

                    return;
                }

                var activos = db.Activos_Fijos.Where(a => a.Descripcion.Contains(search) /*|| a.Codigo_TipoActivo.Contains(search)*/);

                if (cbxCriterio.Text.Equals("Tipo"))
                    dgvActivos.DataSource = activos.OrderBy(a => a.Tipo_Activo).ToList();
                else if (cbxCriterio.Text.Equals("Departamento"))
                    dgvActivos.DataSource = activos.OrderBy(a => a.Departamento).ToList();
                else if (cbxCriterio.Text.Equals("Valor"))
                    dgvActivos.DataSource = activos.OrderBy(a => a.Valor_Compra).ToList();
                else
                    dgvActivos.DataSource = activos.ToList();
            }
        }

        private void cbxCriterio_SelectedValueChanged(object sender, EventArgs e)
        {
            GetActivos("");
        }

        private void frmActivosFijos_Load(object sender, EventArgs e)
        {
            cbxCriterio.SelectedIndex = 0;
            GetActivos("");
        }
    }
}

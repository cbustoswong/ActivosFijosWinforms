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
    public partial class frmUbicacion : Form
    {
        public frmUbicacion()
        {
            InitializeComponent();
            dgvUbicacion.AutoGenerateColumns = false;
        }

        private void GetUbicacion(string search)
        {
            using (var db = new ActivosEntities())
            {
                try
                {
                    if (!(search.Trim().Length > 0))
                    {
                        if (cbxCriterio.Text.Equals("Estado"))
                            dgvUbicacion.DataSource = db.Ubicacion.OrderBy(a => a.Estado).ToList();
                        else
                            dgvUbicacion.DataSource = db.Ubicacion.ToList();
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            GetUbicacion(txtBuscar.Text);
        }

        private void cbxCriterio_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetUbicacion(txtBuscar.Text);
        }

        private void cbxCriterio_SelectedValueChanged(object sender, EventArgs e)
        {
            GetUbicacion(txtBuscar.Text);
        }

        private void frmUbicacion_Activated(object sender, EventArgs e)
        {
            GetUbicacion(txtBuscar.Text);

        }

        private void frmUbicacion_Load(object sender, EventArgs e)
        {
            GetUbicacion("");
            cbxCriterio.SelectedIndex = 0;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
        }
    }
}

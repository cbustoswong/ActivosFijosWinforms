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
    public partial class frmParametros : Form
    {
        public frmParametros()
        {
            InitializeComponent();
        }

        #region Eventos
        private void frmParametros_Load(object sender, EventArgs e)
        {
            cbxCriterio.SelectedIndex = 0;
            GetParametros("");
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            GetParametros(txtBuscar.Text);
        }
        private void cbxCriterio_SelectedValueChanged(object sender, EventArgs e)
        {
            GetParametros(txtBuscar.Text);
        }
        private void frmParametros_Activated(object sender, EventArgs e)
        {
            GetParametros(txtBuscar.Text);
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmParametrosForm frm = new frmParametrosForm();
            frm.ShowDialog();
        }
        private void dgvParametros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmParametrosForm frm = new frmParametrosForm();
            var row = dgvParametros.CurrentRow;

            frm.isEditing = true;
            frm.Id = (int)row.Cells["Id"].Value;
            frm.AnoMesProceso = DateTime.Parse(row.Cells["Ano_Mes_Proceso"].Value.ToString());
            frm.Deprec_Calculada = bool.Parse(row.Cells["Deprec_Calculada"].Value.ToString());
            frm.RNC_Empresa  = row.Cells["RNC_Empresa"].Value.ToString();
            frm.Met_Depreciacion = row.Cells["Met_Drepeciacion"].Value.ToString();

            frm.ShowDialog();
        }
        #endregion

        #region Metodos
        private void GetParametros(string search)
        {
            using (var db = new ActivosEntities())
            {
                try
                {
                  
                    if (!(search.Trim().Length > 0))
                    {
                        if (cbxCriterio.Text.Equals("Año/Mes"))
                            dgvParametros.DataSource = db.Parametro.OrderBy(a => a.Ano_Mes_Proceso).ToList();

                        else if (cbxCriterio.Text.Equals("RNC"))
                            dgvParametros.DataSource = db.Parametro.OrderBy(a => a.RNC_Empresa).ToList();
                        //else
                        //    dgvProveedores.DataSource = db.Empleado.Include("Departamento").ToList();

                        return;
                    }

                    var parametros = db.Parametro.Where(a => a.RNC_Empresa.Contains(search));

                    if (cbxCriterio.Text.Equals("Año/Mes"))
                        dgvParametros.DataSource = parametros.OrderBy(a => a.Ano_Mes_Proceso).ToList();

                    else if (cbxCriterio.Text.Equals("RNC"))
                        dgvParametros.DataSource = parametros.OrderBy(a => a.RNC_Empresa).ToList();
                    else
                        dgvParametros.DataSource = parametros.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.InnerException);
                }
            }
        }

        #endregion

    }
}

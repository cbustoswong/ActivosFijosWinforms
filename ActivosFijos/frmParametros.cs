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
                        if (cbxCriterio.Text.Equals("Año"))
                            dgvParametros.DataSource = db.Proveedor.OrderBy(a => a.Tipo_Proveedor).ToList();

                        else if (cbxCriterio.Text.Equals("   Depreciacion calculada"))
                            dgvParametros.DataSource = db.Proveedor.OrderBy(a => a.Estado).ToList();
                        //else
                        //    dgvProveedores.DataSource = db.Empleado.Include("Departamento").ToList();

                        return;
                    }

                    var Proveedores = db.Proveedor.Where(a => a.Nombre.Contains(search) || a.Cedula_RNC.Contains(search));

                    if (cbxCriterio.Text.Equals("Tipo"))
                        dgvParametros.DataSource = Proveedores.OrderBy(a => a.Tipo_Proveedor).ToList();

                    else if (cbxCriterio.Text.Equals("Estado"))
                        dgvParametros.DataSource = Proveedores.OrderBy(a => a.Estado).ToList();
                    else
                        dgvParametros.DataSource = Proveedores.ToList();
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

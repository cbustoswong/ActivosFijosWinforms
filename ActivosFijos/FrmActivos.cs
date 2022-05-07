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
    public partial class FrmReportActivos : Form
    {
        public string Estado = "A";
        public FrmReportActivos()
        {
            InitializeComponent();
        }

        private void FrmActivos_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'ActivosFijosDataSet.Tipo_Activo' table. You can move, or remove it, as needed.
            this.tipo_ActivoTableAdapter.Fill(this.ActivosFijosDataSet.Tipo_Activo);
            // TODO: This line of code loads data into the 'ActivosFijosDataSet.Activos_Fijos' table. You can move, or remove it, as needed.
            this.Activos_FijosTableAdapter.Fill(this.ActivosFijosDataSet.Activos_Fijos);
            // TODO: This line of code loads data into the 'ActivosFijosDataSet.Departamento' table. You can move, or remove it, as needed.
            this.DepartamentoTableAdapter.Fill(this.ActivosFijosDataSet.Departamento);
            // TODO: This line of code loads data into the 'ActivosFijosDataSet.Ubicacion' table. You can move, or remove it, as needed.
            this.UbicacionTableAdapter.Fill(this.ActivosFijosDataSet.Ubicacion);

            var dt = this.ActivosFijosDataSet.Activos_Fijos.Where(x => x.Estado == Estado).CopyToDataTable();

            this.ActivosFijosDataSet.Activos_Fijos.Clear();
            
            for(var i=0; i < dt.Rows.Count; i++)
            {
                var r = dt.Rows[i];
                this.ActivosFijosDataSet.Activos_Fijos.Rows.Add(r.ItemArray);
            }
            


            this.reportViewer1.RefreshReport();
        }
    }
}

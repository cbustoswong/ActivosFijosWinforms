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

            this.reportViewer1.RefreshReport();
        }
    }
}

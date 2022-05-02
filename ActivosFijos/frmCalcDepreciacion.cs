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
    public partial class frmCalcDepreciacion : Form
    {
        double valorCompra = 0;
        double depAnual = 0;
        double depAcumulada = 0;
        double depRestante = 0;
        int digitoAnos = 0;

        public int IdActivo = 0;

        public frmCalcDepreciacion()
        {
            InitializeComponent();
        }

        private void frmCalcDepreciacion_Load(object sender, EventArgs e)
        {
            var db = new ActivosEntities();
            var Depreciacion = db.Calculo_Depreciacion.Where(x => x.Codigo_Activo_Fijo == IdActivo).OrderBy(x => x.Codigo_Registro).ToList();

            DataTable dt = new DataTable(); // Crea tabla en memoria
            dt.Clear();
            dt.Columns.Add("IdActivo");
            dt.Columns.Add("Activo");
            dt.Columns.Add("Mes"); // Crea columnas de dicha tabla  
            dt.Columns.Add("MontoDep");
            dt.Columns.Add("TotalDep");
            dt.Columns.Add("TotalRest");
            dt.Columns.Add("Fecha");
            dt.AcceptChanges();
            Depreciacion.ForEach(item => {
                DataRow fila = dt.NewRow();
                fila["IdActivo"] = item.Codigo_Activo_Fijo;
                fila["Activo"] = item.Activos_Fijos.Descripcion;
                fila["Mes"] = item.Fecha_Proceso.ToString("dd MMMM").ToUpper(); // Mueve valor a columnas de la tabla 
                fila["Fecha"] = item.Fecha_Proceso;
                fila["MontoDep"] = item.Monto_Depreciado;
                fila["TotalDep"] = item.Depreciacion_Acumulada;
                fila["TotalRest"] = item.Activos_Fijos.Valor_Compra - item.Depreciacion_Acumulada;
                dt.Rows.Add(fila);
            });
            dgvResultados.DataSource = dt;
            dgvResultados.Refresh(); // Muestra resultado en grid
            dgvResultados.Columns["IdActivo"].Visible = false;

        }
            
      
       
        private void BtnView_Click(object sender, EventArgs e)
        {
            FrmReportCalculo frm = new FrmReportCalculo();
            frm.ShowDialog();
        }

        private void rbDigAnos_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dgvResultados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


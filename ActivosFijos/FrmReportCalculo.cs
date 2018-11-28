using ActivosFijos.Models;
using Microsoft.Office.Interop.Excel;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActivosFijos
{
    public partial class FrmReportCalculo : Form
    {
        private string criterio = "Fechas";
        private ActivosEntities db = new ActivosEntities();

        struct DataParameter
        {
            public List<Calculo_Depreciacion> depreciaciones;
            public string FileName;
        }

        DataParameter parameters = new DataParameter();

        public FrmReportCalculo()
        {
            InitializeComponent();
        }

        private void FrmReportCalculo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ActivosFijosDataSet.Calculo_Depreciacion' table. You can move, or remove it, as needed.
            this.Calculo_DepreciacionTableAdapter.Fill(this.ActivosFijosDataSet.Calculo_Depreciacion);
            // TODO: This line of code loads data into the 'ActivosFijosDataSet.Activos_Fijos' table. You can move, or remove it, as needed.
            this.Activos_FijosTableAdapter.Fill(this.ActivosFijosDataSet.Activos_Fijos);

            this.reportViewer1.RefreshReport();

            cmbFilter.SelectedIndex = 0;
            dtpDesde.Value = DateTime.Now.AddMonths(-1);
            dtpHasta.Value = DateTime.Now;
        }

        private void cmbFilter_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbFilter.SelectedIndex == 0)
            {
                criterio = "Fechas";
                dtpDesde.Enabled = true;
                dtpDesde.Visible = true;
                dtpHasta.Enabled = true;
                dtpHasta.Visible = true;
            }
            else
            {
                criterio = "Valor en libro cero";
                dtpDesde.Enabled = false;
                dtpDesde.Visible = false;
                dtpHasta.Enabled = false;
                dtpHasta.Visible = false;
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            var hoy = DateTime.Now;

            if (bgWorker.IsBusy)
                return;

            using (SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "Excel|*.xlsx",
                FileName = $"ReporteDepreciacion-{hoy.Year}-{hoy.Month}-{hoy.Day}.xlsx"
            })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    parameters.FileName = sfd.FileName;
                    parameters.depreciaciones = db.Calculo_Depreciacion.Where(dep => DbFunctions.TruncateTime(dep.Fecha_Proceso) >= dtpDesde.Value.Date
                        && DbFunctions.TruncateTime(dep.Fecha_Proceso) <= dtpHasta.Value.Date).ToList();
                    //progressBar.Value = 0;
                    //progressBar.Minimum = 0;
                    bgWorker.RunWorkerAsync(parameters);
                }
            }
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var depres = ((DataParameter)e.Argument).depreciaciones;
            string filename = ((DataParameter)e.Argument).FileName;
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb = excel.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet ws = excel.Worksheets[1];
            excel.Visible = false;
            int index = 8;
            int process = depres.Count;

            ws.Cells[index, 1] = "Activo Fijo".ToUpper();
            ws.Cells[index, 2] = "Fecha de Proceso".ToUpper();
            ws.Cells[index, 3] = "Monto Depreciado".ToUpper();
            ws.Cells[index, 4] = "Depreciacion Acumulada".ToUpper();

            var headerRange = ws.Range["A8", "D8"];
            headerRange.Font.Bold = true;
            headerRange.Font.Color = Color.White;
            headerRange.Interior.Color = Color.DodgerBlue;

            ws.Cells[5, 1] = "Desde:";
            ws.Cells[5, 2] = dtpDesde.Value.ToShortDateString();
            ws.Cells[6, 1] = "Hasta:";
            ws.Cells[6, 2] = dtpHasta.Value.ToShortDateString();
            ws.Range["A5", "A6"].Font.Bold = true;
            ws.Cells[5, 4] = "Fecha de Reporte:";
            ws.Cells[5, 4].Font.Bold = true;
            ws.Cells[5, 5] = DateTime.Now.ToShortDateString();

            foreach (Calculo_Depreciacion dep in depres)
            {
                if (!bgWorker.CancellationPending)
                {
                    bgWorker.ReportProgress((index++ - 7) * 100 / process);

                    ws.Cells[index, 1] = dep.Activos_Fijos.Descripcion.ToString();
                    ws.Cells[index, 2] = dep.Fecha_Proceso.ToShortDateString();
                    ws.Cells[index, 3] = dep.Monto_Depreciado.ToString();
                    ws.Cells[index, 4] = dep.Depreciacion_Acumulada.ToString();


                    if (index % 2 == 0)
                        ws.Range[$"A{index}", $"D{index}"].Interior.Color = Color.LightBlue;
                    else
                        ws.Range[$"A{index}", $"D{index}"].Interior.Color = Color.AliceBlue;
                }
            }

            ws.Columns.AutoFit();
            var currentDir = System.Windows.Forms.Application.StartupPath;
            var range = ws.Range["A1", "G3"];
            range.Merge(false);
            range.Interior.Color = Color.White;

            ws.Shapes.AddPicture(currentDir + @"\unapeclogo.png", Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, 0, 0, 400, 45);

            ws.SaveAs(filename);
            excel.Quit();
        }

        private void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            lblProgress.Text = string.Format($"Procesando... {e.ProgressPercentage}%");
            progressBar.Update();
        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                Thread.Sleep(100);
                //lblProgress.Text = "Los datos han sido exportado exitosamente";
                progressBar.Value = 0;
                Process.Start(parameters.FileName);
            }
        }
    }
}

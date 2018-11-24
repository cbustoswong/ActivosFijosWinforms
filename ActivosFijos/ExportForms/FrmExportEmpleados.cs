using ActivosFijos.Models;
using ActivosFijos.Properties;
using Microsoft.Office.Interop.Excel;
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

namespace ActivosFijos.ExportForms
{
    public partial class FrmExportEmpleados : Form
    {
        struct DataParameter
        {
            public List<Empleado> empleados;
            public string FileName;
        }

        DataParameter parameters = new DataParameter();
        ActivosEntities db = new ActivosEntities();

        public FrmExportEmpleados()
        {
            InitializeComponent();
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var empleados = ((DataParameter)e.Argument).empleados;
            string filename = ((DataParameter)e.Argument).FileName;
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb = excel.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet ws = excel.Worksheets[1];
            excel.Visible = false;
            int index = 8;
            int process = empleados.Count;

            ws.Cells[index, 1] = "Nombre".ToUpper();
            ws.Cells[index, 2] = "Apellido".ToUpper();
            ws.Cells[index, 3] = "Cedula".ToUpper();
            ws.Cells[index, 4] = "Departamento".ToUpper();
            ws.Cells[index, 5] = "Tipo".ToUpper();
            ws.Cells[index, 6] = "Fecha de Ingreso".ToUpper();
            ws.Cells[index, 7] = "Estado".ToUpper();

            var headerRange = ws.Range["A8", "G8"];
            headerRange.Font.Bold = true;
            headerRange.Font.Color = Color.White;
            headerRange.Interior.Color = Color.DodgerBlue;

            ws.Cells[5, 1] = "Desde:";
            ws.Cells[5, 2] = dtpFrom.Value.ToShortDateString();
            ws.Cells[6, 1] = "Hasta:";
            ws.Cells[6, 2] = dtpTo.Value.ToShortDateString();
            ws.Range["A5", "A6"].Font.Bold = true;
            ws.Cells["D5"] = "Fecha de Reporte:";
            ws.Cells["D5"].Font.Bold = true;
            ws.Cells["E5"] = DateTime.Now.ToShortDateString();

            foreach (Empleado emp in empleados)
            {
                if (!bgWorker.CancellationPending)
                {
                    bgWorker.ReportProgress((index++ - 8) * 100 / process);

                    ws.Cells[index, 1] = emp.Nombre.ToString();
                    ws.Cells[index, 2] = emp.Apellido.ToString();
                    ws.Cells[index, 3] = emp.Cedula.ToString();
                    ws.Cells[index, 4] = emp.Departamento.Nombre.ToString();
                    ws.Cells[index, 5] = emp.Tipo_Persona.ToString();
                    ws.Cells[index, 6] = emp.Fecha_Ingreso.ToShortDateString();
                    ws.Cells[index, 7] = emp.Estado.ToString();

                    if (index % 2 == 0)
                        ws.Range[$"A{index}", $"G{index}"].Interior.Color = Color.LightBlue;
                    else
                        ws.Range[$"A{index}", $"G{index}"].Interior.Color = Color.AliceBlue;
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
                lblProgress.Text = "Los datos han sido exportado exitosamente";
                progressBar.Value = 0;
                Process.Start(parameters.FileName);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            var hoy = DateTime.Now;

            if (bgWorker.IsBusy)
                return;

            using (SaveFileDialog sfd = new SaveFileDialog() {
                Filter = "Excel|*.xlsx",
                FileName = $"ReporteEmpleados-{hoy.Year}-{hoy.Month}-{hoy.Day}.xlsx"
            })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    parameters.FileName = sfd.FileName;
                    parameters.empleados = db.Empleado.Where(emp => DbFunctions.TruncateTime(emp.Fecha_Ingreso) >= dtpFrom.Value.Date 
                        && DbFunctions.TruncateTime(emp.Fecha_Ingreso) <= dtpTo.Value.Date).ToList();
                    progressBar.Value = 0;
                    progressBar.Minimum = 0;
                    bgWorker.RunWorkerAsync(parameters);
                }
            }
        }

        private void FrmExportEmpleados_Load(object sender, EventArgs e)
        {
            dtpTo.Value = DateTime.Now;
            dtpFrom.Value = DateTime.Now.AddMonths(-1);
        }
    }
}

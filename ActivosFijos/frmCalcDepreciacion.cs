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


        public frmCalcDepreciacion()
        {
            InitializeComponent();
        }

        private void frmCalcDepreciacion_Load(object sender, EventArgs e)
        {

        }

        private void cmdCalcular_Click(object sender, EventArgs e)
        {
            //try
            //{
            var db = new ActivosEntities();

            var ActivosFijos = db.Activos_Fijos.ToList();
            var ActivosCalculados = db.Calculo_Depreciacion.ToList();


            DataTable dt = new DataTable(); // Crea tabla en memoria
            dt.Clear();
            dt.Columns.Add("IdActivo");
            dt.Columns.Add("Activo");
            dt.Columns.Add("Mes"); // Crea columnas de dicha tabla  
            dt.Columns.Add("MontoDep");
            dt.Columns.Add("TotalDep");
            dt.Columns.Add("TotalRest");
            dt.Columns.Add("Fecha");
            double depAcumulada = 0;
            digitoAnos = 0;


            foreach (var activo in ActivosFijos)
            {
                valorCompra = 0;
                depAnual = 0;
                depAcumulada = 0;
                depRestante = 0;
                digitoAnos = 0;
                dtpFecha.Value = DateTime.Now;
                int ContadorFecha = 0;

                bool Calculado = false;

                foreach (var deprec in ActivosCalculados)
                {
                    if (deprec.Codigo_Activo_Fijo == activo.Codigo_Activo)
                    {
                        Calculado = true;
                        break;
                    }
                }

                if (Calculado == false)
                {
                    valorCompra = (double)activo.Valor_Compra;

                    for (int anoDep = 1; anoDep <= nudAnosDep.Value; anoDep++)
                        digitoAnos += anoDep;

                    for (int anoDep = 1; anoDep <= nudAnosDep.Value; anoDep++)
                    {
                        if (rbLineaRecta.Checked)
                            depAnual = valorCompra / (int)nudAnosDep.Value;
                        else
                            depAnual = (valorCompra * anoDep) / digitoAnos;

                        depAcumulada += depAnual;
                        depRestante = valorCompra - depAcumulada;

                        DataRow fila = dt.NewRow();
                        fila["IdActivo"] = activo.Codigo_Activo;
                        fila["Activo"] = activo.Descripcion;
                        fila["Mes"] = anoDep; // Mueve valor a columnas de la tabla 
                        fila["Fecha"] = dtpFecha.Value.AddMonths(ContadorFecha); ContadorFecha++;
                        fila["MontoDep"] = depAnual.ToString("#,##0.00");
                        fila["TotalDep"] = depAcumulada.ToString("#,##0.00");
                        fila["TotalRest"] = depRestante.ToString("#,##0.00");
                        dt.Rows.Add(fila);
                    }

                    dgvResultados.DataSource = dt;
                    dgvResultados.Refresh(); // Muestra resultado en grid
                }

            }


            if (dgvResultados.Rows.Count == 0)
            {
                MessageBox.Show("Todos los activos registrados ya han sido calculados", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvResultados.Rows.Count > 0)
                {
                    DataTable dtTabla = (DataTable)dgvResultados.DataSource;

                    for (int i = 0; i <= dtTabla.Rows.Count - 1; i++)
                    {
                        int idActivo = Convert.ToInt32(dtTabla.Rows[i]["IdActivo"]);
                        decimal MontoDep = Convert.ToDecimal(dtTabla.Rows[i]["MontoDep"]);
                        decimal DepAcum = Convert.ToDecimal(dtTabla.Rows[i]["TotalDep"]);
                        DateTime Fecha = Convert.ToDateTime(dtTabla.Rows[i]["Fecha"]);

                        InsertarActivoCalculado(idActivo, MontoDep, DepAcum, Fecha);
                    }

                    MessageBox.Show("Depreciacion calculada con exito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Primero debe calcular la depreciacion", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void InsertarActivoCalculado(int IdActivo, decimal MontoDepreciado, decimal DepreciacionAcumulada, DateTime Fecha)
        {
            try
            {
                using (ActivosEntities db = new ActivosEntities())
                {
                    Calculo_Depreciacion CalcDeprec = new Calculo_Depreciacion
                    {
                        Codigo_Activo_Fijo = IdActivo,
                        Fecha_Proceso = Fecha,
                        Monto_Depreciado = MontoDepreciado,
                        Depreciacion_Acumulada = DepreciacionAcumulada

                    };

                    db.Calculo_Depreciacion.Add(CalcDeprec);

                    db.SaveChanges();
                    Close();
                }

            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}


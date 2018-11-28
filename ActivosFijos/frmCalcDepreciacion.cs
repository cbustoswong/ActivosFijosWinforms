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



                DataTable dt = new DataTable(); // Crea tabla en memoria
                dt.Clear();
                dt.Columns.Add("IdActivo");
                dt.Columns.Add("Activo");
                dt.Columns.Add("Mes"); // Crea columnas de dicha tabla  
                dt.Columns.Add("MontoDep");
                dt.Columns.Add("TotalDep");
                dt.Columns.Add("TotalRest");
                double depAcumulada = 0;
                digitoAnos = 0;

                foreach (var activo in ActivosFijos)
                {
                 valorCompra = 0;
                depAnual = 0;
                 depAcumulada = 0;
                 depRestante = 0;
                digitoAnos = 0;


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
                        fila["MontoDep"] = depAnual;
                        fila["TotalDep"] = depAcumulada;
                        fila["TotalRest"] = depRestante;
                        dt.Rows.Add(fila);
                    }

                    dgvResultados.DataSource = dt;
                    dgvResultados.Refresh(); // Muestra resultado en grid
                }
            //}

            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);


            //}


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
                        decimal MontoDep = Convert.ToDecimal( dtTabla.Rows[i]["MontoDep"]);
                        decimal DepAcum = Convert.ToDecimal( dtTabla.Rows[i]["TotalDep"]);

                        InsertarActivoCalculado(idActivo, MontoDep, DepAcum);
                    }
                }
                else
                {
                    MessageBox.Show("Primero debe calcular la depreciacion");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
            private void InsertarActivoCalculado(int IdActivo, decimal MontoDepreciado, decimal DepreciacionAcumulada)
            {
            try
            {
                using (ActivosEntities db = new ActivosEntities())
                {
                    Calculo_Depreciacion CalcDeprec = new Calculo_Depreciacion
                    {
                        Codigo_Activo_Fijo = IdActivo,
                        Fecha_Proceso = dtpFecha.Value,
                        Monto_Depreciado = MontoDepreciado,
                        Depreciacion_Acumulada = DepreciacionAcumulada

                    };

                    db.Calculo_Depreciacion.Add(CalcDeprec);

                    db.SaveChanges();

                    Close();
                }
                MessageBox.Show("Depreciacion insertada con exito");
            }


                catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        }
    }


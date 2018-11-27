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

        private void cmdCalcular_Click(object sender, EventArgs e)
        {
            var db = new ActivosEntities();

            var ActivosFijos = db.Activos_Fijos.ToList();

          

            //try
            //{
            //    valorCompra = double.Parse(txtValorCompra.Text);
            //}

            //catch (Exception ex)
            //{
            //    MessageBox.Show("El valor de compra no es un monto valido");
            //    txtValorCompra.Focus();
            //    return;
            //}

            DataTable dt = new DataTable(); // Crea tabla en memoria
            dt.Clear();
            dt.Columns.Add("Activo");
            dt.Columns.Add("Mes"); // Crea columnas de dicha tabla  
            dt.Columns.Add("MontoDep");
            dt.Columns.Add("TotalDep");
            dt.Columns.Add("TotalRest");
            double depAcumulada = 0;
            digitoAnos = 0;

            foreach (var activo in ActivosFijos)
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
        }
        //private void GetActivos(string search)
        //{
        //    using (var db = new ActivosEntities())
        //    {
        //        try
        //        {
        //            DataTable dtActivos = new DataTable();

                   

        //            var ubicacion = db.Activos_Fijos.Where(a => a.Descripcion.Contains(search));

        //            dtActivos = (DataTubicacion.OrderBy(a => a.Descripcion).ToList();

        //            if (cbxCriterio.Text.Equals("Descripcion"))
        //                dgvUbicacion.DataSource = ubicacion.OrderBy(a => a.Descripcion).ToList();
        //            else if (cbxCriterio.Text.Equals("Direccion"))
        //                dgvUbicacion.DataSource = ubicacion.OrderBy(a => a.Direccion).ToList();
        //            else
        //                dgvUbicacion.DataSource = ubicacion.ToList();
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message);
        //        }
        //    }
        //}
    }
}

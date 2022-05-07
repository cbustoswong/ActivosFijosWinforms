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
    public partial class frmActivosFijos : Form
    {
        public frmMenu menu = null;

        public frmActivosFijos()
        {
            InitializeComponent();
            dgvActivos.AutoGenerateColumns = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            GetActivos(txtBuscar.Text);
            ParseIds();
        }

        private void GetActivos(string search,string Opcion ="A")
        {
            using (ActivosEntities db = new ActivosEntities())
            {
                var activos = db.v_Activosfijos.Where(x=>x.Estado==Opcion).ToList();

                if (!(search.Trim().Length > 0))
                {
                    if (cbxCriterio.Text.Equals("Tipo"))
                        dgvActivos.DataSource = activos.OrderBy(a => a.TipoActivo).ToList();//db.Activos_Fijos.OrderBy(a => a.Tipo_Activo.Descripcion).ToList();
                    else if (cbxCriterio.Text.Equals("Departamento"))
                        dgvActivos.DataSource = activos.OrderBy(a => a.Departamento).ToList();//db.Activos_Fijos.OrderBy(a => a.Departamento.Nombre).ToList();
                    else if (cbxCriterio.Text.Equals("Valor"))
                        dgvActivos.DataSource = activos.OrderByDescending(a => a.ValorCompra).ToList();//db.Activos_Fijos.OrderByDescending(a => a.Valor_Compra).ToList();
                    else if (cbxCriterio.Text.Equals("Fecha"))
                        dgvActivos.DataSource = activos.OrderByDescending(a => a.FechaCompra).ToList();//db.Activos_Fijos.OrderBy(a => a.Fecha_Registro).ToList();
                    else
                        dgvActivos.DataSource = activos;//db.Activos_Fijos.ToList();

                    return;
                }

                var activoList = activos.Where(a => a.Descripcion.Contains(search) || a.TipoActivo.Contains(search)
                    || a.Departamento.Contains(search) || a.Ubicacion.Contains(search));

                if (cbxCriterio.Text.Equals("Tipo"))
                    dgvActivos.DataSource = activoList.OrderBy(a => a.TipoActivo).ToList();
                else if (cbxCriterio.Text.Equals("Departamento"))
                    dgvActivos.DataSource = activoList.OrderBy(a => a.Departamento).ToList();
                else if (cbxCriterio.Text.Equals("Valor"))
                    dgvActivos.DataSource = activoList.OrderByDescending(a => a.ValorCompra).ToList();
                else if (cbxCriterio.Text.Equals("Fecha"))
                    dgvActivos.DataSource = activoList.OrderBy(a => a.FechaCompra).ToList();
                else
                    dgvActivos.DataSource = activoList.ToList();
            }
        }

        private void cbxCriterio_SelectedValueChanged(object sender, EventArgs e)
        {
            GetActivos("");
            ParseIds();
        }

        private void frmActivosFijos_Load(object sender, EventArgs e)
        {
            cbxCriterio.SelectedIndex = 0;
            GetActivos("");
            ParseIds();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmActivosFijosForm frm = new frmActivosFijosForm();
            frm.menu = this.menu;
            frm.ShowDialog();
        }

        private void frmActivosFijos_FormClosing(object sender, FormClosingEventArgs e)
        {
            menu.Show();
        }

        private void dgvActivos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmActivosFijosForm frm = new frmActivosFijosForm();
            var row = dgvActivos.CurrentRow;

            frm.isEditing = true;
            frm.Id = (int)row.Cells["Codigo_Activo"].Value;
            frm.Descripcion = row.Cells["Descripcion"].Value.ToString();
            frm.Departamento = row.Cells["Departamento"].Value.ToString();
            frm.Ubicacion = row.Cells["Ubicacion"].Value.ToString();
            frm.Tipo = row.Cells["Tipo"].Value.ToString();
            frm.Fecha = DateTime.Parse(row.Cells["Fecha"].Value.ToString());
            frm.Valor = decimal.Parse(row.Cells["Valor"].Value.ToString());
            frm.menu = this.menu;
            frm.ShowDialog();

            GetActivos(txtBuscar.Text);
            ParseIds();
        }

        private void ParseIds()
        {
            //foreach (DataGridViewRow item in dgvActivos.Rows)
            //{
            //    //int activoId = int.Parse(item.Cells["Codigo"].Value.ToString());
            //    //int deptId = int.Parse(item.Cells["Id_Dept"].Value.ToString());
            //    //int ubicId = int.Parse(item.Cells["Id_Ubicacion"].Value.ToString());
            //    //int tipoId = int.Parse(item.Cells["Id_TipoActivo"].Value.ToString());

            //    //using (ActivosEntities db = new ActivosEntities())
            //    //{
            //    //    Activos_Fijos activo = db.Activos_Fijos.FirstOrDefault(a => a.Codigo_Activo == activoId);
            //    //    string deptName = db.Departamento
            //    //        .FirstOrDefault(d => d.Codigo_Departamento == deptId).Nombre;
            //    //    string ubicacion = db.Ubicacion.FirstOrDefault(u => u.Codigo_Ubicacion == ubicId).Descripcion;
            //    //    string tipo = db.Tipo_Activo.FirstOrDefault(t => t.Codigo_TipoActivo == tipoId).Descripcion;

            //    //    item.Cells["Departamento"].Value = deptName;
            //    //    item.Cells["Ubicacion"].Value = ubicacion;
            //    //    item.Cells["Tipo"].Value = tipo;

            //    //    if (activo.Calculo_Depreciacion.Count > 0)
            //    //    {
            //    //        Calculo_Depreciacion depre = activo.Calculo_Depreciacion.OrderBy(a => a.Fecha_Proceso).Last();

            //    //        item.Cells["Depreciacion"].Value = depre.Depreciacion_Acumulada;
            //    //    }
            //    //    else
            //    //        item.Cells["Depreciacion"].Value = "0.00";
            //    //}
            //}
        }

        private void frmActivosFijos_Activated(object sender, EventArgs e)
        {
            GetActivos(txtBuscar.Text);
            ParseIds();
        }

        private void btnDepreciacion_Click(object sender, EventArgs e)
        {
            if (dgvActivos.SelectedRows.Count == 0)
            {
                MessageBox.Show("No ha seleccionado Activo a revisar la depreciacion.");
                return;
            }
            else
            {
                frmCalcDepreciacion frm = new frmCalcDepreciacion();
                var row = dgvActivos.CurrentRow;
                frm.IdActivo = (int)row.Cells["Codigo_Activo"].Value;
                frm.ShowDialog();
            }
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            var Estado = (radioButton1.Checked) ? "A" : ((radioButton2.Checked) ? "I" : "B");
            FrmReportActivos frm = new FrmReportActivos();
            frm.Estado = Estado;
            frm.ShowDialog();
        }

        private void dgvActivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            if (dgvActivos.SelectedRows.Count == 0)
            {
                MessageBox.Show("No ha seleccionado Activo a Transferir.");
                return;
            }
            else
            {
                frmTransferir frm = new frmTransferir();
                var row = dgvActivos.CurrentRow;

                frm.isEditing = true;
                frm.Id = (int)row.Cells["Codigo_Activo"].Value;
                frm.menu = this.menu;
                frm.ShowDialog();
            }
        }

        private void LogMovimientos(int Id, string Tipo)
        {
            using (ActivosEntities db = new ActivosEntities())
            {
                var af = db.Activos_Fijos.Where(x => x.Codigo_Activo == Id).FirstOrDefault();
                MovimientosActivos mov = new MovimientosActivos
                {
                    Codigo_Activo_Fijo = Id,
                    Tipo_Movimiento = Tipo,
                    Fecha_Movimiento = DateTime.Now,
                    Codigo_Ubicacion = af.Codigo_Ubicacion,
                    Codigo_TipoActivo = af.Codigo_TipoActivo,
                    Codigo_Proveedor = af.Codigo_Proveedor,
                    Codigo_Departamento = af.Codigo_Departamento,
                    Codigo_Responsable = af.Codigo_Responsable,
                    Codigo_Usuario = menu.usuario.Id,
                    Descripcion = af.Descripcion,
                    Depreciar = af.Depreciar,
                    Estado = af.Estado,
                    Valor = af.Valor_Compra
                };
                db.MovimientosActivos.Add(mov);
                db.SaveChanges();
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (dgvActivos.SelectedRows.Count == 0)
            {
                MessageBox.Show("No ha seleccionado Activo a dar de Baja.");
                return;
            }
            else
            {
                frmTransferir frm = new frmTransferir();
                var row = dgvActivos.CurrentRow;
                var Id = (int)row.Cells["Codigo_Activo"].Value;
                using (ActivosEntities db = new ActivosEntities())
                {
                    var Saldo = Math.Round(Convert.ToDecimal(db.v_Activosfijos.Where(x => x.Codigo == Id).FirstOrDefault().PorDepreciar), 2);
                    var Depreciar = db.v_Activosfijos.Where(x => x.Codigo == Id).FirstOrDefault().Depreciar;
                    var Titulo = db.v_Activosfijos.Where(x => x.Codigo == Id).FirstOrDefault().Descripcion;

                    if (Depreciar=="S" && Saldo > 0)
                    {
                        DialogResult dialogResult = MessageBox.Show("Todavia esta depreciandose este Activo.\n\n¿Seguro desea dar de baja este Activo?", Titulo, MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.No)
                            return;
                    }
                    if(Depreciar=="N" || Saldo == 0)
                    {
                        DialogResult dialogResult = MessageBox.Show("¿Seguro desea dar de baja este Activo?", Titulo, MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.No)
                            return;
                    }

                    var activo = db.Activos_Fijos.Where(x => x.Codigo_Activo == Id).FirstOrDefault();
                    var activoDB = db.Activos_Fijos.Where(x => x.Codigo_Activo == Id).FirstOrDefault();

                    activo.Estado = "B";
                    db.Entry(activoDB).State = System.Data.Entity.EntityState.Detached;
                    db.Entry(activo).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                    LogMovimientos(Id, "BAJA");

                    GetActivos(txtBuscar.Text);
                    ParseIds();
                }
                
                    
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            btnExcel.Enabled = false;
            try
            {
                Task.Run(() =>
                {
                    Exportacion.ClsExcel excel = new Exportacion.ClsExcel();

                    ActivosFijosDataSet._v_ActivosfijosDataTable tb = new ActivosFijosDataSet._v_ActivosfijosDataTable();
                    ActivosFijosDataSetTableAdapters.v_ActivosfijosTableAdapter adap = new ActivosFijosDataSetTableAdapters.v_ActivosfijosTableAdapter();
                    adap.Fill(tb);
                    var Estado = (radioButton1.Checked) ? "A" : ((radioButton2.Checked) ? "I" : "B");

                    var data = tb.Where(x => x.Estado == Estado).CopyToDataTable();

                    excel.DatosExcel = data;
                    excel.NombreEmpresa = "Empresa ABC";
                    excel.TituloReporte = "Listado de Activos Fijos";
                    excel.NombreFile = $"Af{DateTime.Now.ToString("yyMMddHHmmss")}.xlsx";
                    excel.InicializaHoja();
                    excel.PoneEncabezado();

                    excel.AutoFitColumns = true;
                    excel.Escritorio = true;
                    excel.LLenaHoja();
                    excel.Terminar();
                }).Wait();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                btnExcel.Enabled = true;
            }
           
        }

        private void cbxCriterio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                GetActivos(txtBuscar.Text, "I");
                ParseIds();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                GetActivos(txtBuscar.Text, "A");
                ParseIds();
            }
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                GetActivos(txtBuscar.Text, "B");
                ParseIds();
            }
        }
    }
}

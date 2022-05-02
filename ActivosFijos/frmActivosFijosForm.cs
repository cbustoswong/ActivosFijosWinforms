using ActivosFijos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ActivosFijos
{

    public partial class frmActivosFijosForm : Form
    {
        public frmMenu menu = null;

        private ActivosEntities db;
        public bool isEditing = false;
        public int Id = 0;
        public string Descripcion = "";
        public string Departamento = "";
        public string Ubicacion = "";
        public string Tipo = "";
        public DateTime Fecha;
        public decimal Valor; 

        public frmActivosFijosForm()
        {
            InitializeComponent();
            db = new ActivosEntities();
        }

        private void LogMovimientos(int Id, string Tipo)
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

        private bool ExisteInfoExtra()
        {
            bool existe = false;

            if(txtMarca.Text.Length>0 || txtSerie.Text.Length>0 ||
               txtModelo.Text.Length>0 || txtColor.Text.Length>0 ||
               txtFactura.Text.Length>0 || txtInfoExtra.Text.Length>0)
                existe= true;

            return existe;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            Activos_Fijos activo = new Activos_Fijos
            {
                Codigo_Activo = Id,
                Descripcion = txtDescripcion.Text,
                Codigo_Departamento = Convert.ToInt32(cbxDept.SelectedValue),
                Codigo_Ubicacion = Convert.ToInt32(cbxUbicacion.SelectedValue),
                Codigo_TipoActivo = Convert.ToInt32(cbxTipo.SelectedValue),
                Codigo_Proveedor = Convert.ToInt32(cbxProveedor.SelectedValue),
                Depreciar = (chkDepreciar.Checked)?"S":"N",
                Codigo_Responsable = Convert.ToInt32(cbxResponsable.SelectedValue),
                Codigo_Usuario = menu.usuario.Id,
                Estado = "A",
                Fecha_Creacion = DateTime.Now,
                Fecha_Registro = dtpFecha.Value,
                Valor_Compra = nudValor.Value
            };


            if (Id != 0)
            {
                var activoInDb = db.Activos_Fijos.FirstOrDefault(a => a.Codigo_Activo == activo.Codigo_Activo);

                if (activoInDb != null)
                {
                    db.Entry(activoInDb).State = System.Data.Entity.EntityState.Detached;
                    db.Entry(activo).State = System.Data.Entity.EntityState.Modified;
                }

                if (ExisteInfoExtra())
                {
                    var AfInfoInDb = db.Activos_Fijos_Info.FirstOrDefault(a => a.Codigo_Activo == activo.Codigo_Activo);

                    if (AfInfoInDb != null)
                    {
                        var Info = db.Activos_Fijos_Info.FirstOrDefault(a => a.Codigo_Activo == activo.Codigo_Activo);
                        Info.Marca = txtMarca.Text;
                        Info.Serie = txtSerie.Text;
                        Info.Modelo = txtModelo.Text;
                        Info.Color = txtColor.Text;
                        Info.Factura = txtFactura.Text;
                        Info.InfoAdicional = txtInfoExtra.Text;

                        db.Entry(AfInfoInDb).State = System.Data.Entity.EntityState.Detached;
                        db.Entry(Info).State = System.Data.Entity.EntityState.Modified;
                    }
                    else
                    {
                        var AfInfo = new Activos_Fijos_Info
                        {
                            Codigo_Activo = Id,
                            Marca = txtMarca.Text,
                            Serie = txtSerie.Text,
                            Modelo = txtModelo.Text,
                            Color = txtColor.Text,
                            Factura = txtFactura.Text,
                            InfoAdicional = txtInfoExtra.Text
                        };
                        db.Activos_Fijos_Info.Add(AfInfo);
                        //db.SaveChanges();
                    }
                    
                }

                MessageBox.Show("El activo fijo ha sido modificado exitosamente.");
            }
            else
            {
                
                db.Activos_Fijos.Add(activo);
                MessageBox.Show("El activo fijo ha sido creado exitosamente.");
            }


            db.SaveChanges();

            if (Id != 0)
            {
                LogMovimientos(Id, "ACTUALIZACION");
            }
            else
            {
                Id = activo.Codigo_Activo;

                if (ExisteInfoExtra())
                {
                    var AfInfo = new Activos_Fijos_Info
                    {
                        Codigo_Activo = Id,
                        Marca = txtMarca.Text,
                        Serie = txtSerie.Text,
                        Modelo = txtModelo.Text,
                        Color = txtColor.Text,
                        Factura = txtFactura.Text,
                        InfoAdicional = txtInfoExtra.Text
                    };
                    db.Activos_Fijos_Info.Add(AfInfo);
                    db.SaveChanges();
                }

                LogMovimientos(Id, "CREACION");
            }
            Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var activo = db.Activos_Fijos.FirstOrDefault(a => a.Codigo_Activo == Id);
            var activoInDb = db.Activos_Fijos.FirstOrDefault(a => a.Codigo_Activo == Id);
            activo.Estado = "I";

            db.Entry(activoInDb).State = System.Data.Entity.EntityState.Detached;
            db.Entry(activo).State = System.Data.Entity.EntityState.Modified;

            db.SaveChanges();

            LogMovimientos(Id, "ELIMINACION");

            MessageBox.Show("El activo fijo ha sido eliminado exitosamente");
            Close();
        }

        private void frmActivosFijosForm_Load(object sender, EventArgs e)
        {
            cbxDept.DataSource = db.Departamento.Select(d => new { Codigo = d.Codigo_Departamento, Nombre = d.Nombre }).ToList();
            cbxDept.DisplayMember = "Nombre";
            cbxDept.ValueMember = "Codigo";
            cbxDept.SelectedIndex = 0;

            cbxUbicacion.DataSource = db.Ubicacion.Select(u => new { Codigo = u.Codigo_Ubicacion, Nombre = u.Descripcion }).ToList();
            cbxUbicacion.DisplayMember = "Nombre";
            cbxUbicacion.ValueMember = "Codigo";

            cbxTipo.DataSource = db.Tipo_Activo.Select(t => new { Codigo = t.Codigo_TipoActivo, Nombre = t.Descripcion }).ToList();
            cbxTipo.DisplayMember = "Nombre";
            cbxTipo.ValueMember = "Codigo";

            cbxProveedor.DataSource = db.Proveedor.Select(t => new { Codigo = t.Codigo_Proveedor, Nombre = t.Nombre }).ToList();
            cbxProveedor.DisplayMember = "Nombre";
            cbxProveedor.ValueMember = "Codigo";

            var source = new AutoCompleteStringCollection();

            source.AddRange(db.Activos_Fijos_Info.GroupBy(g => g.Marca).Select(t => t.Key).ToArray());
            txtMarca.AutoCompleteCustomSource = source;
            txtMarca.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtMarca.AutoCompleteSource = AutoCompleteSource.CustomSource;

           
            if (isEditing)
            {
                lblTitle.Text = "Edicion";

                var af = db.v_Activosfijos.Where(x => x.Codigo == this.Id).FirstOrDefault();

                var Bloqueado = (af.Depreciar == "S" || af.Acumulado > 0) ? true : false;

                var activo = db.Activos_Fijos.Where(x => x.Codigo_Activo == this.Id).FirstOrDefault();
                txtDescripcion.Text = activo.Descripcion;
                cbxProveedor.SelectedValue = activo.Codigo_Proveedor;
                cbxDept.SelectedValue = activo.Codigo_Departamento;
                cbxResponsable.SelectedValue = activo.Codigo_Responsable;
                cbxUbicacion.SelectedValue = activo.Codigo_Ubicacion;
                cbxTipo.SelectedValue = activo.Codigo_TipoActivo;
                dtpFecha.Value = activo.Fecha_Registro;
                nudValor.Value = activo.Valor_Compra;
                chkDepreciar.Checked = (activo.Depreciar == "S") ? true : false;

                var info = activo.Activos_Fijos_Info.FirstOrDefault();
                if (info != null)
                {
                    txtMarca.Text = info.Marca;
                    txtModelo.Text = info.Modelo;
                    txtSerie.Text = info.Serie;
                    txtColor.Text = info.Color;
                    txtFactura.Text = info.Factura;
                    txtInfoExtra.Text = info.InfoAdicional;
                }
                else
                {
                    txtMarca.Clear();
                    txtModelo.Clear();
                    txtSerie.Clear();
                    txtColor.Clear();
                    txtFactura.Clear();
                    txtInfoExtra.Clear();
                }


                if (Bloqueado)
                {
                    cbxProveedor.Enabled = !Bloqueado;
                    cbxDept.Enabled = !Bloqueado;
                    cbxResponsable.Enabled = !Bloqueado;
                    cbxUbicacion.Enabled = !Bloqueado;
                    cbxTipo.Enabled = !Bloqueado;
                    dtpFecha.Enabled = !Bloqueado;
                    nudValor.Enabled = !Bloqueado;
                    chkDepreciar.Enabled = !Bloqueado;
                    btnEliminar.Visible = !Bloqueado;
                }

            }
            else
            {
                btnEliminar.Visible = false;
            }
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbxDept_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxDept.ValueMember == "" || cbxDept.SelectedIndex<0) return;

            var Empleado = db.Empleado.ToList();

            if (Empleado.Where(c => c.Codigo_Departamento == Convert.ToInt32(cbxDept.SelectedValue)).ToList().Count > 0)
            {

                cbxResponsable.DataSource = Empleado.Where(c => c.Codigo_Departamento == Convert.ToInt32(cbxDept.SelectedValue)).ToList()
                    .OrderBy(o => o.Apellido).Select(t => new
                    {
                        Codigo = t.Codigo_Empleado,
                        Nombre = t.Apellido.Trim() + " " + t.Nombre.Trim()
                    }).ToList();

                cbxResponsable.DisplayMember = "Nombre";
                cbxResponsable.ValueMember = "Codigo";
            }
            else {
                cbxResponsable.SelectedIndex = -1;
                cbxResponsable.DataSource = null;
            }

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}

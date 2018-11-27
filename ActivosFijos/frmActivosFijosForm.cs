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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Activos_Fijos activo = new Activos_Fijos
            {
                Codigo_Activo = Id,
                Descripcion = txtDescripcion.Text,
                Codigo_Departamento = db.Departamento
                            .FirstOrDefault(d => d.Nombre == cbxDept.SelectedValue.ToString()).Codigo_Departamento,
                Codigo_Ubicacion = db.Ubicacion.FirstOrDefault(u => u.Descripcion == cbxUbicacion.SelectedValue.ToString()).Codigo_Ubicacion,
                Codigo_TipoActivo = db.Tipo_Activo.FirstOrDefault(t => t.Descripcion == cbxTipo.SelectedValue.ToString()).Codigo_TipoActivo,
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

                MessageBox.Show("El activo fijo ha sido modificado exitosamente.");
            }
            else
            {
                db.Activos_Fijos.Add(activo);
                MessageBox.Show("El activo fijo ha sido creado exitosamente.");
            }

            db.SaveChanges();

            Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var activo = db.Activos_Fijos.FirstOrDefault(a => a.Codigo_Activo == Id);

            db.Activos_Fijos.Remove(activo);
            db.SaveChanges();

            MessageBox.Show("El activo fijo ha sido eliminado exitosamente");
            Close();
        }

        private void frmActivosFijosForm_Load(object sender, EventArgs e)
        {
            cbxDept.DataSource = db.Departamento.Select(d => d.Nombre).ToList();
            cbxUbicacion.DataSource = db.Ubicacion.Select(u => u.Descripcion).ToList();
            cbxTipo.DataSource = db.Tipo_Activo.Select(t => t.Descripcion).ToList();

            if (isEditing)
            {
                lblTitle.Text = "Editar empleado";
                txtDescripcion.Text = Descripcion;
                cbxDept.SelectedItem = Departamento;
                cbxUbicacion.SelectedItem = Ubicacion;
                cbxTipo.SelectedItem = Tipo;
                dtpFecha.Value = Fecha;
                nudValor.Value = Valor;
            }
            else
            {
                btnEliminar.Visible = false;
            }
        }
    }
}

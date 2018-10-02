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
    public partial class frmEmpleadosForm : Form
    {
        public int Id = 0;
        public string Nombre = "";
        public string Apellido = "";
        public string Cedula = "";
        public string Departamento = "";
        public string Tipo_Persona = "";
        public DateTime Fecha_Ingreso;
        public string Estado = "";
        public bool isEditing = false;

        public frmEmpleadosForm()
        {
            InitializeComponent();
        }

        private void frmEmpleadosForm_Load(object sender, EventArgs e)
        {
            using (ActivosEntities db = new ActivosEntities())
            {
                cbxDept.DataSource = db.Departamento.Select(d => d.Nombre).ToList();
            }

            if (isEditing)
            {
                lblTitle.Text = "Editar empleado";
                txtNombre.Text = Nombre;
                txtApellido.Text = Apellido;
                txtCedula.Text = Cedula;
                cbxDept.SelectedItem = Departamento;
                cbxTipo.SelectedItem = Tipo_Persona;
                txtFecha.Text = Fecha_Ingreso.ToShortDateString();
                cbxEstado.SelectedItem = Estado;
            }
            else
            {
                cbxTipo.SelectedIndex = 0;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (ActivosEntities db = new ActivosEntities())
            {
                Empleado empleado = new Empleado
                {
                    Codigo_Empleado = Id,
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Cedula = txtCedula.Text,
                    Codigo_Departamento = db.Departamento
                        .FirstOrDefault(d => d.Nombre == cbxDept.SelectedValue.ToString()).Codigo_Departamento,
                    Tipo_Persona = cbxTipo.SelectedItem.ToString(),
                    Fecha_Ingreso = DateTime.Parse(txtFecha.Text),
                    Estado = cbxEstado.SelectedItem.ToString()
                };

                if (Id != 0)
                {
                    var empInDb = db.Empleado.FirstOrDefault(emp => emp.Codigo_Empleado == empleado.Codigo_Empleado);

                    if (empInDb != null)
                    {
                        db.Entry(empInDb).State = System.Data.Entity.EntityState.Detached;
                        db.Entry(empleado).State = System.Data.Entity.EntityState.Modified;
                    }

                    MessageBox.Show("El empleado ha sido modificado exitosamente.");
                }
                else
                {
                    db.Empleado.Add(empleado);
                    MessageBox.Show("El empleado ha sido creado exitosamente.");
                }

                db.SaveChanges();

                Close();
            }
        }

        private void cbxDept_SelectedValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cbxDept.SelectedValue.ToString());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (ActivosEntities db = new ActivosEntities())
            {
                var empleado = db.Empleado.FirstOrDefault(emp => emp.Codigo_Empleado == Id);

                db.Empleado.Remove(empleado);
                db.SaveChanges();
            }

            MessageBox.Show("El empleado ha sido eliminado exitosamente");
            Close();
        }
    }
}

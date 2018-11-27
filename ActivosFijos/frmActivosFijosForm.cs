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
        public int Id = 0;
        public bool isEditing = false;

        public frmActivosFijosForm()
        {
            InitializeComponent();
            db = new ActivosEntities();
        }

        private void frmEmpleadosForm_Load(object sender, EventArgs e)
        {
            using (ActivosEntities db = new ActivosEntities())
            {
                cbxDept.DataSource = db.Departamento.Select(d => d.Nombre).ToList();
            }

            if (isEditing)
            {
                lblTitle.Text = "Editar activo fijo";
            }
            else
            {
                btnEliminar.Visible = false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (ActivosEntities db = new ActivosEntities())
            {
                var empleado = db.Empleado.FirstOrDefault(emp => emp.Codigo_Empleado == Id);

                db.Empleado.Remove(empleado);
                db.SaveChanges();
            }

            MessageBox.Show("El activo fijo ha sido eliminado exitosamente");
            Close();
        }

    }
}

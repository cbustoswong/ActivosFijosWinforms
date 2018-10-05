using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ActivosFijos.Models;

namespace ActivosFijos
{

    public partial class frmDepartamentoForm : Form
    {
        public int Id = 0;
        public string Departamento = "";
        public bool isEditing = false;
        public frmDepartamentoForm()
        {
            InitializeComponent();
        }

        private void frmDepartamentoForm_Load(object sender, EventArgs e)
        {
            if (isEditing)
            {
                lblTitle.Text = "Editar Departamento";
                tbxDepartamento.Text = Departamento;

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (ActivosEntities db = new ActivosEntities())
            {
                Departamento departamento = new Departamento
                {
                    Codigo_Departamento = Id,
                    Nombre = tbxDepartamento.Text,
                };

                if (Id != 0)
                {
                    var deptInDb = db.Departamento.FirstOrDefault(dept => dept.Codigo_Departamento == departamento.Codigo_Departamento);

                    if (deptInDb != null)
                    {
                        db.Entry(deptInDb).State = System.Data.Entity.EntityState.Detached;
                        db.Entry(departamento).State = System.Data.Entity.EntityState.Modified;
                    }

                    MessageBox.Show("El departamento ha sido modificado exitosamente.");
                }
                else
                {
                    db.Departamento.Add(departamento);
                    MessageBox.Show("El departamento ha sido creado exitosamente.");
                }

                db.SaveChanges();

                Close();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (ActivosEntities db = new ActivosEntities())
            {
                var departamento = db.Departamento.FirstOrDefault(dept => dept.Codigo_Departamento == Id);

                db.Departamento.Remove(departamento);
                db.SaveChanges();
            }

            MessageBox.Show("El departamento ha sido eliminado exitosamente");
            Close();
        }
    }
}

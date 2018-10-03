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
    public partial class frmProveedoresForm : Form
    {
        public int Id = 0;
        public string Nombre = "";
        public string Cedula_RNC = "";
        public string Tipo_Persona = "";
        public DateTime FechaRegistro;
        public string Estado = "";
        public bool isEditing = false;
        public frmProveedoresForm()
        {
            InitializeComponent();
        }
        #region Eventos
        private void frmProveedoresForm_Load(object sender, EventArgs e)
        {
            //using (ActivosEntities db = new ActivosEntities())
            //{
            //    cbxDept.DataSource = db.Departamento.Select(d => d.Nombre).ToList();
            //}

            if (isEditing)
            {
                txtNombre.Text = Nombre;
                txtCedula.Text = Cedula_RNC;
                cbxTipo.SelectedItem = Tipo_Persona;
                txtFecha.Text = FechaRegistro.ToShortDateString();
                txtEstado.Text = Estado;
            }
            else
            {
                cbxTipo.SelectedIndex = 0;
            }
        }
        #endregion

        #region Metodos
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (ActivosEntities db = new ActivosEntities())
            {
                Proveedor proveedor = new Proveedor
                {
                    Codigo_Proveedor = Id,
                    Nombre = txtNombre.Text,
                    Cedula_RNC = txtCedula.Text,
                    Tipo_Proveedor = cbxTipo.SelectedItem.ToString(),
                    Fecha_Registro = DateTime.Parse(txtFecha.Text),
                    Estado = txtEstado.Text
                };

                if (Id != 0)
                {
                    var proinDb = db.Proveedor.FirstOrDefault(pro => pro.Codigo_Proveedor == proveedor.Codigo_Proveedor);

                    if (proinDb != null)
                    {
                        db.Entry(proinDb).State = System.Data.Entity.EntityState.Detached;
                        db.Entry(proveedor).State = System.Data.Entity.EntityState.Modified;
                    }

                    MessageBox.Show("El proveedor ha sido modificado exitosamente.");
                }
                else
                {
                    db.Proveedor.Add(proveedor);
                    MessageBox.Show("El proveedor ha sido creado exitosamente.");
                }

                db.SaveChanges();

                Close();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (ActivosEntities db = new ActivosEntities())
            {
                var proveedor = db.Proveedor.FirstOrDefault(pro => pro.Codigo_Proveedor == Id);

                db.Proveedor.Remove(proveedor);
                db.SaveChanges();
            }

            MessageBox.Show("El proveedor ha sido eliminado exitosamente");
            Close();
        }
        #endregion


    }
    }




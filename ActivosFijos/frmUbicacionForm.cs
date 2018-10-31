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
using ActivosFijos.Models;

namespace ActivosFijos
{

    public partial class frmUbicacionForm : Form
    {

        public int Id = 0;
        public string Descripcion = "";
        public string Direccion = "";
        public string Edificio = "";
        public string Estado = "";
        public bool isEditing = false;

        public frmUbicacionForm()
        {
            InitializeComponent();
        }

        private void frmUbicacionForm_Load(object sender, EventArgs e)
        {

            if (isEditing)
            {
                lblTitle.Text = "Editar ubicacion";
                tbxDescripcion.Text = Descripcion;
                tbxDireccion.Text = Direccion;
                tbxEdificio.Text = Edificio;
                cbxEstado.SelectedItem = Estado;
            }
            else
            {
                cbxEstado.SelectedIndex = 0;
                btnEliminar.Visible = false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!checkFields())
            {
                MessageBox.Show("Por favor llene todas las entradas");
                return;
            }

            using (ActivosEntities db = new ActivosEntities())
            {
                Ubicacion ubicacion = new Ubicacion
                {
                    Codigo_Ubicacion = Id,
                    Descripcion = tbxDescripcion.Text,
                    Direccion = tbxDireccion.Text,
                    Edificio = tbxEdificio.Text,
                    Estado = cbxEstado.SelectedItem.ToString()
                };

                if (Id != 0)
                {
                    var ubInDb = db.Ubicacion.FirstOrDefault(ubi => ubi.Codigo_Ubicacion == ubicacion.Codigo_Ubicacion);

                    if (ubInDb != null)
                    {
                        db.Entry(ubInDb).State = System.Data.Entity.EntityState.Detached;
                        db.Entry(ubicacion).State = System.Data.Entity.EntityState.Modified;
                    }

                    MessageBox.Show("La ubicacion ha sido modificado exitosamente.");
                }
                else
                {
                    db.Ubicacion.Add(ubicacion);
                    MessageBox.Show("La ubicacion ha sido creado exitosamente.");
                }

                db.SaveChanges();

                Close();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (ActivosEntities db = new ActivosEntities())
            {
                var ubicacion = db.Ubicacion.FirstOrDefault(ubi => ubi.Codigo_Ubicacion == Id);

                db.Ubicacion.Remove(ubicacion);
                db.SaveChanges();
            }

            MessageBox.Show("La ubicacion ha sido eliminada exitosamente");
            Close();
        }

        private void tbxDescripcion_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex("^[a-zA-Z]+$");
            bool hasOnlyAlpha = regex.IsMatch(tbxDescripcion.Text);
            if (!hasOnlyAlpha || tbxDescripcion.Text.Length == 0)
            {
                MessageBox.Show("Introduzca una descripcion valida");
                tbxDescripcion.Focus();
            }
        }

        private void tbxDireccion_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex("^[a-zA-Z0-9]*$");
            bool hasOnlyAlpha = regex.IsMatch(tbxDireccion.Text);
            if (!hasOnlyAlpha || tbxDireccion.Text.Length == 0)
            {
                MessageBox.Show("Introduzca una direccion valida");
                tbxDireccion.Focus();
            }
        }

        private void tbxEdificio_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex("^[a-zA-Z0-9]*$");
            bool hasOnlyAlpha = regex.IsMatch(tbxEdificio.Text);
            if (!hasOnlyAlpha || tbxEdificio.Text.Length == 0)
            {
                MessageBox.Show("Introduzca un edificio valido");
                tbxEdificio.Focus();
            }
        }

        private bool checkFields()
        {
            if (tbxDescripcion.Text.Length == 0 || tbxDireccion.Text.Length == 0 || tbxEdificio.Text.Length == 0)
            {
                return false;
            }

            return true;
        }
    }
}

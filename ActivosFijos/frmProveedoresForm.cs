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
            if (isEditing)
            {
                lblTitle.Text = "Editar proveedor";
                txtNombre.Text = Nombre;
                txtCedula.Text = Cedula_RNC;
                cbxTipo.SelectedItem = Tipo_Persona;
                dtpFecha.Value = FechaRegistro;
                cbxEstado.SelectedItem = Estado;
            }
            else
            {
                cbxTipo.SelectedIndex = 0;
                cbxEstado.SelectedIndex = 0;
                btnEliminar.Visible = false;
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
                    Fecha_Registro = dtpFecha.Value,
                    Estado = cbxEstado.SelectedItem.ToString()
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

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex("^[a-zA-Z]+$");
            bool hasOnlyAlpha = regex.IsMatch(txtNombre.Text);
            if (!hasOnlyAlpha)
            {
                MessageBox.Show("Introduzca el nombre correctamente");
                txtNombre.Focus();
            }
        }

        private void txtCedula_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckCedula(txtCedula.Text))
            {
                MessageBox.Show("Introduzca una cedula valida");
                txtCedula.Focus();
            }
        }

        public static bool CheckCedula(string Cedula)
        {
            int vnTotal = 0;
            string chkCedula = Cedula.Replace("-", "");
            int pLongCed = chkCedula.Trim().Length;
            int[] digitoMult = new int[11] { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1 };

            if (pLongCed < 11 || pLongCed > 11)
                return false;

            for (int vDig = 1; vDig <= pLongCed; vDig++)
            {
                int vCalculo = int.Parse(chkCedula.Substring(vDig - 1, 1)) * digitoMult[vDig - 1];
                if (vCalculo < 10)
                    vnTotal += vCalculo;
                else
                    vnTotal += int.Parse(vCalculo.ToString().Substring(0, 1)) + int.Parse(vCalculo.ToString().Substring(1, 1));
            }

            if (vnTotal % 10 == 0)
                return true;
            else
                return false;

        }
    }
}

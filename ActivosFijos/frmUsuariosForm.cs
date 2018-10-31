using ActivosFijos.Models;
using ActivosFijos.Services;
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
    public partial class frmUsuariosForm : Form
    {
        public int Id = 0;
        public string Usuario = "";
        public string Nombre = "";
        public string Apellido = "";
        public string Rol = "";
        public bool isEditing = false;


        public frmUsuariosForm()
        {
            InitializeComponent();
        }

        private void frmUsuariosForm_Load(object sender, EventArgs e)
        {
       
            using (ActivosEntities db = new ActivosEntities())
            {
                cobRol.DataSource = db.Roles.Select(d => d.Nombre).ToList();
                
            }
            if (isEditing)
            {
                lblTitle.Text = "Editar Usuario";
                txtUsuario.Text = Usuario; 
                txtNombre.Text = Nombre;
                txtApellido.Text = Apellido;
                cobRol.SelectedItem = Rol;
            }
            else
            {
                btnEliminar.Visible = false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            if (ValidarCampos())
            {
                using (ActivosEntities db = new ActivosEntities())
                {
                    var rol = db.Roles
                            .FirstOrDefault(d => d.Nombre == cobRol.SelectedValue.ToString());

                    MessageBox.Show(rol.Nombre);

                    Usuarios Usuario = new Usuarios
                    {
                        Id = Id,
                        Usuario = txtUsuario.Text,
                        Apellido = txtApellido.Text,
                        Nombre = txtNombre.Text,
                        Roles = { rol },
                        Contrasena = SecurePasswordHasher.Hash(txtContrasena.Text),
                    };

                  

                    if (Id != 0)
                    {
                        var UserInDB = db.Usuarios.FirstOrDefault(user => user.Id == Usuario.Id);

                        if (UserInDB != null)
                        {
                            db.Entry(UserInDB).State = System.Data.Entity.EntityState.Detached;
                            db.Entry(Usuario).State = System.Data.Entity.EntityState.Modified;

                            foreach (var item in Usuario.Roles)
                            {
                                db.Entry(item).State = System.Data.Entity.EntityState.Modified; 
                            }
                        }

                        MessageBox.Show("El usuario ha sido modificado exitosamente.");
                    }
                    else
                    {
                        db.Usuarios.Add(Usuario);
                        MessageBox.Show("El usuario ha sido creado exitosamente.");
                    }

                    db.SaveChanges();

                    Close();
                }
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (ActivosEntities db = new ActivosEntities())
            {
                var Usuario = db.Usuarios.FirstOrDefault(user => user.Id == Id);

                db.Usuarios.Remove(Usuario);
                db.SaveChanges();
            }

            MessageBox.Show("El usuario ha sido eliminado exitosamente");
            Close();
        }

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

        private bool ValidarCampos()
        {
            bool Valido = true;

            if (txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese el nombre");
                Valido = false;
            }

            else if (txtApellido.Text == "")
            {
                MessageBox.Show("Ingrese el apellido");
                Valido = false;
            }
            else if (txtUsuario.Text == "")
            {
                MessageBox.Show("Ingrese el usuario");
                Valido = false;
            }
            else if (txtContrasena.Text == "")
            {
                MessageBox.Show("Ingrese la contrasena");
                Valido = false;
            }

            else if (txtContrasena.Text != txtContrasena2.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden");
                Valido = false;
            }

            return Valido;
        }
    }
}

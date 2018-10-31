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
    public partial class frmUsuarios : Form
    {
        public frmMenu menu = null;
        public frmUsuarios()
        {
            InitializeComponent();
            dgvUsuarios.AutoGenerateColumns = false;
        }
        private void GetUsuario(string search)
        {
            using (var db = new ActivosEntities())
            {
                try
                {
                    if (!(search.Trim().Length > 0))
                    {

                        dgvUsuarios.DataSource = db.Usuarios.ToList();

                        return;
                    }

                    var Usuarios = db.Usuarios.Where(a => a.Nombre.Contains(search) || a.Usuario.Contains(search));

                    dgvUsuarios.DataSource = Usuarios.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            GetUsuario("");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                GetUsuario(txtBuscar.Text);
            }
            catch (Exception)
            {


            }
        }

        private void frmUsuarios_Activated(object sender, EventArgs e)
        {
            GetUsuario(txtBuscar.Text);
        }

        private void frmUsuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            menu.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmUsuariosForm frm = new frmUsuariosForm();
            frm.ShowDialog();
        }

        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmUsuariosForm frm = new frmUsuariosForm();
            var row = dgvUsuarios.CurrentRow;
            var db = new ActivosEntities();

            frm.isEditing = true;
            frm.Id = (int)row.Cells["Id"].Value;
            frm.Usuario = row.Cells["Usuario"].Value.ToString();
            frm.Nombre = row.Cells["Nombre"].Value.ToString();
            frm.Apellido = row.Cells["Apellido"].Value.ToString();

            int IdUser = (int)row.Cells["Id"].Value;
            var a = db.Usuarios
                             .FirstOrDefault(d => d.Id == IdUser).Roles;


            foreach (Roles item in a)
            {
               frm.Rol = item.Nombre;
                break;
            }

            frm.ShowDialog();
        }
    }
 }   

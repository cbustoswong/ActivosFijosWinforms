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
    public partial class FrmLogin : Form
    {
        private ActivosEntities db = new ActivosEntities();


        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var usuario = db.Usuarios.FirstOrDefault(u => u.Usuario == txtUsuario.Text
                && u.Contrasena == txtContrasena.Text);

            if (usuario != null)
            {
                Hide();
                frmMenu frm = new frmMenu();

                frm.frmLogin = this;
                frm.usuario = usuario;
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }
        }
    }
}

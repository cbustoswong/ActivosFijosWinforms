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
    public partial class frmMenu : Form
    {
        public FrmLogin frmLogin;
        public Usuarios usuario;
        public List<string> roles;

        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            roles = usuario.Roles.Select(r => r.Nombre).ToList();

            if (!roles.Contains("RRHH"))
            {
                btnEmpleados.Enabled = false;
                btnDepartamentos.Enabled = false;

            }
            else if (!roles.Contains("Logistica"))
            {
                btnProveedores.Enabled = false;
                btnUbicacion.Enabled = false;
            }

            if (!roles.Contains("Admin"))
            {
                btnUsuarios.Enabled = false;

            }


        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            //Se evalua si el bool es true
            if (roles.Contains("Admin") || roles.Contains("RRHH"))
            {
                frmEmpleados frm = new frmEmpleados();
                frm.menu = this;
                frm.Show();
                Hide();
            }
            else //En caso de que no lo sea
            {
                MessageBox.Show("No tiene los privilegios necesarios para acceder a esta opcion del sistema.");
            }
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            if (roles.Contains("Admin") || roles.Contains("Logistica"))
            {
                frmProveedores frm = new frmProveedores();
                frm.menu = this;
                frm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("No tiene los privilegios necesarios para acceder a esta opcion del sistema.");
            }
        }

        private void btnUbicacion_Click(object sender, EventArgs e)
        {
            if (roles.Contains("Admin") || roles.Contains("Logistica"))
            {
                frmUbicacion frm = new frmUbicacion();
                frm.menu = this;
                frm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("No tiene los privilegios necesarios para acceder a esta opcion del sistema.");
            }
        }

        private void btnParametros_Click(object sender, EventArgs e)
        {
            if (roles.Contains("Admin") || roles.Contains("Logistica"))
            {
                frmParametros frm = new frmParametros();
                frm.menu = this;
                frm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("No tiene los privilegios necesarios para acceder a esta opcion del sistema.");
            }
        }

        private void btnDepartamentos_Click(object sender, EventArgs e)
        {
            if (roles.Contains("Admin") || roles.Contains("RRHH"))
            {
                frmDepartamento frm = new frmDepartamento();
                frm.menu = this;
                frm.Show();
                Hide();
            }
            {
                MessageBox.Show("No tiene los privilegios necesarios para acceder a esta opcion del sistema.");
            }
        }

        private void btnUsuarios_Click(object sender,EventArgs e)
        {
            //Se evalua si el bool es true
            if (roles.Contains("Admin"))
            {
                frmUsuarios frm = new frmUsuarios();
                frm.menu = this;
                frm.Show();
                Hide();
            }
            else //En caso de que no lo sea
            {
                MessageBox.Show("No tiene los privilegios necesarios para acceder a esta opcion del sistema.");
            }
        }

        private void btnEmpleados_MouseEnter(object sender, EventArgs e)
        {
            btnEmpleados.Image = Properties.Resources.account_selected;
        }

        private void btnEmpleados_MouseLeave(object sender, EventArgs e)
        {
            btnEmpleados.Image = Properties.Resources.account;
        }

        private void btnDepartamentos_MouseEnter(object sender, EventArgs e)
        {
            btnDepartamentos.Image = Properties.Resources.account_group_selected;
        }

        private void btnDepartamentos_MouseLeave(object sender, EventArgs e)
        {
            btnDepartamentos.Image = Properties.Resources.account_group;
        }

        private void btnProveedores_MouseEnter(object sender, EventArgs e)
        {
            btnProveedores.Image = Properties.Resources.truck_selected;
        }

        private void btnProveedores_MouseLeave(object sender, EventArgs e)
        {
            btnProveedores.Image = Properties.Resources.truck;
        }

        private void btnUbicacion_MouseEnter(object sender, EventArgs e)
        {
            btnUbicacion.Image = Properties.Resources.location_marker_selected;
        }

        private void btnUbicacion_MouseLeave(object sender, EventArgs e)
        {
            btnUbicacion.Image = Properties.Resources.location_marker;
        }

        private void btnParametros_MouseEnter(object sender, EventArgs e)
        {
            btnParametros.Image = Properties.Resources.format_list_bulleted_selected;
        }
        private void btnUsuarios_MouseEnter(object sender, EventArgs e)
        {
            //btnUsuarios.Image = Properties.Resources.format_list_bulleted_selected;
        }

        private void btnParametros_MouseLeave(object sender, EventArgs e)
        {
            btnParametros.Image = Properties.Resources.format_list_bulleted;
        }
        private void btnUsuarios_MouseLeave(object sender, EventArgs e)
        {
            //btnUsuarios.Image = Properties.Resources.format_list_bulleted;
        }

        private void frmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin.Close();
        }
    }
}

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
    public partial class Menu : Form
    {
        //Estas variables son las que permitirian definir los privilegios de cada rol. Depende del rol, estas cambiaran su
        //valor de true a false.
        bool accessEmpleado = true;
        bool accessDepartamento = false;
        bool accessProveedores = true;
        bool accessUbicacion = true;
        bool accessParametros = true;

        public Menu()
        {
            InitializeComponent();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            //Se evalua si el bool es true
            if (accessEmpleado)
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
            if (accessProveedores)
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
            if (accessUbicacion)
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
            if (accessParametros)
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
            if (accessDepartamento)
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

        private void btnParametros_MouseLeave(object sender, EventArgs e)
        {
            btnParametros.Image = Properties.Resources.format_list_bulleted;
        }
    }
}

﻿using System;
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
        public Menu()
        {
            InitializeComponent();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            frmEmpleados frm = new frmEmpleados();
            frm.menu = this;
            frm.Show();
            Hide();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            frmProveedores frm = new frmProveedores();
            frm.menu = this;
            frm.Show();
            Hide();
        }

        private void btnUbicacion_Click(object sender, EventArgs e)
        {
            frmUbicacion frm = new frmUbicacion();
            frm.menu = this;
            frm.Show();
            Hide();
        }

        private void btnParametros_Click(object sender, EventArgs e)
        {
            frmParametros frm = new frmParametros();
            frm.menu = this;
            frm.Show();
            Hide();
        }

        private void btnDepartamentos_Click(object sender, EventArgs e)
        {
            frmDepartamento frm = new frmDepartamento();
            frm.menu = this;
            frm.Show();
            Hide();
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

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
    public partial class frmParametrosForm : Form
    {
        public int Id = 0;
        public DateTime AnoMesProceso;
        public bool Deprec_Calculada;
        public string RNC_Empresa = "";
        public string Met_Depreciacion = "";
        public bool isEditing = false;

        public frmParametrosForm()
        {
            InitializeComponent();
        }


        #region Eventos
        private void frmParametrosForm_Load(object sender, EventArgs e)
        {
            if (isEditing)
            {
                lblTitle.Text = "Editar parametro";
                dtpAnoMes.Value = AnoMesProceso;
                chkDeprecCalculada.Checked = Deprec_Calculada;
                txtRNC.Text = RNC_Empresa;
                cbxMetDeprec.SelectedItem = Met_Depreciacion;
            }
            else
            {
                cbxMetDeprec.SelectedIndex = 0;
                btnEliminar.Visible = false;
            }
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtRNC.Text.Length == 0)
            {
                MessageBox.Show("Por favor introduzca un RNC");
                return;
            }

            using (ActivosEntities db = new ActivosEntities())
            {
                Parametro parametro = new Parametro
                {
                    Codigo_Parametro = Id,
                    Ano_Mes_Proceso = dtpAnoMes.Value,
                    Deprec_Calculada = chkDeprecCalculada.Checked,
                    RNC_Empresa = txtRNC.Text,
                    Met_Drepeciacion = cbxMetDeprec.SelectedItem.ToString(),
                };

                if (Id != 0)
                {
                    var paraDb = db.Parametro.FirstOrDefault(para => para.Codigo_Parametro == Id);

                    if (paraDb != null)
                    {
                        db.Entry(paraDb).State = System.Data.Entity.EntityState.Detached;
                        db.Entry(parametro).State = System.Data.Entity.EntityState.Modified;
                    }

                    MessageBox.Show("El parametro ha sido modificado exitosamente.");
                }
                else
                {
                    db.Parametro.Add(parametro);
                    MessageBox.Show("El parametro ha sido creado exitosamente.");
                }

                db.SaveChanges();

                Close();
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (ActivosEntities db = new ActivosEntities())
            {
                var parametro = db.Parametro.FirstOrDefault(para => para.Codigo_Parametro == Id);

                db.Parametro.Remove(parametro);
                db.SaveChanges();
            }

            MessageBox.Show("El parametro ha sido eliminado exitosamente");
            Close();
        }

        #endregion

        private void txtRNC_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidateRNC(txtRNC.Text))
            {
                MessageBox.Show("Introduzca un RNC valido");
                txtRNC.Focus();
            }
        }

        public static bool ValidateRNC(string rnc)
        {
            int[] baseRnc = new int[8] { 7, 9, 8, 6, 5, 4, 3, 2 };
            int suma = 0;
            int resto, verificador;

            if (rnc.Trim().Length != 9)
                return false;

            var digitos = rnc.Trim().ToArray();
            var digitoVerificador = int.Parse(digitos.Last().ToString());

            for (var i = baseRnc.Length - 1; i >= 0; i -= 1)
            {
                suma += baseRnc[i] * int.Parse(digitos[i].ToString());
            }

            resto = suma % 11;

            switch (resto)
            {
                case 0:
                    verificador = 2;
                    break;
                case 1:
                    verificador = 1;
                    break;
                default:
                    verificador = 11 - resto;
                    break;
            }

            return verificador == digitoVerificador;
        }
    }
}

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
                dtpAnoMes.Value = AnoMesProceso;
                chkDeprecCalculada.Checked = Deprec_Calculada;
                txtRNC.Text = RNC_Empresa;
                txtMetDeprec.Text = Met_Depreciacion;
            }
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (ActivosEntities db = new ActivosEntities())
            {
                Parametro parametro = new Parametro
                {
                    Codigo_Parametro = Id,
                    Ano_Mes_Proceso = dtpAnoMes.Value,
                    Deprec_Calculada  =chkDeprecCalculada.Checked,
                    RNC_Empresa = txtRNC.Text,
                    Met_Drepeciacion = txtMetDeprec.Text,
                };

                if (Id != 0)
                {
                    var paraDb = db.Parametro.FirstOrDefault(para => para.Codigo_Parametro == parametro.Codigo_Parametro);

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


    }
}

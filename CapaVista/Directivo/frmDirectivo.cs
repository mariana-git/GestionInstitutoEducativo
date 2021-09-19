using System;
using System.Windows.Forms;

namespace CapaVista.Directivo
{
    public partial class FrmDirectivo : Form
    {
        private UserControl userControlActivo = null; //variable para manipular en el metodo de Control del Formulario Activo
        public FrmDirectivo()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void AbrirUC(UserControl UControlActivo)
        {
            //Controla que solo haya un UserControl abierto dentro del Panel
            if (userControlActivo != null) userControlActivo.Dispose();
            userControlActivo = UControlActivo;
            panelDirectivo.Controls.Add(UControlActivo);
            panelDirectivo.Tag = UControlActivo;
            UControlActivo.BringToFront();
            UControlActivo.Show();
        }
        private void BtnEstudiantes_Click(object sender, EventArgs e)
        {
            AbrirUC(new ControlesdeUsuario.uc_GestionPersonas());
        }

        private void BtnAsistencia_Click(object sender, EventArgs e)
        {
            AbrirUC(new ControlesdeUsuario.uc_GestionAsistenciaEstudiantes());
        }

        private void BtnCalificaciones_Click(object sender, EventArgs e)
        {
            AbrirUC(new ControlesdeUsuario.uc_GestionCalificacionesEstudiantes());
        }

        private void BtnGrilla_Click(object sender, EventArgs e)
        {
            AbrirUC(new ControlesdeUsuario.uc_GrillaSemanal());
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BtnDocentes_Click(object sender, EventArgs e)
        {
            AbrirUC(new ControlesdeUsuario.uc_GestionPersonas());
        }
    }
}

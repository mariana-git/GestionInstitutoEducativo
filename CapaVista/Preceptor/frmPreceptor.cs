using System;
using System.Windows.Forms;

namespace CapaVista.Preceptor
{
    public partial class frmPreceptor : Form
    {
        private UserControl userControlActivo = null; //variable para manipular en el metodo de Control del Formulario Activo
        public frmPreceptor()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void AbrirUC(UserControl UControlActivo)
        {
            //Controla que solo haya un UserControl abierto dentro del Panel
            if (userControlActivo != null) userControlActivo.Dispose();
            userControlActivo = UControlActivo;
            panelPreceptor.Controls.Add(UControlActivo);
            panelPreceptor.Tag = UControlActivo;
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

        private void BtnMaterias_Click(object sender, EventArgs e)
        {
            AbrirUC(new ControlesdeUsuario.uc_GestionMaterias());
        }

        private void BtnDocentes_Click(object sender, EventArgs e)
        {
            AbrirUC(new ControlesdeUsuario.uc_GestionPersonas());
        }

        private void BtnAsigAulas_Click(object sender, EventArgs e)
        {
            AbrirUC(new ControlesdeUsuario.uc_GestionAulas());
        }

        private void BtnGrilla_Click(object sender, EventArgs e)
        {
            AbrirUC(new ControlesdeUsuario.uc_GrillaSemanal());
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}

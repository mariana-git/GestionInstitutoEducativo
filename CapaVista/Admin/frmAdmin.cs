using System;
using System.Windows.Forms;

namespace CapaVista.Admin
{
    public partial class frmAdmin : Form
    {
        private UserControl userControlActivo = null; //variable para el metodo AbrirUC
        public frmAdmin()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void AbrirUC(UserControl UControlActivo)
        {
            //Controla que solo haya un UserControl abierto dentro del Panel
            if (userControlActivo != null) userControlActivo.Dispose();
            userControlActivo = UControlActivo;
            panelAdmin.Controls.Add(UControlActivo);
            panelAdmin.Tag = UControlActivo;
            UControlActivo.BringToFront();
            UControlActivo.Show();
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirUC(new ControlesdeUsuario.uc_GestionUsuarios());
        }

        private void BtnPersonas_Click(object sender, EventArgs e)
        {
            AbrirUC(new ControlesdeUsuario.uc_GestionPersonas());
        }

        private void BtnMaterias_Click(object sender, EventArgs e)
        {
            AbrirUC(new ControlesdeUsuario.uc_GestionMaterias());
        }

        private void BtnAulas_Click(object sender, EventArgs e)
        {
            AbrirUC(new ControlesdeUsuario.uc_GestionAulas());
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}

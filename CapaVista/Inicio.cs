using System;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class frmInicio : Form
    {
        #region ATRIBUTOS

        private int xClick = 0, yClick = 0;//para el metodo del evento MouseMove
        //private Form formActivo = null; //variable para manipular en el metodo de Control del Formulario Activo

        #endregion

        #region MÉTODOS
        public frmInicio()
        {
            InitializeComponent();
            AcceptButton = btnLogin;
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void Inicio_MouseMove(object sender, MouseEventArgs e)
        {
            //evento MouseMove del Form, para desplazarlo el form,  al no tener bordes
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { Left += e.X - xClick; Top += e.Y - yClick; }
        }
        #endregion
        #region BOTONES
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            //if (textBox1.Text == "alumno") AbrirForm(new frmEstudiante());
            if (txtUsuario.Text == "p") new Preceptor.FrmPreceptor().Show();               
            else if (txtUsuario.Text == "d") new Docente.FrmDocente().Show();
            else if (txtUsuario.Text == "v") new Directivo.FrmDirectivo().Show();
            else if (txtUsuario.Text == "a") new Admin.FrmAdmin().Show();
            else MessageBox.Show("Verifique los datos ingresados", "USUARIO INEXISTENTE");

            txtClave.Text = "";
            txtUsuario.Text = "";
        }
        #endregion

    }
}

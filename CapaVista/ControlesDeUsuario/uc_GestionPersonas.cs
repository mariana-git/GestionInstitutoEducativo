using System;
using System.Windows.Forms;

namespace CapaVista.ControlesdeUsuario
{
    public partial class uc_GestionPersonas : UserControl
    {
        private string procedencia;

        public string Procedencia { get => procedencia; set => procedencia = value; }

        public uc_GestionPersonas()
        {
            InitializeComponent();
            btnEliminar.Visible = false;
        }

        private void uc_GestionPersonas_Load(object sender, EventArgs e)
        {
            lblRol.Text = Procedencia;
        }
        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            //ver si no esta vacio todo, sino advertir           
            btnVolver.BringToFront();
            btnGuardarCambios.BringToFront();
            btnEliminar.Visible = true; 
        }

        private void BtnGuardarCambios_Click(object sender, EventArgs e)
        {
            MessageBox.Show("guardado");
            btnConsultar.BringToFront();
            btnAgregar.BringToFront();
            btnEliminar.Visible = false;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("eliminamos???","OJOTA", MessageBoxButtons.OK);
            btnConsultar.BringToFront();
            btnAgregar.BringToFront();
            btnEliminar.Visible = false;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            //btnAgregar.Visible = false;
            //btnConsultar.Visible = false;
            btnVolver.BringToFront();
            btnGuardarCambios.BringToFront();
        }


        private void BtnVolver_Click(object sender, EventArgs e)
        {
            //clean
            btnConsultar.BringToFront();
            btnAgregar.BringToFront();
            btnEliminar.Visible = false;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}

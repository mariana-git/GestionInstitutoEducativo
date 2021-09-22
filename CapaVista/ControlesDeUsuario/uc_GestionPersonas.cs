using System;
using System.Windows.Forms;

namespace CapaVista.ControlesdeUsuario
{
    public partial class uc_GestionPersonas : UserControl
    {
        private string procedencia;
        private CapaLogica.Preceptor.CL_Preceptor_Personas LogicaPreceptorPersonas = new CapaLogica.Preceptor.CL_Preceptor_Personas();


        public string Procedencia { get => procedencia; set => procedencia = value; }

        public uc_GestionPersonas()
        {
            InitializeComponent();

            DiseñoDgv();

            flpDatos.Visible = false;
            btnEliminar.Visible = false;
            btnGuardarCambios.Visible = false;
            btnVolver.Visible = false;
        }

        private void Uc_GestionPersonas_Load(object sender, EventArgs e)
        {
            lblRol.Text = Procedencia;
        }
        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            btnConsultar.Visible = false;
            btnAgregar.Visible = false;
            btnVolver.Visible = true;
            txtBusqueda.Enabled = false;
            
            string busqueda = txtBusqueda.Text.ToUpper();
            try
            {
                dgvPersonas.DataSource = LogicaPreceptorPersonas.BuscarEstudiante(busqueda);
            }
            catch (Exception exc)
            {
                MessageBox.Show("No fue posible realizar la acción\n\n\n"+ exc.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            private void BtnGuardarCambios_Click(object sender, EventArgs e)
        {
            MessageBox.Show("guardado");

            dgvPersonas.DataSource = null;
            btnConsultar.Visible = true;
            btnAgregar.Visible = true;
            btnGuardarCambios.Visible = false;
            btnVolver.Visible = false;
            flpDatos.Visible = false;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("eliminamos???","OJOTA", MessageBoxButtons.OK);//cargo con lo del txtbx

            dgvPersonas.DataSource = null;
            btnConsultar.Visible = true;
            btnAgregar.Visible = true;
            btnGuardarCambios.Visible = false;
            btnVolver.Visible = false;
            flpDatos.Visible = false;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            dgvPersonas.DataSource = null;
            txtBusqueda.Enabled = false;
            btnConsultar.Visible = false;
            btnAgregar.Visible = false;
            btnGuardarCambios.Visible = true;
            btnVolver.Visible = true;
            flpDatos.Visible = true;
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            dgvPersonas.DataSource = null;
            txtBusqueda.Enabled = true;
            txtBusqueda.Text = null;
            btnConsultar.Visible = true;
            btnAgregar.Visible = true;
            btnVolver.Visible = false;
            btnEliminar.Visible = false;
            btnGuardarCambios.Visible = false;
            flpDatos.Visible = false;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Uc_GestionPersonas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) btnConsultar.PerformClick();   //presiona ENTER
        }

        private void DiseñoDgv()
        {
            dgvPersonas.ReadOnly = true; //hace que la grilla no se pueda editar
            dgvPersonas.RowsDefaultCellStyle.BackColor = System.Drawing.Color.LightBlue;//alterna colores de las filas
            dgvPersonas.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.White;//alterna colores de las filas
            dgvPersonas.AllowUserToAddRows = false; //desactiva la ultima fila 
        }
    }
}

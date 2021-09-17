using System;
using System.Windows.Forms;

namespace CapaVista.ControlesdeUsuario
{
    public partial class uc_GestionUsuarios : UserControl
    {
        public uc_GestionUsuarios()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}

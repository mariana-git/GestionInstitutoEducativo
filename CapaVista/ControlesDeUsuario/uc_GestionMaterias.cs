using System;
using System.Windows.Forms;

namespace CapaVista.ControlesdeUsuario
{
    public partial class uc_GestionMaterias : UserControl
    {
        public uc_GestionMaterias()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}

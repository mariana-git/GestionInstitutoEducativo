using System;
using System.Windows.Forms;

namespace CapaVista.ControlesdeUsuario
{
    public partial class uc_GestionAulas : UserControl
    {
        public uc_GestionAulas()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}

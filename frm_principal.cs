using System;
using System.Windows.Forms;

namespace ParcialII
{
    public partial class frm_principal : Form
    {
        public frm_principal(string nombreUsuario)
        {
            InitializeComponent();
            lblBienvenida.Text = "Bienvenido(a), " + nombreUsuario;
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            using (frm_usuario frm = new frm_usuario())
            {
                frm.ShowDialog(this);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

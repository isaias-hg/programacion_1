using System;
using System.Windows.Forms;

namespace ParcialII
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // El formulario login es el primero que aparece al ejecutar la aplicación.
            using (login frmLogin = new login())
            {
                if (frmLogin.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new frm_principal(frmLogin.NombreUsuario));
                }
            }
        }
    }
}

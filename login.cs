using System;
using System.Windows.Forms;

namespace ParcialII
{
    public partial class login : Form
    {
        private readonly Conexion_base_datos bd = new Conexion_base_datos();
        private int intentos = 0;

        /// <summary>Nombre del usuario que inició sesión.</summary>
        public string NombreUsuario { get; private set; } = "";

        public login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string clave = txtClave.Text;

            if (usuario == "" || clave == "")
            {
                MessageBox.Show("Ingrese el usuario y la clave.", "Login",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string nombre;
                if (bd.validarLogin(usuario, clave, out nombre))
                {
                    NombreUsuario = nombre;
                    DialogResult = DialogResult.OK;
                    Close();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar con la base de datos:\n" + ex.Message,
                    "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Usuario o clave incorrectos: se deniega el acceso
            intentos++;
            if (intentos >= 3)
            {
                MessageBox.Show("Acceso denegado. Superó el número de intentos permitidos.",
                    "Login", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                DialogResult = DialogResult.Cancel;
                Close();
                return;
            }

            MessageBox.Show("Acceso denegado: usuario o clave incorrectos.\nIntento " + intentos + " de 3.",
                "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtClave.Clear();
            txtClave.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}

using System;
using System.Data;
using System.Windows.Forms;

namespace ParcialII
{
    public partial class frm_usuario : Form
    {
        private const string TABLA = "usuarios_usss008426";

        private readonly Conexion_base_datos bd = new Conexion_base_datos();
        private DataSet ds;
        private DataTable dt;
        private int posicion = 0;
        private string modo = "";   // "" = consultando, "nuevo" = agregando, "modificar" = modificando

        public frm_usuario()
        {
            InitializeComponent();
        }

        private void frm_usuario_Load(object sender, EventArgs e)
        {
            try
            {
                cargarDatos();
                posicion = 0;
                mostrarRegistro();
                habilitarEdicion(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los usuarios:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        // ---------------------------------------------------------------- datos
        private void cargarDatos()
        {
            ds = bd.crearDs();
            dt = ds.Tables[TABLA];
        }

        private void mostrarRegistro()
        {
            if (dt.Rows.Count == 0)
            {
                limpiarCampos();
                lblPosicion.Text = "0 de 0";
                return;
            }

            DataRow fila = dt.Rows[posicion];
            txtIdUsuario.Text = fila["idUsuario"].ToString();
            txtUsuario.Text = fila["usuario"].ToString();
            txtClave.Text = fila["clave"].ToString();
            txtConfirmar.Text = fila["clave"].ToString();
            txtNombre.Text = fila["nombre"].ToString();
            txtDireccion.Text = fila["direccion"].ToString();
            txtTelefono.Text = fila["telefono"].ToString();
            lblPosicion.Text = (posicion + 1) + " de " + dt.Rows.Count;
        }

        private void limpiarCampos()
        {
            txtIdUsuario.Clear();
            txtUsuario.Clear();
            txtClave.Clear();
            txtConfirmar.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
        }

        private void habilitarEdicion(bool editando)
        {
            txtUsuario.ReadOnly = !editando;
            txtClave.ReadOnly = !editando;
            txtConfirmar.ReadOnly = !editando;
            txtNombre.ReadOnly = !editando;
            txtDireccion.ReadOnly = !editando;
            txtTelefono.ReadOnly = !editando;

            btnPrimero.Enabled = !editando;
            btnAnterior.Enabled = !editando;
            btnSiguiente.Enabled = !editando;
            btnUltimo.Enabled = !editando;

            btnNuevo.Enabled = !editando;
            btnModificar.Enabled = !editando;
            btnEliminar.Enabled = !editando;

            btnGuardar.Enabled = editando;
            btnCancelar.Enabled = editando;
        }

        // ----------------------------------------------------------- navegación
        private void btnPrimero_Click(object sender, EventArgs e)
        {
            if (dt.Rows.Count == 0) return;
            posicion = 0;
            mostrarRegistro();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (dt.Rows.Count == 0) return;
            if (posicion > 0) posicion--;
            mostrarRegistro();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (dt.Rows.Count == 0) return;
            if (posicion < dt.Rows.Count - 1) posicion++;
            mostrarRegistro();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            if (dt.Rows.Count == 0) return;
            posicion = dt.Rows.Count - 1;
            mostrarRegistro();
        }

        // -------------------------------------------------------------- edición
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            modo = "nuevo";
            limpiarCampos();
            lblPosicion.Text = "Nuevo";
            habilitarEdicion(true);
            txtUsuario.Focus();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No hay registros para modificar.", "Usuarios",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            modo = "modificar";
            habilitarEdicion(true);
            txtUsuario.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No hay registros para eliminar.", "Usuarios",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult r = MessageBox.Show(
                "¿Desea eliminar al usuario \"" + txtUsuario.Text + "\"?",
                "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r != DialogResult.Yes) return;

            string[] datos = { txtIdUsuario.Text, "", "", "", "", "" };
            string resultado = bd.mantenimiento_usuarios_usss008426(datos, "eliminar");

            if (resultado != "ok")
            {
                MessageBox.Show("No se pudo eliminar:\n" + resultado, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cargarDatos();
            if (posicion > dt.Rows.Count - 1) posicion = dt.Rows.Count - 1;
            if (posicion < 0) posicion = 0;
            mostrarRegistro();
            MessageBox.Show("Usuario eliminado.", "Usuarios",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!validarCampos()) return;

            string[] datos =
            {
                txtIdUsuario.Text,
                txtUsuario.Text.Trim(),
                txtClave.Text,
                txtNombre.Text.Trim(),
                txtDireccion.Text.Trim(),
                txtTelefono.Text.Trim()
            };

            string resultado = bd.mantenimiento_usuarios_usss008426(datos, modo);

            if (resultado != "ok")
            {
                MessageBox.Show("No se pudo guardar:\n" + resultado, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool eraNuevo = (modo == "nuevo");
            cargarDatos();
            if (eraNuevo) posicion = dt.Rows.Count - 1;   // el nuevo queda de último
            if (posicion > dt.Rows.Count - 1) posicion = dt.Rows.Count - 1;

            modo = "";
            habilitarEdicion(false);
            mostrarRegistro();
            MessageBox.Show("Registro guardado correctamente.", "Usuarios",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            modo = "";
            habilitarEdicion(false);
            mostrarRegistro();
        }

        // ---------------------------------------------------------- validaciones
        private bool validarCampos()
        {
            string usuario = txtUsuario.Text.Trim();
            string clave = txtClave.Text;

            // Usuario: mínimo 6 y máximo 16 caracteres
            if (usuario.Length < 6 || usuario.Length > 16)
            {
                aviso("El usuario debe tener como mínimo 6 y como máximo 16 caracteres.", txtUsuario);
                return false;
            }

            // Usuario repetido
            string idActual = (modo == "modificar") ? txtIdUsuario.Text : "";
            foreach (DataRow fila in dt.Rows)
            {
                bool mismoRegistro = fila["idUsuario"].ToString() == idActual;
                bool mismoNombre = string.Equals(fila["usuario"].ToString(), usuario,
                    StringComparison.OrdinalIgnoreCase);
                if (mismoNombre && !mismoRegistro)
                {
                    aviso("Ya existe un usuario con ese nombre.", txtUsuario);
                    return false;
                }
            }

            // Clave: debe llevar letras y números
            bool tieneLetras = false;
            bool tieneNumeros = false;
            foreach (char c in clave)
            {
                if (char.IsLetter(c)) tieneLetras = true;
                if (char.IsDigit(c)) tieneNumeros = true;
            }
            if (!tieneLetras || !tieneNumeros)
            {
                aviso("La clave debe contener letras y números.", txtClave);
                return false;
            }

            // Clave: confirmación
            if (clave != txtConfirmar.Text)
            {
                aviso("La confirmación de la clave no coincide.", txtConfirmar);
                return false;
            }

            // Nombre obligatorio
            if (txtNombre.Text.Trim() == "")
            {
                aviso("Ingrese el nombre.", txtNombre);
                return false;
            }

            return true;
        }

        private void aviso(string mensaje, Control campo)
        {
            MessageBox.Show(mensaje, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            campo.Focus();
        }
    }
}

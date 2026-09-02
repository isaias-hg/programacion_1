namespace parcial_1_computo_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmpresa.Text) || !double.TryParse(txtGanancias.Text, out double ganancias) || ganancias <= 0)
            {
                MessageBox.Show("Ingrese un nombre de empresa válido y un monto de ganancias mayor a 0.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double desde = 0;
            double precioBase = 0;
            double factorAdicional = 0;

            if (ganancias >= 0.01 && ganancias <= 500) { desde = 0.01; precioBase = 1.5; factorAdicional = 0; }
            else if (ganancias <= 1000) { desde = 500.01; precioBase = 1.5; factorAdicional = 3; }
            else if (ganancias <= 2000) { desde = 1000.01; precioBase = 3; factorAdicional = 3; }
            else if (ganancias <= 3000) { desde = 2000.01; precioBase = 6; factorAdicional = 3; }
            else if (ganancias <= 6000) { desde = 3000.01; precioBase = 9; factorAdicional = 2; }
            else if (ganancias <= 18000) { desde = 6000.01; precioBase = 15; factorAdicional = 2; }
            else if (ganancias <= 30000) { desde = 18000.01; precioBase = 39; factorAdicional = 2; }
            else if (ganancias <= 60000) { desde = 30000.01; precioBase = 63; factorAdicional = 1; }
            else if (ganancias <= 100000) { desde = 60000.01; precioBase = 93; factorAdicional = 0.8; }
            else if (ganancias <= 200000) { desde = 100000.01; precioBase = 125; factorAdicional = 0.7; }
            else if (ganancias <= 300000) { desde = 200000.01; precioBase = 195; factorAdicional = 0.6; }
            else if (ganancias <= 400000) { desde = 300000.01; precioBase = 255; factorAdicional = 0.45; }
            else if (ganancias <= 500000) { desde = 400000.01; precioBase = 300; factorAdicional = 0.4; }
            else if (ganancias <= 1000000) { desde = 500000.01; precioBase = 340; factorAdicional = 0.30; }
            else { desde = 1000000.01; precioBase = 490; factorAdicional = 0.18; }

            double exceso = ganancias - desde;
            double montoAdicional = (exceso / 1000.0) * factorAdicional;
            double impuestoTotal = precioBase + montoAdicional;

            dgvDatos.Rows.Add(
                txtEmpresa.Text,
                ganancias.ToString("C2"),
                impuestoTotal.ToString("C2"),
                montoAdicional.ToString("C2")
            );

            txtEmpresa.Clear();
            txtGanancias.Clear();
            txtEmpresa.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

namespace metros_de_cosumo_de_agua
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtMetros.Text, out double metros) && metros >= 0)
            {
                double costoMetro = 0.50; // Tarifa base por metro cúbico (ajustar según la tarifa requerida)
                double cuotaFija = 2.00;   // Cuota fija mensual (opcional)

                double totalPagar = (metros * costoMetro) + cuotaFija;

                txtagua.Text = totalPagar.ToString("$#,##0.00");
            }
            else
            {
                MessageBox.Show("Ingrese un número válido de metros.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

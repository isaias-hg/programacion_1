namespace n_meses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            dvgMeses.Rows.Clear();

            if (int.TryParse(txtNMeses.Text, out int n) && n > 0)
            {
                int acumulado = 0;

                for (int i = 1; i <= n; i++)
                {
                    acumulado += i;
                    dvgMeses.Rows.Add(i, i, acumulado);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un número entero válido mayor a 0.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

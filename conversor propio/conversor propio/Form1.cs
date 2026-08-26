namespace conversor_propio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtDolar.Text, out double dolar))
            {
                double bitcoin = dolar / 60000.0;
                double dogecoin = dolar / 0.12;
                double solana = dolar / 140.0;
                double xrp = dolar / 0.55;

                dgvMoneda.Rows.Clear();
                dgvMoneda.Rows.Add(dolar, bitcoin.ToString("F8"), dogecoin.ToString("F4"), solana.ToString("F4"), xrp.ToString("F4"));
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (dgvMoneda.Rows.Count > 0 && !dgvMoneda.Rows[0].IsNewRow)
            {
                object[] valoresFila = new object[dgvMoneda.Columns.Count];
                for (int i = 0; i < dgvMoneda.Columns.Count; i++)
                {
                    valoresFila[i] = dgvMoneda.Rows[0].Cells[i].Value;
                }

                dgvGuardado.Rows.Add(valoresFila);

                dgvMoneda.Rows.Clear();
                txtDolar.Clear();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

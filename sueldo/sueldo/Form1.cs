namespace sueldo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtSueldo.Text, out double sueldoBase) && sueldoBase > 0)
            {
                double isss = sueldoBase * 0.03;
                if (isss > 30.00)
                {
                    isss = 30.00;
                }

                double afp = sueldoBase * 0.0725;
                double sueldoGravado = sueldoBase - isss - afp;
                double isr = 0.0;

                if (sueldoGravado <= 472.00)
                {
                    isr = 0.0;
                }
                else if (sueldoGravado <= 895.24)
                {
                    isr = (sueldoGravado - 472.00) * 0.10 + 17.67;
                }
                else if (sueldoGravado <= 2038.10)
                {
                    isr = (sueldoGravado - 895.24) * 0.20 + 60.00;
                }
                else
                {
                    isr = (sueldoGravado - 2038.10) * 0.30 + 288.57;
                }

                double total = sueldoBase - isss - afp - isr;

                dgvResualtado.Rows.Add(
                    sueldoBase.ToString("$#,##0.00"),
                    isss.ToString("$#,##0.00"),
                    afp.ToString("$#,##0.00"),
                    isr.ToString("$#,##0.00"),
                    total.ToString("$#,##0.00")
                );

                txtSueldo.Clear();
                txtSueldo.Focus();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un sueldo válido mayor a 0.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}


using System.Text.RegularExpressions;

namespace sistema_estadistico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            List<double> datos = new List<double>();

            foreach (DataGridViewRow fila in dgvDatos.Rows)
            {
                if (fila.IsNewRow) continue;

                for (int c = 1; c <= 3; c++)
                {
                    if (fila.Cells[c].Value != null)
                    {
                        double valor = ExtraerSoloNumero(fila.Cells[c].Value.ToString());
                        if (valor > 0) datos.Add(valor);
                    }
                }
            }

            if (datos.Count == 0)
            {
                MessageBox.Show("No hay datos válidos para calcular.", "Atención");
                return;
            }

            int n = datos.Count;
            double media = datos.Average();

            var ord = datos.OrderBy(x => x).ToList();
            double mediana = (n % 2 != 0) ? ord[n / 2] : (ord[(n / 2) - 1] + ord[n / 2]) / 2.0;

            var frec = datos.GroupBy(x => x).Select(g => new { Valor = g.Key, Cant = g.Count() }).ToList();
            int maxFrec = frec.Max(g => g.Cant);
            var modas = frec.Where(g => g.Cant == maxFrec).Select(g => g.Valor);
            string moda = (maxFrec == 1 && n > 1) ? "No hay" : string.Join(", ", modas);

            double varianza = n > 1 ? datos.Sum(d => Math.Pow(d - media, 2)) / (n - 1) : 0;
            double desviacion = Math.Sqrt(varianza);
            double rango = datos.Max() - datos.Min();
            string tablaFrec = string.Join("\n", frec.Select(g => $"Valor {g.Valor}: {g.Cant} vez/veces"));

            string opcion = cmbOpciones.SelectedItem.ToString();
            string res = "";

            if (opcion == "Media aritmética") res = $"Media: {media:F2}";
            else if (opcion == "Mediana") res = $"Mediana: {mediana:F2}";
            else if (opcion == "Moda") res = $"Moda: {moda}";
            else if (opcion == "Varianza") res = $"Varianza: {varianza:F2}";
            else if (opcion == "Desviacion estandar" || opcion == "Desviacion tipica") res = $"Desviación: {desviacion:F2}";
            else if (opcion == "Rango") res = $"Rango: {rango:F2}";
            else if (opcion == "Frecuencia") res = tablaFrec;
            else
            {
                res = $"Media: {media:F2}\nMediana: {mediana:F2}\nModa: {moda}\n" +
                      $"Varianza: {varianza:F2}\nDesviación: {desviacion:F2}\nRango: {rango:F2}\n\nFrecuencias:\n{tablaFrec}";
            }

            MessageBox.Show(res, opcion);
        }
        
        

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbOpciones.Items.Clear();
            cmbOpciones.Items.AddRange(new string[] {
                "Media aritmética", "Mediana", "Moda", "Varianza",
                "Desviacion estandar", "Desviacion tipica", "Rango", "Frecuencia", "Calcular Todo"
            });
            cmbOpciones.SelectedIndex = 0;
        }

        private double ExtraerSoloNumero(string texto)
        {
            Match m = Regex.Match(texto, @"\d+([.,]\d+)?");
            return m.Success ? double.Parse(m.Value.Replace(',', '.')) : 0;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEstudiantes.Text)) return;

            dgvDatos.Rows.Add(txtEstudiantes.Text, txtEdad.Text, txtTiempoUgb.Text, txtTiempoCelular.Text);

            txtEstudiantes.Clear();
            txtEdad.Clear();
            txtTiempoUgb.Clear();
            txtTiempoCelular.Clear();
            txtEstudiantes.Focus();
        }
    }
}


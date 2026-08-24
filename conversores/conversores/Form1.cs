namespace conversores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Matriz de nombres/etiquetas según la opción seleccionada
        string[][] etiquetas = {
            new string[]{"Metros", "Cm", "Pulgadas", "Pies", "Varas", "Yardas", "Km", "Millas"}, // Longitud (base: Metro)
            new string[]{"Dolar", "Quetzal", "Lempira", "Cordobas", "Colon CR"}, // Monedas (base: Dólar)
            new string[]{"Tonelada", "Kilogramo", "Gramo", "Miligramo", "Microgramo", "Tonelada larga", "Tonelada corta", "Stone", "Libra", "Onza"}, // Masa (base: Kilogramo)
            new string[]{"Litro", "Mililitro", "Galón imperial", "Cuarto imperial", "Pinta imperial", "Taza imperial", "Onza líquida imperial", "Cucharada imperial", "Cucharadita imperial", "Pie cúbico"}, // Volumen (base: Litro)
            new string[]{"Byte", "Kilobyte", "Kibibyte", "Megabyte", "Mebibyte", "Gigabyte", "Gibibyte", "Terabyte", "Tebibyte", "Petabyte", "Pebibyte"}, // Almacenamiento (base: Byte)
            new string[]{"Nanosegundo", "Microsegundo", "Milisegundo", "Segundo", "Minuto", "Hora", "Día", "Semana", "Mes", "Año", "Década", "Siglo"} // Tiempo (base: Segundo)
        };

        // Factores de conversión referenciados exactamente a la unidad base (1) de cada categoría
        double[][] valores = {
            // Longitud (Base: Metro)
            new double[]{1, 100, 39.3701, 3.28084, 1.1963, 1.09361, 0.001, 0.000621371},
            
            // Monedas (Base: Dólar)
            new double[]{1, 7.63, 26.81, 36.80, 449.23},
            
            // Masa (Base: Kilogramo)
            new double[]{1000, 1, 0.000001, 0.000000001, 1016.04691, 907.18474, 6.35029, 0.453592, 0.0283495},
            
            // Volumen (Base: Litro)
            new double[]{1, 1000, 0.219969, 0.879877, 1.75975, 3.51951, 35.1951, 56.3121, 168.936, 0.0353147},
            
            // Almacenamiento (Base: Byte)
            new double[]{1, 1e-3, 9.765625e-4, 1e-6, 9.5367431640625e-7, 1e-9, 9.313225746154785e-10, 1e-12, 9.094947017729282e-13, 1e-15, 8.881784197001252e-16},
            
            // Tiempo (Base: Segundo)
            new double[]{1e9, 1e6, 1000, 1, 1.0/60.0, 1.0/3600.0, 1.0/86400.0, 1.0/604800.0, 1.0/2592000.0, 1.0/31536000.0, 1.0/315360000.0, 1.0/3153600000.0}
        };

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Validaciones para evitar fallos al presionar el botón
            if (cboOpciones.SelectedIndex == -1 || cboDe.SelectedIndex == -1 || cboA.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione todas las opciones requeridas.");
                return;
            }

            if (!double.TryParse(txtCantidad.Text, out double cantidad))
            {
                MessageBox.Show("Ingrese una cantidad numérica válida.");
                return;
            }

            int de = cboDe.SelectedIndex;
            int a = cboA.SelectedIndex;
            int opcion = cboOpciones.SelectedIndex;

            // Fórmula de conversión universal basada en ratios
            double respuesta = cantidad * (valores[opcion][a] / valores[opcion][de]);

            lblRespuesta.Text = respuesta.ToString();
        }

        private void cboOpciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Limpiar las opciones anteriores
            cboDe.Items.Clear();
            cboA.Items.Clear();

            // Asignar los elementos según el tipo seleccionado
            int opcion = cboOpciones.SelectedIndex;

            if (opcion >= 0 && opcion < etiquetas.Length)
            {
                cboDe.Items.AddRange(etiquetas[opcion]);
                cboA.Items.AddRange(etiquetas[opcion]);

                // Seleccionar automáticamente el primer elemento de cada ComboBox
                cboDe.SelectedIndex = 0;
                cboA.SelectedIndex = 0;

            }
        }
    }
}

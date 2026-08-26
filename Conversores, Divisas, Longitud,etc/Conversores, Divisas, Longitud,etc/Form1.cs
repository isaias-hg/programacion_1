namespace Conversores__Divisas__Longitud_etc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboOpciones.Items.AddRange(new string[] {
                "Divisas", "Longitud", "Masa", "Almacenamiento", "Tiempo", "Volumen", "Áreas"
            });

            if (cboOpciones.Items.Count > 0)
                cboOpciones.SelectedIndex = 0;
        }

        private void cboOpciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboDe.Items.Clear();
            cboA.Items.Clear();

            string opcion = cboOpciones.SelectedItem.ToString();

            switch (opcion)
            {
                case "Divisas":
                    string[] divisas = { "USD (Dólar)", "EUR (Euro)", "GBP (Libra)", "MXN (Peso MX)", "GTQ (Quetzal)" };
                    cboDe.Items.AddRange(divisas);
                    cboA.Items.AddRange(divisas);
                    break;

                case "Longitud":
                    string[] longitud = { "Milímetro", "Centímetro", "Metro", "Kilómetro", "Pulgada", "Pie", "Yarda", "Milla" };
                    cboDe.Items.AddRange(longitud);
                    cboA.Items.AddRange(longitud);
                    break;

                case "Masa":
                    string[] masa = { "Miligramo", "Gramo", "Kilogramo", "Libra", "Onza", "Tonelada" };
                    cboDe.Items.AddRange(masa);
                    cboA.Items.AddRange(masa);
                    break;

                case "Almacenamiento":
                    string[] almacenamiento = { "Byte", "Kilobyte (KB)", "Megabyte (MB)", "Gigabyte (GB)", "Terabyte (TB)" };
                    cboDe.Items.AddRange(almacenamiento);
                    cboA.Items.AddRange(almacenamiento);
                    break;

                case "Tiempo":
                    string[] tiempo = { "Segundo", "Minuto", "Hora", "Día", "Semana", "Mes (30 días)", "Año (365 días)" };
                    cboDe.Items.AddRange(tiempo);
                    cboA.Items.AddRange(tiempo);
                    break;

                case "Volumen":
                    string[] volumen = { "Mililitro", "Litro", "Metro Cúbico", "Galón (US)", "Taza" };
                    cboDe.Items.AddRange(volumen);
                    cboA.Items.AddRange(volumen);
                    break;

                case "Áreas":
                    string[] areas = { "Centímetro²", "Metro²", "Kilómetro²", "Hectárea", "Acre", "Vara²" };
                    cboDe.Items.AddRange(areas);
                    cboA.Items.AddRange(areas);
                    break;
            }

            if (cboDe.Items.Count > 0) cboDe.SelectedIndex = 0;
            if (cboA.Items.Count > 1) cboA.SelectedIndex = 1;
            else if (cboA.Items.Count > 0) cboA.SelectedIndex = 0;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (cboOpciones.SelectedItem == null || cboDe.SelectedItem == null || cboA.SelectedItem == null)
            {
                MessageBox.Show("Seleccione todas las opciones.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtCantidad.Text, out double cantidad) || cantidad < 0)
            {
                MessageBox.Show("Ingrese una cantidad válida mayor o igual a 0.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string opcion = cboOpciones.SelectedItem.ToString();
            string de = cboDe.SelectedItem.ToString();
            string a = cboA.SelectedItem.ToString();

            double valorEnBase = 0;
            double resultado = 0;

            switch (opcion)
            {
                case "Divisas":
                    // Base: USD
                    if (de == "USD (Dólar)") valorEnBase = cantidad;
                    else if (de == "EUR (Euro)") valorEnBase = cantidad / 0.92;
                    else if (de == "GBP (Libra)") valorEnBase = cantidad / 0.79;
                    else if (de == "MXN (Peso MX)") valorEnBase = cantidad / 18.0;
                    else if (de == "GTQ (Quetzal)") valorEnBase = cantidad / 7.75;

                    if (a == "USD (Dólar)") resultado = valorEnBase;
                    else if (a == "EUR (Euro)") resultado = valorEnBase * 0.92;
                    else if (a == "GBP (Libra)") resultado = valorEnBase * 0.79;
                    else if (a == "MXN (Peso MX)") resultado = valorEnBase * 18.0;
                    else if (a == "GTQ (Quetzal)") resultado = valorEnBase * 7.75;
                    break;

                case "Longitud":
                    // Base: Metros
                    if (de == "Milímetro") valorEnBase = cantidad * 0.001;
                    else if (de == "Centímetro") valorEnBase = cantidad * 0.01;
                    else if (de == "Metro") valorEnBase = cantidad;
                    else if (de == "Kilómetro") valorEnBase = cantidad * 1000;
                    else if (de == "Pulgada") valorEnBase = cantidad * 0.0254;
                    else if (de == "Pie") valorEnBase = cantidad * 0.3048;
                    else if (de == "Yarda") valorEnBase = cantidad * 0.9144;
                    else if (de == "Milla") valorEnBase = cantidad * 1609.34;

                    if (a == "Milímetro") resultado = valorEnBase / 0.001;
                    else if (a == "Centímetro") resultado = valorEnBase / 0.01;
                    else if (a == "Metro") resultado = valorEnBase;
                    else if (a == "Kilómetro") resultado = valorEnBase / 1000;
                    else if (a == "Pulgada") resultado = valorEnBase / 0.0254;
                    else if (a == "Pie") resultado = valorEnBase / 0.3048;
                    else if (a == "Yarda") resultado = valorEnBase / 0.9144;
                    else if (a == "Milla") resultado = valorEnBase / 1609.34;
                    break;

                case "Masa":
                    // Base: Gramos
                    if (de == "Miligramo") valorEnBase = cantidad * 0.001;
                    else if (de == "Gramo") valorEnBase = cantidad;
                    else if (de == "Kilogramo") valorEnBase = cantidad * 1000;
                    else if (de == "Libra") valorEnBase = cantidad * 453.592;
                    else if (de == "Onza") valorEnBase = cantidad * 28.3495;
                    else if (de == "Tonelada") valorEnBase = cantidad * 1000000;

                    if (a == "Miligramo") resultado = valorEnBase / 0.001;
                    else if (a == "Gramo") resultado = valorEnBase;
                    else if (a == "Kilogramo") resultado = valorEnBase / 1000;
                    else if (a == "Libra") resultado = valorEnBase / 453.592;
                    else if (a == "Onza") resultado = valorEnBase / 28.3495;
                    else if (a == "Tonelada") resultado = valorEnBase / 1000000;
                    break;

                case "Almacenamiento":
                    // Base: Bytes
                    if (de == "Byte") valorEnBase = cantidad;
                    else if (de == "Kilobyte (KB)") valorEnBase = cantidad * 1024;
                    else if (de == "Megabyte (MB)") valorEnBase = cantidad * 1048576;
                    else if (de == "Gigabyte (GB)") valorEnBase = cantidad * 1073741824;
                    else if (de == "Terabyte (TB)") valorEnBase = cantidad * 1099511627776;

                    if (a == "Byte") resultado = valorEnBase;
                    else if (a == "Kilobyte (KB)") resultado = valorEnBase / 1024;
                    else if (a == "Megabyte (MB)") resultado = valorEnBase / 1048576;
                    else if (a == "Gigabyte (GB)") resultado = valorEnBase / 1073741824;
                    else if (a == "Terabyte (TB)") resultado = valorEnBase / 1099511627776;
                    break;

                case "Tiempo":
                    // Base: Segundos
                    if (de == "Segundo") valorEnBase = cantidad;
                    else if (de == "Minuto") valorEnBase = cantidad * 60;
                    else if (de == "Hora") valorEnBase = cantidad * 3600;
                    else if (de == "Día") valorEnBase = cantidad * 86400;
                    else if (de == "Semana") valorEnBase = cantidad * 604800;
                    else if (de == "Mes (30 días)") valorEnBase = cantidad * 2592000;
                    else if (de == "Año (365 días)") valorEnBase = cantidad * 31536000;

                    if (a == "Segundo") resultado = valorEnBase;
                    else if (a == "Minuto") resultado = valorEnBase / 60;
                    else if (a == "Hora") resultado = valorEnBase / 3600;
                    else if (a == "Día") resultado = valorEnBase / 86400;
                    else if (a == "Semana") resultado = valorEnBase / 604800;
                    else if (a == "Mes (30 días)") resultado = valorEnBase / 2592000;
                    else if (a == "Año (365 días)") resultado = valorEnBase / 31536000;
                    break;

                case "Volumen":
                    // Base: Litros
                    if (de == "Mililitro") valorEnBase = cantidad * 0.001;
                    else if (de == "Litro") valorEnBase = cantidad;
                    else if (de == "Metro Cúbico") valorEnBase = cantidad * 1000;
                    else if (de == "Galón (US)") valorEnBase = cantidad * 3.78541;
                    else if (de == "Taza") valorEnBase = cantidad * 0.24;

                    if (a == "Mililitro") resultado = valorEnBase / 0.001;
                    else if (a == "Litro") resultado = valorEnBase;
                    else if (a == "Metro Cúbico") resultado = valorEnBase / 1000;
                    else if (a == "Galón (US)") resultado = valorEnBase / 3.78541;
                    else if (a == "Taza") resultado = valorEnBase / 0.24;
                    break;

                case "Áreas":
                    // Base: Metros Cuadrados
                    if (de == "Centímetro²") valorEnBase = cantidad * 0.0001;
                    else if (de == "Metro²") valorEnBase = cantidad;
                    else if (de == "Kilómetro²") valorEnBase = cantidad * 1000000;
                    else if (de == "Hectárea") valorEnBase = cantidad * 10000;
                    else if (de == "Acre") valorEnBase = cantidad * 4046.86;
                    else if (de == "Vara²") valorEnBase = cantidad * 0.6988;

                    if (a == "Centímetro²") resultado = valorEnBase / 0.0001;
                    else if (a == "Metro²") resultado = valorEnBase;
                    else if (a == "Kilómetro²") resultado = valorEnBase / 1000000;
                    else if (a == "Hectárea") resultado = valorEnBase / 10000;
                    else if (a == "Acre") resultado = valorEnBase / 4046.86;
                    else if (a == "Vara²") resultado = valorEnBase / 0.6988;
                    break;
            }

            lblRespuesta.Text = $"Respuesta: {resultado:N4}";
        }
    }
}


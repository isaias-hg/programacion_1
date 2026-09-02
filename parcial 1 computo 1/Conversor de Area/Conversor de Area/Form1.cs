using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversor_de_Area
{
    public partial class Form1 : Form
    {


        double[] valores =
{
    0.09290304, // Pie cuadrado
    0.698896,   // Vara cuadrada
    0.83612736, // Yarda cuadrada
    1.0,        // Metro cuadrado
    436.81,     // Tarea
    6988.96,    // Manzana
    10000.0     // Hectárea
};

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int de = cboDe.SelectedIndex;
            int a = cboA.SelectedIndex;

            if (de == -1 || a == -1)
            {
                MessageBox.Show("Seleccione las unidades de origen y destino.");
                return;
            }

            if (!double.TryParse(txtCantidad.Text, out double cantidad))
            {
                MessageBox.Show("Ingrese una cantidad válida.");
                return;
            }

            double respuesta = cantidad * valores[de] / valores[a];

            lblRespuesta.Text = respuesta.ToString("N2");
        }
    }
}

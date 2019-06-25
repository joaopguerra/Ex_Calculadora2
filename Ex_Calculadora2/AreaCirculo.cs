using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Ex_Calculadora2
{
    public partial class AreaCirculo : Form
    {
        public AreaCirculo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double raio, pi, resultado;
            pi = 3.14;
            raio = double.Parse(txtraio.Text);
            resultado = pi * raio;
            txtResultado.Text = resultado.ToString("F2", CultureInfo.InvariantCulture);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
            CalculoAreas calculoAreas = new CalculoAreas();
            calculoAreas.Show();
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            txtraio.Text = "";
            txtResultado.Text = "";
        }
    }
}

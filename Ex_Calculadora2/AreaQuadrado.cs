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
    public partial class AreaQuadrado : Form
    {
        public AreaQuadrado()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double lado, resultado;
            lado = double.Parse(txtLado.Text);
            resultado = lado * lado;
            txtResultado.Text = resultado.ToString("F2", CultureInfo.InvariantCulture);
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            txtLado.Text = "";
            txtResultado.Text = "";
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            CalculoAreas calculoAreas = new CalculoAreas();
            calculoAreas.Show();
            Close();
        }
    }
}

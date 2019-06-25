using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_Calculadora2
{
    public partial class AreaTriangulo : Form
    {
        public AreaTriangulo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double base_, altura, resultado;
            base_ = double.Parse(txtBase.Text);
            altura = double.Parse(txtAltura.Text);
            resultado = (base_ * altura)/2;
            txtResultado.Text = resultado.ToString("F2", CultureInfo.InvariantCulture);
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            txtAltura.Text = "";
            txtBase.Text = "";
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

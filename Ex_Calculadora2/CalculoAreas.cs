using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_Calculadora2
{
    public partial class CalculoAreas : Form
    {
        public CalculoAreas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AreaCirculo areaCirculo = new AreaCirculo();
            areaCirculo.Show();
            Hide();
        }

        private void btnQuadrado_Click(object sender, EventArgs e)
        {
            AreaQuadrado areaQuadrado = new AreaQuadrado();
            areaQuadrado.Show();
            Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTriangulo_Click(object sender, EventArgs e)
        {
            AreaTriangulo areaTriangulo = new AreaTriangulo();
            areaTriangulo.Show();
            Hide();
        }

        private void btnRetangulo_Click(object sender, EventArgs e)
        {
            AreaRetangulo areaRetangulo = new AreaRetangulo();
            areaRetangulo.Show();
            Hide();
        }
    }
}

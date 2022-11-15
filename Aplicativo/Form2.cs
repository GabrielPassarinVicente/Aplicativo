using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicativo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }
        private void btnSomar_Click(object sender, EventArgs e)
        {
            int valor1, valor2, resultado;

            valor1 = Convert.ToInt32(textBox3.Text);
            valor2 = Convert.ToInt32(textBox4.Text);

            resultado = valor1 + valor2;

            label10.Text = resultado.ToString();

        }
    }
}

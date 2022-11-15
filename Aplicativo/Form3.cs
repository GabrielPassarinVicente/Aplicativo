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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void btnSubtrair_Click(object sender, EventArgs e)
        {

            int valor1, valor2, resultado;

            valor1 = Convert.ToInt32(textBox1.Text);
            valor2 = Convert.ToInt32(textBox2.Text);

            resultado = valor1 - valor2;

            label6.Text = resultado.ToString();
        }
    }
}

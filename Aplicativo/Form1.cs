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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnSoma_Click(object sender, EventArgs e)
        {
            Form2 nova = new Form2();
            nova.Show();

        }
        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            Form3 novo = new Form3();
            novo.Show();
        }
        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {

        }
        private void btnDivisao_Click(object sender, EventArgs e)
        {

        }
    }
}

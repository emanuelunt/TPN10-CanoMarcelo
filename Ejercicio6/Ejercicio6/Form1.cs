using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio6
{
    public partial class Form1 : Form
    {
        private int numero;
        private string operacion;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            numero = int.Parse(textBox1.Text);
            textBox1.Text = "";
            operacion = "suma";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int aux = int.Parse(textBox1.Text);

            if (operacion == "suma")
            {
                textBox1.Text = (numero + aux).ToString();
            }

            aux = 0;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            numero = 0;
            
        }

        private void btnCuantro_Click(object sender, EventArgs e)
        {
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora_com_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void num1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal v1 = decimal.Parse(textBox1.Text);
            decimal v2 = decimal.Parse(textBox2.Text);

            decimal resultado = v1 * v2;

            listBox1.Items.Add($"Multiplicação: {v1} X {v2} = {resultado}");

            label3.Text = "Resultado da multiplicação: " + resultado.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            decimal v1 = decimal.Parse(textBox1.Text);
            decimal v2 = decimal.Parse(textBox2.Text);

            decimal resultado = v1 + v2;
            listBox1.Items.Add($"Soma: {v1} + {v2} = {resultado}");

            label3.Text = "Resultado da soma: " + resultado.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            decimal v1 = decimal.Parse(textBox1.Text);
            decimal v2 = decimal.Parse(textBox2.Text);

            decimal resultado = v1 - v2;
            listBox1.Items.Add($"subtração: {v1} - {v2} = {resultado}");

            label3.Text = "Resultado da subtração: " + resultado.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal v1 = decimal.Parse(textBox1.Text);
            decimal v2 = decimal.Parse(textBox2.Text);

            decimal resultado = v1/v2;
            listBox1.Items.Add($"Divisão: {v1} / {v2} = {resultado:0.000}");

            label3.Text = ($"Resultado da divisão:  {resultado.ToString():0.000}");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

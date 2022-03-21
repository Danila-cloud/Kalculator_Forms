using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalculator
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

        private void button4_Click(object sender, EventArgs e)
        {
            int answer = 0;
            int val1 = Convert.ToInt32(textBox1.Text);
            int val2 = Convert.ToInt32(textBox2.Text);
            answer = val1 * val2;
            label2.Text = "*";
            label5.Text = "=";
            label1.Text = answer.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int answer = 0;
            int val1 = Convert.ToInt32(textBox1.Text);
            int val2 = Convert.ToInt32(textBox2.Text);
            answer = val1 + val2;
            label2.Text = "+";
            label5.Text = "=";
            label1.Text = answer.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double answer = 0;
            double val1 = Convert.ToDouble(textBox1.Text);
            double val2 = Convert.ToDouble(textBox2.Text);
            answer = val1 / val2;
            label2.Text = "%";
            label5.Text = "=";
            label1.Text = answer.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int answer = 0;
            int val1 = Convert.ToInt32(textBox1.Text);
            int val2 = Convert.ToInt32(textBox2.Text);
            answer = val1 - val2;
            label2.Text = "-";
            label5.Text = "=";
            label1.Text = answer.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

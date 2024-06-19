using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        long num1;
        string op;

        private void seven_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            long num2 = Convert.ToInt32(textBox1.Text);
            double result = Math.Sqrt(num2);
            textBox2.Text = result.ToString();
        }

        private void four_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void five_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void six_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void xsquare_Click(object sender, EventArgs e)
        {
            long num2 = Convert.ToInt32(textBox1.Text);
            double result = (num2 * num2);
            textBox2.Text = result.ToString();
        }

        private void one_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void two_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void three_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void plus_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(textBox1.Text);
            textBox1.Clear();
            op = "+";
        }

        private void zero_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(textBox1.Text);
            textBox1.Clear();
            op = "-";
        }

        private void equal_Click(object sender, EventArgs e)
        {
            long num2;

            if(op == "+")
            {
                num2 = Convert.ToInt32(textBox1.Text);
                long result = num1 + num2;
                textBox2.Text = result.ToString();
            } 
            if (op == "-")
            {
                num2 = Convert.ToInt32(textBox1.Text);
                long result = num1 - num2;
                textBox2.Text = result.ToString();
            }
            if (op == "/")
            {
                num2 = Convert.ToInt32(textBox1.Text);
                long result = num1 / num2;
                textBox2.Text = result.ToString();
            }
            if (op == "*")
            {
                num2 = Convert.ToInt32(textBox1.Text);
                long result = num1 * num2;
                textBox2.Text = result.ToString();
            }
            if (op == "%")
            {
                num2 = Convert.ToInt32(textBox1.Text);
                long result = num1 % num2;
                textBox2.Text = result.ToString();
            }
        }

        private void percentage_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(textBox1.Text);
            textBox1.Clear();
            op = "%";
        }

        private void mul_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(textBox1.Text);
            textBox1.Clear();
            op = "*";
        }

        private void div_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(textBox1.Text);
            textBox1.Clear();
            op = "/";
        }
    }
}

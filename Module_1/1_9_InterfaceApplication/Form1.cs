using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OperationClass op = new OperationClass();
            int res = op.add(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            listBox1.Items.Add("Addition: " + res);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OperationClass op = new OperationClass();
            double res = op.multiply(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
            listBox1.Items.Add("Multiplication: " + res);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OperationClass op = new OperationClass();
            String res = op.concatination(Convert.ToString(textBox3.Text), Convert.ToString(textBox4.Text));
            listBox1.Items.Add("Concatination: " + res);
        }
    }
}

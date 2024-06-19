using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiLevelInheritanceApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Rectangle r = new Rectangle();
                r.Height = Convert.ToDouble(textBox1.Text);
                r.Width = Convert.ToDouble(textBox2.Text);
                MessageBox.Show("Area of the rectangle is:" + r.getArea());
            }
            else if (radioButton2.Checked)
            {
                Square s = new Square();
                s.Height = Convert.ToDouble(textBox1.Text);
                MessageBox.Show("Area of the Square is:" + s.getArea());
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}

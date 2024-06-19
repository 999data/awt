using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SingleLevelInheritanceApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            ChildEmployee c = new ChildEmployee(textBox1.Text, Convert.ToDouble(textBox2.Text));
            MessageBox.Show("The Employee " + c.getName() + " is earning salary of " + c.getSalary());
        }
    }
}

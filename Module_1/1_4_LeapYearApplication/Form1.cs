using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeapYearApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Find_Click(object sender, EventArgs e)
        {
            LeapYear lp = new LeapYear();

            if (lp.getLeap(Convert.ToInt32(textBox1.Text)))
                MessageBox.Show("It is a leap year !!");
            else
                MessageBox.Show("It is not a leap year !!");
        }
    }
}

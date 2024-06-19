using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleInterestApplication
{
    public partial class SimpleInterestForm : Form
    {
        public SimpleInterestForm()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            SimpleInterestCalculator sI = new SimpleInterestCalculator();
            sI.Pamount = Convert.ToDouble(pamount.Text);
            sI.Year = Convert.ToInt32(txtyear.Text);
            sI.Interest = Convert.ToDouble(txtrate.Text);
            MessageBox.Show("The simple interest is: " + sI.getSI());
        }
    }
}

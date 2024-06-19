using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeWageCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            if(checkHourly.Checked)
            {
                HEmp h = new HEmp();
                h.Ename = textBox1.Text;
                h.Dname = textBox2.Text;
                h.Hrs=Convert.ToInt32(textBox3.Text);
                MessageBox.Show("Salary of " + h.Ename + " and working in the department " + h.Dname + " is " + h.getSalary(), "Salary of Hours.");
            }
            if (checkManager.Checked)
            {
                Manager m  = new Manager();
                m.Ename = textBox1.Text;
                m.Dname = textBox2.Text;
                m.Basic = Convert.ToInt32(textBox4.Text);
                MessageBox.Show("Salary of " + m.Ename + " and working in the department " + m.Dname + " is " + m.getSalary(), "Salary of Hours.");
            }
        }
    }
}

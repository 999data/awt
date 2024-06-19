using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XmlCalculatorWcfApp
{
    public partial class WCFCalculatorWebForm : System.Web.UI.Page
    {
        WebService1 obj = new WebService1 ();
        protected void Page_Load(object sender, EventArgs e)
        {
            Label3.Text = "Your Result = " + obj.HelloWorld();
        }

        protected void addition_Click(object sender, EventArgs e)
        {
            double sum = obj.add(Convert.ToDouble(TextBox1.Text), Convert.ToDouble(TextBox2.Text));
            Label3.Text = "Your addition Result = " + sum.ToString();
        }

        protected void subtraction_Click(object sender, EventArgs e)
        {
            double sub = obj.sub(Convert.ToDouble(TextBox1.Text), Convert.ToDouble(TextBox2.Text));
            Label3.Text = "Your substraction Result = " + sub.ToString();
        }

        protected void multiplication_Click(object sender, EventArgs e)
        {
            double mul = obj.mul(Convert.ToDouble(TextBox1.Text), Convert.ToDouble(TextBox2.Text));
            Label3.Text = "Your multiplication Result = " + mul.ToString();
        }

        protected void division_Click(object sender, EventArgs e)
        {
            double div = obj.div(Convert.ToDouble(TextBox1.Text), Convert.ToDouble(TextBox2.Text));
            Label3.Text = "Your division Result = " + div.ToString();
        }
    }
}
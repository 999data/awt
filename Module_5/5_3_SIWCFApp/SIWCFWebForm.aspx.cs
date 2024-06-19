using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SIWCFApp
{
    public partial class SIWCFWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        ServiceReference1.Service1Client ob = new ServiceReference1.Service1Client();

        protected void calculate_Click(object sender, EventArgs e)
        {
            string name = ob.GetName("Sahil!!");
            Response.Write("Hello " + name);
            double p = Convert.ToDouble(TextBox1.Text);
            double t = Convert.ToDouble(TextBox2.Text);
            double r = Convert.ToDouble(TextBox3.Text);
            double si = ob.getSI(p, t, r);
            Label4.Text = si.ToString() + " SI ";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterWebApplication
{
    public partial class ContentPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label2.Text = "You Have Entered " + TextBox1.Text;
            Label2.Visible = true;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginApplication
{
    public partial class LoginApplication : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            Session["id"] = TextBox1.Text;
            Response.Redirect("logout.aspx");
            Session.RemoveAll();
        }
    }
}
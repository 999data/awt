using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CookiesApplication
{
    public partial class CookiesWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void create_Click(object sender, EventArgs e)
        {
            HttpCookie cook1 = new HttpCookie("username");
            cook1.Values["username"] = TextBox1.Text;
            cook1.Expires = DateTime.Now.AddSeconds(10);
            Response.Cookies.Add(cook1);
            Label2.Text = "Cookie " + TextBox1.Text + " Created";
        }

        protected void read_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["username"] != null)
            {
                Label2.Text = "Cookie Read: " + Request.Cookies["username"].Value;
            }
            else
            {
                Label2.Text = "Cookie Empty";
            }
        }

        protected void delete_Click(object sender, EventArgs e)
        {
            Response.Cookies["username"].Expires = DateTime.Now.AddHours(-1);
            Label2.Text = "Cookie Deleted";
        }
    }
}
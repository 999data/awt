using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class StateManagement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack == true)
            {
                Label1.Text = "0";
                Label2.Text = "0";
                Label3.Text = "0";
                Label4.Text = "0";
            }
        }

        protected void cookies_Click(object sender, EventArgs e)
        {
            int cook;
            if (Request.Cookies["cook"] == null)
            {
                cook = 0;
            }
            else
            {
                cook = int.Parse(Request.Cookies["cook"].Value);
            }
            cook++;
            Label1.Text = cook.ToString();
        }

        protected void session_Click(object sender, EventArgs e)
        {
            if (Session["count"] != null)
            {
                Session["count"] = Convert.ToInt32(Session["count"]) + 1;
            }
            else
            {
                Session["count"] = Convert.ToInt32(Session["count"] = 1);
            }
            Label2.Text = Session["count"].ToString();
        }

        protected void viewstate_Click(object sender, EventArgs e)
        {
            if (ViewState["num"] != null)
            {
                ViewState["num"] = Convert.ToInt32(ViewState["num"]) + 1;
            }
            else
            {
                ViewState["num"] = Convert.ToInt32(ViewState["num"] = 1);
            }
            Label3.Text = ViewState["num"].ToString();
        }

        protected void application_Click(object sender, EventArgs e)
        {
            if (Application["num"] != null)
            {
                Application["num"] = Convert.ToInt32(Application["num"]) + 1;
            }
            else
            {
                Application["num"] = Convert.ToInt32(Application["num"] = 1);
            }
            Label4.Text = Application["num"].ToString();
        }
    }
}
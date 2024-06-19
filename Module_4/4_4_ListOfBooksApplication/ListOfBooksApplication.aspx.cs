using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ListOfBooksApplication
{
    public partial class ListOfBooksApplication : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            {
                Session["bookname"] = DropDownList1.SelectedItem;
                if (Session["bookname"] == null)
                {
                    Response.Write("<script> alert('Book NOT selected.')</script>");
                }
                else
                {
                    Server.Transfer("bookinfo.aspx");
                }

            }
        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
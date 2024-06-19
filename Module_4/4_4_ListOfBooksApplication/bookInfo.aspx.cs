using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ListOfBooksApplication
{
    public partial class bookInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string book = Session["bookname"].ToString();
            Label1.Text = book;
        }
    }
}
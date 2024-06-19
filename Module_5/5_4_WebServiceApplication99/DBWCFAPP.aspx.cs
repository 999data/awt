using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebServiceApplication99
{
    public partial class DBWCFAPP : System.Web.UI.Page
    {

        ServiceReference1.DBWCFClient db = new ServiceReference1.DBWCFClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = db.getEmployee();
            GridView1.DataBind();
        }
    }
}
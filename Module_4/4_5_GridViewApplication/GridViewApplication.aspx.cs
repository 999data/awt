using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GridViewApplication
{
    public partial class GridViewApplication : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ArrayList stud;

            if (Cache["stud"] == null)

            {

                stud = new ArrayList();

                stud.Add(DateTime.Now.AddSeconds(10));

                Cache.Add("stud", stud, null, System.Web.Caching.Cache.NoAbsoluteExpiration, new TimeSpan(0, 0, 10), System.Web.Caching.CacheItemPriority.Default, null);

            }

            else

            {

                stud = (ArrayList)Cache["stud"];

                foreach (DateTime dt in stud)

                    Response.Write(dt.ToString() + "cache object <br/>");
            }
        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }
    }
}

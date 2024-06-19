using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinqApplication
{
    public partial class LinqFirstApplication : System.Web.UI.Page
    {
        public List<Dept> Getdata()
        {
            return new List<Dept>
          {
           new Dept { DepartmentId = 1, Name = "Account" },
           new Dept { DepartmentId = 2, Name = "Sales" },
           new Dept { DepartmentId = 3, Name = "Marketing" },
           new Dept { DepartmentId = 4, Name = "Account" },
           new Dept { DepartmentId = 5, Name = "Testing" }
          };
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            var departmentList = Getdata();
            var q = from d in departmentList 
                    where d.DepartmentId >= 3
                    select d;
            this.GridView1.DataSource = q;
            this.GridView1.DataBind();
        }
    }
}
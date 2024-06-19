using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinqDataSetApplication
{
    public partial class LinqDataSet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindGridview();
            }
        }
        protected void BindGridview()
        {
            DataSet ds = new DataSet();
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sahil\OneDrive\Documents\EmployeeDB.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Emp", con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                con.Close();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    var result = from dt in ds.Tables[0].AsEnumerable()
                                 where (dt.Field<string>("Name").EndsWith("i"))
                                 select new
                                 {
                                     Name = dt.Field<string>("Name"),
                                     Salary = dt.Field<int>("Salary")

                                 };
                    GridView1.DataSource = result;
                    GridView1.DataBind();
                }
            }
        }
    }
}
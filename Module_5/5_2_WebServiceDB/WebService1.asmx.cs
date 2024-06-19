using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServiceDB
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        SqlConnection con;
        SqlDataAdapter adap;
        DataSet ds;
        SqlCommand cmd;

        [WebMethod]
        public DataSet GetSmember()
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sahil\OneDrive\Documents\EmployeeDB.mdf;Integrated Security=True;Connect Timeout=30;");
            adap = new SqlDataAdapter("select * from Employee", con);
            ds = new DataSet();
            adap.Fill(ds, "Employee");
            return ds;
        }

        [WebMethod]
        public int SaveData(int Eid, string Ename, string Edept)
        {
            using (con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sahil\OneDrive\Documents\EmployeeDB.mdf;Integrated Security=True;Connect Timeout=30;"))
            {
                con.Open();
                using (cmd = new SqlCommand("INSERT INTO Employee (Eid, Ename, Edept) VALUES (@Eid, @Ename, @Edept)", con))
                {
                    cmd.Parameters.AddWithValue("@Eid", Eid);
                    cmd.Parameters.AddWithValue("@Ename", Ename);
                    cmd.Parameters.AddWithValue("@Edept", Edept);

                    int result = cmd.ExecuteNonQuery();
                    return result;
                }
            }
        }
    }
}

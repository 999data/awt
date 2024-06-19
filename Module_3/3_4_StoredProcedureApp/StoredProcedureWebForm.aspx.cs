using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StoredProcedureApp
{
    public partial class StoredProcedureWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void showNames_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sahil\OneDrive\Documents\EmployeeDB.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand command = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SPEname";
                adapter = new SqlDataAdapter(command);
                adapter.Fill(ds);
                con.Close();
                ListBox1.DataSource = ds.Tables[0];
                ListBox1.DataTextField = "Ename";
                ListBox1.DataBind();
            }
            catch (Exception ex)
            {
                Label1.Text = "Error in execution " + ex.ToString();
            }
        }
    }
}
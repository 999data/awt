using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DatabaseApplication
{
    public partial class ConnectedDisconnected : System.Web.UI.Page
    {
        string StrSQL = "", StrConnection = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            StrSQL = "SELECT * FROM student";
            StrConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sahil\OneDrive\Documents\studentdb.mdf;Integrated Security=True;Connect Timeout=30";
        }

        protected void connected_Click(object sender, EventArgs e)
        {
            using (SqlConnection objConn = new SqlConnection(StrConnection))
            {
                SqlCommand objCmd = new SqlCommand(StrSQL, objConn);
                objCmd.CommandType = CommandType.Text;
                objConn.Open();
                SqlDataReader objDr = objCmd.ExecuteReader();
                GridView1.DataSource = objDr;
                GridView1.DataBind();
                objConn.Close();
            }
        }

        protected void disconnected_Click(object sender, EventArgs e)
        {
            SqlDataAdapter objDa = new SqlDataAdapter();
            DataSet objDs = new DataSet();
            using (SqlConnection objConn = new SqlConnection(StrConnection))
            {
                SqlCommand objCmd = new SqlCommand(StrSQL, objConn);
                objCmd.CommandType = CommandType.Text;
                objDa.SelectCommand = objCmd;
                objDa.Fill(objDs, "stud");
                GridView1.DataSource = objDs.Tables[0];
                GridView1.DataBind();

            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
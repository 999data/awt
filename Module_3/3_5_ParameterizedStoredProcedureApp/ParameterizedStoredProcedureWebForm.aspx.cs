using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace ParameterizedStoredProcedureApp
{
    public partial class ParameterizedStoredProcedureWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.BindGrid();
        }

        protected void insert_Click(object sender, EventArgs e)
        {
            string name = TextBox2.Text;
            string Dept = TextBox3.Text;

            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sahil\OneDrive\Documents\EmployeeDB.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                using (SqlCommand cmd = new SqlCommand("MyProcedure"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Action", "INSERT");
                    cmd.Parameters.AddWithValue("@Eid", TextBox1.Text);
                    cmd.Parameters.AddWithValue("@Ename", name);
                    cmd.Parameters.AddWithValue("@Edept", Dept);
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            this.BindGrid();
        }

        private void BindGrid()
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sahil\OneDrive\Documents\EmployeeDB.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                using (SqlCommand cmd = new SqlCommand("MyProcedure"))
                {
                    cmd.Parameters.AddWithValue("@Action", "SELECT");
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            GridView1.DataSource = dt;
                            GridView1.DataBind();
                        }
                    }
                }
            }
        }

        protected void update_Click(object sender, EventArgs e)
        {
            string str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sahil\OneDrive\Documents\EmployeeDB.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection cn = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("MyProcedure", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Action", "UPDATE");
            cmd.Parameters.AddWithValue("@Eid", TextBox1.Text);
            cmd.Parameters.AddWithValue("@Ename", TextBox2.Text);
            cmd.Parameters.AddWithValue("@Edept", TextBox3.Text);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            this.BindGrid();
        }

        protected void delete_Click(object sender, EventArgs e)
        {
            string str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sahil\OneDrive\Documents\EmployeeDB.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection cn = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("MyProcedure", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Action", "DELETE");
            cmd.Parameters.AddWithValue("@Eid", TextBox1.Text);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            this.BindGrid();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
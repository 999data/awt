using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DBCrudOperationConnectedApp
{
    public partial class CrudApplication : System.Web.UI.Page
    {

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sahil\OneDrive\Documents\EmployeeDB.mdf;Integrated Security=True;Connect Timeout=30");
        }

        private void Display()
        {
            con.Open();
            cmd = new SqlCommand("select * from Employee", con);
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            con.Close();
        }

        protected void insert_Click(object sender, EventArgs e)
        {
            con.Open();
            int eid = Convert.ToInt32(TextBox1.Text);
            string ename = TextBox2.Text;
            string edept = TextBox3.Text;
            cmd = new SqlCommand("INSERT INTO Employee(Eid, Ename,Edept) VALUES ('" + eid + "','" + ename + "','" + edept + "')", con);
            cmd.ExecuteNonQuery();
            Response.Write("one record inserted:");
            con.Close();
            Display();
        }

        protected void delete_Click(object sender, EventArgs e)
        {
            con.Open();
            int eid = Convert.ToInt32(TextBox1.Text);
            cmd = new SqlCommand("DELETE FROM Employee where Eid='" + eid + "'", con);
            cmd.ExecuteNonQuery();
            Response.Write("one record Delete:");
            con.Close();
            Display();
        }

        protected void update_Click(object sender, EventArgs e)
        {
            con.Open();
            int eid = Convert.ToInt32(TextBox1.Text);
            string ename = TextBox2.Text;
            string edept = TextBox3.Text;
            string abc = "UPDATE Employee SET Eid ='" + eid + "', Ename ='" + ename + "',Edept ='" + edept + "' WHERE Eid = '" + eid + "'";
            SqlCommand cmd = new SqlCommand(abc, con);
            cmd.ExecuteNonQuery();
            Response.Write("one record updated:");
            con.Close();
            Display();
        }

        protected void display_Click(object sender, EventArgs e)
        {
            Display();
        }

        protected void search_Click(object sender, EventArgs e)
        {
            con.Open();
            int aa = Convert.ToInt32(TextBox1.Text);
            string abc = "SELECT Eid,Ename,Edept FROM Employee where Eid='" + aa + "'";
            cmd = new SqlCommand(abc, con);
            Response.Write("one record search:");
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            con.Close();
        }

        protected void totalRecord_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("select Count(*) from Employee", con);
            int a = (int)cmd.ExecuteScalar();
            Label4.Text = "Total Record:--> " + a.ToString();
            con.Close();
        }

        protected void exit_Click(object sender, EventArgs e)
        {

        }
    }
}
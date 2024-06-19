using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DBCrudOperationDisconnectedApp
{
    public partial class CrudApplication : System.Web.UI.Page
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sahil\OneDrive\Documents\EmployeeDB.mdf;Integrated Security=True;Connect Timeout=30";
        DataSet ds;
        SqlDataAdapter adapter;
        SqlConnection con;

        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(connectionString);
            if (!IsPostBack)
            {
                ds = new DataSet();
                ViewState["EmployeeDataSet"] = ds;
                Display();
            }
            else
            {
                ds = (DataSet)ViewState["EmployeeDataSet"];
            }
        }

        private void Display()
        {
            using (con = new SqlConnection(connectionString))
            {
                adapter = new SqlDataAdapter("SELECT * FROM Employee", con);
                ds.Clear();
                adapter.Fill(ds, "Employee");
                GridView1.DataSource = ds.Tables["Employee"];
                GridView1.DataBind();
                ViewState["EmployeeDataSet"] = ds;
            }
        }

        protected void insert_Click(object sender, EventArgs e)
        {
            DataTable dt = ds.Tables["Employee"];
            DataRow newRow = dt.NewRow();
            newRow["Eid"] = Convert.ToInt32(TextBox1.Text);
            newRow["Ename"] = TextBox2.Text;
            newRow["Edept"] = TextBox3.Text;
            dt.Rows.Add(newRow);

            using (con = new SqlConnection(connectionString))
            {
                adapter = new SqlDataAdapter("SELECT * FROM Employee", con);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.Update(ds, "Employee");
            }
            Response.Write("One record inserted");
            Display();
        }

        protected void delete_Click(object sender, EventArgs e)
        {
            DataTable dt = ds.Tables["Employee"];
            DataRow[] rows = dt.Select("Eid = " + Convert.ToInt32(TextBox1.Text));

            if (rows.Length > 0)
            {
                rows[0].Delete();

                using (con = new SqlConnection(connectionString))
                {
                    adapter = new SqlDataAdapter("SELECT * FROM Employee", con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    adapter.Update(ds, "Employee");
                }
                Response.Write("One record deleted");
                Display();
            }
        }

        protected void update_Click(object sender, EventArgs e)
        {
            DataTable dt = ds.Tables["Employee"];
            DataRow[] rows = dt.Select("Eid = " + Convert.ToInt32(TextBox1.Text));

            if (rows.Length > 0)
            {
                rows[0]["Eid"] = Convert.ToInt32(TextBox1.Text);
                rows[0]["Ename"] = TextBox2.Text;
                rows[0]["Edept"] = TextBox3.Text;

                using (con = new SqlConnection(connectionString))
                {
                    adapter = new SqlDataAdapter("SELECT * FROM Employee", con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    adapter.Update(ds, "Employee");
                }
                Response.Write("One record updated");
                Display();
            }
        }

        protected void display_Click(object sender, EventArgs e)
        {
            Display();
        }

        protected void search_Click(object sender, EventArgs e)
        {
            DataTable dt = ds.Tables["Employee"];
            DataRow[] rows = dt.Select("Eid = " + Convert.ToInt32(TextBox1.Text));

            if (rows.Length > 0)
            {
                DataTable searchResult = dt.Clone();
                searchResult.ImportRow(rows[0]);
                GridView1.DataSource = searchResult;
                GridView1.DataBind();
                Response.Write("One record found");
            }
            else
            {
                Response.Write("No record found");
            }
        }

        protected void totalRecord_Click(object sender, EventArgs e)
        {
            DataTable dt = ds.Tables["Employee"];
            Label4.Text = "Total Records: " + dt.Rows.Count.ToString();
        }

        protected void exit_Click(object sender, EventArgs e)
        {
            // Add exit functionality if needed
        }
    }
}

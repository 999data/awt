using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntityFrameworkApplication
{
    public partial class EntityFrameworkWebForm : System.Web.UI.Page
    {
        DBNewEmpEntities1 conn = new DBNewEmpEntities1();

        Employee E = new Employee();
        protected void Page_Load(object sender, EventArgs e)
        {
            Display();
        }

        public void Display()

        {

            var result = (from r in conn.Employees

                          select new { r.empID, r.empName, r.empDept_no }).ToList();

            GridView1.DataSource = result;

            GridView1.DataBind();

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void search_Click(object sender, EventArgs e)
        {
            E.empID = Convert.ToInt32(TextBox1.Text);

            var result = (from r in conn.Employees

                          where r.empID == E.empID

                          select new { r.empID, r.empName, r.empDept_no }).Single();

            GridView1.DataSource = result;

            GridView1.DataBind();
        }

        protected void add_Click(object sender, EventArgs e)
        {
            E.empID = Convert.ToInt32(TextBox1.Text);

            E.empName = TextBox2.Text;

            E.empDept_no = TextBox2.Text;

            conn.Employees.Add(E);

            conn.SaveChanges();

            Display();
        }

        protected void edit_Click(object sender, EventArgs e)
        {
            E.empID = Convert.ToInt32(TextBox1.Text);

            E.empName = TextBox2.Text;

            E.empDept_no = TextBox3.Text;

            conn.Employees.AddOrUpdate(E);

            conn.SaveChanges();

            Display();
        }

        protected void delete_Click(object sender, EventArgs e)
        {
            E.empID = Convert.ToInt32(TextBox1.Text);

            var result = (from r in conn.Employees

                          where r.empID == E.empID

                          select r).Single();

            conn.Employees.Remove(result);

            conn.SaveChanges();

            Display();
        }
    }
}
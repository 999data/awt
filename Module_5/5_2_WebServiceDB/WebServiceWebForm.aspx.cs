using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebServiceDB
{
    public partial class WebServiceWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void save_Click(object sender, EventArgs e)
        {
            try
            {
                // Assuming TextBox1 is for Eid, TextBox2 is for Ename, and TextBox3 is for Edept
                int Id = Convert.ToInt32(TextBox1.Text);  // Eid
                string Name = TextBox2.Text;              // Ename
                string Dept = TextBox3.Text;              // Edept

                WebService1 myservice = new WebService1();
                int roweffected = myservice.SaveData(Id, Name, Dept);

                if (roweffected == 1)
                {
                    Label4.Text = "Record is Saved";
                }
                else
                {
                    Label4.Text = "Sorry, record is not saved. Try again.";
                }
            }
            catch (Exception ex)
            {
                Label4.Text = "An error occurred: " + ex.Message;
            }
        }

        protected void show_Click(object sender, EventArgs e)
        {
            WebService1 mys = new WebService1();
            mys.GetSmember();
            GridView1.DataSource = mys.GetSmember();
            GridView1.DataBind();
        }
    }
}
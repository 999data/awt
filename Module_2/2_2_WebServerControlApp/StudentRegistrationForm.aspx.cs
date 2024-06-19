using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebServerControlApp
{
    public partial class StudentRegistrationForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string msg = "";

            msg += "Hello..!!!" + TextBox1.Text;

            msg += "<br/>" + "Your email id is: " + TextBox2.Text;

            if (RadioButton1.Checked)

            msg += "<br/>" + "Gender: " + RadioButton1.Text;

            if (RadioButton2.Checked)

            msg += "<br/>" + "Gender: " + RadioButton2.Text;

            msg += "<br/>" + "Date of Birth: " + Calendar1.SelectedDate.ToShortDateString();

            if (CheckBox1.Checked)
            {
                msg += "<br/>" + "COURSE " + CheckBox1.Text;
            }

            if (CheckBox2.Checked)
            {
                msg += "<br/>" + "COURSE " + CheckBox2.Text;
            }

            if (CheckBox3.Checked)
            {
                msg += "<br/>" + "COURSE " + CheckBox3.Text;
            }

            if (CheckBox4.Checked)
            {
                msg += "<br/>" + "COURSE " + CheckBox4.Text;
            }
            Label7.Text = msg;
        }
    }
}
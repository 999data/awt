using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PageLifeCycleApp
{
    public partial class PageLifeCycle : System.Web.UI.Page
    {
        protected void Page_PriInit(Object sender, EventArgs e)
        {
            Label1.Text = Label1.Text + "<br/>" + "I am PreInit Event";
        }
        protected void Page_Init(Object sender, EventArgs e)
        {
            Label1.Text = Label1.Text + "<br/>" + "I am Init Event";
        }
        protected void Page_InitComplete(Object sender, EventArgs e)
        {
            Label1.Text = Label1.Text + "<br/>" + "I am InitComplete Event";
        }
        protected override void OnPreLoad(EventArgs e)
        {
            Label1.Text = Label1.Text + "<br/>" + "I am PreLoad Event";
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Label1.Text + "<br/>" + "I am Load Event";
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = Label1.Text + "<br/>" + "I am Button Click..... Event";

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalendarApplication
{
    public partial class CalendarApplication : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "Today's Date is: " + Calendar1.TodaysDate.ToShortDateString();
        }

        protected void calender1_SelectionChanged(object sender, EventArgs e)
        {
            Label4.Text = Calendar1.SelectedDate.ToLongDateString();
        }

        protected void calender1_VisibleMonthChanged(object sender, MonthChangedEventArgs e)
        {
            Label3.Text = "Selected Month & Year is: " + e.NewDate.Month + "-" + e.NewDate.Year;
        }

        protected void calender1_DayRender(object sender, DayRenderEventArgs e)
        {
            if (e.Day.Date == new DateTime(2024, 3, 29))
            {
                Literal l1 = new Literal();
                Image img1  = new Image();
                e.Cell.Width = 200;
                e.Cell.Height = 200;
                e.Cell.Font.Italic = true;
                e.Cell.Font.Size = FontUnit.XLarge;
                e.Cell.BackColor = System.Drawing.Color.LightPink;
                img1.ImageUrl = "~/image/holi.jpg";
                img1.Width = 70;
                img1.Height = 70;
                l1.Text = "<br /><font size=2 color=Red>Holi</font>";
                e.Cell.Controls.AddAt(1, l1);
                e.Cell.Controls.AddAt(0, img1);            
            }

            if (e.Day.Date == new DateTime(2024, 3, 21))
            {
                Literal l1 = new Literal();
                Image img1 = new Image();
                e.Cell.Width = 200;
                e.Cell.Height = 200;
                e.Cell.Font.Italic = true;
                e.Cell.Font.Size = FontUnit.XLarge;
                e.Cell.BackColor = System.Drawing.Color.LightGreen;
                img1.ImageUrl = "~/image/bday.jpg";
                img1.Width = 70;
                img1.Height = 70;
                l1.Text = "<br /><font size=2 color=Red>Birthday</font>";
                e.Cell.Controls.AddAt(1, l1);
                e.Cell.Controls.AddAt(0, img1);
            }

        }

    }
}
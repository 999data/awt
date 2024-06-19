<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CalendarApplication.aspx.cs" Inherits="CalendarApplication.CalendarApplication" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           <center>
         <h1 style="color: red;"> CALENDAR CONTROL</h1>
               <br />
               <br />
        <asp:Label ID="Label1" runat="server" Text="Label1"></asp:Label><br />
               <br />    
        <asp:Label ID="Label2" runat="server" Text="Label2"></asp:Label><br />
               <br />
        <asp:Label ID="Label3" runat="server" Text="Label3"></asp:Label><br />
               <br />
        <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="350px" OnDayRender="calender1_DayRender" OnSelectionChanged="calender1_SelectionChanged" OnVisibleMonthChanged="calender1_VisibleMonthChanged">
            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="#333399" ForeColor="White" />
            <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
            <TodayDayStyle BackColor="#CCCCCC" />
            </asp:Calendar>
               <br />
               <br />
        <asp:Label ID="Label4" runat="server" Text="Label4"></asp:Label><br />
               <br />
           </center>
        </div>
    </form>
</body>
</html>

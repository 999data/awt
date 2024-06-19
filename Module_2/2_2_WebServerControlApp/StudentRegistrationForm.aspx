<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentRegistrationForm.aspx.cs" Inherits="WebServerControlApp.StudentRegistrationForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
                <h1>Student Registration Form</h1>
                <br />
                <asp:Label ID="Label1" runat="server" Text="Student Name"></asp:Label>&nbsp<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
                <asp:Label ID="Label2" runat="server" Text="Email ID"></asp:Label>&nbsp<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
                <asp:Label ID="Label3" runat="server" Text="Password"></asp:Label>&nbsp<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
                <asp:Label ID="Label4" runat="server" Text="Gender:"></asp:Label>&nbsp<asp:RadioButton ID="RadioButton1" runat="server" Text="Male" />&nbsp<asp:RadioButton ID="RadioButton2" runat="server" Text="Female" /><br />
                <asp:Label ID="Label5" runat="server" Text="Date of Birth:"></asp:Label><br />
                <br />
                <asp:Calendar ID="Calendar1" runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" ShowGridLines="True" Width="220px">
                    <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
                    <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
                    <OtherMonthDayStyle ForeColor="#CC9966" />
                    <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
                    <SelectorStyle BackColor="#FFCC66" />
                    <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
                    <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
                </asp:Calendar>
                <br />
                <asp:Label ID="Label6" runat="server" Text="Course:"></asp:Label>&nbsp<asp:CheckBox ID="CheckBox1" runat="server" Text="BCA" />&nbsp<asp:CheckBox ID="CheckBox2" runat="server" Text="MCA" />&nbsp<asp:CheckBox ID="CheckBox3" runat="server" Text="MBA" />&nbsp<asp:CheckBox ID="CheckBox4" runat="server" Text="MMS" /><br />
                <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" /><br />
                <asp:Label ID="Label7" runat="server" Text=""></asp:Label>
            </center>
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SIWCFWebForm.aspx.cs" Inherits="SIWCFApp.SIWCFWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
                <h3> Simple Interest Calculator using WCF Service </h3>
                <asp:Label ID="Label1" runat="server" Text="Enter Principle Amount:"></asp:Label>&nbsp<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
                <asp:Label ID="Label2" runat="server" Text="Enter Time:"></asp:Label>&nbsp<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
                <asp:Label ID="Label3" runat="server" Text="Enter Rate:"></asp:Label>&nbsp<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
                <asp:Button ID="calculate" runat="server" Text="Calculate Simple Interest" OnClick="calculate_Click" /><br />
                <br />
                <br />
                <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label><br />
            </center>
        </div>
    </form>
</body>
</html>

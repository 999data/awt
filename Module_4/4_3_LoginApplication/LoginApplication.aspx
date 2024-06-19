<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginApplication.aspx.cs" Inherits="LoginApplication.LoginApplication" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
                <h3>Server-Side Session Management Techniques (Login)</h3>
                <asp:Label ID="Label1" runat="server" Text="Username:"></asp:Label>&nbsp<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
                <asp:Label ID="Label2" runat="server" Text="Password:"></asp:Label>&nbsp<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
                <asp:Button ID="submit" runat="server" Text="Submit" OnClick="submit_Click" />
            </center>
        </div>
    </form>
</body>
</html>

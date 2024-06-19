<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CookiesWebForm.aspx.cs" Inherits="CookiesApplication.CookiesWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
                <h3>Cookies</h3><br />
                <asp:Label ID="Label1" runat="server" Text="Enter your Cookie: "></asp:Label>&nbsp<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
                <br />
                <asp:Button ID="create" runat="server" Text="Create" OnClick="create_Click" />&nbsp<asp:Button ID="read" runat="server" Text="Read" OnClick="read_Click" />&nbsp<asp:Button ID="delete" runat="server" Text="Delete" OnClick="delete_Click" /><br />
                <br />
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            </center>
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="logout.aspx.cs" Inherits="LoginApplication.logout" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
                Logged in Successfully.
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" Text="Logout" OnClick="Button1_Click" /><br />
                <br />
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </center>
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StateManagement.aspx.cs" Inherits="StateManagement.StateManagement" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
                <h3>Session Management</h3>
                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>&nbsp&nbsp<asp:Button ID="cookies" runat="server" Text="Cookies" OnClick="cookies_Click" /><br />
                <br />
                <asp:Label ID="Label2" runat="server" Text=""></asp:Label>&nbsp&nbsp<asp:Button ID="session" runat="server" Text="Session" OnClick="session_Click" /><br />
                <br />
                <asp:Label ID="Label3" runat="server" Text=""></asp:Label>&nbsp&nbsp<asp:Button ID="viewstate" runat="server" Text="View State" OnClick="viewstate_Click" /><br />
                <br />
                <asp:Label ID="Label4" runat="server" Text=""></asp:Label>&nbsp&nbsp<asp:Button ID="application" runat="server" Text="Application" OnClick="application_Click" /><br />
                <br />
            </center>
        </div>
    </form>
</body>
</html>

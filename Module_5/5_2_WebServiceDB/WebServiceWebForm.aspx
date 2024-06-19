<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebServiceWebForm.aspx.cs" Inherits="WebServiceDB.WebServiceWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
                <asp:Label ID="Label1" runat="server" Text="Id"></asp:Label>&nbsp<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
                <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>&nbsp<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
                <asp:Label ID="Label3" runat="server" Text="Department"></asp:Label>&nbsp<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
                <asp:Button ID="save" runat="server" Text="Save" OnClick="save_Click" />&nbsp&nbsp<asp:Button ID="show" runat="server" Text="Show" OnClick="show_Click" /><br />
                <br />
                <asp:Label ID="Label4" runat="server" Text=""></asp:Label><br />
                <br />
                <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            </center>
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CrudApplication.aspx.cs" Inherits="DBCrudOperationConnectedApp.CrudApplication" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
                <h3>Crud Application using Connected Architecture</h3>
                <asp:Label ID="Label1" runat="server" Text="Emp ID"></asp:Label>&nbsp&nbsp<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
                <asp:Label ID="Label2" runat="server" Text="Emp Name"></asp:Label>&nbsp&nbsp<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
                <asp:Label ID="Label3" runat="server" Text="Emp Department"></asp:Label>&nbsp&nbsp<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
                <br />
                <asp:Button ID="insert" runat="server" Text="Insert" OnClick="insert_Click" />&nbsp<asp:Button ID="delete" runat="server" Text="Delete" OnClick="delete_Click" />&nbsp<asp:Button ID="update" runat="server" Text="Update" OnClick="update_Click" />&nbsp<asp:Button ID="display" runat="server" Text="Display" OnClick="display_Click" /><br />
                <asp:Button ID="search" runat="server" Text="Search" OnClick="search_Click" />&nbsp<asp:Button ID="totalRecord" runat="server" Text="Total Record" OnClick="totalRecord_Click" />&nbsp<asp:Button ID="exit" runat="server" Text="Exit" OnClick="exit_Click" />
                <br />
                <br />
                <asp:Label ID="Label4" runat="server" Text=""></asp:Label><br />
                <br />
                <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            </center>
        </div>
    </form>
</body>
</html>

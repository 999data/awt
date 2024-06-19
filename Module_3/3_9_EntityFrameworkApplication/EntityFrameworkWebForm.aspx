<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EntityFrameworkWebForm.aspx.cs" Inherits="EntityFrameworkApplication.EntityFrameworkWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
                <h3>Entity Framework</h3>
                <br />
                <asp:Label ID="Label1" runat="server" Text="Eid"></asp:Label>&nbsp&nbsp<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
                <asp:Label ID="Label2" runat="server" Text="Emp Name"></asp:Label>&nbsp&nbsp<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
                <asp:Label ID="Label3" runat="server" Text="DeptNo"></asp:Label>&nbsp&nbsp<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
                <br />
                <br />
                <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical">
                    <AlternatingRowStyle BackColor="#CCCCCC" />
                    <FooterStyle BackColor="#CCCCCC" />
                    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#808080" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#383838" />
                </asp:GridView>
                <br />
                <br />

                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>&nbsp&nbsp<asp:Button ID="search" runat="server" Text="Search" OnClick="search_Click" /><br />
                <br />
                <asp:Button ID="add" runat="server" Text="Add" OnClick="add_Click" />&nbsp&nbsp<asp:Button ID="edit" runat="server" Text="Edit" OnClick="edit_Click" />&nbsp&nbsp<asp:Button ID="delete" runat="server" Text="Delete" OnClick="delete_Click" />
            </center>
        </div>
    </form>
</body>
</html>

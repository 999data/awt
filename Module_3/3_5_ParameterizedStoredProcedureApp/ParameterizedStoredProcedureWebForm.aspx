<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ParameterizedStoredProcedureWebForm.aspx.cs" Inherits="ParameterizedStoredProcedureApp.ParameterizedStoredProcedureWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
                <h3>Web Form for Stored Procedure with Parameters</h3>
                <br />
                <asp:GridView ID="GridView1" runat="server"></asp:GridView>
                <br />
                <asp:Label ID="Label1" runat="server" Text="Employee ID"></asp:Label>&nbsp&nbsp
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
                <asp:Label ID="Label2" runat="server" Text="Employee Name"></asp:Label>&nbsp&nbsp
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
                <asp:Label ID="Label3" runat="server" Text="Employee Department"></asp:Label>&nbsp&nbsp
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
                <br />
                <br />
                <asp:Button ID="insert" runat="server" Text="Insert" OnClick="insert_Click" />&nbsp<asp:Button ID="update" runat="server" Text="Update" OnClick="update_Click" />&nbsp<asp:Button ID="delete" runat="server" Text="Delete" OnClick="delete_Click" />&nbsp<br />
            </center>
        </div>
    </form>
</body>
</html>

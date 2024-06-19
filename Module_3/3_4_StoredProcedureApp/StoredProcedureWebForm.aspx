<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StoredProcedureWebForm.aspx.cs" Inherits="StoredProcedureApp.StoredProcedureWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
                <asp:Button ID="showNames" runat="server" Text="Show Employee Names" OnClick="showNames_Click" /><br />
                <br />
                <asp:ListBox ID="ListBox1" runat="server" Height="60px" Width="120px"></asp:ListBox><br />
                <br />
                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            </center>
        </div>
    </form>
</body>
</html>

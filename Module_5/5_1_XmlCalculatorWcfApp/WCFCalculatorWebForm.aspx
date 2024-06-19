<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WCFCalculatorWebForm.aspx.cs" Inherits="XmlCalculatorWcfApp.WCFCalculatorWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
                <asp:Label ID="Label1" runat="server" Text="Enter First Number: "></asp:Label>&nbsp<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
                <br />
                <asp:Label ID="Label2" runat="server" Text="Enter First Number: "></asp:Label>&nbsp<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
                <br />
                <asp:Button ID="addition" runat="server" Text="Addition" OnClick="addition_Click" />&nbsp&nbsp<asp:Button ID="subtraction" runat="server" Text="Subtraction" OnClick="subtraction_Click" />&nbsp&nbsp<asp:Button ID="multiplication" runat="server" Text="Multiplication" OnClick="multiplication_Click" />&nbsp&nbsp<asp:Button ID="division" runat="server" Text="Division" OnClick="division_Click" /><br />
                <br />
                <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
            </center>
        </div>
    </form>
</body>
</html>

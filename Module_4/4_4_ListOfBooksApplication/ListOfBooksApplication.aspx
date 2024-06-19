<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListOfBooksApplication.aspx.cs" Inherits="ListOfBooksApplication.ListOfBooksApplication" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
                <asp:Label ID="Label1" runat="server" Text="List of Books"></asp:Label><br />
                <br />
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem Value="AIML"></asp:ListItem>
                    <asp:ListItem>IS</asp:ListItem>
                    <asp:ListItem>IOT</asp:ListItem>
                    <asp:ListItem>AWT</asp:ListItem>
                    <asp:ListItem>UI UX</asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList><br />
                <br />
                <asp:Button ID="submit" runat="server" Text="Submit" OnClick="submit_Click" />
            </center>
        </div>
    </form>
</body>
</html>

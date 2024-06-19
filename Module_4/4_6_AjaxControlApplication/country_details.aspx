<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="country_details.aspx.cs" Inherits="AjaxControlApplication.country_details" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager><br /><br />
                <asp:UpdatePanel runat="server">
                    <ContentTemplate>
                        <asp:Timer runat="server" Interval="2000" ID="Timer1" OnTick="Timer1_Tick"></asp:Timer>
                        <br /><br />
                        <asp:Label ID="Label1" runat="server" Text="Timer Control" BorderColor="Black" Font-Bold="True" ForeColor="#FF66FF"></asp:Label>
                    </ContentTemplate>
                </asp:UpdatePanel>
        </div>
    </form>
</body>
</html>

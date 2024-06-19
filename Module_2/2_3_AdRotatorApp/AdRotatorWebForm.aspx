<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdRotatorWebForm.aspx.cs" Inherits="AdRotatorApp.AdRotatorWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Ad Rotator Application</h1>
            <asp:AdRotator ID="AdRotator1" runat="server" AdvertisementFile="~/DataFileAdRotator.xml" />
        </div>
    </form>
</body>
</html>

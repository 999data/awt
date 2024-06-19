<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FileUploadControl.aspx.cs" Inherits="FileUploadApplication.FileUploadControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 style="color: red; background-color: black; text-align: center">File Upload</h1>
        </div>
        <div>
            <table style="width: 100%;">
                <tr>
                    <td>&nbsp;<asp:Label runat="server" Text="Select Image:" Font-Bold="true"></asp:Label>
                    <br />
                    <br />
                    <br />
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                    <br />
                    <br />
                    <br />
                    <asp:Button ID="btnImage" runat="server" Text="UPLOAD IMAGE" Font-Bold="true" OnClick="btnImage_Click" />
                        <br />
                        <br />
                        <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
                    </td>
                    <td>
                    &nbsp;<asp:Image ID="Image1" runat="server" Height="240px" Width="240px"></asp:Image>
                    </td>
                    <td style="align-content: center;">
                    &nbsp;<asp:Label ID="Label2" runat="server" Text="Select Document:" Font-Bold="true"></asp:Label>
                        <br />
                        <br />
                        <br />
                        <asp:FileUpload ID="FileUpload2" runat="server" />
                        <br />
                        <br />
                        <br />
                        <asp:Button ID="btndoc" runat="server" Text="UPLOAD DOCUMENT" Font-Bold="true" OnClick="btndoc_Click" />
                        <br />
                        <br />
                        <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>

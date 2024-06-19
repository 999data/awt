<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JQueryBGColorApp.aspx.cs" Inherits="JQueryBgColor.JQueryBGColorApp" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Change Background Color with jQuery</title>
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }
    </style>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script type="text/javascript">
        $(function () {
            $("table#table1 tr:even").css("background-color", "yellow");
            $("table#table1 tr:odd").css("background-color", "orange");
            $("table").css("width", "50%");
            $("table").attr("border", "1");
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <h3>jQuery to change background color of odd and even rows</h3>
        <div>
            <table id="table1">
                <tr>
                    <td>Book Number</td>
                    <td>99</td>
                </tr>
                <tr>
                    <td class="auto-style1">ISBN</td>
                    <td class="auto-style1">AAA</td>
                </tr>
                <tr>
                    <td>Author</td>
                    <td>Puneet</td>
                </tr>
                <tr>
                    <td>Publisher</td>
                    <td>TharaBhai</td>
                </tr>
                <tr>
                    <td>Cost</td>
                    <td>999</td>
                </tr>
                <tr>
                    <td>Copies</td>
                    <td>100</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>

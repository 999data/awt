<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ApplyFilterJQuery.aspx.cs" Inherits="ApplyFilterJQuery.ApplyFilterJQuery" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Apply Filter with jQuery</title>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script type="text/javascript">
        $(function () {
            $("table#EmpTable tr:even").css("background-color", "yellow");
            $("table#EmpTable tr:odd").css("background-color", "pink");

            $("#EmpTable tbody tr td.age").filter(function () {
                return parseInt($(this).text()) < 22;
            }).css("color", "red");
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <h3>Apply Filter on jQuery</h3>
        <table id="EmpTable" border="2">
            <thead>
                <tr>
                    <th class="empid">EmpId</th>
                    <th class="fname">First Name</th>
                    <th class="lname">Last Name</th>
                    <th class="email">Email</th>
                    <th class="age">Age</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td class="empid">B64</td>
                    <td class="fname">Sahil</td>
                    <td class="lname">Tiwari</td>
                    <td class="email">sahil999@gmail.com</td>
                    <td class="age">21</td>
                </tr>
                <tr>
                    <td class="empid">B99</td>
                    <td class="fname">Puneet</td>
                    <td class="lname">Singh</td>
                    <td class="email">psingh@gmail.com</td>
                    <td class="age">22</td>
                </tr>
                <tr>
                    <td class="empid">B0958</td>
                    <td class="fname">Sorav</td>
                    <td class="lname">Shah</td>
                    <td class="email">shahsorav@gmail.com</td>
                    <td class="age">29</td>
                </tr>
                <tr>
                    <td class="empid">B9999</td>
                    <td class="fname">Tarun</td>
                    <td class="lname">Gupta</td>
                    <td class="email">vikram@gmail.com</td>
                    <td class="age">20</td>
                </tr>
            </tbody>
        </table>
    </form>
</body>
</html>

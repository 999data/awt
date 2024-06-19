<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AngularBasicCalculator.aspx.cs" Inherits="AngularBasicCalculatorApplication.AngularBasicCalculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Angular Basic Calculator</title>
    <script src="https://ajax.googleapis.com/ajax/libs/angularjs/1.5.0-rc.0/angular.min.js"></script>
</head>
<body ng-app="">
    <form id="form1" runat="server">
        <div>
            <center>
                <h2>Arithmetic Expression In AngularJS</h2>
                <br />
                <h3>Addition</h3> 
                20 + 30 = {{ 20 + 30 }}
                <br />
                <h3>Subtraction</h3> 
                30 - 20 = {{ 30 - 20 }}
                <br />
                <h3>Multiply</h3> 
                10 * 20 = {{ 10 * 20 }}
                <br />
                <h3>Division</h3> 
                20 / 10 = {{ 20 / 10 }}
                <br />
                Enter Numbers for Addition: <input type="number" ng-model="Num1" /> + <input type="number" ng-model="Num2" /> = <span>{{ Num1 + Num2 }}</span>
                <br />
                Enter Numbers for Subtraction: <input type="number" ng-model="Num3" /> - <input type="number" ng-model="Num4" /> = <span>{{ Num3 - Num4 }}</span>
                <br />
                Enter Numbers for Multiplication: <input type="number" ng-model="Num5" /> * <input type="number" ng-model="Num6" /> = <span>{{ Num5 * Num6 }}</span>
                <br />
                Enter Numbers for Division: <input type="number" ng-model="Num7" /> / <input type="number" ng-model="Num8" /> = <span>{{ Num7 / Num8 }}</span>
            </center>
        </div>
    </form>
</body>
</html>

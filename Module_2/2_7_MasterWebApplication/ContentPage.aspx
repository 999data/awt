<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ContentPage.aspx.cs" Inherits="MasterWebApplication.ContentPage" MasterPageFile="~/MasterPage.Master" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Enter your Name: "></asp:Label>
    <br />
    <br />
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
</asp:Content>

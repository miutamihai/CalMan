<%@ Page Title="Main Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CalManV1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>CalMan - Calculate your calories, now on the web!</h1>
    </div>

    <div>
        <p class="text-center text-dark text-bold" style="font-weight: bold; font-size: 28px" >Introduce the desired amount of calories and press "Calculate"</p>
    </div>
    <hr />
    <div>
        <asp:TextBox ID="TextBox1" runat="server" CssClass="center" Width="150px"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" style="top: 414px; left: 700px"></asp:Label>
    </div>
    <div>
        <asp:Button ID="Button1" runat="server" Text="Calculate" OnClick="Button1_Click" />

    </div>
    <div aria-flowto="right">
    </div>
    <div>
        <p>Note: For mobile users, select "Switch to Desktop" in order to fully experience the CalMan service</p>
    </div>

</asp:Content>

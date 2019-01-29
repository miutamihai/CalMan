<%@ Page Title="Main Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CalManV1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>CalMan - Calculate your calories, now on the web!</h1>
    </div>

    <div>
        <p class="text-center text-dark text-bold" style="font-weight: bold; font-size: 28px">Introduce the desired amount of calories and press "Calculate"</p>
    </div>
    <hr />
    <div>
        <asp:TextBox ID="TextBox1" runat="server" CssClass="center" Width="150px"></asp:TextBox>
        <asp:RangeValidator runat="server" Type="Double"
            MinimumValue="1000" MaximumValue="20000" ControlToValidate="TextBox1"
            ErrorMessage="Values must be between 1500 and 20.000 calories" />
        
    </div>
    <div>
        <asp:Button ID="Button1" runat="server" Text="Calculate" OnClick="Button1_Click" />

        <asp:BulletedList ID="BulletedList1" runat="server">
        </asp:BulletedList>

    </div>
    <div aria-flowto="right">
    </div>
    <div>
        <p>Note: For mobile users, select "Switch to Desktop" in order to fully experience the CalMan service</p>
    </div>

</asp:Content>

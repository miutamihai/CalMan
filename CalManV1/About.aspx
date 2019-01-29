<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="CalManV1.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Description:</h3>
    <p>CalMan (short for "Calories, Man!") is a free online calorie calculation service, provided to you by the CalMan Team.</p>
    <div class ="text-center">
        <hr />
        <h3 class="display-4">
            Team members:
        </h3>
        <table class="text-center" align="center">
            <tbody class="justify-content-center">
                <tr>
                    <td width="50%">Name:</td>
                    <td width="50%">Position:</td>
                </tr>
                <hr />
                <tr>
                    <td width="50%">Miuta Mihai</td>
                    <td width="50%">Team leader</td>
                </tr>
                <tr>
                    <td width="50%">Elvis Bogdan</td>
                    <td width="50%">Marketing expert</td>
                </tr>
                <tr>
                    <td width="50%">Gabriel Giroe</td>
                    <td width="50%">Data collector</td>
                </tr>
                <tr>
                    <td width="50%">Vali Pricop</td>
                    <td width="50%">Team Leader Assistant</td>
                </tr>

            </tbody>

        </table>
    </div>
</asp:Content>

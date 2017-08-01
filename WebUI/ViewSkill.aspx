<%@ Page Title="" Language="C#" MasterPageFile="~/WebUI.Master" AutoEventWireup="true" CodeBehind="ViewSkill.aspx.cs" Inherits="WebUI.UpdateSkill" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style14 {
            text-align: right;
            width: 662px;
        }
        .auto-style15 {
            text-align: left;
        }
        .auto-style16 {
            width: 662px;
        }
        .auto-style17 {
            font-family: "Lucida Sans", "Lucida Sans Regular", "Lucida Grande", "Lucida Sans Unicode", Geneva, Verdana, sans-serif;
        }
        .auto-style18 {
            text-align: right;
            width: 662px;
            height: 23px;
        }
        .auto-style19 {
            text-align: left;
            height: 23px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style6">
        <tr>
            <td class="auto-style16">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style14">
                <asp:Label ID="Label1" runat="server" CssClass="auto-style17" Text="ID"></asp:Label>
&nbsp;&nbsp;&nbsp; </td>
            <td class="auto-style15">
                <asp:Label ID="lblId" runat="server" CssClass="auto-style17" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style18">
                <asp:Label ID="Label2" runat="server" CssClass="auto-style17" Text="Name"></asp:Label>
&nbsp;&nbsp;&nbsp; </td>
            <td class="auto-style19">
                <asp:Label ID="lblName" runat="server" CssClass="auto-style17" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style14">
                <asp:Label ID="Label3" runat="server" CssClass="auto-style17" Text="Description"></asp:Label>
&nbsp;&nbsp;&nbsp; </td>
            <td class="auto-style15">
                <asp:Label ID="lblDescription" runat="server" CssClass="auto-style17" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style18">
                <asp:Label ID="Label4" runat="server" CssClass="auto-style17" Text="Category"></asp:Label>
&nbsp;&nbsp;&nbsp; </td>
            <td class="auto-style19">
                <asp:Label ID="lblCategory" runat="server" CssClass="auto-style17" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style16">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style14">
                <asp:Button ID="btnBack" runat="server" CssClass="auto-style17" OnClick="Button1_Click" Text="Back" />
&nbsp;&nbsp;&nbsp; </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style16">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

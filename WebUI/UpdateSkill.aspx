<%@ Page Title="" Language="C#" MasterPageFile="~/WebUI.Master" AutoEventWireup="true" CodeBehind="UpdateSkill.aspx.cs" Inherits="WebUI.UpdateSkill1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style14 {
            text-align: left;
        }
        .auto-style15 {
            text-align: right;
            width: 597px;
        }
        .auto-style16 {
            width: 597px;
        }
        .auto-style17 {
            font-family: "Lucida Sans", "Lucida Sans Regular", "Lucida Grande", "Lucida Sans Unicode", Geneva, Verdana, sans-serif;
        }
        .auto-style18 {
            text-align: right;
            width: 597px;
            height: 25px;
        }
        .auto-style19 {
            text-align: left;
            height: 25px;
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
            <td class="auto-style15">
                <asp:Label ID="Label1" runat="server" CssClass="auto-style17" Text="ID"></asp:Label>
&nbsp;&nbsp;&nbsp; </td>
            <td class="auto-style14">
                <asp:Label ID="lblId" runat="server" CssClass="auto-style17" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style15">
                <asp:Label ID="Label2" runat="server" CssClass="auto-style17" Text="Name"></asp:Label>
&nbsp;&nbsp;&nbsp; </td>
            <td class="auto-style14">
                <asp:TextBox ID="txtName" runat="server" CssClass="auto-style17"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style15">
                <asp:Label ID="Label3" runat="server" CssClass="auto-style17" Text="Description"></asp:Label>
&nbsp;&nbsp;&nbsp; </td>
            <td class="auto-style14">
                <asp:TextBox ID="txtDesc" runat="server" CssClass="auto-style17"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style18">
                <asp:Label ID="Label4" runat="server" CssClass="auto-style17" Text="Category"></asp:Label>
&nbsp;&nbsp;&nbsp; </td>
            <td class="auto-style19">
                <asp:DropDownList ID="ddlCategory" runat="server" CssClass="auto-style17">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style16">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style16">&nbsp;</td>
            <td class="auto-style14">
                <asp:Button ID="btnUpdate" runat="server" CssClass="auto-style17" OnClick="btnUpdate_Click" Text="Update" />
            </td>
        </tr>
        <tr>
            <td class="auto-style16">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

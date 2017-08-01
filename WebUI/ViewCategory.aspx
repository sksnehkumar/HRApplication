<%@ Page Title="" Language="C#" MasterPageFile="~/WebUI.Master" AutoEventWireup="true" CodeBehind="ViewCategory.aspx.cs" Inherits="WebUI.ViewCategory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">


        .auto-style15 {
            width: 406px;
        }
        .auto-style17 {
            width: 210px;
        }
        .auto-style16 {
            width: 230px;
        }
        .auto-style18 {
            width: 210px;
            text-align: right;
        }
        .auto-style19 {
            width: 230px;
            text-align: left;
        }
        .auto-style20 {
            width: 406px;
            height: 26px;
        }
        .auto-style21 {
            width: 210px;
            text-align: right;
            height: 26px;
        }
        .auto-style22 {
            width: 230px;
            text-align: left;
            height: 26px;
        }
        .auto-style23 {
            height: 26px;
        }
        .auto-style24 {
            width: 1269px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style6">
        <tr>
            <td class="auto-style15">&nbsp;</td>
            <td class="auto-style17">&nbsp;</td>
            <td class="auto-style16">
                <br />
                <br />
                <br />
                <br />
                <br />
                <br /></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style15">&nbsp;</td>
            <td class="auto-style18">
                <asp:Label ID="lblName" runat="server" Text="Name"></asp:Label>
&nbsp;&nbsp;&nbsp; </td>
            <td class="auto-style19">
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style15">&nbsp;</td>
            <td class="auto-style18">
                <asp:Label ID="lblDescription" runat="server" Text="Description"></asp:Label>
&nbsp;&nbsp; </td>
            <td class="auto-style19">
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style20"></td>
            <td class="auto-style21">&nbsp;</td>
            <td class="auto-style22">&nbsp;</td>
            <td class="auto-style23"></td>
        </tr>
    </table>
    <table>
        <tr>
            <td class="auto-style24">&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnUpdate" runat="server" Text="Update" />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br /></td>
        </tr>
    </table>
</asp:Content>

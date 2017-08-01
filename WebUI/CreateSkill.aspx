<%@ Page Title="" Language="C#" MasterPageFile="~/WebUI.Master" AutoEventWireup="true" CodeBehind="CreateSkill.aspx.cs" Inherits="WebUI.CreateSkill" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style14 {
            margin-left: 0px;
            font-family: "Lucida Sans", "Lucida Sans Regular", "Lucida Grande", "Lucida Sans Unicode", Geneva, Verdana, sans-serif;
        }
        .auto-style15 {
            width: 406px;
        }
        .auto-style16 {
            width: 230px;
        }
        .auto-style17 {
            width: 210px;
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
        .auto-style25 {
            font-family: "Lucida Sans", "Lucida Sans Regular", "Lucida Grande", "Lucida Sans Unicode", Geneva, Verdana, sans-serif;
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
                <br />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style15">&nbsp;</td>
            <td class="auto-style18">
                <asp:Label ID="Label1" runat="server" Text="Name" CssClass="auto-style25"></asp:Label>
&nbsp;&nbsp;&nbsp; </td>
            <td class="auto-style19">
                <asp:TextBox ID="txtName" runat="server" Height="18px" Width="128px" CssClass="auto-style25"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style15">&nbsp;</td>
            <td class="auto-style18">
                <asp:Label ID="Label2" runat="server" Text="Description" CssClass="auto-style25"></asp:Label>
&nbsp;&nbsp; </td>
            <td class="auto-style19">
                <asp:TextBox ID="txtDesc" runat="server" OnTextChanged="TextBox2_TextChanged" Height="18px" Width="128px" CssClass="auto-style25"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style20"></td>
            <td class="auto-style21">
                <asp:Label ID="Label3" runat="server" Text="Category" CssClass="auto-style25"></asp:Label>
&nbsp;&nbsp; </td>
            <td class="auto-style22">
                <asp:DropDownList ID="ddlCategory" runat="server" CssClass="auto-style14" Height="22px" Width="128px">
                </asp:DropDownList>
            </td>
            <td class="auto-style23"></td>
        </tr>
        <tr>
            <td class="auto-style15">&nbsp;</td>
            <td class="auto-style17">&nbsp;</td>
            <td class="auto-style19">
                <asp:Button ID="btnCreate" runat="server" Text="Create" CssClass="auto-style25" />
                </td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <table>
        <tr>
            <td class="auto-style24">

            &nbsp;&nbsp;&nbsp;&nbsp;
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
                <br />

            </td>
        </tr>
    </table>
</asp:Content>

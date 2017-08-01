<%@ Page Title="" Language="C#" MasterPageFile="~/WebUI.Master" AutoEventWireup="true" CodeBehind="UpdateCategory.aspx.cs" Inherits="WebUI.UpdateCategory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .auto-style15 {
            width: 406px;
        }
        .auto-style17 {
            width: 206px;
            text-align: right;
        }
        .auto-style16 {
            width: 230px;
            text-align: left;
        }
        .auto-style19 {
            width: 230px;
            text-align: left;
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
            <td class="auto-style17">
                <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
&nbsp;&nbsp;&nbsp; </td>
            <td class="auto-style19">
                <asp:TextBox ID="TextBox1" runat="server" Height="18px" Width="128px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style15">&nbsp;</td>
            <td class="auto-style17">
                <asp:Label ID="Label2" runat="server" Text="Description"></asp:Label>
&nbsp;&nbsp; </td>
            <td class="auto-style19">
                <asp:TextBox ID="TextBox2" runat="server" Height="18px" Width="128px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style15">&nbsp;</td>
            <td class="auto-style17">
                <asp:Label ID="Label3" runat="server" style="text-align: center; position: relative" Text="ModifiedBy"></asp:Label>
            </td>
            <td class="auto-style16">
                <asp:TextBox ID="TextBox3" runat="server" Height="18px" Width="128px" style="text-align: left; margin-left: 0px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style15">&nbsp;</td>
            <td class="auto-style17">
                <asp:Label ID="Label4" runat="server" Text="ModifiedDate"></asp:Label>
            </td>
            <td class="auto-style16">
                <asp:TextBox ID="from_date"  runat="server"  type="date" Height="18px" Width="128px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
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

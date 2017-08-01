<%@ Page Title="" Language="C#" MasterPageFile="~/WebUI.Master" AutoEventWireup="true" CodeBehind="UpdateSkill.aspx.cs" Inherits="WebUI.UpdateSkill" %>
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
        .auto-style14 {
            margin-left: 0px;
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
                <asp:Label ID="Label4" runat="server" Text="Id   "></asp:Label>
&nbsp;&nbsp;&nbsp; </td>
            <td class="auto-style19">
                <asp:TextBox ID="TextBox3" runat="server" Width="128px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style15">&nbsp;</td>
            <td class="auto-style18">
                <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
&nbsp;&nbsp;&nbsp; </td>
            <td class="auto-style19">
                <asp:TextBox ID="TextBox1" runat="server" Height="18px" Width="128px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style15">&nbsp;</td>
            <td class="auto-style18">
                <asp:Label ID="Label2" runat="server" Text="Description"></asp:Label>
&nbsp;&nbsp; </td>
            <td class="auto-style19">
                <asp:TextBox ID="TextBox2" runat="server"  Height="18px" Width="128px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style20"></td>
            <td class="auto-style21">
                <asp:Label ID="Label3" runat="server" Text="Category"></asp:Label>
&nbsp;&nbsp; </td>
            <td class="auto-style22">
                <asp:DropDownList ID="ddlCategory" runat="server" CssClass="auto-style14" Height="22px" Width="128px">
                </asp:DropDownList>
            </td>
            <td class="auto-style23"></td>
        </tr>
        <tr>
            <td class="auto-style15">&nbsp;</td>
            <td class="auto-style18">
                <asp:Label ID="Label5" runat="server" Text="ModifiedBy"></asp:Label>
&nbsp;&nbsp;&nbsp; </td>
            <td class="auto-style19">
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style15">&nbsp;</td>
            <td class="auto-style18">
                <asp:Label ID="Label6" runat="server" Text="ModifiedDate"></asp:Label>
&nbsp;&nbsp;&nbsp; </td>
            <td class="auto-style19">
                <asp:TextBox ID="from_date" type="date" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <table>
        <tr>
            <td class="auto-style24">&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnUpdate" runat="server" Text="Update" BackColor="#FF6600" />
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

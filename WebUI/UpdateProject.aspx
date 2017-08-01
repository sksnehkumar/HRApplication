<%@ Page Title="" Language="C#" MasterPageFile="~/WebUI.Master" AutoEventWireup="true" CodeBehind="UpdateProject.aspx.cs" Inherits="WebUI.UpdateProject" %>
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
        .auto-style25 {
            width: 406px;
            height: 28px;
        }
        .auto-style26 {
            width: 210px;
            text-align: right;
            height: 28px;
        }
        .auto-style27 {
            width: 230px;
            text-align: left;
            height: 28px;
        }
        .auto-style28 {
            height: 28px;
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
            text-align: right;
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
            <td class="auto-style25"></td>
            <td class="auto-style26">
                <asp:Label ID="lblName" runat="server" Text="Name"></asp:Label>
&nbsp;&nbsp;&nbsp; </td>
            <td class="auto-style27">
                <asp:TextBox ID="txtName" runat="server" Height="18px" Width="128px"></asp:TextBox>
            </td>
            <td class="auto-style28"></td>
        </tr>
        <tr>
            <td class="auto-style15">&nbsp;</td>
            <td class="auto-style18">
                <asp:Label ID="lblDescription" runat="server" Text="Description"></asp:Label>
&nbsp;&nbsp; </td>
            <td class="auto-style19">
                <asp:TextBox ID="txtDescription" runat="server" Height="18px" Width="128px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style20"></td>
            <td class="auto-style21">
                <asp:Label ID="lblClient" runat="server" Text="Client"></asp:Label>
&nbsp;&nbsp; </td>
            <td class="auto-style22">
                <asp:TextBox ID="txtClient" runat="server" Height="18px" Width="128px"></asp:TextBox>
            </td>
            <td class="auto-style23"></td>
        </tr>
        <tr>
            <td class="auto-style15">&nbsp;</td>
            <td class="auto-style18" id="lblStartDate">Start date&nbsp;&nbsp;&nbsp; </td>
            <td class="auto-style19">
                <asp:TextBox ID="fromDate" type="date" runat="server" Height="18px" Width="128px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style15">&nbsp;</td>
            <td class="auto-style18" id="lblEndDate">End Date&nbsp;&nbsp;&nbsp;&nbsp; </td>
            <td class="auto-style19">
                <asp:TextBox ID="EndDate" type="date" runat="server" Height="18px" Width="128px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style15">&nbsp;</td>
            <td class="auto-style17">&nbsp;</td>
            <td class="auto-style16">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style15">&nbsp;</td>
            <td class="auto-style17">&nbsp;</td>
            <td class="auto-style19">
                <asp:Button ID="btnUpdate" runat="server" Text="Update" Height="31px" Width="89px" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <table>
        <tr>
            <td class="auto-style24">&nbsp;</td>
        </tr>
    </table>
</asp:Content>

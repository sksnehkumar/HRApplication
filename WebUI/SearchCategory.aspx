<%@ Page Title="" Language="C#" MasterPageFile="~/WebUI.Master" AutoEventWireup="true" CodeBehind="SearchCategory.aspx.cs" Inherits="WebUI.SearchCategory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .auto-style14 {
            width: 471px;
        }
        .auto-style17 {
            width: 100%;
            margin-right: 0px;
        }
        .auto-style15 {
            width: 244px;
        }
        .auto-style19 {
            width: 244px;
            text-align: right;
        }
        .auto-style18 {
            font-family: "Lucida Sans", "Lucida Sans Regular", "Lucida Grande", "Lucida Sans Unicode", Geneva, Verdana, sans-serif;
        }
        .auto-style16 {
            text-align: left;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style6">
        <tr>
            <td class="auto-style14">
                <table class="auto-style17">
                    <tr>
                        <td>
                            <table class="auto-style6">
                                <tr>
                                    <td class="auto-style15">&nbsp;</td>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="auto-style19">
                                        <asp:Label ID="lblCategoryName" runat="server" CssClass="auto-style18" Text="Category Name"></asp:Label>
&nbsp;&nbsp; </td>
                                    <td class="auto-style16">
                                        <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style18"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">&nbsp;</td>
                                    <td class="auto-style16">
                                        <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" Text="Search" CssClass="auto-style18" />
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style16">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Button ID="btnCreate" runat="server" OnClick="btnCreate_Click" Text="Create New Category" CssClass="auto-style18" Width="202px" />
                        </td>
                    </tr>
                </table>
            </td>
            <td>
                <asp:GridView ID="gvCategory" runat="server" Width="438px" AutoGenerateColumns="false" OnRowCommand="gvCategory_Rowcommand" DataKeyNames="CategoryId" >
                    <Columns>
                        <asp:HyperLinkField DataNavigateUrlFields="CategoryId" HeaderText="ID" DataNavigateUrlFormatString="ViewCategory.aspx?CategoryId={0}" DataTextField="CategoryId" />
                        <asp:BoundField HeaderText="Name" DataField="CategoryName" />
                        <asp:BoundField HeaderText="Description" DataField="CategoryDescription" />
                        <asp:ButtonField Text="Edit" CommandName="Edit" />
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>

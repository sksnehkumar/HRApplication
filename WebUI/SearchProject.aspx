<%@ Page Title="" Language="C#" MasterPageFile="~/WebUI.Master" AutoEventWireup="true" CodeBehind="SearchProject.aspx.cs" Inherits="WebUI.SearchProject" %>
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
                                        <asp:Label ID="lblProjectName" runat="server" CssClass="auto-style18" Text="Project Name"></asp:Label>
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
                        <td class="auto-style16">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnCreate" runat="server" OnClick="btnCreate_Click" Text="Create New Project.." CssClass="auto-style18" />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        </td>
                    </tr>
                </table>
            </td>
            <td id="Projects">
                <asp:GridView ID="gvProjects" runat="server" Width="403px" AutoGenerateColumns="false" DataKeyNames="ProjId" OnRowCommand="gvProjects_RowCommand" OnSelectedIndexChanged="gvProjects_SelectedIndexChanged">
                    <Columns>
                        <asp:HyperLinkField DataNavigateUrlFields="ProjId" HeaderText="ID" DataNavigateUrlFormatString="ViewProject.aspx?projectId={0}" DataTextField="ProjId" />
                        <asp:BoundField HeaderText="Name" DataField="ProjName" />
                        <asp:BoundField HeaderText="Description" DataField="Description" />
                        <asp:BoundField HeaderText="Client" DataField="Client" />
                        <asp:BoundField HeaderText="Start Date" DataField="StartDate" />
                        <asp:BoundField HeaderText="End Date" DataField="EndDate" />
                        <asp:ButtonField Text="Edit" CommandName="Edit" />

                    </Columns>
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>

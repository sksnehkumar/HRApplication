<%@ Page Title="" Language="C#" MasterPageFile="~/WebUI.Master" AutoEventWireup="true" CodeBehind="SearchSkill.aspx.cs" Inherits="WebUI.SearchSkill" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style14 {
            width: 471px;
        }
        .auto-style15 {
            width: 244px;
        }
        .auto-style16 {
            text-align: left;
        }
        .auto-style17 {
            width: 100%;
            margin-right: 0px;
        }
        .auto-style18 {
            font-family: "Lucida Sans", "Lucida Sans Regular", "Lucida Grande", "Lucida Sans Unicode", Geneva, Verdana, sans-serif;
        }
        .auto-style19 {
            width: 244px;
            text-align: right;
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
                                        <asp:Label ID="Label1" runat="server" CssClass="auto-style18" Text="Skill Name"></asp:Label>
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
                        <td class="auto-style16">
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Button ID="btnCreate" runat="server" OnClick="btnCreate_Click" Text="Create New Skill..." CssClass="auto-style18" />
                        </td>
                    </tr>
                </table>
            </td>
            <td>
                <asp:GridView ID="gvSkills" runat="server" AutoGenerateColumns="False" CssClass="auto-style18" OnRowCommand="gvSkills_RowCommand" DataKeyNames="SkillId" OnSelectedIndexChanged="gvSkills_SelectedIndexChanged" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None">
                    <AlternatingRowStyle BackColor="PaleGoldenrod" />
                    <Columns>
                        <asp:HyperLinkField DataNavigateUrlFields="SkillId" HeaderText ="Id" DataNavigateUrlFormatString ="ViewSkill.aspx?skillId={0}" DataTextField="SkillId" />
                        <asp:BoundField HeaderText="Name" DataField="SkillName" />
                        <asp:BoundField HeaderText="Description" DataField="SkillDescription" />
                        <asp:ButtonField Text="Edit" CommandName="Edit" />
                    </Columns>
                    <FooterStyle BackColor="Tan" />
                    <HeaderStyle BackColor="Tan" Font-Bold="True" />
                    <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                    <SortedAscendingCellStyle BackColor="#FAFAE7" />
                    <SortedAscendingHeaderStyle BackColor="#DAC09E" />
                    <SortedDescendingCellStyle BackColor="#E1DB9C" />
                    <SortedDescendingHeaderStyle BackColor="#C2A47B" />
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>

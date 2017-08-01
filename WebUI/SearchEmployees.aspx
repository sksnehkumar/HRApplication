<%@ Page Title="" Language="C#" MasterPageFile="~/WebUI.Master" AutoEventWireup="true" CodeBehind="SearchEmployees.aspx.cs" Inherits="WebUI.SearchEmployees" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">


        .auto-style14 {
            width: 471px;
        }
        .auto-style17 {
            width: 95%;
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
        .auto-style20 {
            width: 93%;
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
                        <table class="auto-style20">
                            <tr>
                                <td class="auto-style15">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style19">
                                    <asp:Label ID="lblFirstName" runat="server" CssClass="auto-style18" Text="First Name"></asp:Label>
&nbsp;&nbsp; </td>
                                <td class="auto-style16">
                                    <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style18"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style19">
                                    <asp:Label ID="lblLastName" runat="server" CssClass="auto-style18" Text="Last Name"></asp:Label>
                                </td>
                                <td class="auto-style16">
                                    <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style18"></asp:TextBox>
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
                    <td class="auto-style5">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnCreate" runat="server" OnClick="btnCreate_Click" Text="Create New Employee.." CssClass="auto-style18" Width="198px" />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        </td>
                </tr>
            </table>
        </td>
        <td>
            <asp:GridView ID="gvEmployee" runat="server" Width="428px" AutoGenerateColumns="false" OnRowCommand="gvEmployee_RowCommand" DataKeyNames="EmployeeId" OnSelectedIndexChanged="gvEmployee_SelectedIndexChanged"  >
                <Columns>
                    <asp:HyperLinkField DataNavigateUrlFields="EmployeeId" HeaderText="ID" DataNavigateUrlFormatString="ViewEmployee.aspx?employeeId={0}" DataTextField="EmployeeId" />
                        <asp:BoundField HeaderText="First Name" DataField="FirstName" />
                    <asp:BoundField HeaderText="Middle Name" DataField="MiddleName" />
                        <asp:BoundField HeaderText="Last Name" DataField="LastName" />
                        <asp:BoundField HeaderText="City" DataField="City" />
                        <asp:BoundField HeaderText="State" DataField="State" />
                        <asp:ButtonField Text="Edit" CommandName="Edit" />
                </Columns>
            </asp:GridView>
        </td>
    </tr>
</table>
</asp:Content>

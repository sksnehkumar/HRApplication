<%@ Page Title="" Language="C#" MasterPageFile="~/WebUI.Master" AutoEventWireup="true" CodeBehind="ViewEmployee.aspx.cs" Inherits="WebUI.ViewEmployee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">


        .auto-style31 {
            width: 226px;
            height: 70px;
        }
        .auto-style32 {
            width: 200px;
            text-align: left;
            height: 70px;
        }
        .auto-style33 {
            width: 230px;
            height: 70px;
        }
        .auto-style40 {
            font-size: x-large;
            color: #808080;
        }
        .auto-style34 {
            height: 70px;
        }
        .auto-style39 {
            width: 226px;
            height: 70px;
            font-size: x-large;
            color: #808080;
        }
        .auto-style35 {
            width: 200px;
            text-align: right;
            height: 70px;
            font-size: x-large;
            color: #808080;
        }
        .auto-style37 {
            font-weight: normal;
        }
        .auto-style36 {
            width: 230px;
            height: 70px;
            text-align: left;
            font-size: x-large;
            color: #808080;
        }
        .auto-style38 {
            height: 70px;
            font-size: x-large;
            color: #808080;
        }
        .auto-style25 {
            width: 226px;
            height: 28px;
        }
        .auto-style26 {
            width: 200px;
            text-align: left;
            height: 28px;
        }
        .auto-style41 {
            color: #808080;
        }
        .auto-style27 {
            width: 230px;
            text-align: left;
            height: 28px;
        }
        .auto-style28 {
            height: 28px;
        }
        .auto-style29 {
            width: 226px;
            color: #808080;
        }
        
        .auto-style17 {
            width: 200px;
            text-align: left;
        }
        .auto-style19 {
            width: 230px;
            text-align: left;
        }
        .auto-style20 {
            width: 226px;
            height: 26px;
        }
        .auto-style21 {
            width: 200px;
            text-align: left;
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
        .auto-style42 {
            width: 200px;
            text-align: left;
            color: #808080;
        }
        .auto-style43 {
            width: 230px;
            text-align: left;
            color: #808080;
        }
        .auto-style16 {
            width: 230px;
            color: #808080;
        }
        .auto-style30 {
            color: #333333;
            background-color: #FFFFFF;
        }
        .auto-style24 {
            width: 1269px;
            text-align: right;
            color: #808080;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style6">
        <tr>
            <td class="auto-style31"></td>
            <td class="auto-style32"></td>
            <td class="auto-style33">
                <br class="auto-style40" />
                <br class="auto-style40" />
                <br class="auto-style40" /></td>
            <td class="auto-style34"></td>
        </tr>
        <tr>
            <td class="auto-style39">&nbsp;</td>
            <td class="auto-style35"><strong class="auto-style37">View&nbsp; </strong></td>
            <td class="auto-style36"><strong class="auto-style37">Employee</strong></td>
            <td class="auto-style38">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style25"></td>
            <td class="auto-style26">
                <asp:Label ID="Label1" runat="server" Text="First Name" CssClass="auto-style41"></asp:Label>
                <span class="auto-style41">&nbsp;&nbsp;&nbsp; </span></td>
            <td class="auto-style27">
                <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="auto-style28"></td>
        </tr>
        <tr>
            <td class="auto-style29">&nbsp;</td>
            <td class="auto-style17">
                <asp:Label ID="Label2" runat="server" Text="Middle Name" CssClass="auto-style41"></asp:Label>
                <span class="auto-style41">&nbsp;&nbsp; </span></td>
            <td class="auto-style19">
                <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="auto-style41">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style20"></td>
            <td class="auto-style21">
                <asp:Label ID="Label3" runat="server" Text="Last Name" CssClass="auto-style41"></asp:Label>
                <span class="auto-style41">&nbsp;&nbsp; </span></td>
            <td class="auto-style22">
                <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="auto-style23"></td>
        </tr>
        <tr>
            <td class="auto-style29">&nbsp;</td>
            <td class="auto-style42">Date of Birth&nbsp;&nbsp;&nbsp; </td>
            <td class="auto-style19">
                <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="auto-style41">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style29">&nbsp;</td>
            <td class="auto-style42">Age</td>
            <td class="auto-style19">
                <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="auto-style41">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style29">&nbsp;</td>
            <td class="auto-style42">Gender</td>
            <td class="auto-style19">
                <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="auto-style41">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style29">&nbsp;</td>
            <td class="auto-style42">Civil Status</td>
            <td class="auto-style19">
                <asp:Label ID="Label10" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="auto-style41">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style29">&nbsp;</td>
            <td class="auto-style42">Citizenship</td>
            <td class="auto-style19">
                <asp:Label ID="Label11" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="auto-style41">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style29">&nbsp;</td>
            <td class="auto-style42">Religion</td>
            <td class="auto-style19">
                <asp:Label ID="Label12" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="auto-style41">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style29">&nbsp;</td>
            <td class="auto-style42">Address :</td>
            <td class="auto-style43">&nbsp;</td>
            <td class="auto-style41">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style29">&nbsp;</td>
            <td class="auto-style42">Street1</td>
            <td class="auto-style19">
                <asp:Label ID="Label13" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="auto-style41">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style29">&nbsp;</td>
            <td class="auto-style42">Street2&nbsp;&nbsp; </td>
            <td class="auto-style19">
                <asp:Label ID="Label14" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="auto-style41">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style29">&nbsp;</td>
            <td class="auto-style42">City&nbsp;&nbsp; </td>
            <td class="auto-style19">
                <asp:Label ID="Label15" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="auto-style41">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style29">&nbsp;</td>
            <td class="auto-style42">State&nbsp;&nbsp; </td>
            <td class="auto-style19">
                <asp:Label ID="Label16" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="auto-style41">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style29">&nbsp;</td>
            <td class="auto-style42">Zip Code</td>
            <td class="auto-style19">
                <asp:Label ID="Label17" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="auto-style41">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style29">&nbsp;</td>
            <td class="auto-style42">Country&nbsp;&nbsp; </td>
            <td class="auto-style19">
                <asp:Label ID="Label18" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="auto-style41">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style29">&nbsp;</td>
            <td class="auto-style42">Mobile number&nbsp;&nbsp; </td>
            <td class="auto-style19">
                <asp:Label ID="Label19" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="auto-style41">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style29">&nbsp;</td>
            <td class="auto-style42">Home Phone Number&nbsp;&nbsp; </td>
            <td class="auto-style19">
                <asp:Label ID="Label20" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="auto-style41">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style29">&nbsp;</td>
            <td class="auto-style42">Project Profile&nbsp;&nbsp;&nbsp; </td>
            <td class="auto-style19">
                <asp:Label ID="Label21" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="auto-style41">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style29">&nbsp;</td>
            <td class="auto-style42">Skill Profile&nbsp;&nbsp; </td>
            <td class="auto-style19">
                <asp:Label ID="Label22" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="auto-style41">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style29">&nbsp;</td>
            <td class="auto-style42">Education Background&nbsp;&nbsp; </td>
            <td class="auto-style19">
                <asp:Label ID="Label23" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="auto-style41">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style29">&nbsp;</td>
            <td class="auto-style42">Recognitions&nbsp;&nbsp; </td>
            <td class="auto-style19">
                <asp:Label ID="Label24" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="auto-style41">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style29">&nbsp;</td>
            <td class="auto-style42">&nbsp;</td>
            <td class="auto-style43">&nbsp;</td>
            <td class="auto-style41">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style29">&nbsp;</td>
            <td class="auto-style42">&nbsp;</td>
            <td class="auto-style16">&nbsp;</td>
            <td class="auto-style41">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style29">&nbsp;</td>
            <td class="auto-style42">&nbsp;</td>
            <td class="auto-style19">
                <asp:Button ID="btnCreate" runat="server" Text="Update" CssClass="auto-style30" Height="37px" Width="109px" />
            </td>
            <td class="auto-style41">&nbsp;</td>
        </tr>
    </table>
    <table>
        <tr>
            <td class="auto-style24">&nbsp;</td>
        </tr>
    </table>
</asp:Content>

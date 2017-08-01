<%@ Page Title="" Language="C#" MasterPageFile="~/WebUI.Master" AutoEventWireup="true" CodeBehind="CreateEmployee.aspx.cs" Inherits="WebUI.CreateEmployee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .auto-style17 {
            width: 200px;
            text-align: left;
        }
        .auto-style16 {
            width: 230px;
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
        .auto-style27 {
            width: 230px;
            text-align: left;
            height: 28px;
        }
        .auto-style28 {
            height: 28px;
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
        .auto-style24 {
            width: 1269px;
            text-align: right;
            color: #808080;
        }
        .auto-style29 {
            width: 226px;
            color: #808080;
        }
        .auto-style30 {
            color: #333333;
            background-color: #FFFFFF;
        }
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
        .auto-style34 {
            height: 70px;
        }
        .auto-style35 {
            width: 200px;
            text-align: right;
            height: 70px;
            font-size: x-large;
            color: #808080;
        }
        .auto-style36 {
            width: 230px;
            height: 70px;
            text-align: left;
            font-size: x-large;
            color: #808080;
        }
        .auto-style37 {
            font-weight: normal;
        }
        .auto-style38 {
            height: 70px;
            font-size: x-large;
            color: #808080;
        }
        .auto-style39 {
            width: 226px;
            height: 70px;
            font-size: x-large;
            color: #808080;
        }
        .auto-style40 {
            font-size: x-large;
            color: #808080;
        }
        .auto-style41 {
            color: #808080;
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
            <td class="auto-style35"><strong class="auto-style37">Create&nbsp;&nbsp; </strong></td>
            <td class="auto-style36"><strong class="auto-style37">Employee</strong></td>
            <td class="auto-style38">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style25"></td>
            <td class="auto-style26">
                <asp:Label ID="lblFirstName" runat="server" Text="First Name" CssClass="auto-style41"></asp:Label>
                <span class="auto-style41">&nbsp;&nbsp;&nbsp; </span></td>
            <td class="auto-style27">
                <asp:TextBox ID="txtFirstName" runat="server" Height="18px" Width="128px" CssClass="auto-style41"></asp:TextBox>
            </td>
            <td class="auto-style28"></td>
        </tr>
        <tr>
            <td class="auto-style29">&nbsp;</td>
            <td class="auto-style17">
                <asp:Label ID="lblMiddleName" runat="server" Text="Middle Name" CssClass="auto-style41"></asp:Label>
                <span class="auto-style41">&nbsp;&nbsp; </span></td>
            <td class="auto-style19">
                <asp:TextBox ID="txtMiddleName" runat="server" Height="18px" Width="128px" CssClass="auto-style41"></asp:TextBox>
            </td>
            <td class="auto-style41">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style20"></td>
            <td class="auto-style21">
                <asp:Label ID="lblLastName" runat="server" Text="Last Name" CssClass="auto-style41"></asp:Label>
                <span class="auto-style41">&nbsp;&nbsp; </span></td>
            <td class="auto-style22">
                <asp:TextBox ID="txtLastName" runat="server" Height="18px" Width="128px" CssClass="auto-style41"></asp:TextBox>
            </td>
            <td class="auto-style23"></td>
        </tr>
        <tr>
            <td class="auto-style29">&nbsp;</td>
            <td class="auto-style42" id="lblDateOfBirth">Date of Birth&nbsp;&nbsp;&nbsp; </td>
            <td class="auto-style19">
                <asp:TextBox ID="fromDate" type="date" runat="server" Height="18px" Width="125px" CssClass="auto-style41"></asp:TextBox>
            </td>
            <td class="auto-style41">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style29">&nbsp;</td>
            <td class="auto-style42" id="lblAge">Age</td>
            <td class="auto-style19">
                <asp:TextBox ID="txtAge" runat="server" CssClass="auto-style41" Width="123px"></asp:TextBox>
            </td>
            <td class="auto-style41">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style29">&nbsp;</td>
            <td class="auto-style42" id="lblGender">Gender</td>
            <td class="auto-style19">
                <asp:DropDownList ID="ddlGender" runat="server" CssClass="auto-style41" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                    <asp:ListItem>Other</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style41">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style29">&nbsp;</td>
            <td class="auto-style42" id="lblCivilStatus">Civil Status</td>
            <td class="auto-style19">
                <asp:DropDownList ID="ddlCivilStatus" runat="server" CssClass="auto-style41" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <td class="auto-style41">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style29">&nbsp;</td>
            <td class="auto-style42" id="lblCitizenship">Citizenship</td>
            <td class="auto-style19">
                <asp:TextBox ID="txtCitizenship" runat="server" CssClass="auto-style41" Width="123px"></asp:TextBox>
            </td>
            <td class="auto-style41">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style29">&nbsp;</td>
            <td class="auto-style42" id="lblReligion">Religion</td>
            <td class="auto-style19">
                <asp:TextBox ID="txtReligion" runat="server" CssClass="auto-style41" Width="123px"></asp:TextBox>
            </td>
            <td class="auto-style41">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style29">&nbsp;</td>
            <td class="auto-style42" id="lblAddress">Address :</td>
            <td class="auto-style43">&nbsp;</td>
            <td class="auto-style41">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style29">&nbsp;</td>
            <td class="auto-style42" id="lblStreet1">Street1</td>
            <td class="auto-style19">
                <asp:TextBox ID="txtStreet1" runat="server" CssClass="auto-style41" Width="123px"></asp:TextBox>
            </td>
            <td class="auto-style41">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style29">&nbsp;</td>
            <td class="auto-style42" id="lblStreet2">Street2&nbsp;&nbsp; </td>
            <td class="auto-style19">
                <asp:TextBox ID="txtStreet2" runat="server" CssClass="auto-style41" Width="123px"></asp:TextBox>
            </td>
            <td class="auto-style41">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style29">&nbsp;</td>
            <td class="auto-style42" id="lblCity">City&nbsp;&nbsp; </td>
            <td class="auto-style19">
                <asp:TextBox ID="txtCity" runat="server" CssClass="auto-style41" Width="123px"></asp:TextBox>
            </td>
            <td class="auto-style41">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style29">&nbsp;</td>
            <td class="auto-style42" id="lblState">State&nbsp;&nbsp; </td>
            <td class="auto-style19">
                <asp:TextBox ID="txtState" runat="server" CssClass="auto-style41" Width="123px"></asp:TextBox>
            </td>
            <td class="auto-style41">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style29">&nbsp;</td>
            <td class="auto-style42" id="lblZipCode">Zip Code</td>
            <td class="auto-style19">
                <asp:TextBox ID="txtZipCode" runat="server" CssClass="auto-style41" Width="123px"></asp:TextBox>
            </td>
            <td class="auto-style41">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style29">&nbsp;</td>
            <td class="auto-style42" id="lblCountry">Country&nbsp;&nbsp; </td>
            <td class="auto-style19">
                <asp:TextBox ID="txtCountry" runat="server" CssClass="auto-style41" Width="123px"></asp:TextBox>
            </td>
            <td class="auto-style41">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style29">&nbsp;</td>
            <td class="auto-style42" id="lblMobileNumber">Mobile number&nbsp;&nbsp; </td>
            <td class="auto-style19">
                <asp:TextBox ID="txtMobileNumber" runat="server" CssClass="auto-style41" Width="123px"></asp:TextBox>
            </td>
            <td class="auto-style41">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style29">&nbsp;</td>
            <td class="auto-style42" id="lblHomePhoneNumber">Home Phone Number&nbsp;&nbsp; </td>
            <td class="auto-style19">
                <asp:TextBox ID="txtHomePhoneNumber" runat="server" CssClass="auto-style41" Width="123px"></asp:TextBox>
            </td>
            <td class="auto-style41">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style29">&nbsp;</td>
            <td class="auto-style42" id="lblProjectProfile">Project Profile&nbsp;&nbsp; </td>
            <td class="auto-style19">
                <asp:TextBox ID="txtProjectProfile" runat="server" CssClass="auto-style41" Width="123px"></asp:TextBox>
            </td>
            <td class="auto-style41">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style29">&nbsp;</td>
            <td class="auto-style42" id="lblSkillProfile">Skill Profile&nbsp;&nbsp; </td>
            <td class="auto-style19">
                <asp:TextBox ID="txtSkillProfile" runat="server" CssClass="auto-style41" Width="123px"></asp:TextBox>
            </td>
            <td class="auto-style41">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style29">&nbsp;</td>
            <td class="auto-style42" id="lblEducationBackground">Education Background&nbsp;&nbsp; </td>
            <td class="auto-style19">
                <asp:TextBox ID="txtEducationBackground" runat="server" CssClass="auto-style41" Width="123px"></asp:TextBox>
            </td>
            <td class="auto-style41">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style29">&nbsp;</td>
            <td class="auto-style42" id="lblRecognitions">Recognitions&nbsp;&nbsp; </td>
            <td class="auto-style19">
                <asp:TextBox ID="txtRecognitions" runat="server" CssClass="auto-style41" Width="123px"></asp:TextBox>
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
                <asp:Button ID="btnCreate" runat="server" Text="Create" CssClass="auto-style30" Height="37px" Width="109px" />
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

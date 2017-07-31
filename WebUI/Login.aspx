<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebUI.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 205px;
            width: 1296px;
        }
        .auto-style1 {
            width: 61%;
            height: 115px;
        }
        .auto-style2 {
            font-size: x-large;
            color: #333333;
        }
        .auto-style3 {
            color: #333333;
            width: 375px;
        }
        .auto-style4 {
            width: 375px;
        }
    </style>
</head>
<body style="width: 1295px; text-align: center">
    <form id="form1" runat="server">
        <span class="auto-style2">Login</span>
        <br />
        <br />
        <table align="center" cellpadding="2" cellspacing="3" class="auto-style1">
            <tr>
                <td class="auto-style3" style="text-align: right">UserName&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                <td style="text-align: left">
                    <asp:TextBox ID="TextBox2" runat="server" Height="23px" Width="137px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3" style="text-align: right">Password&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                <td style="text-align: left">
                    <asp:TextBox ID="TextBox1" runat="server" Height="24px" Width="137px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td style="text-align: left">
                    <asp:Button ID="btnLogIn" runat="server" Height="33px" Text="Login" Width="84px" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="register.aspx.cs" Inherits="register" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            height: 23px;
        }
        .style2
        {
            height: 23px;
            width: 715px;
        }
        .style3
        {
            width: 715px;
        }
        </style>
</head>
<body style="height: 245px; width: 878px;">
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%; height: 75px;">
            <tr>
                <td class="style1" align="right">
                    <asp:Label ID="Label1" runat="server" Text="用户名:"></asp:Label>
                </td>
                <td class="style2">
                    <asp:TextBox ID="txtUserName" runat="server" ontextchanged="TextBox1_TextChanged"></asp:TextBox>
                    <asp:Button ID="checkbutton" runat="server" onclick="checkbutton_Click" 
                        Text="检查用户名" />
                </td>
                <td class="style1">
                </td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    <asp:Label ID="Label2" runat="server" Text="设置密码:"></asp:Label>
                </td>
                <td class="style2">
                    <asp:TextBox ID="txtPassword" runat="server" BorderStyle="Outset" 
                        TextMode="Password"></asp:TextBox>
                </td>
                <td class="style1">
                    </td>
            </tr>
            <tr>
                <td align="right">
                    <asp:Label ID="Label3" runat="server" Text="确认密码:"></asp:Label>
                </td>
                <td class="style3">
                    <asp:TextBox ID="txtPasswordAgain" runat="server" AutoCompleteType="Disabled" 
                        TextMode="Password"></asp:TextBox>
                </td>
                <td>
                    <br />
                </td>
            </tr>
            <tr>
                <td align="right">
                    <asp:Label ID="Label4" runat="server" Text="昵称："></asp:Label>
                </td>
                <td class="style3">
                    <asp:TextBox ID="txtnickname" runat="server" 
                        ontextchanged="TextBox1_TextChanged"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="right">
                    <asp:Label ID="Label5" runat="server" Text="Email:"></asp:Label>
                </td>
                <td class="style3">
                    <asp:TextBox ID="txtemail" runat="server" ontextchanged="TextBox1_TextChanged"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="right">
                    <asp:Label ID="Label6" runat="server" Text="QQ:"></asp:Label>
                </td>
                <td class="style3">
                    <asp:TextBox ID="txtQQ" runat="server" ontextchanged="TextBox1_TextChanged"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="right">
                    <asp:Label ID="Label7" runat="server" Text="CellPhone"></asp:Label>
                </td>
                <td class="style3">
                    <asp:TextBox ID="txtPhone" runat="server" ontextchanged="TextBox1_TextChanged"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="right">
                    &nbsp;</td>
                <td class="style3">
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="注册" Width="76px" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    
    </form>
</body>
</html>

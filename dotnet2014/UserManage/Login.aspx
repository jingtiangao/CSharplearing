<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            height: 20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        <table style="width: 100%;">
            <tr>
                <td class="style1" align="right">
                    &nbsp;
                    <asp:Label ID="Label1" runat="server" Text="用户名:"></asp:Label>
                </td>
                <td class="style1">
                    &nbsp;
                    <asp:TextBox ID="txtUserName" runat="server" ontextchanged="TextBox1_TextChanged"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right">
                    &nbsp;
                    <asp:Label ID="Label2" runat="server" Text="密码:"></asp:Label>
                </td>
                <td>
                    &nbsp;
                    <asp:TextBox ID="txtPassWord" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;
                    
        <asp:Button ID="btnreader" runat="server" Text="datareader" 
            onclick="btnreader_Click" />
    
                </td>
                <td>
                    &nbsp;
                        
        <asp:Button ID="btnLogin" runat="server" Text=" 登陆" onclick="btnLogin_Click" 
                        Height="19px" />
    
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>

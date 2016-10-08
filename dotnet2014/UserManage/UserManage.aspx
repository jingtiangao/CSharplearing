<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserManage.aspx.cs" Inherits="UserManage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .dxgv
        {
            margin-top: 2px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    <asp:GridView ID="gvUsers" runat="server" 
        onselectedindexchanged="GridView1_SelectedIndexChanged" BackColor="White" 
        BorderColor="White" BorderStyle="Ridge" BorderWidth="4px" CellPadding="4" 
        CellSpacing="4" CssClass="dxgv" DataKeyNames="Id" 
        EnableSortingAndPagingCallbacks="True" EnableViewState="False" GridLines="None" 
        Height="16px" onrowcancelingedit="gvUsers_RowCancelingEdit" 
        onrowdatabound="gvUsers_RowDataBound" onrowdeleting="gvUsers_RowDeleting" 
        onrowediting="gvUsers_RowEditing" onrowupdating="gvUsers_RowUpdating" 
        Width="677px" AllowPaging="True">
        <Columns>
            <asp:CommandField ShowEditButton="True" CancelText="               取消" />
            <asp:CommandField ShowDeleteButton="True" CancelText="       取消" />
        </Columns>
        <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
        <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
        <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
        <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#594B9C" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#33276A" />
    </asp:GridView>
    <asp:Label ID="txtlb1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>

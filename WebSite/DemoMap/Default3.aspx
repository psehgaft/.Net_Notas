<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Default3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:SiteMapPath ID="SiteMapPath1" runat="server">
        </asp:SiteMapPath>
    <marquee> Esta es la pagina 3 </marquee>
    </div>
    <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" />
    <asp:TreeView ID="TreeView1" runat="server" DataSourceID="SiteMapDataSource1">
    </asp:TreeView>
    </form>
</body>
</html>

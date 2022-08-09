<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Demo1.aspx.cs" Inherits="Demo1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script language="javascript" type="text/javascript">
// <![CDATA[

        function Submit1_onclick() {
            alert("Este codigo se proceso en el Browser");
        }

// ]]>
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Button" 
            BackColor="#66FF99" />
        <asp:TextBox ID="TextBox1" runat="server" BackColor="Red" 
            EnableViewState="False" AutoPostBack="True"></asp:TextBox>
        <input id="Submit1" type="submit" value="submit" onclick="return Submit1_onclick()" /><asp:Button ID="Button2" 
            runat="server" Text="Button" onclick="Button2_Click" />
        <input id="Text1" runat="server" type="text" /><br />
        </div>
    </form>
</body>
</html>

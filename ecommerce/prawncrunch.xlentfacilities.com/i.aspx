<%@ Page Language="C#" AutoEventWireup="true" CodeFile="i.aspx.cs" Inherits="i" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
<div id="topbar" runat="server"  >
    <asp:Repeater ID="Repeater1" runat="server">
 <ItemTemplate>
 

    <span class="close" onclick="document.getElementById('topbar').style.display='none';"></span>
    <img src=<%#Eval("pimage")%> id="i1" runat="server" alt="" />
    <h1>Discounts Upto<br />
        <a href="#">Click Here</a>
    </h1>
    <h2><%#Eval("discount")%>%</h2>
    <h3><%#Eval("pname")%> <br /><%#Eval("text") %></h3>  </ItemTemplate>  </asp:Repeater>
</div>
    </form>
</body>
</html>

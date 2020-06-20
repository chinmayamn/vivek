<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server" name="ecom" method="post" 

action="https://test.timesofmoney.com/direcpay/secure/dpMerchantPayment.jsp">


    <asp:TextBox ID="requestparameter" runat="server"></asp:TextBox>
    <asp:TextBox ID="billingDtls" runat="server"></asp:TextBox>
    <asp:TextBox ID="shippingDtls" runat="server"></asp:TextBox>
    <input type="submit" name="submit" value="Submit">
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Default3" %>

<html>
	<head>
		<title>Payment Checkout</title>
		<script>
			function generateAction()
			{
				document.frmPost.requestparameter.value = document.getElementById("requestparams").value;
				document.frmPost.merchantId.value = document.getElementById("merchantId").value;
				document.frmPost.action = "http://test.timesofmoney.com/direcpay/secure/dpDirectIntegration.jsp";
				document.frmPost.submit();
			}

			function createOrderNo() {
				document.getElementById("orderNumber").value = new Date().getTime();
			}
		</script>
	</head>

	<body onload="createOrderNo();">
		<form id="Form1" name="frmEnc" runat="server">
			<table align="center" width="300px">				
				<tr>
					<td width="120px"><b><asp:Label id=lblMerchantId runat="server">Merchant Id</asp:Label></b></td>
					<td width="20px"><b>:</b></td>
					<td><asp:TextBox id=merchantId value="200702091000001" runat="server"></asp:TextBox></td>
				</tr>
				<tr>
					<td><b><asp:Label id=lblColloboratorId runat="server">Collaborator Id</asp:Label></b></td>
					<td><b>:</b></td>
					<td><asp:TextBox id=collaboratorId value="TOML" runat="server"></asp:TextBox></td>
				</tr>
				<tr>
					<td><b><asp:Label id=lblOperatingMode runat="server">Operating Mode</asp:Label></b></td>
					<td><b>:</b></td>
					<td><asp:TextBox id=operatingMode value="DOM" runat="server"></asp:TextBox></td>
				</tr>
				<tr>
					<td><b><asp:Label id=lblCountry runat="server">Country</asp:Label></b></td>
					<td><b>:</b></td>
					<td><asp:TextBox id=country value="IND" runat="server"></asp:TextBox></td>
				</tr>
				<tr>
					<td><b><asp:Label id=lblCurrency runat="server">Currency</asp:Label></b></td>
					<td><b>:</b></td>
					<td><asp:TextBox id=currency value="INR" runat="server"></asp:TextBox></td>
				</tr>
				<tr>
					<td><b><asp:Label id=lblAmount runat="server">Amount</asp:Label></b></td>
					<td><b>:</b></td>
					<td><asp:TextBox id=amount value="10" runat="server"></asp:TextBox></td>
				</tr>
				<tr>
					<td><b><asp:Label id=lblOrderNumber runat="server">Order Number</asp:Label></b></td>
					<td><b>:</b></td>
					<td><asp:TextBox id=orderNumber runat="server"></asp:TextBox></td>
				</tr>
				<tr>
					<td><b><asp:Label id=lblOtherDetails runat="server">Other Details</asp:Label></b></td>
					<td><b>:</b></td>
					<td><asp:TextBox id=otherDetails value="None" runat="server"></asp:TextBox></td>
				</tr>
				<tr>
					<td><b><asp:Label id=lblSuccessUrl runat="server">Success URL</asp:Label></b></td>
					<td><b>:</b></td>
					<td><asp:TextBox id=successUrl value="http://test.timesofmoney.com/direcpay/secure/merchant.jsp" runat="server"></asp:TextBox></td>
				</tr>
				<tr>
					<td><b><asp:Label id=lblFailureUrl runat="server">Failure URL</asp:Label></b></td>
					<td><b>:</b></td>
					<td><asp:TextBox id=failureUrl value="http://test.timesofmoney.com/direcpay/secure/merchant.jsp" runat="server"></asp:TextBox></td>
				</tr>
				<tr>
					<td><b><asp:Label id=lblGatewayId runat="server">Gateway Id</asp:Label></b></td>
					<td><b>:</b></td>
					<td><asp:TextBox id=gatewayId value="1025" runat="server"></asp:TextBox></td>
				</tr>
				<tr>
					<td><b><asp:Label id=lblGatewayName runat="server">Gateway Name</asp:Label></b></td>
					<td><b>:</b></td>
					<td><asp:TextBox id=gatewayName value="Demo Bank" runat="server"></asp:TextBox></td>
				</tr>
				<tr>
					<td><b><asp:Label id=lblGatewayType runat="server">Gateway Type</asp:Label></b></td>
					<td><b>:</b></td>
					<td><asp:TextBox id=gatewayType value="DD" runat="server"></asp:TextBox></td>
				</tr>
				<tr>
					<td></td>
					<td></td>
					<td><asp:Button id=Button1 runat="server" Text="Encrypt"></asp:Button></td>
				</tr>
			</table>
			<table align="center">
				<tr>
					<td><asp:HiddenField id=requestparams runat="server"></asp:HiddenField></td>
				</tr>
			</table>
		</form>
		<form name="frmPost" method="post">
			<table align="center" width="300px">
				<tr>
					<td width="120px"><b>After Encrypt >></b></td>
					<td width="20px"><input type="hidden" name="requestparameter" value=""><input type="hidden" name="merchantId" value=""></td>
					<td><input type="submit" value="Submit" onclick="generateAction();"></td>
				</tr>
			</table>
		</form>
	</body>
</html>
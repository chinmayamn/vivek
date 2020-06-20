<%@ Page Title="" Language="C#" MasterPageFile="~/User.master" AutoEventWireup="true" CodeFile="PaymentDetails.aspx.cs" Inherits="PaymentDetails" %>

<%@ Register src="Paymentdetail.ascx" tagname="Paymentdetail" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="full mid-bg">
	<div id="cont-mid">
    	<div id="content">
            <h2 style="font:bold 14px Arial, Helvetica, sans-serif; color:#666666; margin:8px 0;">Payment Details</h2>
				<table>
        			<tr>
            			<td style="border:1px solid #666666;-moz-border-radius:5px; border-radius:5px; width:960px; padding:18px;">
                <asp:Panel ID="Panel1" Width="950px" ScrollBars="Auto" runat="server">
           <uc1:Paymentdetail ID="Paymentdetail1" runat="server" /></asp:Panel></td>
          			</tr>
      			</table>
            </div>
            </div></div>
</asp:Content>


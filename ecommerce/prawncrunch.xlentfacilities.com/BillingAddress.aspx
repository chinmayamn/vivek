<%@ Page Title="" Language="C#" MasterPageFile="~/user.master" AutoEventWireup="true" CodeFile="BillingAddress.aspx.cs" Inherits="BillingAddress" %>

<%@ Register src="~/BillingAddress.ascx" tagname="BillingAddress" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="full mid-bg">
	<div id="cont-mid">
    	<div id="content">
            <h2 style="font:bold 14px Arial, Helvetica, sans-serif; color:#666666; margin:8px 0;">Billing Address</h2>
            <table width="960" border="0" cellspacing="0" cellpadding="0">
                <tr>
                    <td style="border:1px solid #666666;-moz-border-radius:5px; border-radius:5px; width:960px; padding:18px;">
                        <asp:Panel ID="Panel1" Width="100%" ScrollBars="Auto" runat="server">
                        <uc1:BillingAddress ID="BillingAddress1" runat="server" /></asp:Panel>
                    </td>
                </tr>
            </table>
          </div>
    </div>
    </div>
</asp:Content>


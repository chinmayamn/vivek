<%@ Page Title="" Language="C#" MasterPageFile="user.master" AutoEventWireup="true" CodeFile="ConfirmTransaction.aspx.cs" Inherits="Shop_ConfirmTransaction" %>

<%@ Register src="ConfirmTransaction.ascx" tagname="ConfirmTransaction" tagprefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<div class="full mid-bg">
	<div id="cont-mid">
    	<div id="content">
            <h2 style="font:bold 14px Arial, Helvetica, sans-serif; color:#666666; margin:8px 0;">Confirm Transaction</h2>

  <table border="0" cellspacing="0" cellpadding="0">
       
        
          <tr>
            <td style="border:1px solid #666666; -moz-border-radius:5px; border-radius:5px; width:960px; padding:18px;">
                <asp:Panel ID="Panel1" Width="940px" ScrollBars="Auto"  runat="server">
              <uc2:ConfirmTransaction ID="ConfirmTransaction1" runat="server" />  </asp:Panel></td>
          </tr>
        
        </table></div></div></div>
</asp:Content>


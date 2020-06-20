<%@ Page Language="C#" MasterPageFile="~/user.master" AutoEventWireup="true" CodeFile="cart.aspx.cs" Inherits="cart"  %>
<%@ Register Src="~/carting.ascx" TagName="cart" TagPrefix="ucl" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       <div class="full mid-bg">
    	<div id="cont-mid">
        	<div id="content">
  				<h2 style="font:bold 14px Arial, Helvetica, sans-serif; color:#666666; margin:8px 0;">My Cart</h2>
                <table border="0" cellspacing="0" cellpadding="0">
                	<tr>
                    	<td style="border:1px solid #666666; -moz-border-radius:5px; border-radius:5px; width:960px; padding:18px;">
                        	<asp:Panel ID="Panel1" Width="950" ScrollBars="Auto" runat="server">
                            	<ucl:cart ID="Cart1" runat="server" />
                            </asp:Panel>
                     	</td>
                  	</tr>
       			</table>
          </div>
     	</div>
    </div>
</asp:Content>


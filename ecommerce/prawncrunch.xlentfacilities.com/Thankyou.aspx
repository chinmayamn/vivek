<%@ Page Language="C#" MasterPageFile="~/user.master" AutoEventWireup="true" CodeFile="Thankyou.aspx.cs" Inherits="Thankyou"  %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<div class="full mid-bg">
    <div id="cont-mid">
        <div id="content">
        	<h2>Thank You</h2>
      		<img src="images/thank-you.jpg" width="256" height="192" alt="" style="margin:0 0 20px 20px; float:right;" />
           <p>Dear Customer, Thank you for shopping with Prawn Crunch. Your transaction is successfull and details are as follows
               <asp:Label ID="Label1" runat="server" ></asp:Label>. Your ordered prawns will be delivered as per your delivery date given.</p>
               
               <div align="center">
               <table style=" background:#c3e2f4;  margin:0;" cellpadding="6" cellspacing="3" align="center">
                <tr class="light">
                <td colspan="2" align="center">
               <b> Transaction Details</b>
                </td>
                </tr>
                <tr>
                    <td>
                   <b>DirecPay Reference Id : </b> 
                    </td>
                    <td>
                        <asp:Label ID="Label2" runat="server" ></asp:Label>
                    </td>
                </tr>
                <tr class="light">
                    <td>
                   <b>  Order Id :</b>
                    </td>
                    <td>
                     <asp:Label ID="Label3" runat="server" ></asp:Label>
                    </td>
                </tr>
                <tr >
                    <td>
                   <b> Amount :</b> 
                    </td>
                    <td>
                     <asp:Label ID="Label4" runat="server" ></asp:Label>
                    </td>
                </tr>
               </table>
               </div>
               
               <p>Click <a href="index.aspx"><b><font color="blue">here</font></b></a> to return to home page</p>
                 </div>
   	</div>
</div>

</asp:Content>


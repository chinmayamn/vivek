<%@ Control Language="C#" AutoEventWireup="true" CodeFile="BillingAddress.ascx.cs" Inherits="BillingAddress" %>
<link href="css/style.css" rel="stylesheet" type="text/css" />
 
<style type="text/css">
.simpletextstyle
{
	font-weight:bold;
}
</style>
<div align="center">


<table  >
	<tr>
		<td align="center" colspan="2">
    		<img src="images/2.jpg" />
		</td>
	</tr>
	</table>
	<div style="background-color:#c3e2f4">
	
	
	<table cellpadding="4" cellspacing="2" class="registration" style="width:300px;float:none; margin:0 auto;" align="center">
	
	<tr>
		<td colspan="2"><b>Your Billing Address :</b></td>
	</tr>
    <tr>
		<td >
   			<b>Name : </b> 
   			
   			</td><td>
   			<asp:Label ID="lblname" CssClass="boldtextstyle" runat="server"  Text="" ></asp:Label>
		</td>
	</tr>
	<tr>
		<td >
   		<b >Mobile:</b>
   		</td><td>
   		
   		<asp:Label
       ID="lblmobile"  runat="server" Text="Label"></asp:Label></td>
	</tr>
	<tr> 
		<td >
    		<b>Email : </b>
    		</td><td>
    		
    		<asp:Label ID="lblmail" runat="server" Text="Label" ></asp:Label>
		</td>
	</tr>
	<tr>
		<td >
  			<b>Address : </b> 
  			
  			</td><td>
  			 <asp:Label ID="lbladdress"  runat="server" Text="" ></asp:Label>
		</td>
	</tr>
	<tr>
	    <td>
	    	<b>Landmark : </b>
	    	</td><td>
	    	
	    	<asp:Label ID="lblphone"  runat="server" Text="Label" ></asp:Label>
	    </td>
	</tr>
	<tr>
		<td>
   			<b>City :</b>
   			</td><td>
   			
   			<asp:Label ID="lblcity"   runat="server" Text="Label" ></asp:Label>
    		

		</td>
	</tr>
	<tr>
	    <td>
	     <b>State :</b>
	     </td><td>
	     
	     <asp:Label ID="lblstate"  runat="server" Text="Label"></asp:Label>
	    </td>
	</tr>
</table> 
</div>
<table class="registration" border="0">
	
	<tr class="light">
		<td align="center">
            <asp:UpdatePanel ID="UpdatePanel2" runat="server">
            <ContentTemplate>
            
            <b>Delivery Address :  </b>
            <asp:CheckBox CssClass="boldtextstyle" ID="chkdelivary" runat="server" Text="Same As Billing Address" AutoPostBack="True" OnCheckedChanged="CheckBox1_CheckedChanged" />
              </ContentTemplate>
            </asp:UpdatePanel>
        </td>
	</tr>
	<tr>
		<td align="center">
            <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                <ContentTemplate>
                <asp:Panel ID="Panel1" runat="server" >
    				<table>
    					<tr>
    						<td align="left" class="simpletextstyle">Name :</td>
    						<td align="left" class="search-field1">
                                <asp:TextBox ID="txtname" runat="server" ValidationGroup="v1" ></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter Name" ControlToValidate="txtname" ValidationGroup="v1">*</asp:RequiredFieldValidator>
    						</td>
    					</tr>
        			
    						<tr>
                                <td align="left" class="simpletextstyle">Delivery Email:</td>
    							<td align="left" class="search-field1"><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
    						</tr>
        				
        					<tr>
                                <td align="left" class="simpletextstyle">Mobile : </td>
                                <td align="left" class="search-field1">
                                    <asp:TextBox ID="txtmobile" runat="server" 
                                        ValidationGroup="v1"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                                        ControlToValidate="txtmobile" ErrorMessage="Enter Mobile No." 
                                        ValidationGroup="v1">*</asp:RequiredFieldValidator>
                                </td>
					        </tr>
        					<tr>
                                <td align="left" class="simpletextstyle">Street Address :</td>
                                <td align="left" class="search-field1">
                                    <asp:TextBox ID="txtstreetaddress" runat="server" ValidationGroup="v1" TextMode="MultiLine" Rows="5" Columns="19"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                        ControlToValidate="txtstreetaddress" ErrorMessage="Enter Address" 
                                        ValidationGroup="v1">*</asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            	<tr>
    							<td align="left" class="simpletextstyle">LandMark:</td>
    							<td align="left" class="search-field1"><asp:TextBox ID="txtphone" runat="server" ValidationGroup="v1" ></asp:TextBox></td>
    						</tr>
           					<tr>
    							<td align="left" class="simpletextstyle">City :</td>
                                <td align="left" class="search-field1">
                                    <asp:TextBox ID="txtcity" runat="server" ValidationGroup="v1" ></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Enter City" ControlToValidate="txtcity" ValidationGroup="v1">*</asp:RequiredFieldValidator>
                                </td>
    						</tr>
          					<tr>
                                <td align="left" class="simpletextstyle">State :</td>
                                <td align="left" class="search-field1">
                                    <asp:TextBox ID="txtstate"  ValidationGroup="v1" runat="server"></asp:TextBox>    
                                    <asp:RequiredFieldValidator InitialValue="--Select--" ID="RequiredFieldValidator4" runat="server" ErrorMessage="Enter State" ControlToValidate="txtstate" ValidationGroup="v1">*</asp:RequiredFieldValidator></td>
    						</tr>
 							
    					</table>
    			</asp:Panel>
               </ContentTemplate>
            </asp:UpdatePanel>
       </td>
	</tr>
	<tr class="light">
		<td align="center"><b>Write Your Message(Max 500 Characters) </b><br /><asp:TextBox ID="txtcomments" runat="server" Height="80px" Width="420px" TextMode="MultiLine" ></asp:TextBox></td>
	</tr>
    <tr>
    	<td><span style="float:left">
    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/shopping.jpg"
        OnClick="ImageButton1_Click" /></span>
    <span style="float:right; height: 21px;">   
    <asp:ImageButton ID="ImageButton2" runat="server" onclick="ImageButton2_Click"  ValidationGroup="v1"
       ImageUrl="images/checkout.jpg"    /></span><%--<cc1:ModalPopupExtender ID="ModalPopupExtender1" runat="server" TargetControlID="HiddenField1" PopupControlID="Panel2" BackgroundCssClass="modalBackground"  x="50" Y="50" >
</cc1:ModalPopupExtender>--%>
<asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True"
    ShowSummary="False" ValidationGroup="v1" /></td>
    </tr>
</table>
</div>
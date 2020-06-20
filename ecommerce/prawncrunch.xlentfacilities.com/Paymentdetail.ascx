<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Paymentdetail.ascx.cs" Inherits="Paymentdetail" %>
 <%@ Register TagPrefix="mp" TagName="MyMP" Src="~/user.master" %>

<style type="text/css">
.bold
{
font-weight:bold;
}
</style>
<center><asp:Image ID="Image1" runat="server" ImageUrl="images/3.jpg" /></center>

<table align="left" style="width:940px;" border="0">     
    <tr>
    	<td  colspan="2" valign="top">
    		<table border="0" style="width:940px ; vertical-align:top;" >
    			<tr>
					<td align="left" valign="top" >
						<asp:UpdatePanel ID="UpdatePanel1" runat="server">
							<ContentTemplate>
								<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" ShowHeader="False" Width="930px">
    <RowStyle VerticalAlign="Top" />
    <Columns>
    <asp:TemplateField>
    <ItemTemplate>
    
   
    					<table class="registration" width="350px" style="vertical-align:top" style="vertical-align:top; background-color:#c3e2f4;">
    						<tr>
    							<td colspan="3" width="250px" class="purpletextstyle"><b>Billing Address :</b></td>
    						</tr>
							<tr class="light">
								<td><b>Name : </b> <asp:Label ID="lblname" runat="server" Text='<%#Eval("firstname")%>'></asp:Label></td>
							</tr>
                            <tr>
								<td align="left"><b> Mobile : </b> <asp:Label ID="Label5" runat="server" Text='<%#Eval("mobile")%>'></asp:Label>
 								</td>
                          	</tr>
 							<tr class="light">
                            	<td>
								   <b>Email : </b> <asp:Label ID="lblmail" runat="server" Text='<%#Eval("email")%>'></asp:Label>
   								</td>
                         	</tr>
   							<tr>
                                <td><b>Address : </b><asp:Label ID="lbladdress" runat="server" Text='<%#Eval("address")%>'></asp:Label></td>
							</tr>
							
							<tr class="light">
							<td>
							<b>Landmark : </b> <asp:Label ID="lblmobile" runat="server" Text='<%#Eval("phone")%>'></asp:Label>
							</td>
							</tr>
							<tr>
                                <td>
                                <b>City :</b>    <asp:Label ID="lblcity" runat="server" Text='<%#Eval("city")%>'></asp:Label> 
                                     
                                </td>
							</tr>
							<tr class="light">
							    <td>
							 <b>State  :</b>       <asp:Label ID="lblstate" runat="server" Text='<%#Eval("state")%>'></asp:Label>
                             
							    </td>
							</tr>
    					</table>
    					
                    </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                    <ItemTemplate>
       					<table class="registration" style="vertical-align:top">
						
							<tr>
       							<td colspan="2" class="purpletextstyle"><b>Delivery Address :</b></td>
       						</tr>
							<tr class="light">
								<td align="left"><b>Name : </b><asp:Label ID="lbldel_name" runat="server" Text='<%#Eval("delivery_firstname")%>'></asp:Label>   
								</td>
							</tr>
							<tr>
								<td align="left"> <b >Mobile:</b>
    <asp:Label ID="Label8" runat="server" Text='<%#Eval("delivery_mobile")%>'></asp:Label>
								</td>
							</tr>
							<tr class="light">
								<td align="left"><b>Email:</b> <asp:Label ID="Label11" runat="server" Text='<%#Eval("delivery_email")%>'></asp:Label></td>
							</tr>
                            <tr>
                                <td align="left">
                                   <b>Address : </b> <asp:Label ID="lbldel_address" runat="server" Text='<%#Eval("delivery_address")%>'></asp:Label>
                                </td>
                            </tr>
                            <tr class="light">
                                <td>
                                <b>Landmark : </b>
    <asp:Label ID="lbldel_mobile" runat="server" Text='<%#Eval("delivery_phone")%>'></asp:Label>
                                </td>
                            </tr>
							<tr >
                                <td align="left">
                              <b>City :</b>      <asp:Label ID="lbldel_city" runat="server" Text='<%#Eval("delivery_city")%>'></asp:Label>  
                                  
                                        </td>
                            </tr>
                            <tr class="light">
                            <td>
                            <b>State :</b>  <asp:Label ID="lbldel_state" runat="server" Text='<%#Eval("delivery_state")%>'></asp:Label>
                            </td>
                            </tr>
                        </table>
        </ItemTemplate>
        
        <EditItemTemplate>
        	<table border="0" style="vertical-align:top" class="registration">
        	<tr>
       							<td colspan="2" class="purpletextstyle"><b>Delivery Address :</b></td>
       						</tr>
			<tr class="light">
                <td class="bold" align="left">Name :</td>
                <td align="left" class="search-field1" ><asp:TextBox ID="txtfirstname" runat="server"  Text='<%#Eval("delivery_firstname")%>'></asp:TextBox></td>
            </tr>
          		<tr >
				<td align="left" class="bold">Mobile :</td>
				<td align="left" class="search-field1"><asp:TextBox ID="txtmobile" runat="server"  Text='<%#Eval("delivery_mobile")%>'></asp:TextBox></td>
			</tr><tr class="light">
				<td align="left" class="bold">Email :</td>
				<td align="left" class="search-field1"><asp:TextBox ID="TextBox1" runat="server"  Text='<%#Eval("delivery_email")%>'></asp:TextBox></td>
			</tr>
		
			
			<tr >
				<td align="left" class="bold">Address :</td>
				<td align="left" class="search-field1"><asp:TextBox ID="txtaddress" runat="server"  Text='<%#Eval("delivery_address")%>' TextMode="MultiLine" Rows="5" Columns="19"></asp:TextBox></td>
			</tr>
			<tr class="light">
				<td align="left" class="bold">Landmark :</td>
                <td align="left" class="search-field1"><asp:TextBox ID="txtphone" runat="server"  Text='<%#Eval("delivery_phone")%>'></asp:TextBox></td>
			</tr>
			
			
            <tr >
				<td align="left" class="bold">City :</td>
				<td align="left" class="search-field1"><asp:TextBox ID="txtcity" runat="server" Text='<%#Eval("delivery_city")%>'></asp:TextBox></td>
			</tr>
			<tr class="light">
			<td align="left" class="bold">State : </td>
			<td align="left" class="search-field1">
			    <asp:TextBox ID="txtstate" runat="server"  Text='<%#Eval("delivery_state")%>'></asp:TextBox>
           	</td>
		</tr>
		
    </table>
    	</EditItemTemplate>
    </asp:TemplateField>
    
        <asp:CommandField ShowEditButton="True" EditText="Click here to edit &lt;br /&gt;  Delivery address" ButtonType="Image" EditImageUrl="~/images/edit.jpg" UpdateImageUrl="~/images/update.jpg" CancelImageUrl="~/images/3_cancel.jpg" >
            <ItemStyle Width="180px" HorizontalAlign="Center" VerticalAlign="Middle" />
        </asp:CommandField>
    </Columns>
    </asp:GridView>
    </ContentTemplate>
    </asp:UpdatePanel>
					</td>
				</tr>
			</table>
		</td>
	</tr>
	<tr>
		<td>
   <asp:UpdatePanel ID="UpdatePanel2" runat="server">
       <ContentTemplate>
           <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" OnRowCancelingEdit="GridView2_RowCancelingEdit" OnRowEditing="GridView2_RowEditing" OnRowUpdating="GridView2_RowUpdating" OnRowDeleting="GridView2_RowDeleting"  GridLines="Both" HeaderStyle-Height="50px" Width="935px">
               <Columns>
                   <asp:TemplateField  HeaderText="Product" >
                       <ItemTemplate>
                           <asp:HiddenField ID="HiddenField1" runat="server" 
                               Value='<%#Eval("productID") %>' />
                           <asp:Label ID="Label1" runat="server" Text='<%#Eval("ProductName")%>'></asp:Label>
                       </ItemTemplate>
                       <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                       <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                   </asp:TemplateField>
                   <asp:TemplateField  HeaderText="Item" >
                       <ItemTemplate>
                           <asp:Image ID="Image1" runat="server" ImageUrl='<%#Eval("ProductImageUrl")%>' 
            Width="120px" Height="100px"/>
                       </ItemTemplate>
                       <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="130px" 
            Height="100px" />
                       <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle"  />
                   </asp:TemplateField>
                   <asp:TemplateField  HeaderText="Price" >
                       <ItemTemplate>
                           Rs.
                           <asp:Label ID="Label2" runat="server" Text='<%#Eval("Price")%>'></asp:Label>
                       </ItemTemplate>
                       <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                       <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                   </asp:TemplateField>
                   <asp:TemplateField  HeaderText="Quantity" >
                       <ItemTemplate>
                           <asp:Label ID="Label3" runat="server" Text='<%#Eval("Quantity")%>'></asp:Label>
                       </ItemTemplate>
                       <EditItemTemplate>
                           <asp:TextBox ID="txteditqty" runat="server" Text='<%#Eval("Quantity")%>'></asp:TextBox>
                       </EditItemTemplate>
                       <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="60px" />
                       <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="60px" />
                   </asp:TemplateField>
                   <asp:TemplateField  
            HeaderText="Discount">
                       <ItemTemplate>
                           <asp:Label ID="Label3222" runat="server" 
                    Text='<%#Eval("discount")%>'></asp:Label>%
                       </ItemTemplate>
                       <ItemStyle HorizontalAlign="Center" 
                VerticalAlign="Middle" Width="60px" />
                       <HeaderStyle HorizontalAlign="Center" 
                VerticalAlign="Middle" Width="60px" />
                   </asp:TemplateField>
                   <asp:TemplateField  HeaderText="Line Total" >
                       <ItemTemplate>
                           Rs.
                           <asp:Label ID="Label4" runat="server" Text='<%#Eval("Linetotal")%>'></asp:Label>
                       </ItemTemplate>
                       <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="80px" />
                       <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="80px" />
                   </asp:TemplateField>
                   <asp:CommandField ShowEditButton="True"  ButtonType="Image" 
            EditImageUrl="~/images/edit.jpg" UpdateImageUrl="~/images/update.jpg" 
            CancelImageUrl="~/images/3_cancel.jpg" >
                       <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                   </asp:CommandField>
                   <asp:CommandField ShowDeleteButton="True"   ButtonType="Button" 
            DeleteImageUrl="~/images/delete.jpg">
            <ControlStyle CssClass="buttona" />             
                       <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                   </asp:CommandField>
               </Columns>
                <HeaderStyle BackColor="#007CC2" ForeColor="White" />
           </asp:GridView>
       </ContentTemplate>
    </asp:UpdatePanel>
		</td>
	</tr>
	<tr>
    	<td>
			<table style="width:940px">
            	<tr>
					<td>
                        <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                        <ContentTemplate>
						<table align="right">
                            <tr>
                            	<td align="right" style=" font-size:16px; font-weight:bold;">Grand Total : Rs.</td>
								<td align="right" style=" font-size:16px; font-weight:bold;"><asp:Label ID="lblcartTotal" runat="server"></asp:Label></td>
							</tr>
						</table>
                       	</ContentTemplate>
                        </asp:UpdatePanel>
					</td>
				</tr>
				<tr>
					<td align="left">
						<asp:Label ID="Label22"  runat="server" ></asp:Label>
					    <asp:Label ID="Label23"  runat="server" ></asp:Label>
					</td>
				</tr>
				<tr>
					<td align="left">
						<span style="float:right">

    <asp:UpdatePanel ID="UpdatePanel4" runat="server">
    <ContentTemplate>
    <asp:ImageButton ID="ImageButton2" runat="server" ValidationGroup="v1" 
        ImageUrl="~/images/checkout.jpg" onclick="ImageButton2_Click"/>
    </ContentTemplate>
    </asp:UpdatePanel>
</span>
    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/shopping.jpg"
        OnClick="ImageButton1_Click"  /></td>
				</tr>
				<tr>
					<td height="15px">
						<asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True" ShowSummary="False" ValidationGroup="v1" />
					</td>
				</tr>
				<tr>
    <td align="left">
    <b style="color:#007dbf;">Note:</b> Discount option will be provided at the last stage of checkout.
    </td>
  
</tr>
          	</table>
      	</td>
  	</tr>
</table>


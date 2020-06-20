<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ConfirmTransaction.ascx.cs" Inherits="User_ConfirmTransaction" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Src="carting.ascx" TagName="cart" TagPrefix="uc1" %>
 <%@ Register TagPrefix="mp" TagName="MyMP" Src="~/user.master" %>


<link href="css/style.css" rel="stylesheet" type="text/css" />
<link type="text/css" href="date/jquery-ui-1.7.2.custom.css" rel="stylesheet" />
	<script type="text/javascript" src="js/jquery.js"></script>
	<script type="text/javascript" src="date/ui.core.js"></script>
	<script type="text/javascript" src="date/ui.datepicker.js"></script>
	<link type="text/css" href="date/demos.css" rel="stylesheet" />
	<script type="text/javascript">
	$(function() {
		$('#datepicker').datepicker({
			changeMonth: true,
			changeYear: true
		});
	});
	</script>

<center><asp:Image ID="Image1" runat="server" ImageUrl="images/4.jpg" /></center>


<br />
<div align="center">


<table style="width:940px; padding-top:20px;">
<tr>
<td align="center" >
 <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    
    <ContentTemplate>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            OnRowCancelingEdit="GridView1_RowCancelingEdit" 
            OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" 
           ShowHeader="False"  >
        <RowStyle VerticalAlign="Top" />
    <Columns>
    <asp:TemplateField>
    <ItemTemplate>
    <table class="registration" style="width:350px;background-color:#c3e2f4;" >
        <tr>
            <td colspan="3" ><b>Billing Address :</b></td>
        </tr>
		<tr class="light">
			<td><b>Name : </b><asp:Label ID="lblname" runat="server" Text='<%#Eval("firstname")%>'> </asp:Label> </td>
		</tr>
        <tr>
			<td><b>Mobile : </b><asp:Label ID="Label5" runat="server" Text='<%#Eval("mobile")%>'></asp:Label></td>
     	</tr>
		<tr class="light">
        	<td><b>Email : </b><asp:Label ID="lblmail" runat="server" Text='<%#Eval("email")%>'></asp:Label></td>
        </tr>
		<tr>
			<td><b>Address: </b><asp:Label ID="lbladdress" runat="server" Text='<%#Eval("address")%>'></asp:Label></td>
		</tr>
		<tr class="light">
		    <td>
		    
		    <b>Landmark : </b><asp:Label ID="lblmobile" runat="server" Text='<%#Eval("phone")%>'></asp:Label>
	
		    </td>
		</tr>
			<tr >
			<td><b>City : </b><asp:Label ID="lblcity" runat="server" Text='<%#Eval("city")%>'></asp:Label>
			
  </td>
		</tr>
		<tr class="light">
		    <td>
		    
		     <b>State : </b><asp:Label ID="lblstate" runat="server" Text='<%#Eval("state")%>'></asp:Label>
		    </td>
		</tr>
    </table>
    </ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField>
    <ItemTemplate>
       	
        <table class="registration" width="350px">
       		<tr>
            	<td colspan="3" ><b> Delivery Address :</b></td>
       		</tr>
            <tr class="light">
				<td><b>Name : </b><asp:Label ID="lbldel_name" runat="server" Text='<%#Eval("delivery_firstname")%>'></asp:Label> </td>
			</tr>
            <tr>
            	<td>
					
                    <b>Mobile : </b><asp:Label ID="Label8" runat="server" Text='<%#Eval("delivery_mobile")%>'></asp:Label></td>
           	</tr>
            <tr class="light">
				<td><b>Email : </b><asp:Label ID="Label6" runat="server" Text='<%#Eval("delivery_email")%>'></asp:Label></td>
			</tr>
            <tr>
				<td><b>Address : </b><asp:Label ID="lbldel_address" runat="server" Text='<%#Eval("delivery_address")%>'></asp:Label></td>
			</tr>
			<tr class="light">
			    <td>
			    <b>Landmark : </b><asp:Label ID="lbldel_mobile" runat="server" Text='<%#Eval("delivery_phone")%>'></asp:Label>
			    </td>
			</tr>
            <tr >
				<td>
				<b>City : </b>
				<asp:Label ID="lbldel_city" runat="server" Text='<%#Eval("delivery_city")%>'></asp:Label>
   
 </td>
			</tr>
			<tr class="light">
			   <td>
<b>State : </b>			   <asp:Label ID="lbldel_state" runat="server" Text='<%#Eval("delivery_state")%>'></asp:Label>
  
			   </td>
			</tr>
    </table>
    </ItemTemplate>
    <EditItemTemplate>
<table class="registration" width="450px">
<tr>
    <td colspan="2">
    <b>
    Delivery Address:
    </b>
    </td>
</tr>
<tr class="light">
<td align="left"  >
<b>Name :</b>
</td>
<td align="left"  >
    <asp:TextBox ID="txtdelname" runat="server"  Text='<%#Eval("delivery_firstname")%>'></asp:TextBox>
</td>
</tr>

<tr>
<tr>
<td align="left" class="light">
<b>Email :</b>
</td>
<td align="left"  >
   <asp:TextBox ID="TextBox1" runat="server"  Text='<%#Eval("delivery_email")%>'></asp:TextBox>
</td>
</tr>

<tr class="light">
<td align="left" class="light">
 <b>Mobile :</b>
</td>
<td align="left" >
   <asp:TextBox ID="txtphone1" runat="server"  Text='<%#Eval("delivery_mobile")%>'></asp:TextBox>
</td>
</tr>
<tr>
<td align="left">
<b>Address : </b>
</td>
<td align="left" >
   <asp:TextBox ID="txtstreet" runat="server"  Text='<%#Eval("delivery_address")%>' TextMode="MultiLine" Rows="5" Columns="19"></asp:TextBox>
</td>
</tr>
<tr  class="light">
<td align="left">
 <b>Landmark :</b>
</td>
<td align="left" >
   <asp:TextBox ID="txtphone" runat="server"  Text='<%#Eval("delivery_phone")%>'></asp:TextBox>
</td>
</tr>
<tr >
<td align="left" class="light">
<b>City :</b>
</td>
<td align="left" >

     <asp:TextBox ID="txtcity" runat="server"  Text='<%#Eval("delivery_city")%>'></asp:TextBox>
</td>
</tr>

<tr class="light">
<td align="left">
<b>State : </b>
</td>
 <td align="left" >
    <asp:TextBox ID="txtstate" runat="server"  Text='<%#Eval("delivery_state")%>'></asp:TextBox>
    </td>
</tr>



    </table>
    </EditItemTemplate>
    </asp:TemplateField>
    
        <asp:CommandField ShowEditButton="True" EditText="Click here to edit &lt;br /&gt;  Delivery address" ButtonType="Image" EditImageUrl="~/images/edit.jpg" UpdateImageUrl="~/images/update.jpg" CancelImageUrl="~/images/3_cancel.jpg" >
            <ItemStyle  HorizontalAlign="Center" VerticalAlign="Middle" />
        </asp:CommandField>
    </Columns>
    </asp:GridView>
      </ContentTemplate>
    </asp:UpdatePanel>
</td>
</tr>
</table><br />
<table>
<tr>
<td>

    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
    <ContentTemplate>
<asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
            OnRowCancelingEdit="GridView2_RowCancelingEdit" 
            OnRowEditing="GridView2_RowEditing" OnRowUpdating="GridView2_RowUpdating" 
            OnRowDeleting="GridView2_RowDeleting" HeaderStyle-Height="50px"
    Width="700px" 
         
            onselectedindexchanged="GridView2_SelectedIndexChanged">
    <Columns>
    <asp:TemplateField  HeaderText="Product" >
    <ItemTemplate>
      <asp:HiddenField ID="HiddenField1" runat="server" Value='<%#Eval("productID") %>' />
    
    <asp:Label ID="Label1" runat="server" Text='<%#Eval("ProductName")%>'></asp:Label> 
    </ItemTemplate>
        <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
        
    
    </asp:TemplateField>
    
    
    <asp:TemplateField  HeaderText="Item" >
    <ItemTemplate>
    
        <asp:Image ID="Image1" runat="server" ImageUrl='<%#Eval("ProductImageUrl")%>' Width="120px" Height="100px"/>
    
    </ItemTemplate>
        <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="130px"  Height="110px" />
        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
        
    
    </asp:TemplateField>
    
    <asp:TemplateField  HeaderText="Price" >
    <ItemTemplate>
Rs.<asp:Label ID="Label2" runat="server" Text='<%#Eval("Price")%>'></asp:Label> 
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
        <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="60px"  />
        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="60px"  />
        
    
    </asp:TemplateField>
    
    
    
    
      <asp:TemplateField HeaderText="Discount" ItemStyle-HorizontalAlign="Center">
       <ItemTemplate>
    <asp:Label ID="Label444" runat="server" Text='<%#Eval("discount")%>'></asp:Label>% 
    </ItemTemplate>
        <EditItemTemplate>
            
            <asp:Label ID="Label9" runat="server" Text='<%#Eval("discount")%>'></asp:Label>
        </EditItemTemplate>
          <ItemStyle HorizontalAlign="Center" />
        </asp:TemplateField>
    
    
    
    
    
    
    
    
    
    
    
    
  
    <asp:TemplateField  HeaderText="Line Total" >
    <ItemTemplate>
 Rs.  <asp:Label ID="Label4" runat="server" Text='<%#Eval("Linetotal")%>'></asp:Label> 
    </ItemTemplate>
        <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="80px" />
        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="80px" />
        
    
    </asp:TemplateField>
        <asp:CommandField ShowEditButton="True"   UpdateImageUrl="~/images/update.jpg" CancelImageUrl="~/images/3_cancel.jpg" ButtonType="Image" EditImageUrl="~/images/edit.jpg">
           
            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
        </asp:CommandField>
        <asp:CommandField ShowDeleteButton="True" ButtonType="Button"  DeleteImageUrl="~/images/delete.jpg" >
        
            <ControlStyle CssClass="submit" />
        
            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle"  />
        </asp:CommandField>
        
      
    
    
    
    </Columns>
    <HeaderStyle BackColor="#007CC2" ForeColor="White" />
    </asp:GridView>
        </ContentTemplate>
    </asp:UpdatePanel>
</td>

</tr>
<tr><td><table style=" width:700px" ><tr>
<td>
    <asp:UpdatePanel ID="UpdatePanel3" runat="server">
    <ContentTemplate>
<table  align = "left"  width="700px" >
<tr><td></td>
<td align = "right" style="font-weight: bold; ">&nbsp;

    </td>
<td align = "right" ><b>
    Delivery Date:</b>
    <asp:TextBox ID="datepicker" runat="server" AutoPostBack="True" 
        ontextchanged="datepicker_TextChanged2" ValidationGroup="v1" ></asp:TextBox>
    <asp:CalendarExtender ID="CalendarExtender1" runat="server" 
        TargetControlID="datepicker"   >
    </asp:CalendarExtender>
   
   
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
        ErrorMessage="Delivery date required" ControlToValidate="datepicker" 
        ValidationGroup="v1">*</asp:RequiredFieldValidator>
    <asp:Label ID="Label10" runat="server" ></asp:Label>
    </td>
</tr>

    <tr>
        <td>
            <asp:Label ID="Label22" runat="server" Text=""></asp:Label>
            <asp:Label ID="Label23" runat="server" Text=""></asp:Label>
            
            <asp:ImageButton ID="ImageButton2" runat="server" 
                ImageUrl="~/images/shopping.jpg" onclick="ImageButton2_Click"
        />
        </td>
        <td align="right" style="font-weight: bold; ">
        </td>
        <td align="right" style=" font-size:large ">
            Grand Total : Rs.<asp:Label ID="lblcartTotal" runat="server"></asp:Label>
        </td>
    </tr>

<tr>

<td colspan="3" align="center" style="color:#007dbf;">
    <asp:Label ID="Label11" runat="server" ></asp:Label>
</td>
</tr>
<tr>
    
    <td colspan="3" align="center"><asp:ValidationSummary ID="ValidationSummary1" runat="server" 
        ShowMessageBox="True" ShowSummary="False" ValidationGroup="v1" />
    <asp:ImageButton ID="ImageButton1" runat="server" 
        ImageUrl="~/images/submit.jpg" onclick="ImageButton1_Click" 
            ValidationGroup="v1" />
    </td>
    
</tr>


</table>
    </ContentTemplate>
    </asp:UpdatePanel>
</td>
</tr>

</table></td></tr>

</table>
 
</div>


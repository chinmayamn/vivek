<%@ Page Language="C#" MasterPageFile="~/user.master" AutoEventWireup="true" CodeFile="my-orders.aspx.cs" Inherits="my_orders"  %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <style type="text/css">
.bold
{
  font-weight:bold;
}
</style>
<div class="full mid-bg">
    <div id="cont-mid">
        <div id="content">
<h2>Order Details</h2>
<div style="width:100%; float:left; padding:0 0 10px 0;">
<table class="registration" style="width:330px; border-right:#fff solid 2px;">
    <tr class="light">
        <td colspan="2"><b>Customer Detail:</b></td>
    </tr>
    <tr >
        <td class="bold" width="120">Name:</td>
        <td width="150"><asp:Label ID="lblname" runat="server" Text=""></asp:Label></td>
    </tr>
  
    <tr class="light">
        <td class=" bold">Email:</td>
        <td><asp:Label ID="lbladdress" runat="server" Text=""></asp:Label></td>
    </tr>
   
    <tr >
        <td class=" bold">Mobile:</td>
        <td><asp:Label ID="lblregion" runat="server" Text=""></asp:Label> </td>
    </tr>
    <tr class="light">
        <td class=" bold">Address:</td>
        <td><asp:Label ID="lblpostalcode" runat="server" Text=""></asp:Label></td>
    </tr> <tr>
        <td class=" bold">LandMark:</td>
        <td><asp:Label ID="lblcity" runat="server" Text=""></asp:Label></td>
    </tr>
    <tr class="light">
        <td class="bold">City:</td>
        <td><asp:Label ID="lblcountry" runat="server" Text=""></asp:Label></td>
    </tr>
    <tr>
        <td class=" bold">State:</td>
        <td><asp:Label ID="Label2" runat="server" ></asp:Label></td>
    </tr>
  
</table>
<table class="registration" style="width:330px; border-right:#fff solid 2px;">
	<tr class="light">
        <td colspan="2"><b>Shipping Address:</b></td>
    </tr>
   	<tr >
    	<td><b>Name:</b></td>
        <td><asp:Label ID="lbldeliveryname" runat="server" Text=""></asp:Label></td>
   	</tr>
  
    <tr class="light">
    	<td><b>Email:</b></td>
        <td><asp:Label ID="Label4" runat="server" Text=""></asp:Label></td>
  	</tr>
   
    <tr>
    	<td><b>Mobile:</b></td>
        <td><asp:Label ID="Label6" runat="server" Text=""></asp:Label></td>
   	</tr>
    <tr class="light">
    	<td><b>Address:</b></td>
        <td><asp:Label ID="lbldeliveryaddress" runat="server" Text=""></asp:Label></td>
   	</tr>
   	 <tr>
    	<td><b>LandMark:</b></td>
        <td align="left"><asp:Label ID="Label5" runat="server" Text=""></asp:Label></td>
   	</tr>
    <tr class="light">
    	<td><b>City:</b></td>
       	<td><asp:Label ID="lbldeliverycity" runat="server" Text=""></asp:Label></td>
    </tr>
    <tr>
    	<td><b>State:</b></td>
        <td><asp:Label ID="lbldeliveryregion" runat="server" Text=""></asp:Label></td>
    </tr>
  
</table>
<table class="registration" style="width:330px; border-right:#fff solid 2px;">
	<tr class="light">
    	<td colspan="2"><b>Billing Address:</b></td>
        
   	</tr>
    <tr >
    	<td><b>Name:</b></td>
        <td><asp:Label ID="lblname3" runat="server" Text=""></asp:Label></td>
  	</tr>
  
    <tr class="light">
    	<td><b>Email:</b></td>
        <td><asp:Label ID="Label8" runat="server" Text=""></asp:Label></td>
   	</tr>
  
    <tr >
    	<td><b>Mobile:</b></td>
       	<td><asp:Label ID="Label10" runat="server" Text=""></asp:Label></td>
  	</tr>
    <tr class="light">
    	<td><b>Address:</b></td>
	    <td><asp:Label ID="lbladdress3" runat="server" Text=""></asp:Label></td>
   	</tr>
   	  <tr>
    	<td><b>LandMark:</b></td>
        <td><asp:Label ID="Label9" runat="server" Text=""></asp:Label></td>
   	</tr>
    <tr class="light">
    	<td><b>City:</b></td>
        <td><asp:Label ID="lblcity3" runat="server" Text=""></asp:Label></td>
   	</tr>
    <tr>
    	<td><b>State:</b></td>
        <td><asp:Label ID="lblregion3" runat="server" Text=""></asp:Label></td>
   	</tr>
   
</table>
</div><div align="center">
<h2>Ordered items list</h2>


<table >
    <tr>
        <td>
            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False"   
               BorderWidth="2px" 
                HeaderStyle-Font-Bold="true"  CellPadding="6"   CellSpacing="4"
                 >
                <Columns>
                    <asp:BoundField DataField="order_id" HeaderText="Order Id" 
                        SortExpression="products_name" ItemStyle-Width="150" ItemStyle-HorizontalAlign="Center" />
                    <asp:BoundField DataField="productname" HeaderText="Products Name" 
                        SortExpression="products_name" ItemStyle-Width="200" ItemStyle-HorizontalAlign="Center" />
                    <asp:BoundField DataField="product_price" HeaderText="Price (In Rs.)" ItemStyle-Width="80" ItemStyle-HorizontalAlign="Center"
                        SortExpression="products_price" />
                    <asp:BoundField DataField="finalprice" HeaderText="Final Price (In Rs.)" ItemStyle-Width="125" ItemStyle-HorizontalAlign="Center"
                        SortExpression="final_price" />
                  <asp:BoundField DataField="city1" HeaderText="City" ItemStyle-Width="150" ItemStyle-HorizontalAlign="Center" 
                      />
                        
                    <asp:BoundField DataField="quantity" HeaderText="Product Quantity" ItemStyle-HorizontalAlign="Center"
                        SortExpression="products_quantity" />
                         <asp:TemplateField HeaderText="Discount" ItemStyle-HorizontalAlign="Center">
                         <ItemTemplate>
                             <asp:Label ID="Label11" runat="server" Text=<%#Eval("Discount")%>></asp:Label>%
                         </ItemTemplate>
                         </asp:TemplateField>
                         
                         
                            <asp:BoundField DataField="Date" HeaderText="Delivery Date" ItemStyle-HorizontalAlign="Center"
                        SortExpression="products_quantity" />
                            
                </Columns>
<HeaderStyle BackColor="#007CC2" ForeColor="White" />

            </asp:GridView>
        </td>
    </tr>
    <tr>
        <td align="center">
        <h2>Order Summary</h2>
        </td>
    </tr>
    <tr>
        <td align="center">
            &nbsp;
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"   
              
                HeaderStyle-Font-Bold="true" 
                HorizontalAlign="Center" BorderWidth="2px" CellPadding="6" 
                CellSpacing="4" >
            <Columns>
            <asp:TemplateField HeaderText="Date Added">
            <ItemTemplate>
            <%#Eval("createddate")%>
            
            </ItemTemplate>
            </asp:TemplateField>
            
            <asp:TemplateField HeaderText="Customer Notified">
            <ItemTemplate>
            <%#Eval("notified")%>
            
            </ItemTemplate>
            </asp:TemplateField>
            
            <asp:TemplateField HeaderText="Status">
            <ItemTemplate>
            <%#Eval("status")%>
            
            </ItemTemplate>
            </asp:TemplateField>
            
             <asp:TemplateField HeaderText="Comments">
            <ItemTemplate>
            <%#Eval("comments")%>
            
            </ItemTemplate>
            </asp:TemplateField>
            </Columns>
<HeaderStyle BackColor="#007CC2" ForeColor="White" />
            </asp:GridView>
        </td>
    </tr>
    <tr>
        <td align="center">
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </td>
    </tr>
</table>


</div>
</div></div></div>
</asp:Content>


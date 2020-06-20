<%@ Page Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="view-orders.aspx.cs" Inherits="admin_view_orders"  %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<style type="text/css">
.bold
{
  font-weight:bold;
}
</style>
<div align="center">
<h2>View Order</h2>


<table  width="980px">
 <tr  style="height:30px" >
        <td valign="top" style=" font-size:25px; font-weight:bold;"  >
             
    Order Detail
                
          
          
       </td>
    </tr>
    </table>


<table width="100%"  cellspacing="0" cellpadding="2"   > 
          <tr> 
            <td colspan="3">
            <div align="right">
                <asp:ImageButton ID="img_print" runat="server" 
                    ImageUrl="~/images/Print_Icon.gif" onclick="img_print_Click"  />
            </div>
            
            </td> 
          </tr> 
          <tr> 
            <td valign="top" >
            
            <table class="registration" width="330px" border="0" cellspacing="0" cellpadding="2" style=" border-right:#fff solid 2px;"> 
              <tr > 
                
                <td  style="height: 174px" valign="top">
                <table width="100%">
                <tr class="light">
                <td align="left" colspan="2">
                 <b>   Customer Detail:</b>
                </td>
                
              
                
                </tr>
                
                <tr >
                <td align="left" class="bold">
                    Name:
                    
                    </td>
                
                <td align="left">
                <asp:Label ID="lblname" runat="server" Text=""></asp:Label>
                </td>
                
                </tr>
                
              
                
                <tr class="light">
                <td align="left" class=" bold">
                    Email:</td>
                
                <td align="left">
                <asp:Label ID="lbladdress" runat="server" Text=""></asp:Label>
                </td>
                
                </tr>
                
             
                
                <tr >
                <td align="left" class=" bold">
                    Mobile:</td>
                <td align="left">
                <asp:Label ID="lblregion" runat="server" Text=""></asp:Label> 
                </td>
                </tr>
                
                <tr class="light">
                <td align="left" class=" bold">
                    Address:</td>
                <td align="left">
                    <asp:Label ID="lblpostalcode" runat="server" Text=""></asp:Label> 
                </td>
                </tr>
                
                   <tr>
                <td align="left" class=" bold">
                    Landmark:</td>
                <td align="left">
                <asp:Label ID="lblcity" runat="server" Text=""></asp:Label>
                </td>
                </tr>
                
                
                <tr class="light" >
                <td align="left" class=" bold">
                   City:</td>
                <td align="left">
                    <asp:Label ID="lblcountry" runat="server" Text=""></asp:Label>
                </td>
                </tr>
                

                <tr>
                <td align="left"  class=" bold">
                    State:</td>
                <td align="left">
                    <asp:Label ID="Label2" runat="server" ></asp:Label>
                </td>
                </tr>
                

           

                

               
                

                </table>
                     
                    
                     </td> 
              </tr> 
              
                
               
            
            </table></td> 
            <td valign="top" >
            
            <table width="330px" border="0" cellspacing="0" cellpadding="2" class="registration" style=" border-right:#fff solid 2px;"> 
              <tr> 
                <td  style="height: 174px">
                
                <table  width="100%">
                <tr class="light">
                <td align="left" colspan="2">
                    <b>Shipping Address:</b></td>
    
                </tr>
                
                <tr >
                <td align="left">
              <b>Name:</b></td>
                <td align="left">
                <asp:Label ID="lbldeliveryname" runat="server" Text=""></asp:Label>
                </td>
                </tr>
               
                 <tr class="light">
                <td align="left">
              <b>   Email:</b></td>
                <td align="left">
                <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
                </td>
                </tr>
               
                
                 <tr >
                <td align="left">
              <b>   Mobile:</b></td>
                <td align="left">
                <asp:Label ID="Label6" runat="server" Text=""></asp:Label>
                </td>
                </tr>
                
                <tr class="light">
                <td align="left">
                   <b>Address:</b></td>
                <td align="left">
                <asp:Label ID="lbldeliveryaddress" runat="server" Text=""></asp:Label>
                </td>
                </tr>
                
                  <tr>
                <td align="left">
              <b>   Landmark:</b></td>
                <td align="left">
                <asp:Label ID="Label5" runat="server" Text=""></asp:Label>
                </td>
                </tr>
                
                
                <tr class="light">
                <td align="left">
                  <b>  City:</b></td>
                <td align="left">
                 <asp:Label ID="lbldeliverycity" runat="server" Text=""></asp:Label>
                </td>
                </tr>
                <tr>
                <td align="left">
                    <b>State:</b></td>
                <td align="left">
                 <asp:Label ID="lbldeliveryregion" runat="server" Text=""></asp:Label> 
                </td>
                </tr>
               
              
          
                </table>
                
                 
               
                   </td> 
              </tr> 
            </table></td> 
            <td valign="top" ><table class="registration" width="330px" border="0" cellspacing="0" cellpadding="2" style=" border-right:#fff solid 2px;"> 
              <tr> 
                <td >
                
                <table width="100%">
                <tr class="light">
                <td align="left" colspan="2">
                    <b>Billing Address:</b></td>
                </tr>
                
                <tr >
                <td align="left">
                  <b>Name:</b></td>
                <td align="left">
                <asp:Label ID="lblname3" runat="server" Text=""></asp:Label>
                </td>
                </tr>
                
                  <tr class="light">
                <td align="left">
                  <b> Email:</b></td>
                <td align="left">
                <asp:Label ID="Label8" runat="server" Text=""></asp:Label>
                </td>
                </tr>
                
               
                  <tr >
                <td align="left">
                   <b>Mobile:</b></td>
                <td align="left">
                <asp:Label ID="Label10" runat="server" Text=""></asp:Label>
                </td>
                </tr>
                <tr class="light">
                <td align="left">
                   <b>Address:</b></td>
                <td align="left">
                <asp:Label ID="lbladdress3" runat="server" Text=""></asp:Label>
                </td>
                </tr>
                   <tr>
                <td align="left">
                   <b>Landmark:</b></td>
                <td align="left">
                <asp:Label ID="Label9" runat="server" Text=""></asp:Label>
                </td>
                </tr>
                <tr class="light">
                <td align="left">
                    <b>City:</b></td>
                <td align="left">
                 <asp:Label ID="lblcity3" runat="server" Text=""></asp:Label>
                </td>
                </tr>
                <tr>
                <td align="left">
                   <b>State:</b> </td>
                <td align="left">
                <asp:Label ID="lblregion3" runat="server" Text=""></asp:Label> 
                </td>
                </tr>
                
            
           
                
                </table>
                
       
                   
                    </td> 
              </tr> 
            </table></td> 
          </tr> 
        </table>
        <br /><br />
        <h2>Ordered items list</h2>
<table  align="center">
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
    </table>
    <br /><br />
     <h2>Order Summary</h2>
    <table>
  
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
<br /><br />
<table align="center">
      <tr> 
        <td><br><b >Comments</b></td> 
      </tr> 
      <tr> 
        <td align="left"><img src="images/pixel_trans.gif" border="0" alt="" width="1" height="5"></td> 
      </tr> 
      <tr> <td >
          <asp:TextBox ID="txtcomment" runat="server" Height="100px" TextMode="MultiLine" Width="500px"></asp:TextBox>
      
      </td> 
      </tr> 
      <tr> 
        <td align="left"><img src="images/pixel_trans.gif" border="0" alt="" width="1" height="10"></td> 
      </tr> 
      <tr> 
        <td align="left"><table border="0" cellspacing="0" cellpadding="2"> 
          <tr> 
            <td align="left"><table border="0" cellspacing="0" cellpadding="2" > 
              <tr> 
                <td ><b>Status:</b> 
                
                
                    <asp:DropDownList ID="ddlstatus" runat="server">
                    <asp:ListItem Text="Pending">
                   
                    </asp:ListItem>
                    
                    <asp:ListItem Text="Processing">
                   
                    </asp:ListItem>
                    
                    <asp:ListItem Text="Delivered">
                    
                    </asp:ListItem>
                    </asp:DropDownList>
                
                
                </td> 
              </tr> 
              <tr> 
                <td ><b>Notify Customer:</b>
                
                    <asp:CheckBox ID="CheckBox_notify" runat="server" Checked="true"/>
                    
                 </td> 
                <td ><b>Append Comments:</b>&nbsp;
                    <asp:CheckBox ID="Check_comment" runat="server"  Checked="true"/></td> 
              </tr> 
              <tr> 
                <td colspan="2">&nbsp;
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Submit" class="submit" />
                </td> 
                <td >&nbsp;</td> 
              </tr> 
            </table></td> 
            
          </tr> 
        </table>
</table>
 
</div>
</asp:Content>


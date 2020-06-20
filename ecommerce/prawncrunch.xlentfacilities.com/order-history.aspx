<%@ Page Language="C#" MasterPageFile="~/user.master" AutoEventWireup="true" CodeFile="order-history.aspx.cs" Inherits="order_history"  %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="full mid-bg">
    <div id="cont-mid">
        <div id="content"  style="min-height:300px">
                    	<h2 style="margin:0 0 10px 0;">My Orders</h2>
        	<table class="registration">
    			<tr>
        			<td valign="top">
                        
            <asp:GridView  BorderWidth="1px" ID="GridView1" runat="server" HorizontalAlign="Center" DataKeyNames="ID" AutoGenerateColumns="False" AllowPaging="True" onpageindexchanging="GridView1_PageIndexChanging"  onrowdeleting="GridView1_RowDeleting" CellPadding="6" CellSpacing="0" PageSize="25" onrowdatabound="GridView1_RowDataBound" width="950">
                <Columns>
               <asp:BoundField HeaderText="Order Id" DataField="id"  ItemStyle-HorizontalAlign="Center"/>
                    
                    <asp:TemplateField HeaderText="Customer" ItemStyle-HorizontalAlign="Center">
                        <ItemTemplate>
                             <a href="my-orders.aspx?orders_id=<%#Eval("id") %>"> <%#Eval("firstname") %> </a>
                        </ItemTemplate>
                    </asp:TemplateField>
        			<asp:BoundField DataField="date" HeaderText="Order Date" ItemStyle-HorizontalAlign="Center"/>
               			<asp:TemplateField HeaderText="Status" ItemStyle-HorizontalAlign="Center">
            			<ItemTemplate>
            				<asp:Label ID="Label2" runat="server"  Text=<%#Eval("Status") %>></asp:Label>
                        </ItemTemplate>
            			</asp:TemplateField>
            		<asp:TemplateField ItemStyle-HorizontalAlign="Center">
            			<ItemTemplate>
                        	<a href="my-orders.aspx?orders_id=<%#Eval("id") %>">View Details</a>
            			</ItemTemplate>
            		</asp:TemplateField>
            	</Columns>
            </asp:GridView>
         </td>
    </tr>
     <tr>
    	<td><asp:Label ID="Label1" runat="server" Text=""></asp:Label></td>
    </tr>
</table>
</div>
</div></div>
</asp:Content>


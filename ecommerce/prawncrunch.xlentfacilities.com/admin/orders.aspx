<%@ Page Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="orders.aspx.cs" Inherits="admin_orders"  %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div align="center">
<h2>  Manage Orders</h2>
<table >
    <tr>
        <td >
        
            <asp:GridView BorderWidth="2px" ID="GridView1" runat="server" HorizontalAlign="Center" 
                DataKeyNames="ID" AutoGenerateColumns="False" AllowPaging="True" 
                onpageindexchanging="GridView1_PageIndexChanging"  
                onrowdeleting="GridView1_RowDeleting" CellPadding="6" 
        CellSpacing="4" PageSize="25" onrowdatabound="GridView1_RowDataBound">
                <Columns>
                <asp:BoundField HeaderText="Order Id" DataField="id"  HeaderStyle-HorizontalAlign="Center" />
                    <asp:TemplateField HeaderText="Customer">
                        <ItemTemplate>
                             <a href="view-orders.aspx?orders_id=<%#Eval("id") %>"> <%#Eval("firstname") %> </a>
                        </ItemTemplate>
                    </asp:TemplateField>
        
       
            
            <asp:BoundField DataField="date" HeaderText="Order Date" />
               <asp:TemplateField HeaderText="Status">
            <ItemTemplate>
            
         
                <asp:Label ID="Label2" runat="server"  Text=<%#Eval("Status") %>></asp:Label>
            </ItemTemplate>
            
            </asp:TemplateField>
            
            <asp:TemplateField>
            <ItemTemplate>
            
             <a href="view-orders.aspx?orders_id=<%#Eval("id") %>">View Details</a>
             
            </ItemTemplate>
            
            </asp:TemplateField>
            
                    <asp:CommandField ShowDeleteButton="True" />
                </Columns>
                 <HeaderStyle BackColor="#007CC2" ForeColor="White" />
            </asp:GridView>
           
         </td>
    </tr>


    <tr><td>
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label></td></tr>
</table>
</div>
</asp:Content>


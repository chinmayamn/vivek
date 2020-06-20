<%@ Control Language="C#" AutoEventWireup="true" CodeFile="newcart.ascx.cs" Inherits="Shop_newcart" %>
<link href="../css/style.css" rel="stylesheet" type="text/css" />
        
       
       
<table style="width:100%"   >

<tr>

<td align="center"  colspan="2">
    <img src="images/1.jpg"  />
  
</td>

</tr>
<tr >
<td>
  <b> Enter Discount Coupon Here:</b> <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
</td>
<td>
    <asp:Button ID="Button1" runat="server" Text="Add Coupon" 
        onclick="Button1_Click" BackColor="#6B207F" BorderColor="#6B207F" 
        Font-Bold="True" ForeColor="White" /></td>
</tr>
</table>

<table  style="width:100%; padding-top:20px;" > 




<tr style="width:100%;">
<td align="left" colspan="2" >

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:GridView ID="GridView1" runat="server"  HeaderStyle-Height="50px"
    AlternatingRowStyle-BackColor="#c39dcb" AutoGenerateColumns="False" 
    BorderColor="#6B207F" OnRowCancelingEdit="GridView1_RowCancelingEdit" 
    OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" 
    OnRowUpdating="GridView1_RowUpdating" 
     Width="100%" Height="35px">
                <Columns>
                    <asp:TemplateField HeaderStyle-BackColor="#6B207F" 
            HeaderText="Product">
                        <ItemTemplate>
                            <asp:Label ID="Label5" runat="server" Text='<%#Eval("ProductId")%>' Visible="false"></asp:Label>
                            <asp:Label ID="Label1" runat="server" 
                    Text='<%#Eval("ProductName")%>'></asp:Label>
                        </ItemTemplate>
                        <ItemStyle HorizontalAlign="Center" 
                VerticalAlign="Middle" />
                        <HeaderStyle HorizontalAlign="Center" 
                VerticalAlign="Middle" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderStyle-BackColor="#6B207F" 
            HeaderText="Item">
                        <ItemTemplate>
                       <asp:Image ID="Image1" runat="server" Height="100px" 
                    ImageUrl='<%#Eval("ProductImageUrl")%>' Width="120px" />
                    
                  
                    
                    
                        </ItemTemplate>
                        <ItemStyle Height="100px" HorizontalAlign="Center" 
                VerticalAlign="Middle" Width="130px" />
                        <HeaderStyle HorizontalAlign="Center" 
                VerticalAlign="Middle" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderStyle-BackColor="#6B207F" 
            HeaderText="Price">
                        <ItemTemplate>
                   Rs:
                            <asp:Label ID="Label21" runat="server" 
                    Text='<%#Eval("Price")%>'></asp:Label>
                        </ItemTemplate>
                        <ItemStyle HorizontalAlign="Center" 
                VerticalAlign="Middle" />
                        <HeaderStyle HorizontalAlign="Center" 
                VerticalAlign="Middle" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderStyle-BackColor="#6B207F" 
            HeaderText="Tax ">
                        <ItemTemplate>
                    Rs:        <asp:Label ID="Label2" runat="server" 
                    Text='<%#Eval("Tax")%>'></asp:Label>
                        </ItemTemplate>
                        <ItemStyle HorizontalAlign="Center" 
                VerticalAlign="Middle" />
                        <HeaderStyle HorizontalAlign="Center" 
                VerticalAlign="Middle" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderStyle-BackColor="#6B207F" 
            HeaderText="Shipping">
                        <ItemTemplate>
             Rs:               <asp:Label ID="Shipping" runat="server" 
                    Text='<%#Eval("Shipping")%>'></asp:Label>
                        </ItemTemplate>
                        <ItemStyle HorizontalAlign="Center" 
                VerticalAlign="Middle" />
                        <HeaderStyle HorizontalAlign="Center" 
                VerticalAlign="Middle" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderStyle-BackColor="#6B207F" 
            HeaderText="Quantity">
                        <ItemTemplate>
                            <asp:Label ID="Label3" runat="server" 
                    Text='<%#Eval("Quantity")%>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txteditqty" runat="server" 
                    Text='<%#Eval("Quantity")%>' Width="50px"></asp:TextBox>
                        </EditItemTemplate>
                        <ItemStyle HorizontalAlign="Center" 
                VerticalAlign="Middle" Width="60px" />
                        <HeaderStyle HorizontalAlign="Center" 
                VerticalAlign="Middle" Width="60px" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderStyle-BackColor="#6B207F" 
            HeaderText="Line Total">
                        <ItemTemplate>
                 Rs:          <asp:Label ID="Label4" runat="server" 
                    Text='<%#Eval("Linetotal")%>'></asp:Label>
                        </ItemTemplate>
                        <ItemStyle HorizontalAlign="Center" 
                VerticalAlign="Middle" Width="80px" />
                        <HeaderStyle HorizontalAlign="Center" 
                VerticalAlign="Middle" Width="80px" />
                    </asp:TemplateField>
                    <asp:CommandField ButtonType="Image" 
            EditImageUrl="../images/edit.jpg" HeaderStyle-BackColor="#6B207F"  UpdateImageUrl="~/images/update.jpg" CancelImageUrl="~/images/3_cancel.jpg"
            ShowEditButton="True">
                    <HeaderStyle BackColor="#6B207F" />
                    <ItemStyle HorizontalAlign="Center" 
            VerticalAlign="Middle" />
                    </asp:CommandField>
                    <asp:CommandField ButtonType="Button" 
            DeleteImageUrl="~/images/delete.jpg" HeaderStyle-BackColor="#6B207F" 
            ShowDeleteButton="True" ControlStyle-ForeColor="White" ControlStyle-BackColor="#6B207F" ControlStyle-Height="24">
                    <ControlStyle BackColor="#6B207F" ForeColor="White" />
                    <HeaderStyle BackColor="#6B207F" />
                    <ItemStyle HorizontalAlign="Center" 
            VerticalAlign="Middle" />
                    </asp:CommandField>
                </Columns>
                <HeaderStyle ForeColor="White" />
                <AlternatingRowStyle BackColor="#C39DCB" />
            </asp:GridView>
        </ContentTemplate>
    </asp:UpdatePanel>
</td>
</tr>
<tr><td>
<table style="background-color:#6B207F; width:100%"><tr >
<td>
    <asp:Label ID="Label22" ForeColor="White" runat="server" Text=""></asp:Label>
    :<asp:Label ID="Label23" ForeColor="White" runat="server" Text=""></asp:Label>
</td>
<td  align="right" >

<span style ="padding-left: 30px">

    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
    
    <ContentTemplate>
    
    
<span  style=" font-size:16px; font-weight:bold; color:White">Total :&nbsp;Rs:&nbsp; <asp:Label ID="lblcartotal" ForeColor="White" runat="server" Text="Label"></asp:Label></span> 

</ContentTemplate>
    </asp:UpdatePanel>
</span>
    

</td>
</tr>
<tr  style="background-color:#6B207F">
<td align="left">
    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="images/shopping.jpg"
        OnClick="ImageButton1_Click"  /></td>
<td align="right">
    
  
        <asp:ImageButton ID="ImageButton2" runat="server"  
            ImageUrl="~/images/checkout.jpg" OnClick="ImageButton2_Click" />
    <%--<asp:LinkButton ID="lnkchkout" runat="server" CssClass="checkouttext" Font-Underline="False" OnClick="lnkchkout_Click" Visible="False"></asp:LinkButton>--%>
     
</td>
</tr>
<tr  style="background-color:#6B207F">
<td align="left">
    &nbsp;</td>
<td align="right">
    
  
        &nbsp;</td>
</tr></table></td></tr>

</table>

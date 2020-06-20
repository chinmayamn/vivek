<%@ Control Language="C#" AutoEventWireup="true" CodeFile="carting.ascx.cs" Inherits="carting" %>
  <%@ Register TagPrefix="mp" TagName="MyMP" Src="~/user.master" %>

      <center><img src="images/1.jpg"  /></center>

<table style="width:100%; padding-top:20px;" > 
	<tr>
		<td align="left" colspan="2" >

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:GridView ID="GridView1" runat="server"  HeaderStyle-Height="50px" AutoGenerateColumns="False" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" Width="940px">
                <Columns>
                    <asp:TemplateField  
            HeaderText="Product">
                        <ItemTemplate>
                            <asp:Label ID="Label1" runat="server" 
                    Text='<%#Eval("ProductName")%>'></asp:Label>
                        </ItemTemplate>
                        <ItemStyle HorizontalAlign="Center" 
                VerticalAlign="Middle" />
                        <HeaderStyle HorizontalAlign="Center" 
                VerticalAlign="Middle" />
                    </asp:TemplateField>
                    
                    
                    <asp:TemplateField  
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
                    
                    
                    <asp:TemplateField  
            HeaderText="Price">
                        <ItemTemplate>
                   Rs.    <asp:Label ID="Label21" runat="server" 
                    Text='<%#Eval("Price")%>'></asp:Label>
                        </ItemTemplate>
                        <ItemStyle HorizontalAlign="Center" 
                VerticalAlign="Middle" />
                        <HeaderStyle HorizontalAlign="Center" 
                VerticalAlign="Middle" />
                    </asp:TemplateField>
                    
                    
                 
                    
                  
                    <asp:TemplateField  
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
                    
                    
                      <asp:TemplateField  
            HeaderText="Discount">
                        <ItemTemplate>
                            <asp:Label ID="Label3222" runat="server" 
                    Text=<%#Eval("discount")%>></asp:Label>%
                        </ItemTemplate>
                     
                        <ItemStyle HorizontalAlign="Center" 
                VerticalAlign="Middle" Width="60px" />
                        <HeaderStyle HorizontalAlign="Center" 
                VerticalAlign="Middle" Width="60px" />
                    </asp:TemplateField>
                    
                    
                    
                    <asp:TemplateField  
            HeaderText="Line Total">
                        <ItemTemplate>
                Rs.         <asp:Label ID="Label4" runat="server" 
                    Text='<%#Eval("Linetotal")%>'></asp:Label>
                        </ItemTemplate>
                        <ItemStyle HorizontalAlign="Center" 
                VerticalAlign="Middle" Width="80px" />
                        <HeaderStyle HorizontalAlign="Center" 
                VerticalAlign="Middle" Width="80px" />
                    </asp:TemplateField>
                    
                    
                    
                    <asp:CommandField ButtonType="Image" 
            EditImageUrl="images/edit.jpg" UpdateImageUrl="images/update.jpg" CancelImageUrl="~/images/3_cancel.jpg"
            ShowEditButton="True">
                  
                    <ItemStyle HorizontalAlign="Center" 
            VerticalAlign="Middle" />
                    </asp:CommandField>
                    <asp:CommandField ButtonType="Button" DeleteImageUrl="~/images/delete.jpg" ShowDeleteButton="True"   ControlStyle-Height="24">    
                    <ControlStyle CssClass="buttona" />             
                
                    <ItemStyle HorizontalAlign="Center" 
            VerticalAlign="Middle" />
                    </asp:CommandField>
                </Columns>
             <HeaderStyle BackColor="#007CC2" ForeColor="White" />
            </asp:GridView>
        </ContentTemplate>
    </asp:UpdatePanel>
</td>
</tr>
<tr><td>
<table width="100%"><tr >
<td>
    <asp:Label ID="Label22" ForeColor="White" runat="server" Text=""></asp:Label>
   <asp:Label ID="Label23" ForeColor="White" runat="server" Text=""></asp:Label>
</td>
<td  align="right" >

<span style ="padding-left: 30px">

    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
    
    <ContentTemplate>
    
    
<span  style=" font-size:16px; font-weight:bold;" >Total :&nbsp;Rs. <asp:Label ID="lblcartotal"  runat="server" ></asp:Label></span> 

</ContentTemplate>
    </asp:UpdatePanel>
</span>
    

</td>
</tr>
<tr  >
<td align="left">
    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="images/shopping.jpg"
        OnClick="ImageButton1_Click"  /></td>
<td align="right">
    
    <asp:UpdatePanel ID="UpdatePanel3" runat="server">
    <ContentTemplate>
  
        <asp:ImageButton ID="ImageButton2" runat="server"  
            ImageUrl="images/checkout.jpg" OnClick="ImageButton2_Click" />
       </ContentTemplate>
    </asp:UpdatePanel>
</td>
</tr>
<tr>
    <td align="left">
    <b style="color:#007dbf;">Note:</b> Discount option will be provided at the last stage of checkout.
    </td>
    <td></td>
</tr>

</table></td></tr>

</table>
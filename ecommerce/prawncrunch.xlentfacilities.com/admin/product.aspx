<%@ Page Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="product.aspx.cs" Inherits="admin_product"  %>
<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  
  <style type="text/css">
  .bold
  {
  font-weight:bold;
  }
  </style>
    <div align="center">
    <h2>Manage Product</h2>
    <table cellpadding="6" cellspacing="2">
 
   <tr><td class="bold">
                Category:</td>
    <td>
        <asp:DropDownList ID="DropDownList1" runat="server" ValidationGroup="v1">
        </asp:DropDownList>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ControlToValidate="DropDownList1" ErrorMessage="Select category" 
            InitialValue="Select" ValidationGroup="v1">*</asp:RequiredFieldValidator>
    </td>
    </tr>
    
 <tr><td class="bold">
     Product Name:</td>
    <td>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:RequiredFieldValidator
            ID="RequiredFieldValidator1" runat="server" 
            ErrorMessage="Product  name required" ValidationGroup="v1" 
            ControlToValidate="TextBox1">*</asp:RequiredFieldValidator>
    </td>
    </tr>
    
    
        
            <tr><td class="bold">
                Product Image:</td>
    <td>
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <asp:Image ID="Image2" runat="server" Width="250" />
    </td>
    </tr>
    
    
            <tr><td class="bold">
                Description:</td>
    <td>
        &nbsp;        <FCKeditorV2:FCKeditor ID="fck1" runat="server" BasePath="~/fckeditor/" Height="500px" Width="700px"></FCKeditorV2:FCKeditor>
</td>
    </tr>
    
    
        
          
    
        
            <tr><td colspan="2" align="center" class="btns1">
                <asp:Button ID="Submit" runat="server" Text="Create" onclick="Submit_Click" 
                    ValidationGroup="v1" class="submit" />
                <asp:Button ID="btnupdate" runat="server" Text="Update" 
                class="submit"    onclick="btnupdate_Click" ValidationGroup="v1" Visible="false"/>
                </td></tr>
                <tr> <td colspan="2">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                        ShowMessageBox="True" ShowSummary="False" ValidationGroup="v1" />
                </td></tr>
        </table>
        
        
        <table style="margin-bottom:15px"><tr><td>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                DataKeyNames="id" onrowdeleting="GridView1_RowDeleting" BorderWidth="2px" 
                BorderColor="White" BorderStyle="Groove" AllowPaging="True"  PageSize="10"
                onpageindexchanging="GridView1_PageIndexChanging1" 
              CellPadding="6" CellSpacing="2">
                <Columns>
                <asp:TemplateField HeaderText="Category Name">
                        
                        <ItemTemplate>
                            <asp:Label ID="Label2" runat="server" Text=<%#Bind("categoryname") %>></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                 
                 <asp:TemplateField HeaderText="Product Name">
                        
                        <ItemTemplate>
                         
                            <asp:Label ID="Label3" runat="server" Text=<%#Bind("pname") %> ></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    
                    <asp:TemplateField HeaderText="Product Image">
                        
                        <ItemTemplate>
                         
                            <asp:Image ID="Image1" runat="server" Width="100" Height="100" ImageUrl=<%#Bind("pimage") %> />
                        </ItemTemplate>
                    </asp:TemplateField>
                    
                  
              
               <asp:TemplateField HeaderText="Description">
                        
                        <ItemTemplate>
                   
                            <asp:Label ID="Label5" runat="server" Text=<%#Server.HtmlDecode(Eval("description").ToString()) %>></asp:Label>      
                        </ItemTemplate>
                    </asp:TemplateField>
                    
                        <asp:TemplateField >
                        
                        <ItemTemplate>
                   
                 <a href=product.aspx?id=<%#Eval("id")%> >Edit</a>            </ItemTemplate>
                    </asp:TemplateField>
                    
                    <asp:CommandField ShowDeleteButton="True" />
                 
                </Columns>
                 <HeaderStyle BackColor="#007CC2" ForeColor="White" />
            </asp:GridView>
        </td></tr>
        <tr>
        <td>
           <asp:Label ID="Label1" runat="server" Text="Album Name"></asp:Label>
        </td>
        </tr>
        </table>
        </div>
</asp:Content>


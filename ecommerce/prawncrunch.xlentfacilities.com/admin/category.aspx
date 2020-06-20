<%@ Page Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="category.aspx.cs" Inherits="admin_category"  %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <style type="text/css">
   .bold
   
   {
   font-weight:bold;
   }
   </style>
    <div align="center">
    
    <h2>Manage Category</h2>
    <table cellpadding="6" cellspacing="2"><tr><td class="bold">
        Category Name:</td>
    <td>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><asp:RequiredFieldValidator
            ID="RequiredFieldValidator1" runat="server" 
            ErrorMessage="Category name required" ValidationGroup="v1" ControlToValidate="TextBox3">*</asp:RequiredFieldValidator>
    </td>
    </tr>
    
    
        
            <tr><td class="bold">
                Upload Image:</td>
    <td>
        <asp:FileUpload ID="FileUpload1" runat="server" />
        
        <asp:Image ID="Image2" runat="server" width="250"/>
    </td>
    </tr>
    
    
        
            <tr><td colspan="2" align="center" class="btns1">
                <asp:Button ID="Submit" runat="server" Text="Create" onclick="Submit_Click" 
                    ValidationGroup="v1" class="submit"/>
                <asp:Button ID="btnupdate" runat="server" Text="Update" 
                    onclick="btnupdate_Click" ValidationGroup="v1" Visible="false" class="submit"/>
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
                <Columns><asp:TemplateField HeaderText="Category name">
                        
                        <ItemTemplate>
                            <asp:Label ID="Label2" runat="server" Text=<%#Bind("categoryname") %>></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                 
                 <asp:TemplateField HeaderText="Category Image">
                        
                        <ItemTemplate>
                         
                            <asp:Image ID="Image1" runat="server" Width="100" Height="100" ImageUrl=<%#Bind("categoryimage") %> />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField >
                        <ItemTemplate>
                        <a href=category.aspx?id=<%#Eval("id")%> > Edit</a>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:CommandField ShowDeleteButton="True" />
                 
                </Columns>
                <HeaderStyle BackColor="#007CC2" ForeColor="White" />
            </asp:GridView>
        </td></tr>
        <tr>
        <td>
           <asp:Label ID="Label1" runat="server" ></asp:Label>
        </td>
        </tr>
        </table>
        </div>
</asp:Content>


<%@ Page Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="discount.aspx.cs" Inherits="Management_discount" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

 <div align="center">
<table>
    <tr>
        <td>
            Select Category:
        </td>
        <td>
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
                onselectedindexchanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            InitialValue="Select"     ErrorMessage="Category name required" ControlToValidate="DropDownList1" 
                ValidationGroup="v1">*</asp:RequiredFieldValidator>
        </td>
    </tr>
   <tr>
        <td>
            Select Product:         </td>
        <td>
            <asp:DropDownList ID="DropDownList2" runat="server">
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
              InitialValue="Select"    ErrorMessage="Category name required" ControlToValidate="DropDownList2" 
                ValidationGroup="v1">*</asp:RequiredFieldValidator>
        </td>
    </tr>
   <tr>
        <td>
            Small Text:         </td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
          
        </td>
    </tr>
    
     <tr>
        <td>
           Discount:         </td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server" ValidationGroup="v1"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
             ErrorMessage="Discount required" ControlToValidate="TextBox2" 
             ValidationGroup="v1">*</asp:RequiredFieldValidator>
        </td>
    </tr>
    
    
  
    <tr>
        <td>
            
        </td>
        <td>
            <asp:Button ID="Button1" runat="server" Text="Add Discount" 
                ValidationGroup="v1" onclick="Button1_Click" />
                <asp:Button ID="Button2" runat="server" Text="Update Discount" 
                ValidationGroup="v1" onclick="Button2_Click" />
        </td>
    </tr>
    <tr>
        <td>
        </td>
        <td>
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                ShowMessageBox="True" ShowSummary="False" ValidationGroup="v1" />
        </td>
    </tr>
</table>
<br />
<br />
<table>
    <tr>
        <td>
            <asp:GridView ID="GridView1" runat="server" DataKeyNames="id"  PageSize="10"  CellPadding="6" CellSpacing="3"
                AutoGenerateColumns="False" AllowPaging="True"   onrowdeleting="GridView1_RowDeleting"
             >
                <Columns>
                    <asp:BoundField HeaderText="Category" DataField="categoryname" />
                    <asp:BoundField HeaderText="Product" DataField="pname" />
                    <asp:TemplateField HeaderText="Image">
                     <ItemTemplate>
                         <asp:Image ID="Image1" runat="server"  Width="100" Height="100" ImageUrl=<%#Eval("pimage")%>/>
                     </ItemTemplate>
                    </asp:TemplateField>
                     <asp:BoundField HeaderText="Text" DataField="text" />
                      <asp:BoundField HeaderText="Discount (%)" DataField="discount" />
                      <asp:TemplateField HeaderText="Edit">
                      <ItemTemplate>
                      <a href=discount.aspx?id=<%#Eval("id") %>>Edit</a>
                      </ItemTemplate>
                      </asp:TemplateField>
                    <asp:CommandField ShowDeleteButton="True" />
                </Columns>
            </asp:GridView>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label1" runat="server" Text="No discount added till now" ></asp:Label>
        </td>
    </tr>
</table>

</div>
</asp:Content>



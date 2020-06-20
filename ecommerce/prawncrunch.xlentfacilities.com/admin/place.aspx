<%@ Page Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="place.aspx.cs" Inherits="admin_place"  %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <style type="text/css">
.bold
{
 font-weight:bold;
}
</style>
<div align="center">
    <h2>Manage Price</h2>
<table>
<tr>
        <td class="bold">
            Category:
        </td>
        <td>
            <asp:DropDownList ID="DropDownList2" runat="server" ValidationGroup="v1" width="250"
                AutoPostBack="True" onselectedindexchanged="DropDownList2_SelectedIndexChanged">
            
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                ErrorMessage="Select Category" ControlToValidate="DropDownList2" 
                InitialValue="Select" ValidationGroup="v1">*</asp:RequiredFieldValidator>
        </td>
    </tr>

<tr>
        <td class="bold">
            Product:         </td>
        <td>
            <asp:DropDownList ID="DropDownList3" runat="server" ValidationGroup="v1" width="250">
           
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                ErrorMessage="Select Product" ControlToValidate="DropDownList3" 
                InitialValue="Select" ValidationGroup="v1">*</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="bold">
            City:
        </td>
        <td>
            <asp:DropDownList ID="DropDownList1" runat="server" ValidationGroup="v1" width="250">
            <asp:ListItem Text="Select" Value="Select"></asp:ListItem>
            <asp:ListItem Text="Bangalore" Value="Bangalore"></asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ErrorMessage="City required" ControlToValidate="DropDownList1" 
                InitialValue="Select" ValidationGroup="v1">*</asp:RequiredFieldValidator>
        </td>
    </tr>
 <%--   <tr>
        <td class="bold">
           Place:
        </td>
        <td>
            <asp:DropDownList ID="DropDownList4" runat="server" AutoPostBack="True" width="250"
                onselectedindexchanged="DropDownList4_SelectedIndexChanged">
            <asp:ListItem Text="Select"></asp:ListItem>
            <asp:ListItem Text="Bangalore North"></asp:ListItem>
              <asp:ListItem Text="Bangalore South"></asp:ListItem>
                <asp:ListItem Text="Bangalore East"></asp:ListItem>
                  <asp:ListItem Text="Bangalore West"></asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                ErrorMessage="Select place" ControlToValidate="DropDownList4" ValidationGroup="v1" InitialValue="Select">*</asp:RequiredFieldValidator>
        </td>
    </tr>
    --%>
   
    <tr>
        <td class="bold">
           Price:
        </td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server" ValidationGroup="v1" width="250"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                ErrorMessage="Price required" ControlToValidate="TextBox1" ValidationGroup="v1">*</asp:RequiredFieldValidator>
        </td>
    </tr>
    
    <tr>
        <td>
            
        </td>
        <td>
            <asp:Button ID="Button1" runat="server" Text="Add Price" class="submit"
                onclick="Button1_Click" ValidationGroup="v1" />
                <asp:Button ID="Button2" runat="server" Text="Update Price" class="submit1"
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
            <asp:GridView ID="GridView1" runat="server" DataKeyNames="id"  PageSize="10"
                AutoGenerateColumns="False" AllowPaging="True" 
                onpageindexchanging="GridView1_PageIndexChanging" 
                onrowdeleting="GridView1_RowDeleting" CellPadding="10" CellSpacing="8">
                <Columns>
                  <asp:BoundField HeaderText="Category" DataField="categoryname" />
                    <asp:BoundField HeaderText="Product" DataField="pname" />
                    <asp:BoundField HeaderText="City" DataField="city" />
                 <%--   <asp:BoundField HeaderText="Place" DataField="placename" />
                 --%>   
                     <asp:BoundField HeaderText="Price/Kg." DataField="price" />
               
                <asp:TemplateField>
                
                <ItemTemplate>
                <a href=place.aspx?id=<%#Eval("id") %> >Edit</a>
                </ItemTemplate>
                </asp:TemplateField>
               
                    <asp:CommandField ShowDeleteButton="True" />
                </Columns>
                    <HeaderStyle BackColor="#007CC2" ForeColor="White" />
            </asp:GridView>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label1" runat="server" ></asp:Label>
        </td>
    </tr>
</table>

</div>
</asp:Content>


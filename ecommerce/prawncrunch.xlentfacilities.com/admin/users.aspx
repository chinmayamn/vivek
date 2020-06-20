<%@ Page Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="users.aspx.cs" Inherits="admin_users"  %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <script type="text/javascript" src="../highslide-with-html.js"></script>
<link rel="stylesheet" type="text/css" href="../highslide.css" />
<script type="text/javascript">
hs.graphicsDir = '../graphics/';
hs.outlineType = 'rounded-white';
hs.wrapperClassName = 'draggable-header';

</script>
<div align="center">
<h2>Manage Users</h2>

 
 
<table >
<tr>
<td>
  


    <asp:GridView ID="GridView1" runat="server" DataKeyNames="UserName" BorderWidth="1" CellPadding="5" CellSpacing="3" GridLines="Horizontal">
    <Columns>
    <asp:TemplateField>
    <ItemTemplate>
        <asp:CheckBox ID="CheckBox1" runat="server" />
    </ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button ID="btnDelete" runat="server" BackColor="Transparent" 
                        BorderColor="LightGray" BorderStyle="None" Font-Bold="True" ForeColor="Blue" 
                        OnClick="BtnDelete_Click" OnClientClick="showConfirm(this); return false;" 
                        Text="Delete" Width="50px" />
                </ItemTemplate>
             
            </asp:TemplateField>
            
          <asp:TemplateField >
          <ItemTemplate>
          <a href=viewuser.aspx?id=<%#Eval("username")%> onclick="return hs.htmlExpand(this, { objectType: 'iframe' } )">
              <asp:Label ID="Label1" runat="server" Text="View Details"></asp:Label>
              <asp:Label ID="Label2" runat="server" Text=<%#Eval("mobilenumber")%> Visible=false></asp:Label>
          </a>
          </ItemTemplate>
          </asp:TemplateField>
            </Columns>
          <HeaderStyle BackColor="#007CC2" ForeColor="White" />
    </asp:GridView>
    </td>
</tr>
</table>
   
   <br />
   
    <asp:Button ID="Button3" runat="server" Text="Select All" onclick="Button3_Click" CssClass="submit" />
    <asp:Button ID="Button4" runat="server" Text="Unselect All" onclick="Button4_Click" CssClass="submit"  />
   <br />
    <asp:Button ID="Button1" runat="server" Text="Export to Excel"  class="submit1"
        onclick="Button1_Click" />
        <br />Sms Content:
    <asp:TextBox ID="TextBox1" runat="server" Columns="30" Rows="8"  ValidationGroup="v1"
        TextMode="MultiLine" ></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
        ErrorMessage="SMS content required" ControlToValidate="TextBox1" 
        ValidationGroup="v1">*</asp:RequiredFieldValidator>
        <br />
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
        ShowMessageBox="True" ShowSummary="False" ValidationGroup="v1" />
        <asp:Button ID="Button2" runat="server" Text="Send SMS"  class="submit1" 
        ValidationGroup="v1" onclick="Button2_Click"
         />
        
</div>
</asp:Content>


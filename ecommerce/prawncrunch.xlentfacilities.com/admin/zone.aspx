<%@ Page Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="zone.aspx.cs" Inherits="admin_zone" Title="Untitled Page" %>

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
    
    <h2>Manage Zones</h2>
    <table cellpadding="6" cellspacing="2">
    
    <tr><td class="bold">
        City:</td>
    <td>
        
        <asp:DropDownList ID="DropDownList1" runat="server">
        <asp:ListItem Text="Select"></asp:ListItem>
        <asp:ListItem Text="Bangalore"></asp:ListItem>
        </asp:DropDownList>
        
                <asp:RequiredFieldValidator
            ID="RequiredFieldValidator2" runat="server" 
            ErrorMessage="Select city" ValidationGroup="v1" ControlToValidate="DropDownList1" InitialValue="Select">*</asp:RequiredFieldValidator>
    </td>
    </tr>
    
    
     <tr><td class="bold">
       Place:</td>
    <td>
        
       <asp:DropDownList ID="DropDownList2" runat="server">
            <asp:ListItem Text="Select"></asp:ListItem>
            <asp:ListItem Text="Bangalore North"></asp:ListItem>
              <asp:ListItem Text="Bangalore South"></asp:ListItem>
                <asp:ListItem Text="Bangalore East"></asp:ListItem>
                  <asp:ListItem Text="Bangalore West"></asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"  InitialValue="Select"
                ErrorMessage="Select place" ControlToValidate="DropDownList2" ValidationGroup="v1" >*</asp:RequiredFieldValidator>
        </td>
    </tr>
    
    
    
    
    <tr><td class="bold">
        Zone Name:</td>
    <td>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><asp:RequiredFieldValidator
            ID="RequiredFieldValidator1" runat="server" 
            ErrorMessage="Zone name required" ValidationGroup="v1" ControlToValidate="TextBox3">*</asp:RequiredFieldValidator>
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
                <Columns>
                
           <asp:BoundField HeaderText="City" DataField="city" />
           <asp:BoundField HeaderText="Place" DataField="place" />
           <asp:BoundField HeaderText="Zone" DataField="zone" />
                    <asp:TemplateField >
                        <ItemTemplate>
                        <a href=zone.aspx?id=<%#Eval("id")%> > Edit</a>
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


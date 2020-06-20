<%@ Page Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="offer.aspx.cs" Inherits="admin_offer"  %>

<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div align="center">
<h2>Manage Special Offers</h2>
<table>


<tr>
    <td>
  <b>  Subject:</b>
    </td>
    <td>
        <asp:TextBox ID="TextBox1" runat="server" ValidationGroup="v1"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ErrorMessage="Subject required" ValidationGroup="v1" 
            ControlToValidate="TextBox1">*</asp:RequiredFieldValidator>
    </td>
</tr>
<tr>
    <td>
      <b>  Description:</b>
    </td>
    <td>
      <FCKeditorV2:FCKeditor ID="FCKeditor1" runat="server" Height="400px"  BasePath="~/fckeditor/" 
                                Width="800px">
                            </FCKeditorV2:FCKeditor>
    </td>
</tr>
<tr>
    <td>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
            ShowMessageBox="True" ShowSummary="False" ValidationGroup="v1" />
    
    </td>
    <td>
        <asp:Button ID="Button1" runat="server" Text="Add Offer"  ValidationGroup="v1"
            onclick="Button1_Click" class="submit" />
        <asp:Button ID="Button2" runat="server" Text="Update Offer" ValidationGroup="v1" 
            onclick="Button2_Click" class="submit" />
    </td>
</tr>
    </table>

<br /><br /><br />
<table>
    <tr>
        <td>
            <asp:GridView ID="GridView1" runat="server" DataKeyNames="id" 
                AutoGenerateColumns="False" AllowPaging="True" CellPadding="6" CellSpacing="4" 
                onpageindexchanging="GridView1_PageIndexChanging" 
                onrowdeleting="GridView1_RowDeleting">
                <RowStyle VerticalAlign="Top" />
            <Columns>
            <asp:BoundField HeaderText="Subject" DataField="subject" />
            <asp:TemplateField HeaderText="Contents">
            <ItemTemplate>
                <asp:Label ID="Label2" runat="server" Text=<%#Server.HtmlDecode(Eval("description").ToString()) %>></asp:Label>
            </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField >
            <ItemTemplate>
            <a href=offer.aspx?id=<%#Eval("id")%> >
                <asp:Label ID="Label3" runat="server" Text="Edit"></asp:Label>
            </a>
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
            <asp:Label ID="Label1" runat="server" Text="No special offer has been added till now"></asp:Label>
        </td>
    </tr>
</table>

</div>
</asp:Content>


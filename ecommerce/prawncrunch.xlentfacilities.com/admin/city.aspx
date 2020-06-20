<%@ Page Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="city.aspx.cs" Inherits="admin_city" Title="Untitled Page" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<div align="center">
<table>
    <tr>
        <td>
            Enter City:
        </td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server" ValidationGroup="v1"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ErrorMessage="City name required" ControlToValidate="TextBox1" 
                ValidationGroup="v1">*</asp:RequiredFieldValidator>
        </td>
    </tr>
   
    <tr>
        <td>
            
        </td>
        <td>
            <asp:Button ID="Button1" runat="server" Text="Add City" onclick="Button1_Click" 
                ValidationGroup="v1" />
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
                onrowdeleting="GridView1_RowDeleting">
                <Columns>
                    <asp:BoundField HeaderText="City" DataField="cityname" />
                    <asp:CommandField ShowDeleteButton="True" />
                </Columns>
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


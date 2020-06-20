<%@ Page Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="dollarvalue.aspx.cs" Inherits="admin_dollarvalue"  %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<div align="center">
                <h2>Dollar Value</h2>
               
                   <table>
                <tr>
                        <td>
                       <b> Dollar Value:</b>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBox1" runat="server" ValidationGroup="v1"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Dollar value required" Text="*" ControlToValidate="TextBox1" ValidationGroup="v1"></asp:RequiredFieldValidator>
                            <asp:CompareValidator ID="CompareValidator1" runat="server" 
                                ErrorMessage="Invalid dollar value" ValidationGroup="v1" Type="Double" 
                                Operator="DataTypeCheck" ControlToValidate="TextBox1"></asp:CompareValidator>
                        </td>
                    </tr>
                    <tr>
                    <td>
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="v1" ShowMessageBox="True" ShowSummary="False" />
                    </td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Add" onclick="Button1_Click" ValidationGroup="v1" class="submit"/>
                        <asp:Button ID="Button2" runat="server" Text="Update" onclick="Button2_Click" ValidationGroup="v1" class="submit"/>
                    </td>
                    </tr>
                </table>
                <br /><br />
                <table>
                <tr>
                    <td>
                    <b>Dollar Value:</b>
                    </td>
                    <td>
                        <asp:Label ID="Label1" runat="server" ></asp:Label>
                    </td>
                    
                </tr>
                </table>
                
                </div>
     
</asp:Content>


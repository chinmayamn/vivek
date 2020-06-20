<%@ Page Language="C#" MasterPageFile="~/user.master" AutoEventWireup="true" CodeFile="forgot-password.aspx.cs" Inherits="forgot_password"  %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="full mid-bg">
    	<div id="cont-mid">
        	<div id="content">
            
            
                       <%-- <table>
                        <tr>
                            <td>
                           <b> Username:</b>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox1" runat="server" ValidationGroup="v1"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                    ErrorMessage="Username required" ControlToValidate="TextBox1" 
                                    ValidationGroup="v1">*</asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                        <td>
                            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="v1" ShowMessageBox="True" ShowSummary="False" />
                        </td>
                        <td>
                            <asp:Button ID="Button1" runat="server" Text="Retrieve Password" 
                               ValidationGroup="v1" onclick="Button1_Click" />
                        </td>
                        </tr>
                     
                        
                        </table>--%>
                        <div style="margin:0px auto; width:352px;">
                        	<div style="float:left; margin:50px 0; width:320px; border:#333 solid 1px; background:#017cc2; -moz-border-radius:5px; border-radius:5px; padding:15px;">
                				<h1 style="color:#fff; font:bold 14px Arial, Helvetica, sans-serif; border-bottom:#fff solid 1px; padding:0 0 5px 0;">
                                    Forgot Password</h1>
                        <table>
                        <tr>
                            <td>
                            Username: 
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox1" runat="server" ValidationGroup="v1"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                    ErrorMessage="Username required" ControlToValidate="TextBox1" 
                                    ValidationGroup="v1" Text="*">*</asp:RequiredFieldValidator>
                            </td>
                        </tr>
                            <tr>
                            <td></td>
                                <td>
                             <asp:ValidationSummary ID="ValidationSummary1" ShowMessageBox="true" 
                    ValidationGroup="v1" ShowSummary="False" runat="server" />
                    
                     <asp:Button ID="Button1" runat="server" Text="Send Password" onclick="Button1_Click" class="submit1"
                    ValidationGroup="v1" />
                    
                                </td>
                            </tr>
                        </table>
                   </div>
             	</div>
            
            </div>
        </div>
    </div>
</asp:Content>


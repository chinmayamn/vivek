<%@ Page Language="C#" MasterPageFile="~/user.master" AutoEventWireup="true" CodeFile="contactus.aspx.cs" Inherits="contactus" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<div class="full mid-bg">
    <div id="cont-mid">
        <div id="content">
        	<h2>Contact us</h2>
            <div id="feedback">
                	<h2>Feed Back</h2>
                    <table cellpadding="0" cellspacing="0" border="0">
                    	<tr>
                        	<td width="100">Name</td>
                            <td width="5">:</td>
                            <td width="180">
                            
                          
                            
                                <asp:TextBox ID="TextBox1" runat="server" class="feed" ValidationGroup="v1"></asp:TextBox>
                           
                               <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Name required" ControlToValidate="TextBox1" Text="*" ValidationGroup="v1" ForeColor="White"></asp:RequiredFieldValidator>
                         
                               </td>
                        </tr>
                    	<tr>
                        	<td>Mobile / Phone</td>
                            <td>:</td>
                            <td>
                            
                            <asp:TextBox ID="TextBox2" runat="server" class="feed" ValidationGroup="v1"></asp:TextBox>
                              
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Mobile number required" ValidationGroup="v1" ForeColor="White" Text="*" ControlToValidate="TextBox2"></asp:RequiredFieldValidator>
                            
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Invalid mobile number" ValidationGroup="v1" ValidationExpression="\d{10}" ForeColor="White" Text="*" ControlToValidate="TextBox2"></asp:RegularExpressionValidator>
              
                            
                            </td>
                        </tr>
                    	<tr>
                        	<td>E-mail</td>
                            <td>:</td>
                            <td>
                            
                             <asp:TextBox ID="TextBox3" runat="server" class="feed" ValidationGroup="v1"></asp:TextBox>
                              <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Email required" ForeColor="White" Text="*" ControlToValidate="TextBox3" ValidationGroup="v1"></asp:RequiredFieldValidator>
                            
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Invalid email id" ForeColor="White" Text="*" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="v1" ControlToValidate="TextBox3"></asp:RegularExpressionValidator>
                           
                            
                            </td>
                        </tr>
                    	<tr>
                        	<td>Address</td>
                            <td>:</td>
                            <td>
                            <asp:TextBox ID="TextBox4" runat="server" class="feed" ValidationGroup="v1"></asp:TextBox>
                            
                               <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Address required" ValidationGroup="v1" Text="*" ForeColor="White" ControlToValidate="TextBox4"></asp:RequiredFieldValidator>
                      
                            </td>
                        </tr>
                    	<tr>
                        	<td>Comments</td>
                            <td>:</td>
                            <td>
                            
                            
                              <asp:TextBox ID="TextBox5" runat="server" class="feed" ValidationGroup="v1"></asp:TextBox>
                            
                            
                            </td>
                        </tr>
                        <tr>
                        	<td colspan="2"></td>
                            <td>
                                <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                                    ShowMessageBox="True" ShowSummary="False" ValidationGroup="v1" />
                           
                                <asp:Button ID="Button1" runat="server" Text="Submit" onclick="Button1_Click" class="submit" ValidationGroup="v1" />
                            
                             <input type="reset" value="Reset" class="submit" /></td>
                        </tr>
                    </table>
                </div>
      		<img src="images/contact.jpg" width="256" height="192" alt="" style="margin:100px 0 20px 20px; float:right;" />
            
         <p>
             <asp:Label ID="Label1" runat="server" ></asp:Label>
         </p>
            
            
       	</div>
  	</div>
</div>
</asp:Content>


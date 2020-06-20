<%@ Page Language="C#" MasterPageFile="~/user.master" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login"  %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="full mid-bg">
    	<div id="cont-mid">
        	<div id="content">
            
            	<!-- Latest News	-->
                <div id="lat-news">
                	<h1 class="heading">Latest News</h1>
                    <ul class="news">
                    <asp:DataList ID="DataList2" runat="server">
                        <ItemTemplate>
                        
                       
                        <li>
                            <asp:Label ID="Label5" runat="server" Text=<%#Eval("sub") %>></asp:Label>
                            
                            </li> </ItemTemplate>
                        </asp:DataList>
                   
                             	</ul>
                    <a href="news.aspx" title="Read More" class="more">Read More</a>
                </div>
                <!-- End of Latest News	-->
                     <div id="right-nav">
                    <h1>
                       Login</h1>
<div align=center>


               
                <table style="background:#ececec; -moz-border-radius:6px; border-radius:6px; float:left; width:100%; border:#c3c3c3 solid 1px; margin:10px 0 0 0;" cellpadding="5">
                	<tr>
            			<td style="font-family: Arial, Helvetica, sans-serif; font-size: 12px; font-weight: normal; padding:10px;" 
                         colspan="2" valign="top">If you have already registered with Fresh Farm Prawns then sign in below. Else, <a  href="Registration.aspx" title="IF you are new to Fresh Farm Prawns , click here to register." style="font:bold 12px Arial, Helvetica, sans-serif; text-decoration:underline; color:red;">Sign up</a>
                     	</td>
  					</tr>
  					<tr>
                        <td align="left" valign="top" colspan="2">
                        	<div style="float:left; width:100%; border-top:#017cc2 solid 2px; border-bottom:#017cc2 solid 2px; background:#fff;">
                            <asp:Login ID="Login1" runat="server"  CssClass="" 
                                DestinationPageUrl="~/myprofile.aspx" ForeColor="White" 
                                Height="144px" LoginButtonImageUrl="" LoginButtonType="Image" >
                                <%----%>
                                <LayoutTemplate>
                                <table border="0" cellpadding="6" cellspacing="4">
                                	<tr>
                                    	<td >
                                        	<asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName" Font-Bold="True" ForeColor="Black">User Name :</asp:Label>
                                       </td>
                                       <td >
                                           <asp:TextBox ID="UserName" runat="server"  Width="150px"></asp:TextBox>
                                           <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" ErrorMessage="User Name is required." ToolTip="User Name is required." ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                                     	</td>
                              		</tr>
                                    <tr>
                                    	<td>
                                            <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password" Font-Bold="True" ForeColor="Black">Password :</asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="Password" runat="server" TextMode="Password" Width="150px"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password" ErrorMessage="Password is required." ToolTip="Password is required." ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                                       	</td>
                      	            </tr>
                                    <tr>
                                        <td>
                                            <asp:ImageButton ID="LoginImageButton" runat="server" AlternateText="Log In" CommandName="Login" ImageUrl="~/images/5-Login.jpg" ValidationGroup="Login1" />
                                        </td>
                                    	<td>
                                           	<asp:CheckBox ID="RememberMe" runat="server" Checked="True" Font-Bold="True" ForeColor="Black" Text="Remember me next time." />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="2" style="color:red">
                                            <asp:Literal ID="FailureText" runat="server" EnableViewState="False"></asp:Literal>
                                        </td>
		                           </tr>
        	                     </table>
                                         
                                </LayoutTemplate>
                            </asp:Login>
                            </div>
                        </td>
                    </tr>
                    <tr>
                        <td>
                           
                            
                            <asp:LinkButton ID="LinkButton1" runat="server" class="register" 
                                title="IF you are new to Fresh Farm Prawns , click here to register." 
                                style=" font-size:large;color:#007cc2" onclick="LinkButton1_Click">Not registered, 
                            Click to Sign Up</asp:LinkButton>
                            </td>
                        <td>
                            <a class="register1" href="Forgot-password.aspx"  style=" font-size:large;color:#007cc2" class="register" 
                                title="If yor have forgot your password, click here to recover the password.">
                            Forgot Password ?</a>
                        </td>
                    </tr>
  
  
</table>
<!-- login page ends -->

</div>


</div>
   </div>
        </div>
    </div>
</asp:Content>


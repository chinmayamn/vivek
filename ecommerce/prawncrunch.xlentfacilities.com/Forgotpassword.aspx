<%@ Page Title="" Language="C#" MasterPageFile="~/user.master" AutoEventWireup="true" CodeFile="Forgotpassword.aspx.cs" Inherits="Forgotpassword" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   <div class="full mid-bg">
    	<div id="cont-mid">
        	<div id="content">
            
            	<!-- Latest News	-->
                <div id="lat-news">
                	<h1 class="heading">Latest News</h1>
                    <ul class="news">
                    	<li>Raw Prawns Available, Fresh and Crunch Farm Fresh Prawns</li>
                    	<li>Raw Prawns Available, Fresh and Crunch Farm Fresh Prawns</li>
                    	<li>Raw Prawns Available, Fresh and Crunch Farm Fresh Prawns</li>
                    	<li>Raw Prawns Available, Fresh and Crunch Farm Fresh Prawns</li>
                 	</ul>
                    <a href="#" title="Read More" class="more">Read More</a>
                </div>
                <!-- End of Latest News	-->
            	
                <!-- Right Navigation	-->
                <div id="right-nav">
  <h1>
                        <asp:Label ID="Label2" runat="server"  Text="Forgot Password"></asp:Label></h1>
                        <table style=" height:300px; width:100%; border-color:Black; border-width:thin; " border="1" align="center">
                            <tr>
                                <td align="center">
                                    <asp:PasswordRecovery ID="PasswordRecovery1" runat="server" AnswerRequiredErrorMessage="Answer is not matching" MailDefinition-From="" MailDefinition-Subject="Your Password" MailDefinition-IsBodyHtml="true" >
    
    </asp:PasswordRecovery>
                                </td>
                            </tr>
                        </table>

    
                    
                </div>
                <!-- End of Right Nav	-->
            
            </div>
        </div>
    </div>
   
   
   
   
   
   
   
   
   
   
   
   
   
   
    
</asp:Content>


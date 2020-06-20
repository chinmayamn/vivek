<%@ Page Title="" Language="C#" MasterPageFile="~/user.master" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="Registration" %>



<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server" >
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
                    <h1>New Registration</h1>
<table class="registration"  >
<tr class="light">
            <td colspan="3" align="center" >
                <asp:Label ID="Msg" runat="server" Visible="false" Text="" ForeColor="Red"  Font-Bold="True"></asp:Label></td>
            
        </tr>
	<tr>
		<td width="150">User Name :</td>
        <td><asp:TextBox ID="Username" runat="server" ontextchanged="Username_TextChanged"  ValidationGroup="v1"></asp:TextBox>
          	<asp:Label ID="Label4" runat="server" ></asp:Label>
        </td>
        <td style="width: 10px">
        	<asp:RequiredFieldValidator ID="RequiredFieldValidator17" runat="server" ControlToValidate="Username" ErrorMessage="Enter Username" Text="*" ValidationGroup="v1"></asp:RequiredFieldValidator>
        </td>
 	</tr>
    <tr class="light">
    	<td></td>
        <td><asp:Button ID="Button2" runat="server" Text="Check Availability" onclick="Button2_Click" class="submit1" /></td>
        <td style="width: 10px"></td>
    </tr>
    <tr>
    	<td>Password : </td>
        <td style="width: 39px"><asp:TextBox ID="Password" runat="server" ValidationGroup="v1" TextMode="Password" ></asp:TextBox>
        </td>
        <td style="width: 10px"><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"  Text="*"  ControlToValidate="Password" ValidationGroup="v1" ErrorMessage="Enter Password"></asp:RequiredFieldValidator>   
       	</td>
 	</tr>
    <tr class="light">
      	<td>Re Enter Password : </td>
        <td><asp:TextBox ID="Repassword" runat="server" ontextchanged="Username_TextChanged" ValidationGroup="v1" TextMode="Password"></asp:TextBox></td>
        <td style="width: 10px">
                    <asp:CompareValidator ID="CompareValidator1" runat="server" 
                ErrorMessage="Passwords mismatch" ControlToCompare="Password" 
                ControlToValidate="Repassword" ValidationGroup="v1"></asp:CompareValidator>
       
                 
                  	</td>
         
	</tr>
    
    <tr>
    <td>Name : </td>
        <td><asp:TextBox ID="firstname" runat="server" ValidationGroup="v1" ></asp:TextBox></td>
        <td style="width: 10px">
        	<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server"  Text="*"  ControlToValidate="firstname" ValidationGroup="v1" ErrorMessage="Enter First Name"></asp:RequiredFieldValidator>   </td>

    
      	</tr>
  
    <tr class="light" >
    	<td>Address : </td>
        <td><asp:TextBox ID="address1" runat="server" ValidationGroup="v1"  Rows="5" Columns="19"
                TextMode="MultiLine" ></asp:TextBox></td>
        <td style="width: 10px">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server"  Text="*"  ControlToValidate="address1" ValidationGroup="v1" ErrorMessage="Enter Address"></asp:RequiredFieldValidator>
        </td>
   	</tr>
   	  <tr >
            <td>LandMark :</td>
            <td><asp:TextBox ID="phone" runat="server" ValidationGroup="v1" ></asp:TextBox></td>
            <td><asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ErrorMessage="Landmark required" ControlToValidate="phone" ValidationGroup="v1" Text="*" ></asp:RequiredFieldValidator></td>
        </tr>
   	
   	  
          <tr class="light">
            <td>City : </td>
            <td>
            
              <asp:DropDownList ID="DropDownList1" runat="server">
        <asp:ListItem Text="Select"></asp:ListItem>
        <asp:ListItem Text="Bangalore"></asp:ListItem>
        </asp:DropDownList>
            
            </td>
            <td>
                <asp:RequiredFieldValidator  ID="RequiredFieldValidator9" runat="server"  Text="*"  ControlToValidate="DropDownList1" InitialValue="Select" ValidationGroup="v1" ErrorMessage="Select City"></asp:RequiredFieldValidator>   </td>
        </tr>
        
        
        
        
        
      
        
           <tr  >
            <td>State : </td>
            <td>
               
                <asp:TextBox ID="Region" ValidationGroup="v1"  runat="server"></asp:TextBox>
              </td>
            <td>
                <asp:RequiredFieldValidator InitialValue="--Select--" ID="RequiredFieldValidator8" runat="server"  Text="*"  ControlToValidate="region" ValidationGroup="v1" ErrorMessage="Select Country"></asp:RequiredFieldValidator>   </td>
        </tr>
        
   	
     
        <tr  class="light">
            <td class="light">Email : </td>
            <td>
                <asp:TextBox ID="Email" runat="server" ValidationGroup="v1" ></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ErrorMessage="Enter Postal Code" ControlToValidate="Email" ValidationGroup="v1" Text="*" ></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                    ErrorMessage="Improper Email-Id" ControlToValidate="Email" 
                    ValidationGroup="v1" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                </td>
        </tr>
              
        <tr >
            <td>Mobile Number : </td>
            <td><asp:TextBox ID="mobile" runat="server" ></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ErrorMessage="Enter Mobile Number" ControlToValidate="mobile" ValidationGroup="v1" Text="*" ></asp:RequiredFieldValidator>
                
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                    ErrorMessage="Invalid mobile number" ControlToValidate="mobile" 
                    ValidationExpression="\d{10}" ValidationGroup="v1">*</asp:RegularExpressionValidator>
                
                </td>
        </tr>
        
      
         <tr class="light" >
       <td valign="top">Terms & Conditions</td>
             <td><textarea id="TextArea1" cols="40" rows="4">
                                    Fresh Farm Prawns Terms of Service

Welcome to Fresh Farm Prawns!

www.freshprawnsonline.com is part of the Farm Fresh Prawns (FFP) a proprietorship concern and wherever  Farm Fresh Prawns  is mentioned, it would imply (FFP). By using this site you consent and agree to terms and conditions contained in this agreement. These terms and conditions apply to the use of the website and services of www.freshprawnsonline.com.

The terms and conditions on the site can be changed at the sole discretion of the management and you are required to keep abreast of the changes in the terms and conditions from time to time. By registering or by placing order as a guest or registered user, you expressly agree that any information that you provide now or in future is accurate. Misrepresentation of information in any form can make you liable for legal prosecution.

The design and the information in this site is the exclusive property of www.freshprawnsonline.com and nothing in this agreement shall be construed as transferring or assigning any ownership rights to any other person or entity. The user may not resell, redistribute, broadcast or transfer information, software and applications in any form without prior written authorization by (FFP).

The website may be temporarily unavailable from time to time due to required maintenance, telecommunication or bandwidth or other interruptions or other disruptions. (FFP)shall not be liable to any user or member or any third party should (FFP)exercise its right to modify or discontinue any or all of the contents, information, software, products, features and services published on the website.

Under no circumstances shall (FFP)shall be held liable for any direct, indirect or any other damages arising out of or in any way connected with the use of this website or delay or inability to use the website for any contents, information, software, products, features  and services obtained through the website.

The website may contain links to and from other websites. (FFP) does not approve or reviewed these sites. The linked sites are not under control of (FFP)and (FFP)will not be held liable for any omissions or commissions on any third party websites.

All product-related pictures are provided for indicative and reference purposes only. Original product may vary from the indicative picture shown on the website and you should exercise due care to select the right product during the ordering. The products/services provided on this site are without warranties of any kind either expressed or implied and (FFP)disclaims all or any of them to the fullest extent.

www.freshprawnsonline.com should NOT be used for following purposes:

·          For any unlawful activities, threatening, abuse, harassment, obscene or any other objectionable activities

·          Copying the content for reproduction by similar business

·          For gaining unauthorized access or any information related to (FFP)and its customers

·          For breaching any law with internet and its usage

·          For any activities leading to criminal offence.

The user of the website shall indemnify, defend and hold harmless (FFP) (including its Directors, Employees or its representatives) from any and all claims arising out of: Use and access to www.freshprawnsonline.com any non-compliance to the Terms and Conditions and/or any third party actions related to users receipt and use of any authorized or unauthorized information.

The prices of the products are subject to change .The availability of the products is subject to change without any prior information by www.freshprawnsonline.com




                  </textarea>
                                        
                 </td>
          <td></td>
         </tr>
            <tr >
             <td></td>
             <td>
                 <asp:CheckBox ID="CheckBox2" runat="server" Text="I accept terms and conditions" 
                    CssClass="search-field1" Font-Bold="true" /></td>
             <td style="width: 10px">&nbsp;
                 </td>
         </tr>
      
        <tr class="light">
            <td  >
              </td>
            <td >
                <asp:Button ID="Button1" runat="server" Text="Register" onclick="Button1_Click" class="submit"
                    ValidationGroup="v1" />
               <input type="reset" class="submit" />
            </td>
            <td style="width: 10px">&nbsp;
                </td>
        </tr>
        
        <tr >
            <td >&nbsp;
                </td>
            <td >
                <asp:ValidationSummary ID="ValidationSummary1" ShowMessageBox="true" 
                    ValidationGroup="v1" ShowSummary="False" runat="server" />
            </td>
            <td style="width: 10px">&nbsp;
                </td>
        </tr>
    </table>
        <!-- login page ends -->

</div>


</div>
   </div>
        </div>
   
</asp:Content>





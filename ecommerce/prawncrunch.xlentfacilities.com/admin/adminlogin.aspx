<%@ Page Language="C#" AutoEventWireup="true" CodeFile="adminlogin.aspx.cs" Inherits="admin_adminlogin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head><meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>FARM FRESH PRAWNS</title>
  
<link href="../css/style.css" rel="stylesheet" type="text/css" />
<link href="../images/logo.ico" rel="shortcut icon" />
<!-- Banner Script	-->
<link rel="stylesheet" href="../slides/nivo-slider.css" type="text/css" media="screen" />
    <link rel="stylesheet" href="../slides/style.css" type="text/css" media="screen" /><script type="text/javascript" src="slides/jquery-1.4.3.min.js"></script>
    <script type="text/javascript" src="../slides/jquery.nivo.slider.pack.js"></script>
    <script type="text/javascript">
    $(window).load(function() {
        $('#slider').nivoSlider();
    });
    </script>
<!-- End of Banner	Script	-->
</head>

<body>
    <form id="form1" runat="server">
    <div id="wrapper">

	<!-- Logo Navigation	-->
    <div class="full">
        <div id="logo-cen">
            <div id="logo-nav">
            	<a href="#" title="FARM FRESH PRAWNS"><img src="../images/logo.jpg" width="897" height="160" alt="FARM FRESH PRAWNS" /></a>
            </div>
        </div>
    </div>
      <!-- Menus -->
    <div class="full menu-bg">
    	<div id="menu-cen">
        	<div id="menus">
            	<ul>
           
                </ul>
            </div>
        </div>
    </div>
    <!-- End of Menus	-->
    <!-- End of Logo Navigation	-->
    
    <div class="full mid-bg">
    	<div id="cont-mid">
        	<div id="content">
            <div align="center"  style="height:320px">
                              <table  cellpadding="6" cellspacing="3" style=" margin-top:50px; margin-bottom:50px;">
                    	<tr>
                    	<td>
                    	 <asp:Label ID="Label1" runat="server" Text="Username:" ForeColor="Brown" Font-Bold="true"></asp:Label>
                            
                    	</td>
                    	<td>
                            <asp:TextBox ID="TextBox1" runat="server" ValidationGroup="v1"></asp:TextBox>
                       
                    	</td>
                    	<td> <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ErrorMessage="Username required" ControlToValidate="TextBox1" 
                        ValidationGroup="v1">*</asp:RequiredFieldValidator>
                         </td>
                    	</tr>
                    	<tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Password:" ForeColor="Brown" Font-Bold="true"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"  ValidationGroup="v1" 
                    TextMode="Password"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ErrorMessage="Password required" ControlToValidate="TextBox2" 
                    ValidationGroup="v1">*</asp:RequiredFieldValidator>
            </td>
            </tr>
            <tr>
            <td>
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="v1" ShowMessageBox="True" ShowSummary="False" />
            </td>
            <td >
                <asp:Button ID="Button1" runat="server" Text="Login" ValidationGroup="v1" 
                    onclick="Button1_Click" class="submit" />
            </td>
            <td>
            </td>
            </tr>

                    	</table>
                </div>
          </div>
        </div>
    </div>
    
    
    <div class="full foot-bg">
    	<div id="footer">
        	<div id="foot">
            	<%--<ul>
                	<li><a href="index.aspx" title="Home">Home</a></li>
                    <li><a href="#" title="Why Farm Fresh Prawn">Why Farm Fresh Prawn</a></li>
                    <li><a href="#" title="Cooking the Perfect Prawn">Cooking the Perfect Prawn</a></li>
                    <li><a href="#" title="Why Fresh Crunch">Why Fresh Crunch</a></li>
                    <li><a href="#" title="About us">About us</a></li>
                    <li><a href="#" title="Contact us">Contact us</a></li>
                </ul>
                --%>
                <p class="copy">&copy; Copy Rights Reserved By  FarmFreshPrawns.com</p>
                <p class="powered">Powered by <a href="http://www.xlentfacilities.com" target="_blank">Xlent Facilities</a></p>
            </div>
        </div>
    </div>
    <!-- End of Footer	-->

</div>
</form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Merchant.aspx.cs" Inherits="Merchant" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>FARM FRESH PRAWNS</title>
<link href="css/style.css" rel="stylesheet" type="text/css" />
<link href="images/logo.ico" rel="shortcut icon" />
<!-- Banner Script	-->
<link rel="stylesheet" href="slides/nivo-slider.css" type="text/css" media="screen" />
    <link rel="stylesheet" href="slides/style.css" type="text/css" media="screen" /><script type="text/javascript" src="slides/jquery-1.4.3.min.js"></script>
    <script type="text/javascript" src="slides/jquery.nivo.slider.pack.js"></script>
    <script type="text/javascript">
    $(window).load(function() {
        $('#slider').nivoSlider();
    });
    </script>
<!-- End of Banner	Script	-->
<script type="text/javascript" src="js/scrolling.js"></script>

</head>

<body>

<div id="topbar" runat="server">
    <asp:Repeater ID="Repeater1" runat="server">
 <ItemTemplate>
 

    <span class="close" onclick="document.getElementById('topbar').style.display='none';"></span>
    <img src=<%#Eval("pimage")%> id="i1" runat="server" alt="" />
    <h1>Discounts Upto<br />
        <a href=product-details.aspx?id=<%#Eval("id2") %>&s=1>Click Here</a>
    </h1>
    <h2><%#Eval("discount")%>%</h2>
    <h3><%#Eval("pname")%> <br /><%#Eval("text") %></h3>  </ItemTemplate>  </asp:Repeater>
</div>
<div id="wrapper">

	<!-- Logo Navigation	-->
    <div class="full">
        <div id="logo-cen">
            <div id="logo-nav">
            	<a href="index.aspx" title="FARM FRESH PRAWNS"><img src="images/logo.jpg" width="897" height="160" alt="FARM FRESH PRAWNS" /></a>
            </div>
        </div>
    </div>
    <!-- End of Logo Navigation	-->
    
    <!-- Menus -->
    <div class="full menu-bg">
    	<div id="menu-cen">
        	<div id="menus">
            	<ul>
            	
     
                              
                              
            	
              <li><a href="index.aspx" title="Home" class="current">Home</a></li>
                    <li><a href="freshprawn.aspx" title="Why Farm Fresh Prawn">Why Farm Fresh Prawn</a></li>
                    <li><a href="cookingprawn.aspx" title="How to buy online">How to buy online</a></li>
                <%--    <li><a href="freshcrunch.aspx" title="Quality Policy">Quality Policy</a></li>
                  <li><a href="privacy-policy.aspx" title="Privacy Policy">Privacy Policy</a></li>
              --%>      <li><a href="aboutus.aspx" title="About us">About us</a></li>
                    <li><a href="contactus.aspx" title="Contact us">Contact us</a></li>
                       
                </ul>
            </div>
        </div>
    </div>
    <!-- End of Menus	-->
          <div class="full" style="background:#dadcda;">
   	<div id="menu-cen1">
        	
    </div>
    </div>
    <!-- Banner -->
    <div class="full ban-bg">
    	<div id="ban-cen">
        	<div id="bans">
            
            	<!-- Special Offers	-->
                <div id="spe">
                	<h1 class="heading">Special Offers</h1>
                    <ul class="spe-list">
                    	
                    		 <asp:Repeater ID="DataList3" runat="server">
                        <ItemTemplate>
                        
                       
                        <li>
                         <a href="specialoffer.aspx">
                            <asp:Label ID="Label5" runat="server" Text=<%#Eval("subject") %>></asp:Label>
                            </a>
                            </li> </ItemTemplate>
                        </asp:Repeater>
                    	
                    	
                    	
                    </ul>	
                    <a href="specialoffer.aspx" title="Read More" class="more">Read More</a>
                </div>
                <!-- End of Special Offers	-->
            
            	<!-- Banner Slides	-->
                <div id="banner">
                    <div id="slider" class="nivoSlider">
                  
                        <img src="images/ban3.jpg" width="742" height="245" alt="" />  
                           <img src="images/ban1.jpg" width="742" height="245" alt="" />  
                        <img src="images/ban2.jpg" width="742" height="245" alt="" /> 
                        
                        <img src="images/ban5.jpg" width="742" height="245" alt="" />            
            		</div>
                </div>
                <!-- End of Banner Slides	-->
            
            </div>
        </div>
    </div>
    <!-- End of Banner	-->


<div class="full mid-bg">
    	<div id="cont-mid">
        	<div id="content">
            
            <div class="main-left">
            	<!-- Latest News	-->
                <div id="lat-news">
                	<h1 class="heading">Latest News</h1>
                    <ul class="news">
                    	 <asp:Repeater ID="DataList2" runat="server">
                        <ItemTemplate>
                        
                       
                        <li>
                        <a href="news.aspx">
                      
                            <asp:Label ID="Label5" runat="server" Text=<%#Eval("sub") %>></asp:Label>
                              </a>
                            </li> </ItemTemplate>
                        </asp:Repeater>
                    	
                    	
                    	       	</ul>
                    <a href="news.aspx" title="Read More" class="more">Read More</a>
                </div>
                <!-- End of Latest News	-->
                
                <div id="lat-news">
                	<h1 class="heading">Discounts</h1>
					<ul class="spe-list">
                    	<li>0-5 days no discount</li>
						<li>6-10 days 5%</li>
						<li>11-20 days 7%</li>
						<li>21-30 days 10%</li>
						<li>above 31 days 10%</li>
                    </ul>
                </div>
                
                <img src="images/guarantee.gif" width="100%" alt=""  />
                
                </div>
            	
                <!-- Right Navigation	-->
                <div id="right-nav">
                	<h3 >Redirecting to Payment Gateway</h3>
                	
                	<div align="center"  style="min-height:200px;vertical-align:middle;">
                	
                	
                     <form id="form2" runat="server" name="ecom" method="post" 

action="https://www.timesofmoney.com/direcpay/secure/dpMerchantPayment.jsp">

<table height="200">
<tr>
    <td>
    Security Codes
    </td>
</tr>
<tr>
<td>


    <asp:TextBox ID="requestparameter" runat="server"  ReadOnly=true></asp:TextBox>
    <asp:TextBox ID="billingDtls" runat="server" ReadOnly=true> </asp:TextBox>
    <asp:TextBox ID="shippingDtls" runat="server" ReadOnly=true></asp:TextBox>
    <input type="hidden" name="merchantId" value ="201207201000001"/> 
    </td>
</tr>
<tr>
<td>
 <input type="submit" name="submit" value="Redirect Me to Payment Gateway" class="submit2" >
   
</td>
</tr>
</table>
    </form>
                    
                    </div>
                </div>
                <!-- End of Right Nav	-->
            
            </div>
        </div>
    </div>

 <!-- Footer	-->
    <div class="full foot-bg">
    	<div id="footer">
        	<div id="foot">
            	<ul>
                  	<li><a href="index.aspx" title="Home">Home</a></li>
                    <li><a href="freshprawn.aspx" title="Why Farm Fresh Prawn">Why Farm Fresh Prawn</a></li>
                    <li><a href="cookingprawn.aspx" title="How to buy online">How to buy online</a></li>
                    <li><a href="freshcrunch.aspx" title="Why Fresh Crunch">Why Fresh Crunch</a></li>
                    <li><a href="aboutus.aspx" title="About us">About us</a></li>
                    <li><a href="contactus.aspx" title="Contact us">Contact us</a></li>
                        <li><a href="privacy-policy.aspx" title="Privacy Policy">Privacy Policy</a></li>
                      <li><a href="return-policy.aspx" title="Return Policy">Return Policy</a></li>
                       <li><a href="terms-conditions.aspx" title="Terms & Conditions">Terms & Conditions</a></li>
              
                </ul>
                
               <p class="copy">
                
                  &copy; Copy Rights Reserved By FarmFreshPrawns.com
<div id="fb-root" style="float:left" ></div>
<script>(function(d, s, id) {
  var js, fjs = d.getElementsByTagName(s)[0];
  if (d.getElementById(id)) return;
  js = d.createElement(s); js.id = id;
  js.src = "//connect.facebook.net/en_US/all.js#xfbml=1";
  fjs.parentNode.insertBefore(js, fjs);
}(document, 'script', 'facebook-jssdk'));</script>





<div class="fb-like" style="float:left" data-href="http://www.facebook.com/FreshPrawnsOnline" data-send="true" data-width="50" data-show-faces="true"></div>

                
                
              </p>
                
                <p class="powered">Powered by <a href="http://www.xlentfacilities.com" target="_blank">Xlent Facilities</a></p>
            </div>
        </div>
    </div>
    <!-- End of Footer	-->

</div>

</body>
</html>



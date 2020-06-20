<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>East West Cabs</title>
<link href="css/style.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="js/slideit.js"></script>
<script src="Scripts/AC_RunActiveContent.js" type="text/javascript"></script>

<script type="text/javascript" src="js/jquery.js"></script>

<script type="text/javascript" src="js/js.js"></script>
<!--[if lt IE 7]>
<script language="JavaScript" src="js/png.js"></script>
<link href="css/ie.css" rel="stylesheet" type="text/css" />
<![endif]-->
<script type="text/javascript">
function val()
{
var x=document.forms["submit"]["name"].value;

if (x==null || x=="" || x=="Name")
  {
  
  alert("Name required");
  return false;
  }
 
 
    var z=document.forms["submit"]["email"].value;
if (z==null || z==""||z=="Email")
  {
  alert("Email-Id required");
  return false;
  }
var ck_email = /^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$/;
  var email = document.forms["submit"]["email"].value;
   if (!ck_email.test(email)) {
  alert("You must enter a valid email address");
return false;
 }
 
 
  var y=document.forms["submit"]["mobile"].value;
if (y==null || y=="")
  {
  alert("Mobile number required");
  return false;
  }
  
  var mobile=document.forms["submit"]["mobile"].value;
 
  if(isNumber(mobile)!=true)
			{
				alert("Please enter valid mobile number");
				
				return false;
			}	
 
 if(mobile.length<10)
 {
 alert("Please enter valid mobile number");
 return false;
 }
 
 
 
  var b= document.forms["submit"]["company"].value;
  if(b==null||b==""||b=="Company")
  {
   alert("Company name required");
  return false;
  }
   var c= document.forms["submit"]["Comments"].value;
  if(c==null||c==""||c=="Comments")
  {
   alert("Comments required");
  return false;
  }
 
 
 
 
 
 
   }
  
  
function isNumber(data)
{
	var numStr="1234567890-_";
	var thisChar;
	var counter=0;
	for(var i=0; i < data.length; i++)
		{
			thisChar=data.substring(i,i+1);
			if(numStr.indexOf(thisChar)!=-1)
			{counter++;}
		}
		if(counter==data.length)
		{return true;}
		else
		return false;
 }		
 
</script>
</head>

<body>
<div id="wrapper">
	<div id="container">
    	<!-- Quick Enquiry	-->
		
    	<div id="topbar">
            <div class="quick-main">
            	<h1>Corporate requirement form</h1>
                <div class="num">
                	94486 00000<br />
					94488 20000
                </div>
                <a href="contactus.html" class="cont more">More Contacts</a>
            	<h2 style="margin-bottom:10px;">Subsidized rates for cars on monthly contract. Please fill up the below form and we will initiate a call-back</h2>
                <form name="submit" action="" method="post" onSubmit="return val();">
                <div class="fill"><input type="text" name="name" value="Name" onblur="if(this.value=='') this.value='Name';" onfocus="if(this.value=='Name') this.value='';" class="fill-in" /></div>
                <div class="fill"><input type="text" name="email" value="Email" onblur="if(this.value=='') this.value='Email';" onfocus="if(this.value=='Email') this.value='';" class="fill-in" /></div>
                <div class="fill"><input type="text" name="mobile" value="Mobile" onblur="if(this.value=='') this.value='Mobile';" onfocus="if(this.value=='Mobile') this.value='';" class="fill-in" /></div>
                <div class="fill"><input type="text" name="company" value="Company" onblur="if(this.value=='') this.value='Company';" onfocus="if(this.value=='Company') this.value='';" class="fill-in" /></div>
                <div class="fill"><textarea name="Comments" onblur="if(this.value=='') this.value='Comments';" onfocus="if(this.value=='Comments') this.value='';" class="fill-in" rows="3" cols="15">Comments</textarea></div>
                
                <div class="fill">
                	<input type="submit" value="Submit" class="btn" />
                	<input type="reset" value="Reset" class="btn" />
                </div>
			   </form>
                
            </div>
        </div>
        <!-- ENd of Quick Enquiry	-->
    
    	<!-- Logo and Menus	-->
        <div id="logo-menus">
        	<div class="logo">
       		  <script type="text/javascript">
AC_FL_RunContent( 'codebase','http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=9,0,28,0','width','217','height','99','src','images/logo','quality','high','pluginspage','http://www.adobe.com/shockwave/download/download.cgi?P1_Prod_Version=ShockwaveFlash','movie','images/logo','wmode','transparent' ); //end AC code
</script><noscript><object classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000" codebase="http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=9,0,28,0" width="217" height="99">
                  <param name="movie" value="images/logo.swf" />
                  <param name="quality" value="high" />
                  <param name="wmode" value="transparent" />
       		  </object></noscript>
            </div>
            
<ul class="menus">
            	<li><a href="index.html" class="cont">Home</a></li>
                <li><a href="services.html" class="cont">Services</a></li>
                <li><a href="clients.html" class="cont">Clients</a></li>
                <li><a href="contactus.html" class="cont">Contact us </a></li>
            </ul>
        </div>
    <!-- End of Logo and Menus	-->
        <div id="banner">
           	  <script type="text/javascript">
AC_FL_RunContent( 'codebase','http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=9,0,28,0','width','710','height','275','src','images/banner','quality','high','pluginspage','http://www.adobe.com/shockwave/download/download.cgi?P1_Prod_Version=ShockwaveFlash','movie','images/banner','wmode','transparent' ); //end AC code
</script><noscript><object classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000" codebase="http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=9,0,28,0" width="710" height="275">
                  <param name="movie" value="images/banner.swf" />
                  <param name="quality" value="high" />
                  <param name="wmode" value="transparent" />
                  
          	  </object></noscript>
              <img src="images/shadow.png" width="725" alt="" style="margin:10px 0 0 0;" />
        </div>
        
        <div id="content">
        	
            <h2>Welcome to East West Cabs</h2>
            
            <img src="images/car.png" width="161" height="94" alt="" style="float:right; margin:0 0 10px 10px;" />
            
            <p>East West Cab services was established during the year 1983, and has since become one of Bangalore's leading provider of road transport. We have a large fleet of cars at our service, to facilitate road transport based on individual or organisational requirements.</p>

			<p>In 1999, East West Cab Services initiated the 'City Taxi' service, the first of its kind in the city. Ever since, East West Cab Services has served many Private and Government organisations meeting their road transport requirement.</p>
            
            <p>East West Cab Services continues to be one of the leading providers of road transport in Bangalore City, with a long list of Private and Government organisations as our loyal clients.</p>
            
            <div class="sub">
            	<div class="sub1">
                	<h3>Our Aims</h3>
                    <p>To establish ourselves as the undisputed leaders of road transport within the city and live up to our legacy to continue serving the citizens of Bangalore as the leading service provider of road transport. We intend on providing our customers with a safe, hastle free and prompt method of road transport 24/7.</p>
                </div>
            	<div class="sub1 ri">
                	<h3>What We Do ?</h3>
                    <p>East West Cab services specialises in road transport services. Pioneers in the field of road transport for over 25 years in Bangalore city serving individuals, private and government organisations alike.</p>

					<p>East West Cab Services has a fleet of cars to cater to every individual and organisational requirements..</p>
                </div>
            </div>
            
        </div>
    

    	<!-- Footer	-->
        <div id="footer">
        	<p class="copy">Copyrights &copy; reserved</p>
            <p class="power">Powered by <a href="http://www.xlentfacilities.com" target="_blank">Xlent Facilities</a></p>
        <div class="clear"></div>
        <div class="clear"></div>
        <div class="clear"></div>
        </div>
        <!-- ENd of Footer	-->
        
    </div>
</div>	
</body>
</html>
<?php

if(isset($_POST['name']))
{
@$name = $_POST['name'] ;
}


if(isset($_POST['mobile']))
{
@$mobile = $_POST['mobile'] ;
}


if(isset($_POST['email']))
{
@$email = $_POST['email'] ;
$emails = $_POST['email'] ;
}


if(isset($_POST['company']))
{
@$company = $_POST['company'] ;
}


if(isset($_POST['query']))
{
@$comments = $_POST['comments'] ;
}

	$message ="";
	$message.="Name:: ";
	$message.=@$name;
	$message.="\r\n";
	$message.="\r\n";
	$message.="Email:: ";
	$message.=@$email;
	$message.="\r\n";
	$message.="\r\n";
	$message.="Mobile:: ";
	$message.=@$mobile;
	$message.="\r\n";
	$message.="\r\n";
	$message.="company:: ";
	$message.=@$company;
	$message.="\r\n";
	$message.="\r\n";
	$message.="Comments:: ";
	$message.=@$comments;
	$message.="\r\n";
	$message.="\r\n";

	
	 $headers = $email . "\r\n" .
     'Reply-To: chinmayamn@gmail.com' . "\r\n" .
   'X-Mailer: PHP/' ."\r\n".'X-Priority:$priority'. phpversion();

		

if(isset($_POST) && !empty($_POST))
{
	if(mail("chinmayamn@gmail.com","Enquiry from East West Cabs", $message, $headers))
	
	{
	   print "<html><body><script type=text/javascript>alert('Enquiry has been sent successfully');</script></body></html>";
 
	  }
	 }
	 


?>
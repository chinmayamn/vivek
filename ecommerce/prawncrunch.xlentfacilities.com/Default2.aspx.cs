using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using com.toml.dp.util;
using System.Text;
using System.IO;
public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
   string temp = "200904281000001|DOM|IND|INR|1024|1025120|None| http://www.freshprawnsonline.com/thankyou.aspx | http://www.freshprawnsonline.com/failure.aspx |TOML";
        string temp1 = "chinmaya|ganganagar|bangalore|karnataka|560001|IN|91|080|1233456|9741447221|chinmayamn@gmail.com|test transaction for direcpay";
        string temp2 = "chinmaya|malleshwaram|bangalore|karnataka|560001|IN|91|080|1233456|9741447221";
    string key="qcAHa6tt8s0l5NN7UWPVAQ==";
 
        //  string key = "mFLZSVqv3ZORJOMiX1FL5Q==";
        
        
        
     //  string temp = "200702091000001|TOML|IND|INR|1024|1025120|None| http://www.freshprawnsonline.com/index.aspx | http://www.freshprawnsonline.com |TOML|1025|chinmayabank|DD";
       
      

        
        temp = AES128Bit.Encrypt(temp, key,128);
        temp1 = AES128Bit.Encrypt(temp1, key,128);
        temp2 = AES128Bit.Encrypt(temp2, key,128);
       
        temp = temp.Replace("\n", "");
        temp1 = temp1.Replace("\n", "");
        temp2 = temp2.Replace("\n", "");

        requestparameter.Text = temp;
        billingDtls.Text=temp1;
        shippingDtls.Text=temp2;



    }
}

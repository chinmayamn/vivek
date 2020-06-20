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
using SBMartCartItem;
using prawncrunchShopping;
public partial class Merchant : System.Web.UI.Page
{
    admin ad = new admin();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {


            filloffers();
            filllatest();
            filldiscount();

            Order or = new Order();
            MembershipUser memb = Membership.GetUser(Profile.UserName);
            string userid = "";
            try
            {
                userid = memb.ProviderUserKey.ToString();
                DataTable dt = or.select_order_userid(userid);
                string orderid = dt.Rows[0][0].ToString();
               
            
             
                double amount = Profile.prawncrunchShopping.Total;


                DataSet ds = or.select_order(userid);

                string name = ds.Tables[0].Rows[0]["firstname"].ToString() ;
                string address = ds.Tables[0].Rows[0]["address"].ToString();
                string city = ds.Tables[0].Rows[0]["city"].ToString();
                string state = ds.Tables[0].Rows[0]["state"].ToString();
             
                string email = ds.Tables[0].Rows[0]["email"].ToString();
                string mobile = ds.Tables[0].Rows[0]["mobile"].ToString();

                string ship_name = ds.Tables[0].Rows[0]["delivery_firstname"].ToString();
                string ship_address = ds.Tables[0].Rows[0]["delivery_address"].ToString();
                string ship_city = ds.Tables[0].Rows[0]["delivery_city"].ToString();
                string ship_state = ds.Tables[0].Rows[0]["delivery_state"].ToString();
          
                string ship_email = ds.Tables[0].Rows[0]["delivery_email"].ToString();
                string ship_mobile = ds.Tables[0].Rows[0]["delivery_mobile"].ToString();



                string temp = "201207201000001|DOM|IND|INR|" + amount + "|" + orderid + "|None| http://www.freshprawnsonline.com/thankyou.aspx | http://www.freshprawnsonline.com/failure.aspx |DirecPay";
     //billing
               // string temp1 = "chinmaya|ganganagar|bangalore|karnataka|560001|IN|91|080|1233456|9741447221|chinmayamn@gmail.com|test transaction for direcpay";
                
                string temp1=name+ "|" + address+ "|"+  city+ "|" + state + "|" + "560032" + "|IN|91|080|758956|" + mobile + "|" + email + "|test transaction for direcpay" ;
                //shipping
                
               // string temp2 = "chinmaya|malleshwaram|bangalore|karnataka|560001|IN|91|080|1233456|9741447221";

                string temp2 = ship_name + "|" + ship_address + "|" + ship_city + "|" + ship_state + "|" + "560032|IN|91|080|758956|" + ship_mobile;
                string key = "DjOL6xasKPqk1ZOeSeMFFQ==";


                temp = AES128Bit.Encrypt(temp, key, 128);
                temp1 = AES128Bit.Encrypt(temp1, key, 128);
                temp2 = AES128Bit.Encrypt(temp2, key, 128);

                temp = temp.Replace("\n", "");
                temp1 = temp1.Replace("\n", "");
                temp2 = temp2.Replace("\n", "");

                requestparameter.Text = temp;
                billingDtls.Text = temp1;
                shippingDtls.Text = temp2;

            }
            catch (Exception ex)
            {
                Response.Redirect("Login.aspx");
            }


        }

    }
    public void filldiscount()
    {
        DataSet ds = ad.getdiscount();
        if (ds.Tables[0].Rows.Count == 0)
        {
            topbar.Visible = false;
        }
        else
        {
            topbar.Visible = true;
            Repeater1.DataSource = ds;
            Repeater1.DataBind();
        }
    }
    public void filloffers()
    {
        DataSet ds = ad.getoffers();
        if (ds.Tables[0].Rows.Count == 0)
        {
        }
        else
        {
            DataList3.DataSource = ds;
            DataList3.DataBind();
        }
    }
   
 
    
    public void filllatest()
    {
        DataSet ds = ad.getlatestnews();
        if (ds.Tables[0].Rows.Count == 0)
        {

        }
        else
        {
            DataList2.DataSource = ds;
            DataList2.DataBind();
        }
    }
   
}

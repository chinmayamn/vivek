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

public partial class failure : System.Web.UI.Page
{
    Order or = new Order();
    mailing em = new mailing();
    MessageBox msg = new MessageBox();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {

            string s = Request.Form["responseparams"];
            string[] param = s.Split('|');
            Label2.Text = param[0].ToString();
            Label3.Text = param[5].ToString();
            Label4.Text = param[6].ToString();





          


            MembershipUser memb = Membership.GetUser(Profile.UserName);
            string userid = "";
            try
            {
                userid = memb.ProviderUserKey.ToString();
            }
            catch (Exception ex)
            {
                Response.Redirect("Login.aspx");
            }

            DataSet ds = or.select_order(userid);
            string name = ds.Tables[0].Rows[0]["firstname"].ToString();
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


            //email to delivery address
            string msg = "Dear " + ship_name + ", An order for prawn from " + name + " account of amount Rs." + Label4.Text + " has been marked as unsuccessfull. Order id is " + Label3.Text + " and direcpay reference id " + Label2.Text;



            em.mymail(ship_email, msg, "Order Unsuccessfull");
            string msg1 = "Dear " + name + ", " + "An order made for " + ship_name + " from your farmfreshprawns account of amount  Rs." + Label4.Text + " has been marked as unsuccessfull. Order id is " + Label3.Text + " and direcpay reference id " + Label2.Text;

            //email to billing address
            em.mymail(email, msg1, "Order Unsuccessfull");

            sms sm = new sms();

            sm.SendSMS(mobile, msg1);

            string adminmobile = sms.adminsms;
            string adminemail = sms.adminemail;

            string adminmessage = "Dear Admin, New order placed from " + name + "for amount of  Rs." + Label4.Text + ". has been marked as unsuccessfull. Order id is " + Label3.Text + " and DirecPay reference id is " + Label2.Text;
            em.mymail(adminemail, adminmessage, "Order Unsuccessfull");
            sm.SendSMS(adminmobile, adminmessage);
            Profile.prawncrunchShopping.Items.Clear();

        }
    }
}

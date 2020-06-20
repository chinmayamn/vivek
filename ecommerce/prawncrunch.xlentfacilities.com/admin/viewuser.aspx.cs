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
using System.Data.SqlClient;
public partial class admin_viewuser : System.Web.UI.Page
{
    admin ad = new admin();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            string id = Request.QueryString["id"].ToString();
            MembershipUser u = Membership.GetUser(id);
           Guid a = new Guid(u.ProviderUserKey.ToString());
            Label1.Text = u.UserName.ToString();
            DataSet ds = ad.getuserpassword(a);
            if (ds.Tables[0].Rows.Count == 0)
            {
            }
            else
            {
                Label2.Text = ds.Tables[0].Rows[0]["password"].ToString();
            }
            Label5.Text = u.Email.ToString();

            ProfileCommon comm = Profile.GetProfile(Label1.Text);
            Label3.Text = comm.FirstName;
      
            Label6.Text = comm.Mobile;
            Label7.Text = comm.Phone;
            Label8.Text = comm.Address;
            Label9.Text = comm.City;
            Label10.Text = comm.State;


           


        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        sms s = new sms();
        s.SendSMS(Label6.Text, TextBox1.Text);
        MessageBox msg = new MessageBox();
        TextBox1.Text = "";
        msg.Show("SMS sent successfully");
    }
}

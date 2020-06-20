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
public partial class forgot_password : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        MessageBox msg = new MessageBox();

        admin ad = new admin();
        MembershipUser u = Membership.GetUser(TextBox1.Text);

        if (u == null)
        {
            msg.Show("Invalid username");
        }
        else
        {
        
        Guid a = new Guid(u.ProviderUserKey.ToString());
        
        
        DataSet ds = ad.getuserpassword(a);
        
            string pass = ds.Tables[0].Rows[0]["password"].ToString();
            string email= u.Email.ToString();

            ProfileCommon comm = Profile.GetProfile(TextBox1.Text);
            string username = TextBox1.Text;
            string mobile = comm.Mobile;
            string name = comm.FirstName;
            mailing mail = new mailing();
            string mess1 = "Dear " + name + ",<br><br>Your freshprawnsonline account password is:" + pass +"<br><br>Regards,<br>Admin, Farm Fresh Prawns.";
            string mess = "Dear " + name + " Your freshprawnsonline account password is:" + pass;
            mail.mymail(email, mess1, "Password Retrieval");
            sms s = new sms();
            s.SendSMS(mobile, mess);
            TextBox1.Text = "";
            msg.Show("Password has been sent to your provided email and mobile number");
        }
      
    }
}

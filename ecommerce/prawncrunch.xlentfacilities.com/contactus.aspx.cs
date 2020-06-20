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
using System.Net.Mail;
public partial class contactus : System.Web.UI.Page
{
    MessageBox msg = new MessageBox();
    admin ad = new admin();
    protected void Page_Load(object sender, EventArgs e)
    {
        System.Web.UI.HtmlControls.HtmlAnchor a;
        a = (System.Web.UI.HtmlControls.HtmlAnchor)this.Master.FindControl("l7");

        a.Attributes.Add("class", "current");

        if (!Page.IsPostBack)
        {
            filldata();
        }
    }
    public void filldata()
    {
        DataSet ds = ad.getdata("contact-us");
        if (ds.Tables[0].Rows.Count == 0)
        {
        }
        else
        {
            Label1.Text = Server.HtmlDecode( ds.Tables[0].Rows[0]["contents"].ToString());
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
string mto = "";
        string mFrom = "";
        {
            mto = "sales@freshprawnsonline.com";


            mFrom = TextBox3.Text;




            try
            {
                if (mto != "" && mFrom != "")
                {

                    MailMessage message = new MailMessage();
                    message.From = new MailAddress(mFrom);
                    message.To.Add(mto);


                    message.IsBodyHtml = true;


                    string temp = "Name: " + TextBox1.Text + " <br><br> " + "Mobile: " + TextBox2.Text + "<br> <br> " + "Email: " + TextBox3.Text + "<br><br>" + "Address:" + TextBox4.Text + "<br><br>" + "Comments:" + TextBox5.Text;
                    message.Body = temp;
                    message.Subject = "Contact from Fresh Farm Prawns";

                    SmtpClient smtp = new SmtpClient("localhost", 25);

                    smtp.Send(message);
                    message.Dispose();




                    MessageBox msg1 = new MessageBox();
                    msg1.Show("Your contact has been sent to Fresh Farm Prawns");
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    TextBox3.Text = "";
                    TextBox4.Text = "";
                    TextBox5.Text = "";

                }

                else
                {
                    MessageBox msg2 = new MessageBox();
                    msg2.Show("Send feed back again after some time");

                }



            }
            catch (Exception ex)
            {

                MessageBox msg3 = new MessageBox();
                msg3.Show(ex.ToString());

            }
        }
    }
    
}

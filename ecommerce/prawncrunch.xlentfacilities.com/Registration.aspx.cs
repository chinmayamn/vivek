using System;
using System.Collections;
using System.Configuration;
using System.Data;
//////using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Net.Mail;
using System.Threading;
public partial class Registration : System.Web.UI.Page
{
    admin ad = new admin();
    MessageBox msg = new MessageBox();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            filllatest();  Label4.Visible = false;
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
    protected void Username_TextChanged(object sender, EventArgs e)
    {

    }
  
        protected void city_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("registration.aspx");
        }
        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("registration.aspx");
        }
      
        protected void Button2_Click(object sender, EventArgs e)
        { MembershipUser mem = Membership.GetUser(Username.Text);
            if (Username.Text == "")
            {
                MessageBox msg = new MessageBox();
                msg.Show("Enter username");
            }
            else
            {

                if (mem == null)
                {
                   msg.Show("Username is available");

                }
                else
                {msg.Show("Desired username is not available");

                }
            }

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (CheckBox2.Checked == true)
            {
                try
                {
                    MembershipCreateStatus status;
                    MembershipUser newuser = Membership.CreateUser(Username.Text, Password.Text, Email.Text,"test","test", true, out status);
                    if (newuser == null)
                    {
                        Msg.Visible = true;
                        Msg.Text = GetErrorMessage(status);
                       
                    }
                    else
                    {
                        Msg.Visible = true;
                       Msg.Text = GetErrorMessage(status);
                        
                        msg.Show("Registered successfully");
                        System.Threading.Thread.Sleep(5000);

                        if (Request.QueryString["returnurl"] == null)
                        {
                            FormsAuthentication.SetAuthCookie(Username.Text, true);
                            Response.Redirect("index.aspx");
                        }
                        else
                        {
                            FormsAuthentication.SetAuthCookie(Username.Text, true);
                            Response.Redirect(Request.QueryString["returnurl"].ToString());
                        }
                  
                    }
                }
                catch
                {
                    Msg.Text = "An exception occurred creating the user";

                }
            }
            else
            {
                msg.Show("Please accept terms and conditions");
                //   ImageButton5.Attributes["click"] = "javascript:alert('Please accept terms and conditions.";
            }

        }

        public string GetErrorMessage(MembershipCreateStatus status)
        {
            switch (status)
            {
                case MembershipCreateStatus.DuplicateUserName:
                    return "Username already exists. Please enter a different user name.";

                case MembershipCreateStatus.DuplicateEmail:
                    return "A username for that e-mail address already exists. Please enter a different e-mail address.";

                case MembershipCreateStatus.InvalidPassword:
                    return "Password should be of minimum of 6 characters and should be alphanumeric";

                case MembershipCreateStatus.InvalidEmail:
                    return "The e-mail address provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.InvalidAnswer:
                    return "The password retrieval answer provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.InvalidQuestion:
                    return "The password retrieval question provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.InvalidUserName:
                    return "The user name provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.ProviderError:
                    return "The authentication provider returned an error. Please verify your entry and try again. If the problem persists, please contact your system administrator.";

                case MembershipCreateStatus.UserRejected:
                    return "The user creation request has been canceled. Please verify your entry and try again. If the problem persists, please contact your system administrator.";
                case MembershipCreateStatus.Success:
                   
                    ProfileCommon pc = (ProfileCommon)ProfileCommon.Create(Username.Text, true);
                    Roles.AddUserToRole(Username.Text, "user");
                  
                    

                    pc.FirstName = firstname.Text;
             
                    pc.Phone = phone.Text;
                    pc.Mobile = mobile.Text;
                  pc.Address = address1.Text;

                  pc.City = DropDownList1.SelectedItem.Text;
              
                
                    pc.State = Region.Text;
                  
                

                    pc.Save();
                
                  
                   
                    mailing mail = new mailing();
                    string msg1 = "Congratulations you are registered successfully with Fresh Farm Prawns" + "<br>" + "Username: " + Username.Text+ "<br>" + "Password: " + Password.Text + "<br>" + "Regards ," + "<br>" + "Admin" + ", " + "Fresh Farm Prawns";
                    mail.mymail(Email.Text, msg1, "User Registration");
                    sms s = new sms();
                    s.SendSMS(mobile.Text, "Dear " + firstname.Text + " your freshprawnsonline account has been created. Username:" + Username.Text + " Password:" + Password.Text);

                    //Username.Text = "";
                    //Password.Text = "";
                    //Repassword.Text = "";
           
                    //firstname.Text = "";
              
                    //address1.Text = "";
                    //DropDownList1.SelectedIndex = 0;
                
                 
                    //Region.Text = "";
                    //Email.Text = "";
                    //mobile.Text = "";
                    //phone.Text = "";
                    //CheckBox2.Checked = false;



                    
                   // address1.Text = city.Text = answer.Text = Region.Text = Email.Text = firstname.Text = lastname.Text = phone.Text = mobile.Text = Username.Text = "";
               
                  return "Registered Successfully";

               


                default:
                    return "An unknown error occurred. Please verify your entry and try again. If the problem persists, please contact your system administrator.";
            }
        
        }
   
}

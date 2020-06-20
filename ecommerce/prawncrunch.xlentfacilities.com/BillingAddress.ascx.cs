using System;
using System.Collections.Generic;
//////using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Data;

public partial class BillingAddress : System.Web.UI.UserControl
{
    Order obj1 = new Order();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
   
            MembershipUser memb = Membership.GetUser(Profile.UserName);
            string userid = "";
            try
            {
                userid = memb.ProviderUserKey.ToString();
                filladdress();

            }
            catch (Exception ex)
            {
                Response.Redirect("~/Login.aspx");
            }
            
               
            
        }
    }

    public void insert_order()
    {
        MembershipUser memb = Membership.GetUser(Profile.UserName);
        string userid = "";
          userid = memb.ProviderUserKey.ToString();
           
         
       DataTable i= obj1.Insertorder(
                userid,
                Profile.FirstName,
                Profile.LastName,
                Profile.Address,
                Profile.City,
             
                Profile.State,
                Profile.Country,
                Profile.Mobile,
                Profile.Phone,
                memb.Email,
            
                txtname.Text,
                "a",
                TextBox1.Text,
                txtstreetaddress.Text,
                txtcity.Text,
            
                txtstate.Text,
               "IN",
                txtmobile.Text,
                txtphone.Text,
                txtcomments.Text);
       if (Convert.ToInt32(i.Rows[0]["id"]) != 0)
       {
           Session["orderid"] = i.Rows[0]["id"].ToString();
       }
       else
       {

           Response.Redirect("Login.aspx");
       }

     
      

    }

    public void filladdress()
    {
       MembershipUser memb = Membership.GetUser(Profile.UserName);
      
        lblname.Text = Profile.FirstName;
        lbladdress.Text = Profile.Address;
     
        lblcity.Text = Profile.City;
        lblstate.Text = Profile.State;
        

        lblmobile.Text = Profile.Mobile;
        lblmail.Text = memb.Email;
        lblphone.Text = Profile.Phone;
  
    }
    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        if (chkdelivary.Checked==true)
        {
            MembershipUser memb = Membership.GetUser(Profile.UserName);
            
            txtname.Text = Profile.FirstName;
         
            txtstreetaddress.Text = Profile.Address;
          
            txtcity.Text = Profile.City;
            txtstate.Text = Profile.State;
            
            TextBox1.Text = memb.Email.ToString();
            txtmobile.Text = Profile.Mobile;
            txtphone.Text = Profile.Phone;

            txtname.ReadOnly = true;
       
            txtstreetaddress.ReadOnly = true;
            txtcity.ReadOnly = true;
            txtstate.ReadOnly = true;
        
            TextBox1.ReadOnly = true;
            txtmobile.ReadOnly = true;
            txtphone.ReadOnly = true;


        }
        else if (chkdelivary.Checked == false)
        {
            txtname.Text = "";
            txtstreetaddress.Text = "";
         
            txtcity.Text = "";
            txtstate.Text = "";
         
            txtmobile.Text = "";
            txtphone.Text = "";
          
            TextBox1.Text = "";

            txtname.ReadOnly = false;
       
            txtstreetaddress.ReadOnly = false;
            txtcity.ReadOnly = false;
            txtstate.ReadOnly = false;
         
            TextBox1.ReadOnly = false;
            txtmobile.ReadOnly = false;
            txtphone.ReadOnly = false;

        }
    }
  

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
   
    }
    protected void HiddenField1_ValueChanged(object sender, EventArgs e)
    {

       

    }


    protected void Back_Click(object sender, EventArgs e)
    {
        filladdress();
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("change_account_setting.aspx");
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("index.aspx");
    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        
        insert_order();
        Response.Redirect("PaymentDetails.aspx");
    }
}

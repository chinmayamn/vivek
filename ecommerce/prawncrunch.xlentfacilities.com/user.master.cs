using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class user : System.Web.UI.MasterPage
{



    admin ad = new admin();

    protected void Page_Load(object sender, EventArgs e)
    {

      

         if (!Page.IsPostBack)
        {

        // filldiscount();
            MembershipUser mem = Membership.GetUser();
            if (mem != null)
            {
                Label text = (Label)LoginView1.FindControl("Label1");
                text.Text = mem.UserName;
              span1.Visible = true;
              span2.Visible = true;
            }
            else
            {
              	span1.Visible = false;
              	span2.Visible = false;
            }


            total();
     
        }
    
    }
    //public void filldiscount()
    //{
    //    DataSet ds = ad.getdiscount();
    //    if (ds.Tables[0].Rows.Count == 0)
    //    {

    //        i1.Visible = false;
    //    }
    //    else
    //    {
    //        i1.Visible = true;
    //        Repeater1.DataSource = ds;
    //        Repeater1.DataBind();
    //    }
    //}
    public void total()
    {
        int i = Convert.ToInt32(Profile.prawncrunchShopping.Items.Count);
        if (i == 0 || i == 1)
        {
            Label3.Text = i + " Item";
        }
        else
        {
            Label3.Text = i + " Items";
        }
    }

    protected void LoginStatus1_LoggingOut(object sender, LoginCancelEventArgs e)
    {
       
    }
 
    protected void LoginStatus1_LoggedOut(object sender, EventArgs e)
    {
        
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Management/AddProducts.aspx");
    }
}

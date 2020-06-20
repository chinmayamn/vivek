using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Data.SqlClient;
public partial class index : System.Web.UI.Page
{
    admin ad = new admin();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            filloffers();
            fillcategory(); filllatest();
            filldiscount();
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
    protected void LoginStatus1_LoggingOut(object sender, LoginCancelEventArgs e)
    {
        // Response.Redirect("login.aspx?returnurl=" + Request.Url + "");
    }
    //protected void LoginStatus1_LoggingOut(object sender, LoginCancelEventArgs e)
    //{
    //  http://localhost:1705/SBMart_Newdesign/Shop/login.aspx?ReturnUrl=%2fSBMart_Newdesign%2fShop%2flogin.aspx

    //}
    protected void LoginStatus1_LoggedOut(object sender, EventArgs e)
    {
        //     Response.Redirect("login.aspx?returnurl=" + Request.Url + "");
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Management/AddProducts.aspx");
    }
    public void total()
    {
        int i = Convert.ToInt32(Profile.prawncrunchShopping.Items.Count);
        if (i == 0 || i == 1)
        {
            Label3.Text = i + " Item";
        }
        else
        {
            Label3.Text = i + "Items";
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
    public void fillcategory()
        {
            DataSet ds = ad.getcategory();
            if (ds.Tables[0].Rows.Count == 0)
            {
                Label1.Visible = true;
                 Label1.Text="No category added till now";
                 DataList1.Visible = false;
            }
            else
            {
                Label1.Visible = false;
                DataList1.Visible = true;
                DataList1.DataSource = ds;
                DataList1.DataBind();
            }
        }
}

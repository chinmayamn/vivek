using System;
using System.Collections.Generic;
//////using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SBMartCartItem;
using prawncrunchShopping;
using System.Web.Security;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
public partial class Paymentdetail : System.Web.UI.UserControl
{
    Order or = new Order();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            lblcartTotal.Text = Profile.prawncrunchShopping.Total.ToString();


            if (GridView2.Rows.Count == 0)
            {

                ImageButton2.Visible = false;
            }
            else
            {

                ImageButton2.Visible = true;
            }

          
            //fillsessionid();
            bindgrid();
            fillgrid();
           
            fillcartTotal();
           
        
        }


    }

    

    public void fillcartTotal()
    {
        lblcartTotal.Text = Profile.prawncrunchShopping.Total.ToString();
    }




    //public void fillsessionid()
    //{
    //    MembershipUser memb = Membership.GetUser(Profile.UserName);
    //    string userid = "";
    //    try
    //    {
    //        userid = memb.ProviderUserKey.ToString();
    //    }
    //    catch (Exception ex)
    //    {
    //        Response.Redirect("Login.aspx");
    //    }
    //    string id;
       
    //    DataTable dt =or.select_order_userid(userid);
    //    id = dt.Rows[0][0].ToString();
    //    Session["orderid"] = id;
    //}

    public void fillgrid()
    {
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

        string id;
     
        DataTable dt = or.select_order_userid(userid);
        id = dt.Rows[0][0].ToString();


        DataTable dt1 = or.select_ordersid(id);
        GridView1.DataSource = dt1;
        GridView1.DataBind();

    }
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
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
        string id;
              DataTable dt = or.select_order_userid(userid);
        id = dt.Rows[0][0].ToString();


        TextBox txtfirstname = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtfirstname");
        
          TextBox txtaddress = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtaddress");
        TextBox txtcity = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtcity");
        TextBox txtstate = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtstate");
        TextBox txtemail = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox1");
       
        TextBox txtphone = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtphone");
        TextBox txtmobile = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtmobile");
      
       or.update_delivary_address(id,
            txtfirstname.Text,
            "a",
            txtemail.Text,
        txtaddress.Text,
            txtcity.Text,
         
            txtstate.Text,
           "IN",
            txtphone.Text,
            txtmobile.Text);
        GridView1.EditIndex = -1;
    
       
        fillgrid();
       
        fillcartTotal();

    

        bindgrid();

    }
    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        fillgrid();
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        fillgrid();
    }


   

    private void bindgrid()
    {
        if (Profile.prawncrunchShopping.Items.Count == 0)
        {
            ImageButton2.Visible = false;
        }
        else
        {
            ImageButton2.Visible = true;
        }
        GridView2.DataSource = Profile.prawncrunchShopping.Items;
        GridView2.DataBind();

       
    }


    protected void GridView2_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView2.EditIndex = e.NewEditIndex;
        bindgrid();
    }
    protected void GridView2_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView2.EditIndex = -1;
        bindgrid();
    }

    protected void GridView2_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        TextBox QuantityTextBox = (TextBox)GridView2.Rows[e.RowIndex].FindControl("txteditqty");
        int Quantity = Convert.ToInt32(QuantityTextBox.Text);
        if (Quantity == 0)
        {
            Profile.prawncrunchShopping.Items.RemoveAt(e.RowIndex);
        }
        else
        {
            Profile.prawncrunchShopping.Items[e.RowIndex].quantity = Quantity;
        }
        GridView2.EditIndex = -1;
        bindgrid();
        System.Web.UI.Page page = (System.Web.UI.Page)this.Page;
        user u = (user)page.Master;
        u.total();
        fillcartTotal();
    

    }
    protected void GridView2_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        Profile.prawncrunchShopping.Items.RemoveAt(e.RowIndex);
       lblcartTotal.Text = Profile.prawncrunchShopping.Total.ToString();
        System.Web.UI.Page page = (System.Web.UI.Page)this.Page;
        user u = (user)page.Master;

        bindgrid();
        u.total();
    }

       protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("index.aspx");
    }
   
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("ConfirmTransaction.aspx");
    }
}

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
using SBMartCartItem;
using prawncrunchShopping;
public partial class carting : System.Web.UI.UserControl
{

    public delegate void GridViewDeleteEventHandler(string value);
    public event GridViewDeleteEventHandler gdhandler;


    Order or = new Order();
    MessageBox msg = new MessageBox();
    admin ad = new admin();
    protected void Page_Load(object sender, EventArgs e)
    {
        Label22.Visible = false;
        Label23.Visible = false;
       
        if (!Page.IsPostBack)
        {
            

            lblcartotal.Text = Profile.prawncrunchShopping.Total.ToString();

           
            if (GridView1.Rows.Count == 0)
            {
              
                ImageButton2.Visible = false;
            }
            else
            {
              
                ImageButton2.Visible = true;
            }
            bindgrid();
            MembershipUser mem = Membership.GetUser(Profile.UserName);
            if (mem != null)
            {


            }
            else
            {

            }
            if (Profile.prawncrunchShopping.Items.Count == 0)
            {
                Label22.Visible = false; Label23.Visible = false;
            }
        }


    }


    public void insercart()
    {

        DataTable dt = or.prod_disp_id(Request.QueryString["prod_id"].ToString());


        if (Profile.prawncrunchShopping == null)
        {
            Profile.prawncrunchShopping = new ShoppingCart();
        }

      

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
        GridView1.DataSource = Profile.prawncrunchShopping.Items;
        GridView1.DataBind();
      
    }


    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        bindgrid();
    }
    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        bindgrid();
    }

    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        TextBox QuantityTextBox = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txteditqty");
        int Quantity = Convert.ToInt32(QuantityTextBox.Text);
        if (Quantity == 0)
        {
            Profile.prawncrunchShopping.Items.RemoveAt(e.RowIndex);
        }
        else
        {
            Profile.prawncrunchShopping.Items[e.RowIndex].quantity = Quantity;
        }


        lblcartotal.Text = Profile.prawncrunchShopping.Total.ToString();
        GridView1.EditIndex = -1;
        bindgrid();
        System.Web.UI.Page page = (System.Web.UI.Page)this.Page;
        user u = (user)page.Master;
        u.total();

    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        Profile.prawncrunchShopping.Items.RemoveAt(e.RowIndex);
        lblcartotal.Text = Profile.prawncrunchShopping.Total.ToString();
      

        System.Web.UI.Page page = (System.Web.UI.Page)this.Page;
        user u = (user)page.Master;
       
        bindgrid();
        u.total();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
    protected void lnkchkout_Click(object sender, EventArgs e)
    {

    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("index.aspx");


    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("BillingAddress.aspx");
    }


}

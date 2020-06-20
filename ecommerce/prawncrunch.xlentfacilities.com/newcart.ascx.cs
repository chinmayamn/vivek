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
using SBMartCartItem;
using prawncrunchShopping;



public partial class Shop_newcart : System.Web.UI.UserControl
{
    public delegate void GridViewDeleteEventHandler(string value);
    public event GridViewDeleteEventHandler gdhandler;

    admin ad = new admin();
    Order or = new Order();
    MessageBox msg = new MessageBox();
    protected void Page_Load(object sender, EventArgs e)
    {
        Label22.Visible = false;
        Label23.Visible = false;
        if (Request.QueryString["prod_id"] != null && !Page.IsPostBack)
        {
            //insercart();
        }
        if (!Page.IsPostBack)
        {
            //    update_tax_ship();

            lblcartotal.Text = Profile.prawncrunchShopping.Total.ToString();

            bindgrid();
            if (GridView1.Rows.Count == 0)
            {
                // lnkchkout.Visible = false;
                ImageButton2.Visible = false;
            }
            else
            {
                //  lnkchkout.Visible = true;
                ImageButton2.Visible = true;
            }
            MembershipUser mem = Membership.GetUser(Profile.UserName);
            if (mem != null)
            {
                //   DataTable dt = or.get_tax_shipping(Profile.Country);
                //int country = Convert.ToInt32(Session["country"]);
             //   DataTable dt = ad.gettaxbycity();
               
            }
            else
            {
                Label22.Visible = true;
                Label23.Visible = true;
                Label22.Text = "Tax and shipping for "; Label23.Text = "Bangalore";
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

        //  Profile.prawncrunchShopping.Insert(Convert.ToInt32(dt.Rows[0][0]), Convert.ToDouble(dt.Rows[0][24]),1, dt.Rows[0][4].ToString(), dt.Rows[0][12].ToString(), 12);



        //bindgrid();

    }






    private void bindgrid()
    {
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
           // Profile.prawncrunchShopping.Items[e.RowIndex].Quantity = Quantity;
        }


        lblcartotal.Text = Profile.prawncrunchShopping.Total.ToString();
        GridView1.EditIndex = -1;
        bindgrid();

    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        Profile.prawncrunchShopping.Items.RemoveAt(e.RowIndex);
        lblcartotal.Text = Profile.prawncrunchShopping.Total.ToString();
        gdhandler(string.Empty);
 ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "clientScript", "alert('Product removed from your cart successfully')", true);
       
        bindgrid();
          
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



    //public void update_tax_ship()
    //{
    //    MembershipUser mem = Membership.GetUser(Profile.UserName);
    //    if (mem == null)
    //    {
    //        //GridView1.Columns[3].Visible = false;
    //        //GridView1.Columns[4].Visible = false;
    //        Profile.prawncrunchShopping.updatetest(0, 0);
    //        Label22.Visible = true;
    //        Label22.Text = "Tax and shipping not included";
    //    }
    //    else
    //    {
    //        if (Convert.ToString(Session["country"]) == "")
    //        {
    //            //GridView1.Columns[3].Visible = true;
    //            //GridView1.Columns[4].Visible = true;
    //            DataTable dt = or.get_tax_shipping(Profile.Country);
    //            if (dt.Rows[0]["tax"].ToString() != "" || dt.Rows[0]["ship"].ToString() != "")
    //            {
    //                Label22.Visible = true;
    //                Label23.Visible = true;
    //                Label22.Text = "Tax and shipping for "; Label23.Text = Profile.Country.ToString();
    //                Profile.prawncrunchShopping.updatetest(Convert.ToDouble(dt.Rows[0]["tax"].ToString()), Convert.ToDouble(dt.Rows[0]["ship"].ToString()));
    //            }
    //            else
    //            {
    //                DataTable dt1 = or.get_tax_shipping("United Kingdom");
    //                Label22.Visible = true;
    //                Label23.Visible = true;
    //                Label22.Text = "Tax and shipping for "; Label23.Text = "United Kingdom.";
    //                Profile.prawncrunchShopping.updatetest(Convert.ToDouble(dt.Rows[0]["tax"].ToString()), Convert.ToDouble(dt.Rows[0]["tax"].ToString()));
    //            }
    //        }
    //    }
    //}

    //public void update_tax_shipping()
    //{
    //    DataTable dt = or.get_tax_shipping(Convert.ToString(Session["country"]));
    //    if (dt.Rows[0]["tax"].ToString() != "" || dt.Rows[0]["ship"].ToString() != "")
    //    {
    //        Label22.Visible = true;
    //        Label23.Visible = true;
    //        Label22.Text = "Tax and shipping for "; Label23.Text = Profile.Country.ToString();
    //        Profile.prawncrunchShopping.updatetest(Convert.ToDouble(dt.Rows[0]["tax"].ToString()), Convert.ToDouble(dt.Rows[0]["tax"].ToString()));
    //    }
    //    else
    //    {
    //        DataTable dt1 = or.get_tax_shipping("United Kingdom");
    //        Label22.Visible = true;
    //        Label23.Visible = true;
    //        Label22.Text = "Tax and shipping for "; Label23.Text = "United Kingdom.";
    //        double ship = Convert.ToDouble(dt1.Rows[0]["ship"].ToString());
    //        double tax = Convert.ToDouble(dt1.Rows[0]["tax"].ToString());
    //        Profile.prawncrunchShopping.updatetest(tax, ship);
    //    }
    //}

    protected void Button1_Click(object sender, EventArgs e)
    {
        string str = TextBox1.Text;
        //  DataSet ds = ad.getdiscountdetails(str);

        DataSet ds = new DataSet();
        if (ds.Tables[0].Rows.Count == 0)
        {
            msg.Show("Invalid Coupon");
        }
        else
        {


            string name = ds.Tables[0].Rows[0]["issuedto"].ToString();
            string pid = ds.Tables[0].Rows[0]["pid"].ToString();
            double amount = Convert.ToDouble(ds.Tables[0].Rows[0]["amount"].ToString());
            MembershipUser mem = Membership.GetUser(Profile.UserName);

            string temp1 = mem.UserName.ToString();
            if (temp1 == name)
            {
                //Profile.prawncrunchShopping.Update(

                //Profile.prawncrunchShopping.Items[e.RowIndex].Quantity = Quantity;
                //Profile.prawncrunchShopping.Items.RemoveAt(e.RowIndex);


                for (int i = 0; i < GridView1.Rows.Count; i++)
                {
                    Label templabel = (Label)GridView1.Rows[i].FindControl("Label5");
                    string tempest = templabel.Text;

                    if (tempest == pid)
                    {
                        MessageBox msg = new MessageBox();

                   //     Profile.prawncrunchShopping.Update1(i, amount);
                        msg.Show("Product has been discounted");
                        bindgrid();
                        lblcartotal.Text = Profile.prawncrunchShopping.Total.ToString();
                        TextBox1.Text = "";
                      //  ad.updatediscountfromuserside(str, pid);
                    }

                }
            }
        }
    }



}

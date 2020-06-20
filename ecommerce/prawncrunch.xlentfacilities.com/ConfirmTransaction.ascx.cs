using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using SBMartCartItem;
using prawncrunchShopping;


public partial class User_ConfirmTransaction : System.Web.UI.UserControl
{
    Order or = new Order();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
         
            fillgrid();
            bindgrid();
            fillcartTotal();
       
        }
    }

   

    public void fillcartTotal()
    {
        lblcartTotal.Text = Profile.prawncrunchShopping.Total.ToString();
    }

  
    
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

        TextBox txtdelname = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtdelname");
       
        TextBox txtstreet = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtstreet");
        TextBox txtcity = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtcity");
        TextBox txtstate = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtstate");
        TextBox txtemail = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox1");
         
        TextBox txtphone = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtphone");
        TextBox txtphone1 = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtphone1");

        or.update_delivary_address(id,
            txtdelname.Text,
            "a",
              txtemail.Text,
            txtstreet.Text,
            txtcity.Text,
       
            txtstate.Text, 
"IN",
           
            txtphone.Text,
            txtphone1.Text);
       
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
         Label discounttext = (Label)GridView2.Rows[e.RowIndex].FindControl("Label9");

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
        fillcartTotal();

        System.Web.UI.Page page = (System.Web.UI.Page)this.Page;
        user u = (user)page.Master;
        u.total();
        bindgrid();
    }



   
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
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
        DataTable dt = or.select_order_userid(userid);
        string orderid  = dt.Rows[0][0].ToString();

        foreach (CartItem item in Profile.prawncrunchShopping.Items)
        {

            or.Insertproduct_order(orderid, item.ProductId.ToString(), item.ProductName, item.price.ToString(), item.Linetotal.ToString(), item.quantity.ToString(), item.city1.ToString(), item.discount.ToString(), item.Date.ToString());
        }
        admin ad=new admin();
        DataSet ds22 = ad.getdollar();
        double tempdoll = Convert.ToDouble(ds22.Tables[0].Rows[0]["dollar"]);
         double amount= Profile.prawncrunchShopping.Total;
         amount = amount / tempdoll;

         DataSet   ds = or.select_order(userid);

        string name=ds.Tables[0].Rows[0]["firstname"].ToString()+" " + ds.Tables[0].Rows[0]["lastname"].ToString();
        string address =ds.Tables[0].Rows[0]["address"].ToString();
        string city =ds.Tables[0].Rows[0]["city"].ToString();
        string state =ds.Tables[0].Rows[0]["state"].ToString();
        string country =ds.Tables[0].Rows[0]["country"].ToString();
        string email=ds.Tables[0].Rows[0]["email"].ToString();
        string mobile =ds.Tables[0].Rows[0]["mobile"].ToString();

        string ship_name = ds.Tables[0].Rows[0]["delivery_firstname"].ToString() + " " + ds.Tables[0].Rows[0]["delivery_lastname"].ToString();
        string ship_address = ds.Tables[0].Rows[0]["delivery_address"].ToString();
        string ship_city = ds.Tables[0].Rows[0]["delivery_city"].ToString();
        string ship_state = ds.Tables[0].Rows[0]["delivery_state"].ToString();
        string ship_country = ds.Tables[0].Rows[0]["delivery_country"].ToString();
        string ship_email = ds.Tables[0].Rows[0]["delivery_email"].ToString();
        string ship_mobile = ds.Tables[0].Rows[0]["delivery_mobile"].ToString();


    


       //  Response.Redirect("http://prosperitymagick.com/pay1.aspx?orderid="+ orderid+"&amount=" + lblcartTotal.Text +"&name=" +name + "&address=" + address +"&city="+ city +"&state="+state+"&country="+country+"&email="+email+"&mobile="+mobile+"&ship_name="+ ship_name +"&ship_address="+ ship_address+"&ship_city="+ship_city+"&ship_state="+ship_state+"&ship_email="+ ship_email+"&ship_phone="+ship_mobile);

        Response.Redirect("Merchant.aspx?oid=" + orderid);


     

        
    }
    protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void datepicker_TextChanged2(object sender, EventArgs e)
    {
        admin ad = new admin();
        double discount;
        double caldisc;

        DateTime added =Convert.ToDateTime(datepicker.Text);
        DateTime current = Convert.ToDateTime( DateTime.Today.ToShortDateString());
        if (DateTime.Compare(added , current)<=0)
        {
            Label10.Text = "Today or previous dates for booking are not allowed";
            Label11.Text = "";
            datepicker.Text = "";
        }
        else
        {
            Label10.Text = "";
            Label11.Text = "";

           
            DataSet ds1=ad.getdiscount();
            if(ds1.Tables[0].Rows.Count==0)
            {
                caldisc=0;
            }
            else
            {
                caldisc=Convert.ToDouble( ds1.Tables[0].Rows[0]["discount"]);
            }

            DataSet ds = ad.getdiscountdates(datepicker.Text);
            if (ds.Tables[0].Rows.Count == 0)
            {
            }
            else
            {
                int dating = Convert.ToInt32(ds.Tables[0].Rows[0]["dating"].ToString());

                if (dating <=5)               {
                    discount = 0;

                    foreach (CartItem item in Profile.prawncrunchShopping.Items)
                    {
                        if (item.discount == caldisc)
                        {
                            item.discount = caldisc;
                           
                        }
                        else
                        {
                           
                           item.discount = discount;
                        }

                        item.Date = datepicker.Text;
                    }
                   
                    bindgrid();
                    fillcartTotal();
                    double newtotal = Convert.ToDouble(lblcartTotal.Text);
                    double oldtotal = Convert.ToDouble(Profile.prawncrunchShopping.discal);
                    double ori = oldtotal - newtotal;
                    Label11.Text = "You have saved Rs." + Math.Round(ori, 2) ;
           
             
             
                }
                else if (dating >= 6 && dating <= 10)
                {
                    discount = 5;
                    foreach (CartItem item in Profile.prawncrunchShopping.Items)
                    {
                        if (item.discount == caldisc)
                        {
                            item.discount = caldisc;
                        }
                        else
                        {

                            item.discount =discount;
                        }

                        item.Date = datepicker.Text;
                    }
                    bindgrid();
                    fillcartTotal();
                   
                        double newtotal=Convert.ToDouble(lblcartTotal.Text);
                        double oldtotal = Convert.ToDouble(Profile.prawncrunchShopping.discal);
                        double ori = oldtotal - newtotal;

                        Label11.Text = "You have saved Rs." + Math.Round(ori, 2) ;
                }
                else if (dating >= 11 && dating <= 20)
                {
                    discount = 7;
                    foreach (CartItem item in Profile.prawncrunchShopping.Items)
                    {
                        if (item.discount == caldisc)
                        {
                            item.discount = caldisc;
                        }
                        else
                        {

                            item.discount = discount;
                        }

                        item.Date = datepicker.Text;
                    }
                    bindgrid();
                    fillcartTotal();
                    double newtotal = Convert.ToDouble(lblcartTotal.Text);
                    double oldtotal = Convert.ToDouble(Profile.prawncrunchShopping.discal);
                    double ori = oldtotal - newtotal;
                    Label11.Text = "You have saved Rs." + Math.Round(ori,2) ;
            
                }
                else if (dating >= 21 && dating <= 30)
                {
                    discount = 10;
                    foreach (CartItem item in Profile.prawncrunchShopping.Items)
                    {
                        if (item.discount == caldisc)
                        {
                            item.discount = caldisc;
                        }
                        else
                        {

                            item.discount = discount;
                        }
                        item.Date = datepicker.Text;
                    }
                    bindgrid();
                    fillcartTotal();
                    double newtotal = Convert.ToDouble(lblcartTotal.Text);
                    double oldtotal = Convert.ToDouble(Profile.prawncrunchShopping.discal);
                    double ori = oldtotal - newtotal;
                    Label11.Text = "You have saved Rs." + Math.Round(ori, 2) ;
            
                }
                else if (dating >= 31)
                {
                    discount = 10;
                    foreach (CartItem item in Profile.prawncrunchShopping.Items)
                    {
                        if (item.discount == caldisc)
                        {
                            item.discount = caldisc;
                        }
                        else
                        {

                            item.discount = discount;
                        }

                        item.Date = datepicker.Text;
                    }
                    bindgrid();
                    fillcartTotal();
                    double newtotal = Convert.ToDouble(lblcartTotal.Text);
                    double oldtotal = Convert.ToDouble(Profile.prawncrunchShopping.discal);
                    double ori = oldtotal - newtotal;
                    Label11.Text = "You have saved Rs." + Math.Round(ori, 2) ;
            
                }
            }
        }
    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("index.aspx");
    }
}

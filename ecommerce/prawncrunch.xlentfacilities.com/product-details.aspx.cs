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
using SBMartCartItem;
using prawncrunchShopping;
public partial class product_details : System.Web.UI.Page
{
    admin ad = new admin();
    code co = new code();
    Order or = new Order();
    MessageBox msg = new MessageBox();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Request.QueryString["id"] != null)
            {

                int id = Convert.ToInt32(Request.QueryString["id"]);


                
            MembershipUser mem = Membership.GetUser();
            if (mem == null)
            {

                string tempest = HttpContext.Current.Request.Url.AbsoluteUri;
                Response.Redirect("login.aspx?returnurl=" + tempest);
            }



                filldata(id);

                if (Session["city1"] != null & Session["city2"] != null)
                {

                    string city1 = Convert.ToString(Session["city1"]);
                    string city2 = Convert.ToString(Session["city2"]);
                    string qty = Convert.ToString(Session["qty"]);


                    for (int i = 0; i < DropDownList1.Items.Count; i++)
                    {
                        if (DropDownList1.Items[i].Text == city1)
                        {
                            DropDownList1.Items[i].Selected = true;
                        }
                    }

                    string prod = Convert.ToString(Request.QueryString["id"]);
                  

                  
               


                    DataSet ds22 = ad.getprice(city1, city2, prod);
                    if (ds22.Tables[0].Rows.Count == 0)
                    {
                        Label3.Text = "";
                    }

                    else
                    {
                        Label3.Text = ds22.Tables[0].Rows[0]["price"].ToString() + "/-";
                    }

                }
                filllatest();
            }
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
            DataList1.DataSource = ds;
            DataList1.DataBind();
        }
    }
        public void filldata(int data)
        {
            DataSet ds=ad.getproductdetailsbyidnew(data);
            Label1.Text = ds.Tables[0].Rows[0]["categoryname"].ToString();
            Label4.Text= " - " + ds.Tables[0].Rows[0]["pname"].ToString();
            Label7.Text = ds.Tables[0].Rows[0]["pname"].ToString();
            a1.HRef = "products.aspx?id=" + ds.Tables[0].Rows[0]["id1"].ToString();
            Label2.Text = Server.HtmlDecode( ds.Tables[0].Rows[0]["description"].ToString());
            Image1.ImageUrl = ds.Tables[0].Rows[0]["pimage"].ToString();


            DataSet ds1 = ad.getproductprice(data);

            if (ds1.Tables[0].Rows.Count == 0)
            {
                Button1.Visible = false;
                Label6.Visible = true;
            }
            else
            {
                Button1.Visible = true;
                Label6.Visible = false;
            }
        }
      
        
        protected void Button1_Click(object sender, EventArgs e)
        {
            MembershipUser mem = Membership.GetUser();
            if (mem == null)
            {
                Session["city1"] = DropDownList1.SelectedItem.Text.ToString();
            
                Session["qty"] = TextBox1.Text;
                Session["id"] = Convert.ToInt32(Request.QueryString["id"]);
                    
                string tempest = HttpContext.Current.Request.Url.AbsoluteUri;
                Response.Redirect("login.aspx?returnurl=" +tempest);
            }
            else
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                string city1 = DropDownList1.SelectedItem.Text.ToString();


                double disdis = 0;

                DataTable dt = co.getproductdetailbyid(id,city1);


                DataSet dts = ad.getdiscount();
                if (dts.Tables[0].Rows.Count == 0)
                {
                    disdis = 0;
                }
                else
                {
                   

                        if (Convert.ToInt32(dts.Tables[0].Rows[0]["pid"]) == Convert.ToInt32(Request.QueryString["id"]))
                        {
                            disdis = Convert.ToDouble(dts.Tables[0].Rows[0]["discount"]);
                        }
                        else
                        {
                            disdis = 0;
                        }
                   


                }

               int qty = Convert.ToInt32(TextBox1.Text);
             
                if (qty > 0)
                {

        Profile.prawncrunchShopping.Insert(Convert.ToInt32(dt.Rows[0]["id"]), dt.Rows[0]["pname"].ToString(), dt.Rows[0]["pimage"].ToString(), Convert.ToDouble(dt.Rows[0]["price"]),city1,qty,disdis);


       
        ((user)this.Page.Master).total();

        TextBox1.Text = "";
        Label3.Text = "";
        DropDownList1.SelectedIndex = 0;
    

        Response.Redirect("cart.aspx");
                }
                else
                {
                    msg.Show("Quantity must be greater than zero");
                    TextBox1.Text = "";
                    Label3.Text = "";
                    DropDownList1.SelectedIndex = 0;
               
                }




            }



        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string city = Convert.ToString(DropDownList1.SelectedItem.Value.ToString());
            string prod = Convert.ToString(Request.QueryString["id"]);
            DataSet ds = ad.getplacebycity(city, prod);
            if (ds.Tables[0].Rows.Count == 0)
            {
                Label3.Text = "";
            }
            else
            {
             
                Label3.Text = ds.Tables[0].Rows[0]["price"].ToString() + "/-";
            }
        }
}


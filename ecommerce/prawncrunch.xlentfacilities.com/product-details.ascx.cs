using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;


public partial class product_details : System.Web.UI.UserControl
{
    //public delegate void OnButtonClick(string value);
    //public event OnButtonClick btnhandler;

   

    admin ad = new admin();
    code co = new code();
    MessageBox msg = new MessageBox();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            int i = Convert.ToInt32(Request.QueryString["id"]);
            fillproductdetails(i);
        }
    }
    public void fillproductdetails(int i)
    {
        //DataSet ds = ad.fillproductdetails(i);

        //if (ds.Tables[0].Rows.Count == 0)
        //{
        //}
        //else
        //{
        //    Label1.Text = ds.Tables[0].Rows[0]["pname"].ToString();
        //    Label2.Text = ds.Tables[0].Rows[0]["description"].ToString();
        //    Image1.ImageUrl = ds.Tables[0].Rows[0]["pimage"].ToString();
        //    Label4.Text = ds.Tables[0].Rows[0]["price"].ToString();

        //}


    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //int id = Convert.ToInt32(Request.QueryString["id"].ToString());
        //DataSet ds = ad.fillproductdetails(id);


        //int qty = Convert.ToInt32(DropDownList1.SelectedItem.Value);
        //if (qty > 0)
        //{
        //    DataTable dt = co.getproductdetail(id);
        //    DataTable dt1 = ad.gettaxbycity();
        //    double price = Convert.ToDouble(dt.Rows[0]["price"].ToString());
        //    double percentage = Convert.ToDouble(dt.Rows[0]["discountprice"].ToString());
        //    double finalprice = Convert.ToDouble(dt.Rows[0]["price"].ToString()) - ((price / 100) * percentage);
        //    MembershipUser mem = Membership.GetUser(Profile.UserName);

        //    Profile.prawncrunchShopping.Insert(Convert.ToInt32(dt.Rows[0]["id"]), finalprice, qty, dt.Rows[0]["pname"].ToString(), dt.Rows[0]["pimage"].ToString(), Convert.ToDouble(dt1.Rows[0]["tax"].ToString()), Convert.ToDouble(dt1.Rows[0]["shipping"].ToString()));
        //}
        //else
        //{
        //    //lblmsg.Visible = true;
        //    //lblmsg.Text = "Quantity must be greater than ZERO";
        //    msg.Show("Quantity must be greater than ZERO");

        //}

        //btnhandler(string.Empty);

    }
}

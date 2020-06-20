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

public partial class admin_print_order : System.Web.UI.Page
{
    MessageBox msg = new MessageBox();
    revieworder ro = new revieworder();
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Visible = false;
        if (!Page.IsPostBack)
        {
            if (Request.QueryString["orders_id"] != null)
            {
                fillgrid();
                fillorderstatusgrid();
                fillgridproduct();
            }
        }


    }

    private void fillgridproduct()
    {
        int id = Convert.ToInt32(Request.QueryString["orders_id"]);
        DataTable dt = ro.fillproduct(id);
        GridView2.DataSource = dt;
        GridView2.DataBind();
    }
    public void fillgrid()
    {
        int id = Convert.ToInt32(Request.QueryString["orders_id"]);
        DataTable dt = ro.fillorderbyid(id);

        //customer address
        lblname.Text = dt.Rows[0][2].ToString();
        lbladdress.Text = dt.Rows[0][4].ToString();
        lblcity.Text = dt.Rows[0][5].ToString();
        lblregion.Text = dt.Rows[0][6].ToString();
        lblpostalcode.Text = dt.Rows[0][7].ToString();
        lblcountry.Text = dt.Rows[0][8].ToString();
      
        Label2.Text = dt.Rows[0]["state"].ToString();

        //shipping address

        lbldeliveryname.Text = dt.Rows[0]["delivery_firstname"].ToString();
      
        Label4.Text = dt.Rows[0]["delivery_email"].ToString();
        Label5.Text = dt.Rows[0]["delivery_phone"].ToString();
        Label6.Text = dt.Rows[0]["delivery_mobile"].ToString();

        lbldeliveryaddress.Text = dt.Rows[0]["delivery_address"].ToString();
        lbldeliverycity.Text = dt.Rows[0]["delivery_city"].ToString();
        lbldeliveryregion.Text = dt.Rows[0]["delivery_state"].ToString();

      

        //billing address
        lblname3.Text = dt.Rows[0]["firstname"].ToString();
    
        Label8.Text = dt.Rows[0]["email"].ToString();
        Label9.Text = dt.Rows[0]["phone"].ToString();
        Label10.Text = dt.Rows[0]["mobile"].ToString();
        lbladdress3.Text = dt.Rows[0]["address"].ToString();
        lblcity3.Text = dt.Rows[0]["city"].ToString();
        lblregion3.Text = dt.Rows[0]["state"].ToString();

        

    }
    public void fillorderstatusgrid()
    {
        int id = Convert.ToInt32(Request.QueryString["orders_id"]);
        DataSet ds = ro.fillorderstatus(id);
        if (ds.Tables[0].Rows.Count == 0)
        {
            Label1.Visible = true;
            Label1.Text = "No summary added yet";
            GridView1.Visible = false;
        }
        else
        {
            Label1.Visible = false;
            GridView1.Visible = true;
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
    }

   
    protected void img_print_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("print-order.aspx?orders_id=" + Request.QueryString["orders_id"].ToString() + "");
    }
}

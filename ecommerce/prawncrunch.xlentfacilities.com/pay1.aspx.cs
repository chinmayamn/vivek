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
public partial class pay1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)

        {
            reference_no.Text = Request.QueryString["orderid"].ToString();

            amount.Text = Request.QueryString["amount"].ToString();
            name.Text = Request.QueryString["name"].ToString();
            address.Text = Request.QueryString["address"].ToString();
            city.Text = Request.QueryString["city"].ToString();
            state.Text = Request.QueryString["state"].ToString();
            email.Text = Request.QueryString["email"].ToString();
            phone.Text = Request.QueryString["mobile"].ToString();

            ship_name.Text = Request.QueryString["ship_name"].ToString();
            ship_address.Text = Request.QueryString["ship_address"].ToString();
            ship_city.Text = Request.QueryString["ship_city"].ToString();
            ship_state.Text = Request.QueryString["ship_state"].ToString();
          //  ship_email.Text = Request.QueryString["ship_email"].ToString();
            ship_phone.Text = Request.QueryString["ship_phone"].ToString();
            return_url.Text = "http://prawncrunch.xlentfacilities.com/thankyou.aspx?id=" + reference_no.Text;
        }

    }
}

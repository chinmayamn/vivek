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
public partial class login : System.Web.UI.Page
{
    admin ad = new admin();
    MessageBox msg = new MessageBox();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            filllatest();

           
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
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        if (Request.QueryString["returnurl"] == null)
        {
            Response.Redirect("registration.aspx");
        }
        else
        {
           Response.Redirect("registration.aspx?returnurl=" + Request.QueryString["returnurl"].ToString());
        }
    }
}

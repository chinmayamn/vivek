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
public partial class products : System.Web.UI.Page
{
    admin ad = new admin();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if(Request.QueryString["id"]!=null)
            {
                int id= Convert.ToInt32(Request.QueryString["id"]);
            fillproduct(id);
          
            }
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
    public void fillproduct(int id)
    {
        //DataSet ds = ad.getproductbycatnew(id);
        DataSet ds = ad.getproductbycatnewest(id);
        if (ds.Tables[0].Rows.Count == 0)
        {
            Label1.Visible = true;
            DataList1.Visible = false;
        }
        else
        {
            Label1.Visible = false;
            DataList1.Visible = true;
            DataList1.DataSource = ds;
            DataList1.DataBind();
            Label2.Text = ds.Tables[0].Rows[0]["categoryname"].ToString();
        }
    }
}

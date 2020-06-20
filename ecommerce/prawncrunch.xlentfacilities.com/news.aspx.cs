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

public partial class news : System.Web.UI.Page
{
    admin ad = new admin();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            fillgrid();
        }
    }
    public void fillgrid()
    {
        DataSet ds = ad.getnews();
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
        }
    }
}

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
public partial class i : System.Web.UI.Page
{
    admin ad = new admin();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {

            filldiscount();
        }

    }
    public void filldiscount()
    {
        DataSet ds = ad.getdiscount();
        if (ds.Tables[0].Rows.Count == 0)
        {

            topbar.Visible = false;
        }
        else
        {
            topbar.Visible = true;
            Repeater1.DataSource = ds;
            Repeater1.DataBind();
        }
    }
}

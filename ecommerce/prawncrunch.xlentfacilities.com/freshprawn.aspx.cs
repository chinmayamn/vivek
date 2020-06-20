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
public partial class freshprawn : System.Web.UI.Page
{
    MessageBox msg = new MessageBox();
    admin ad = new admin();
    protected void Page_Load(object sender, EventArgs e)
    {
        System.Web.UI.HtmlControls.HtmlAnchor a;
        a = (System.Web.UI.HtmlControls.HtmlAnchor)this.Master.FindControl("l2");

        a.Attributes.Add("class", "current");
        if (!Page.IsPostBack)
        {
            filldata();
        }
    }
    public void filldata()
    {
        DataSet ds = ad.getdata("farm-fresh");
        if (ds.Tables[0].Rows.Count == 0)
        {
        }
        else
        {
            Label1.Text = Server.HtmlDecode(ds.Tables[0].Rows[0]["contents"].ToString());
        }
    }
}
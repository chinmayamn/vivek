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

public partial class terms_conditions : System.Web.UI.Page
{
    MessageBox msg = new MessageBox();
    admin ad = new admin();


    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            filldata();
        }
    }
    public void filldata()
    {
        DataSet ds = ad.getdata("Terms-Conditions");
        if (ds.Tables[0].Rows.Count == 0)
        {
        }
        else
        {
            Label1.Text = Server.HtmlDecode(ds.Tables[0].Rows[0]["contents"].ToString());
        }
    }
}

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
public partial class admin_dollarvalue : System.Web.UI.Page
{
    admin ad = new admin();
    MessageBox msg = new MessageBox();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            fillgrid();
        }

    }
    public void fillgrid()
    {
        DataSet ds = ad.getdollar();
        if (ds.Tables[0].Rows.Count == 0)
        {
            Button1.Visible = true;
            Button2.Visible = false;
        }
        else
        {
           Label1.Text = Server.HtmlDecode(ds.Tables[0].Rows[0]["dollar"].ToString());
            Button1.Visible = false;
            Button2.Visible = true;
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        string content = TextBox1.Text;
        ad.dollar(content);
        msg.Show("Dollar value added successfully");
        fillgrid();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {

        string content = TextBox1.Text;
        ad.dollar(content);
        msg.Show("Dollar value updated successfully");
        fillgrid();
    }
}

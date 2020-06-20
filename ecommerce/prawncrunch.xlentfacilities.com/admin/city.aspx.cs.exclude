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

public partial class admin_city : System.Web.UI.Page
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
        DataSet ds = ad.getcity();
        if (ds.Tables[0].Rows.Count == 0)
        {
            GridView1.Visible = false;
            Label1.Visible = true;
            Label1.Text = "No city added yet";
        }
        else
        {
            Label1.Visible = false;
            GridView1.Visible = true;
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        ad.addcity(TextBox1.Text);
        msg.Show("City added successfully");
        TextBox1.Text = "";
        fillgrid();
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        fillgrid();
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);

        DataSet ds = ad.checkplaces(id);

        if (ds.Tables[0].Rows.Count == 0)
        {
        ad.delcity(id);
        msg.Show("City deleted successfully");
        fillgrid();
        }
        else
        {
            msg.Show("Places are present for this city, delete them first");
        }
    }
}

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
using System.Drawing;
public partial class admin_orders : System.Web.UI.Page
{
    MessageBox msg = new MessageBox();
    revieworder ro = new revieworder();
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Visible = false;
        if (!Page.IsPostBack)
        {
            fillgrid();
        }



    }
    public void fillgrid()
    {
        DataSet ds = ro.fillorder();
        if (ds.Tables[0].Rows.Count == 0)
        {
            Label1.Visible = true;
            Label1.Text = "No orders placed yet";
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
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        fillgrid();
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {

        int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
        ro.deleteorder(id);

        msg.Show("Order deleted successfully");
        fillgrid();

    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        DataRowView drv = (DataRowView)e.Row.DataItem;

    
      

      
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
           Label l = e.Row.FindControl("Label2") as Label;

            if (l.Text == "Pending")
            {
                l.ForeColor = Color.Red;
            }
            else if (l.Text == "Processing")
            {

                l.ForeColor = Color.Green;
            }
            else if (l.Text == "Delivered")
            {
                l.ForeColor = Color.Green;
            }

        }
    }
}

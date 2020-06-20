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
public partial class admin_zone : System.Web.UI.Page
{
    admin ad = new admin();
    MessageBox msg = new MessageBox();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Submit.Visible = true;
            btnupdate.Visible = false;
            
            fillgrid();

            if (Request.QueryString["id"] != null)
            {
                Submit.Visible = false;
                btnupdate.Visible = true;
               
                edits();
            }
            else
            {
                Submit.Visible = true;
                btnupdate.Visible = false;
               
            }

        }

    }
    public void edits()
    {
        string id = Convert.ToString(Request.QueryString["id"]);
        DataSet ds = ad.getzonebyid(id);
        if (ds.Tables[0].Rows.Count == 0)
        {
        }
        else
        {
            TextBox3.Text = ds.Tables[0].Rows[0]["zone"].ToString();
            string city = ds.Tables[0].Rows[0]["city"].ToString();
            string place = ds.Tables[0].Rows[0]["place"].ToString();

            for (int i = 0; i < DropDownList1.Items.Count; i++)
            {
                if (DropDownList1.Items[i].Text == city)
                {
                    DropDownList1.Items[i].Selected = true;
                }
            }
            for (int j = 0; j < DropDownList2.Items.Count; j++)
            {
                if (DropDownList2.Items[j].Text == place)
                {
                    DropDownList2.Items[j].Selected = true;
                }
            }
        }
    }
    public void fillgrid()
    {
        DataSet ds = ad.getzone();
        if (ds.Tables[0].Rows.Count == 0)
        {
            GridView1.Visible = false;
            Label1.Visible = true;
            Label1.Text = "No zone added yet";
        }
        else
        {
            Label1.Visible = false;
            GridView1.Visible = true;
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
    }


    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);

        DataSet ds = ad.checkforzone(id);

        if (ds.Tables[0].Rows.Count == 0)
        {
            ad.delzone(id);
            msg.Show("Zone deleted successfully");
            fillgrid();
        }
        else
        {
            msg.Show("Delete places under this zone first");
        }

    }
    protected void Submit_Click(object sender, EventArgs e)
    {
      
            ad.addzone(DropDownList1.SelectedItem.Text.ToString(), DropDownList2.SelectedItem.Text.ToString(), TextBox3.Text);
            msg.Show("Zone created successfully");
            fillgrid();
            TextBox3.Text = "";
            DropDownList1.SelectedIndex = 0;
            DropDownList2.SelectedIndex = 0;
           
       
    }
    protected void btnupdate_Click(object sender, EventArgs e)
    {
        string id = Request.QueryString["id"].ToString();

        ad.updatezone(id,DropDownList1.SelectedItem.Text.ToString(), DropDownList2.SelectedItem.Text.ToString(), TextBox3.Text);
        msg.Show("Zone updated successfully");
        fillgrid();
        TextBox3.Text = "";
        DropDownList1.SelectedIndex = 0;
        DropDownList2.SelectedIndex = 0;
        Response.Redirect("zone.aspx");

    }
    protected void GridView1_PageIndexChanging1(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        fillgrid();
    }

}

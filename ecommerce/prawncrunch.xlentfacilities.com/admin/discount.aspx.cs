using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Net.Mail;
using System.IO;
using System.Data.SqlClient;    
public partial class Management_discount : System.Web.UI.Page
{
    admin ad = new admin();
    MessageBox msg = new MessageBox();
  
    protected void Page_Load(object sender, EventArgs e)
    {
        Button1.Visible = true;
        Button2.Visible = false;

        if (!Page.IsPostBack)
        {
            fillcategory();
            fillgrid();
            if (Request.QueryString["id"] != null)
            {
                edit();
            }
        }
       
    }
    public void edit()
    {
        Button1.Visible = false;
        Button2.Visible = true;
        DataTable dt=ad.getdiscountbyid(Convert.ToInt32( Request.QueryString["id"]));
        if (dt.Rows.Count == 0)
        {
        }
        else
        {
            string cid = dt.Rows[0]["cid"].ToString();
            string pid = dt.Rows[0]["pid"].ToString();
            string discount = dt.Rows[0]["discount"].ToString();
            string text = dt.Rows[0]["text"].ToString();


            DataSet ds = ad.getproductbycatadmin(Convert.ToInt32(cid));
            if (ds.Tables[0].Rows.Count == 0)
            {
                DropDownList2.Items.Clear();
            }
            else
            {
                DropDownList2.DataSource = ds;
                DropDownList2.DataTextField = ds.Tables[0].Columns["pname"].ToString();
                DropDownList2.DataValueField = ds.Tables[0].Columns["id"].ToString();
                DropDownList2.DataBind();
                DropDownList2.Items.Insert(0, "Select");

            }



            for (int i = 0; i < DropDownList1.Items.Count; i++)
            {
                if (DropDownList1.Items[i].Value == cid)
                {
                    DropDownList1.Items[i].Selected = true;
                }
            }
            for (int j = 0; j< DropDownList2.Items.Count; j++)
            {
                if (DropDownList2.Items[j].Value == pid)
                {
                    DropDownList2.Items[j].Selected = true;
                }
            }

            TextBox1.Text = text;
            TextBox2.Text = discount;
        }
    }

    
    public void fillgrid()
    {
        DataSet ds = ad.getdiscount();
        if (ds.Tables[0].Rows.Count == 0)
        {
            Label1.Visible = true;
            GridView1.Visible = false;
        }
        else
        {
            GridView1.Visible = true;
            GridView1.DataSource = ds;
            GridView1.DataBind();
            Label1.Visible = false;

        }
    }
    public void fillcategory()
    {
        DataSet ds = ad.getcategory();
        if (ds.Tables[0].Rows.Count == 0)
        {
            
        }
        else
        {
            DropDownList1.DataSource = ds;
            DropDownList1.DataTextField = ds.Tables[0].Columns["categoryname"].ToString();
            DropDownList1.DataValueField = ds.Tables[0].Columns["id"].ToString();
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, "Select");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        ad.insertdiscount(DropDownList1.SelectedItem.Value.ToString(), DropDownList2.SelectedItem.Value.ToString(), TextBox1.Text, TextBox2.Text);
        msg.Show("Discount added successfully");
        fillgrid();
        TextBox1.Text = "";
        TextBox2.Text = "";
        DropDownList2.Items.Clear();
        DropDownList1.SelectedIndex = 0;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        ad.updatediscount(Request.QueryString["id"].ToString(), DropDownList1.SelectedItem.Value.ToString(), DropDownList2.SelectedItem.Value.ToString(), TextBox1.Text, TextBox2.Text);
        Response.Redirect("discount.aspx");
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedItem.Text == "Select")
        {
            msg.Show("Select category");

        }
        else
        {
            DataSet ds = ad.getproductbycatadmin(Convert.ToInt32( DropDownList1.SelectedItem.Value));
            if (ds.Tables[0].Rows.Count == 0)
            {
                DropDownList2.Items.Clear();
            }
            else
            {
                DropDownList2.DataSource = ds;
                DropDownList2.DataTextField = ds.Tables[0].Columns["pname"].ToString();
                DropDownList2.DataValueField = ds.Tables[0].Columns["id"].ToString();
                DropDownList2.DataBind();
                DropDownList2.Items.Insert(0, "Select");

            }
        }

    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
        ad.deletediscount(id);
        fillgrid();
        msg.Show("Discount deleted successfully");
    }
}

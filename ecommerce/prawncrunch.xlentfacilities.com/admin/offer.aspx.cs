﻿using System;
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
public partial class admin_offer : System.Web.UI.Page
{
    admin ad = new admin();
    MessageBox msg = new MessageBox();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            fillgrid();
            if (Request.QueryString["id"] != null)
            {
                Button1.Visible = false;
                Button2.Visible = true;
                edits();
            }
            else
            {
                Button2.Visible = false;
                Button1.Visible = true;

            }
        }

    }
    public void edits()
    {
        int id = Convert.ToInt32(Request.QueryString["id"]);
        DataSet ds = ad.getofferbyid(id);
        if (ds.Tables[0].Rows.Count == 0)
        {
        }
        else
        {
            TextBox1.Text = ds.Tables[0].Rows[0]["subject"].ToString();
            FCKeditor1.Value = Server.HtmlDecode(ds.Tables[0].Rows[0]["description"].ToString());
            Button1.Visible = false;
            Button2.Visible = true;
        }
    }
    public void fillgrid()
    {
        DataSet ds = ad.getoffers();
        if (ds.Tables[0].Rows.Count == 0)
        {
            Label1.Visible = true;
            GridView1.Visible = false;
        }
        else
        {
            Label1.Visible = false;
            GridView1.Visible = true;
            GridView1.DataSource = ds; GridView1.DataBind();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        string sub = TextBox1.Text;
        string desc = Server.HtmlEncode(FCKeditor1.Value);
        ad.addoffer(sub, desc);
        TextBox1.Text = "";
        FCKeditor1.Value = "";


        fillgrid();
        msg.Show("Offer added successfully");

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        int id = Convert.ToInt32(Request.QueryString["id"]);
        string sub = TextBox1.Text;
        string desc = Server.HtmlEncode(FCKeditor1.Value);
        ad.updateoffer(id, sub, desc);
        TextBox1.Text = "";
        FCKeditor1.Value = "";

        Button2.Visible = false;
        Button1.Visible = true;

        fillgrid();
        msg.Show("Offer updated successfully");
        Response.Redirect("offer.aspx");
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        fillgrid();
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
        ad.deleteoffer(id);
        fillgrid();
        msg.Show("Offer deleted successfully");
    }
}

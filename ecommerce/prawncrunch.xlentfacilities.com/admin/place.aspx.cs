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

public partial class admin_place : System.Web.UI.Page
{
    admin ad = new admin();
    MessageBox msg = new MessageBox();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            fillgrid();
          fillcategory();




          Button1.Visible = true;
         Button2.Visible = false;
        
   

          if (Request.QueryString["id"] != null)
          {
              Button1.Visible = false;
              Button2.Visible = true;
        
              edits();
          }
          else
          {
              Button1.Visible = true;
              Button2.Visible = false;
        
          }
        }
    }

    public void edits()
    {
        int id = Convert.ToInt32(Request.QueryString["id"]);
        DataSet ds = ad.getplacebyid(id);
        if (ds.Tables[0].Rows.Count == 0)
        {
        }
        else
        {
            string cat = ds.Tables[0].Rows[0]["category"].ToString();
            string city = ds.Tables[0].Rows[0]["city"].ToString();
          
            string price = ds.Tables[0].Rows[0]["price"].ToString();
            TextBox1.Text = price;
           
            for (int i = 0; i < DropDownList2.Items.Count; i++)
            {
                if (DropDownList2.Items[i].Value == cat)
                {
                    DropDownList2.Items[i].Selected = true;
                }
            }

            //for (int z = 0; z < DropDownList4.Items.Count; z++)
            //{
            //    if (DropDownList4.Items[z].Text == placename)
            //    {
            //        DropDownList4.Items[z].Selected = true;
            //    }
            //}
            DataSet ds1 = ad.getproductbycatadmin( Convert.ToInt32( cat));
            DropDownList3.DataSource = ds1;
            DropDownList3.DataTextField = ds1.Tables[0].Columns["pname"].ToString();
            DropDownList3.DataValueField = ds1.Tables[0].Columns["id"].ToString();
            DropDownList3.DataBind();
            DropDownList3.Items.Insert(0, "Select");

            string prod = ds.Tables[0].Rows[0]["product"].ToString();
            for (int j = 0; j < DropDownList3.Items.Count; j++)
            {
                if (DropDownList3.Items[j].Value == prod)
                {
                    DropDownList3.Items[j].Selected = true;
                }
            }


            for (int z = 0; z < DropDownList1.Items.Count; z++)
            {
                if (DropDownList1.Items[z].Text == city)
                {
                    DropDownList1.Items[z].Selected = true;
                }
            }
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
            DropDownList2.DataSource = ds;
            DropDownList2.DataTextField = ds.Tables[0].Columns["categoryname"].ToString();
            DropDownList2.DataValueField = ds.Tables[0].Columns["id"].ToString();
            DropDownList2.DataBind();
            DropDownList2.Items.Insert(0, "Select");
        }
    }
    public void fillgrid()
    {
        DataSet ds = ad.getplace();
        if (ds.Tables[0].Rows.Count == 0)
        {
            GridView1.Visible = false;
            Label1.Visible = true;
            Label1.Text = "No place added yet";
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
        if (DropDownList3.SelectedItem.Text == "Select" || DropDownList3.SelectedItem.Text == "")
        {
            msg.Show("Select product");
        }
        else
        {


            string d = Convert.ToString(DropDownList1.SelectedItem.Value.ToString());
            int cat = Convert.ToInt32(DropDownList2.SelectedItem.Value);
            int prod = Convert.ToInt32(DropDownList3.SelectedItem.Value);
            DropDownList1.SelectedIndex = 0;
            DropDownList2.SelectedIndex = 0;
            DropDownList3.SelectedIndex = 0;

            DataTable ds = ad.checkplacess(d,  cat, prod);

            if (ds.Rows.Count == 0)
            {
                ad.addplace(d, TextBox1.Text, cat, prod);
                msg.Show("Price and place added successfully");
                //DropDownList4.SelectedIndex = 0;
                fillgrid();
            }
            else
            {
                msg.Show("Price has been already added");
            }
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

        ad.delplace(id);
        msg.Show("Place deleted successfully");
        fillgrid();
      
    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDownList2.SelectedItem.Value == "Select")
        {
            msg.Show("Select Category");
                
        }
        else
        {

            int id = Convert.ToInt32(DropDownList2.SelectedItem.Value);
            DataSet ds = ad.getproductbycatadmin(id);
            if (ds.Tables[0].Rows.Count == 0)
            {
                DropDownList3.Items.Clear();
            }
            else
            {
                DropDownList3.DataSource = ds;
                DropDownList3.DataTextField = ds.Tables[0].Columns["pname"].ToString();
                DropDownList3.DataValueField = ds.Tables[0].Columns["id"].ToString();
                DropDownList3.DataBind();
                DropDownList3.Items.Insert(0, "Select");
            }
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        int id = Convert.ToInt32(Request.QueryString["id"]);
        int cat = Convert.ToInt32(DropDownList2.SelectedItem.Value);
        int product = Convert.ToInt32(DropDownList3.SelectedItem.Value);
        string city = Convert.ToString(DropDownList1.SelectedItem.Value);
     
      
        string price = TextBox1.Text;
        ad.updateplace(id, cat, product, city, price);
        Response.Redirect("place.aspx");
    }
    
}

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

public partial class admin_product : System.Web.UI.Page
{
    admin ad = new admin();
    MessageBox msg = new MessageBox();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            fillgrid();
            filldropdown();
            Submit.Visible = true;
            btnupdate.Visible = false;
            Image2.Visible = false;
            fillgrid();

            if (Request.QueryString["id"] != null)
            {
                Submit.Visible = false;
                btnupdate.Visible = true;
                Image2.Visible = true;
                edits();
            }
            else
            {
                Submit.Visible = true;
                btnupdate.Visible = false;
                Image2.Visible = false;
            }

        }

    }
    public void edits()
    {
        string id = Convert.ToString(Request.QueryString["id"]);
        DataSet ds = ad.getproductbyid(id);
        if (ds.Tables[0].Rows.Count == 0)
        {
        }
        else
        {
            TextBox1.Text = ds.Tables[0].Rows[0]["pname"].ToString();
            fck1.Value = Server.HtmlDecode(ds.Tables[0].Rows[0]["description"].ToString());
            Image2.ImageUrl = ds.Tables[0].Rows[0]["pimage"].ToString();

            string cat = ds.Tables[0].Rows[0]["category"].ToString();

            for (int i = 0; i < DropDownList1.Items.Count; i++)
            {
                if (DropDownList1.Items[i].Value == cat)
                {
                    DropDownList1.Items[i].Selected = true;
                }
            }
        }
    }
    public void fillgrid()
    {
        DataSet ds = ad.getproduct();
        if (ds.Tables[0].Rows.Count == 0)
        {
            GridView1.Visible = false;
            Label1.Visible = true;
            Label1.Text = "No product added yet";
        }
        else
        {
            Label1.Visible = false;
            GridView1.Visible = true;
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
    }
    public void filldropdown()
    {
        DataSet ds = ad.getcategory();
        if (ds.Tables[0].Rows.Count == 0)
        {

            DropDownList1.Enabled = false;

        }
        else
        {

            DropDownList1.Enabled = true;
            DropDownList1.DataSource = ds;
            DropDownList1.DataTextField = ds.Tables[0].Columns["categoryname"].ToString();
            DropDownList1.DataValueField = ds.Tables[0].Columns["id"].ToString();

            DropDownList1.DataBind(); 
            DropDownList1.Items.Insert(0, "Select");
        }


    }
    protected void GridView1_PageIndexChanging1(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        fillgrid();
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);

        ad.delproduct(id);
        msg.Show("Product deleted successfully");
        fillgrid();

    }
    protected void Submit_Click(object sender, EventArgs e)
    {
        int cat = Convert.ToInt32(DropDownList1.SelectedItem.Value.ToString());
        string pname = TextBox1.Text;
     

       
        int flag1 = 0;


        string UniqueName = (DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString());
        string ImageFile1 = string.Empty;
        if (FileUpload1.PostedFile.ContentLength > 0)
        {
            string temp = System.IO.Path.GetExtension(FileUpload1.PostedFile.FileName);
            if (temp == ".jpeg" || temp == ".JPEG" || temp == ".jpg" || temp == ".JPG" || temp == ".png" || temp == ".PNG" || temp == ".bmp" || temp == ".BMP" || temp == ".gif" || temp == ".GIF" || temp == ".wmf" || temp == ".WMF")
            {


                string z;
                string x = Server.MapPath("~\\uploads") + "\\";
                string s = System.IO.Path.GetFileName(FileUpload1.PostedFile.FileName);
                string[] words = s.Split('.');
                z = x + UniqueName + s;//file extension
                FileUpload1.PostedFile.SaveAs(z);
                string urldet = "~\\" + "uploads" + "\\" + UniqueName + s;
                ImageFile1 = urldet.Replace("\\", "/");
                flag1 = 1;
            }
            else
            {
                msg.Show("Upload proper image file");
            }


        }
        string desc = Server.HtmlEncode(fck1.Value);
        if (flag1 == 1)
        {
            ad.addproduct( cat,pname,ImageFile1,desc);
            msg.Show("Product added successfully");
            fillgrid();
            DropDownList1.SelectedIndex = 0;
            TextBox1.Text = "";
            fck1.Value = "";
        }
        else
        {
            msg.Show("Product image required");
        }
    }
    protected void btnupdate_Click(object sender, EventArgs e)
    {
        int id = Convert.ToInt32( Request.QueryString["id"]);
       
        string UniqueName = (DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString());
        string ImageFile1 = string.Empty;
        if (FileUpload1.PostedFile.ContentLength > 0)
        {
            string temp = System.IO.Path.GetExtension(FileUpload1.PostedFile.FileName);
            if (temp == ".jpeg" || temp == ".JPEG" || temp == ".jpg" || temp == ".JPG" || temp == ".png" || temp == ".PNG" || temp == ".bmp" || temp == ".BMP" || temp == ".gif" || temp == ".GIF" || temp == ".wmf" || temp == ".WMF")
            {


                string z;
                string x = Server.MapPath("~\\uploads") + "\\";
                string s = System.IO.Path.GetFileName(FileUpload1.PostedFile.FileName);
                string[] words = s.Split('.');
                z = x + UniqueName + s;//file extension
                FileUpload1.PostedFile.SaveAs(z);
                string urldet = "~\\" + "uploads" + "\\" + UniqueName + s;
                ImageFile1 = urldet.Replace("\\", "/");


                ad.updateproduct(id , Convert.ToInt32( DropDownList1.SelectedItem.Value), TextBox1.Text, ImageFile1, Server.HtmlEncode(fck1.Value));
                Response.Redirect("product.aspx");
            }
            else
            {
                msg.Show("Upload proper image file");
            }


        }
        else
        {
            ad.updateproductwithoutimage(id, Convert.ToInt32(DropDownList1.SelectedItem.Value), TextBox1.Text, Server.HtmlEncode(fck1.Value));
            Response.Redirect("product.aspx");
        }
    }
}

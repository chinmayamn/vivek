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

public partial class admin_category : System.Web.UI.Page
{
    admin ad = new admin();
    MessageBox msg = new MessageBox();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
          Submit.Visible=true;
            btnupdate.Visible=false;
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
        DataSet ds = ad.getcategorybyid(id);
        if (ds.Tables[0].Rows.Count == 0)
        {
        }
        else
        {
            TextBox3.Text = ds.Tables[0].Rows[0]["categoryname"].ToString();
            Image2.ImageUrl = ds.Tables[0].Rows[0]["categoryimage"].ToString();
        }
    }
    public void fillgrid()
    {
        DataSet ds = ad.getcategory();
        if (ds.Tables[0].Rows.Count == 0)
        {
            GridView1.Visible = false;
            Label1.Visible = true;
            Label1.Text = "No category created yet";
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

        DataSet ds = ad.checkforproducts(id);

        if (ds.Tables[0].Rows.Count == 0)
        {
        ad.delcategory(id);
            msg.Show("Category deleted successfully");
            fillgrid();
        }
        else
        {
            msg.Show("Delete products under this category first");
        }

    }
    protected void Submit_Click(object sender, EventArgs e)
    {
        string name = TextBox3.Text;
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
        if (flag1 == 1)
        {
            ad.addcategory(name, ImageFile1);
            msg.Show("Category created successfully");
            fillgrid();
            TextBox3.Text = "";
        }
        else
        {
            msg.Show("Category image required");
        }
    }
    protected void btnupdate_Click(object sender, EventArgs e)
    {
        string id = Request.QueryString["id"].ToString();
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
                ad.updatecategory(id, TextBox3.Text, ImageFile1);
                Response.Redirect("category.aspx");
            }
            else
            {
                msg.Show("Upload proper image file");
            }
        }
        else
        {
            ad.updatecategorywithoutimage(id, TextBox3.Text);
            Response.Redirect("category.aspx");
        }

     
       
    }
    protected void GridView1_PageIndexChanging1(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        fillgrid();
    }
   
}

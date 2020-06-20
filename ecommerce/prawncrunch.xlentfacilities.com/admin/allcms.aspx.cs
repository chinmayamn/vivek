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
public partial class admin_allcms : System.Web.UI.Page
{
    admin ad = new admin();
    MessageBox msg = new MessageBox();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Button1.Visible = true;
            Button2.Visible = false;
        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string name = DropDownList1.SelectedItem.Value.ToString();

        if (name == "Select")
        {
            msg.Show("Select type");
        }
        else
        {

            DataSet ds = ad.checkfortype(name);
            if (ds.Tables[0].Rows.Count == 0)
            {
                Button1.Visible = true;
                Button2.Visible = false;
                FCKeditor1.Value = "";
            }
            else
            {

                Button1.Visible = false;
                Button2.Visible = true;
                FCKeditor1.Value = Server.HtmlDecode(ds.Tables[0].Rows[0]["contents"].ToString());

            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string type = DropDownList1.SelectedItem.Value.ToString();
        if (type == "Select")
        {
            msg.Show("Select page");
        }
        else
        {
            string content = Server.HtmlEncode(FCKeditor1.Value);
            ad.insertcontent(type, content);
            msg.Show("Content added successfully");
            DropDownList1.SelectedIndex = 0;
            FCKeditor1.Value = "";
            Button1.Visible = true;
            Button2.Visible = false;
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        string type = DropDownList1.SelectedItem.Value.ToString();
        string content = Server.HtmlEncode(FCKeditor1.Value);
        ad.updatecontent(type, content);
        msg.Show("Content updated successfully");
        DropDownList1.SelectedIndex = 0;
        FCKeditor1.Value = "";
        Button1.Visible = true;
        Button2.Visible = false;
    }
}
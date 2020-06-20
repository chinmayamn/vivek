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

public partial class admin_adminlogin : System.Web.UI.Page
{
    MessageBox msg = new MessageBox();

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string username = TextBox1.Text;
        string password = TextBox2.Text;

        if (username == "admin" && password == "admin@123")
        {
            Session["pwd"] = TextBox2.Text;
            Session["name"] = TextBox1.Text;
            Response.Redirect("cms.aspx");
        }
        else
        {
            msg.Show("Enter correct username and password");
        }


    }
}

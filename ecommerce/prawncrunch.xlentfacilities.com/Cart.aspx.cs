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

public partial class cart : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
      //  cart.gdhandler += new carting.GridViewDeleteEventHandler(carts_gdhandler);
      //  carts.gdhandler += new newcart.GridViewDeleteEventHandler(carts_gdhandler);
       // carts.gdhandler += new carting.GridViewDeleteEventHandler(carts_gdhandler);
    }

    public void carts_gdhandler(string value)
    {
       
        user ms = (user)Page.Master;
        ms.total();
    }

    

}

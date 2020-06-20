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
using System.Net.Mail;
public partial class admin_view_orders : System.Web.UI.Page
{
    MessageBox msg = new MessageBox();
    revieworder ro = new revieworder();
    sms s = new sms();
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Visible = false;
        if (!Page.IsPostBack)
        {
            if (Request.QueryString["orders_id"] != null)
            {
                fillgrid();
                fillorderstatusgrid();
                fillgridproduct();
            }
        }


    }

    private void fillgridproduct()
    {
        int id = Convert.ToInt32(Request.QueryString["orders_id"]);
        DataTable dt = ro.fillproduct(id);
        GridView2.DataSource = dt;
        GridView2.DataBind();
    }
    public void fillgrid()
    {
        int id = Convert.ToInt32(Request.QueryString["orders_id"]);
        DataTable dt = ro.fillorderbyid(id);

        //customer address
        lblname.Text = dt.Rows[0][2].ToString();
        lbladdress.Text = dt.Rows[0][4].ToString();
        lblcity.Text = dt.Rows[0][5].ToString();
        lblregion.Text = dt.Rows[0][6].ToString();
        lblpostalcode.Text = dt.Rows[0][7].ToString();
        lblcountry.Text = dt.Rows[0][8].ToString();
  
        Label2.Text = dt.Rows[0]["state"].ToString();
 
       

        //shipping address

        lbldeliveryname.Text = dt.Rows[0]["delivery_firstname"].ToString();
        
        Label4.Text = dt.Rows[0]["delivery_email"].ToString();
        Label5.Text = dt.Rows[0]["delivery_phone"].ToString();
        Label6.Text = dt.Rows[0]["delivery_mobile"].ToString();

        lbldeliveryaddress.Text = dt.Rows[0]["delivery_address"].ToString();
        lbldeliverycity.Text = dt.Rows[0]["delivery_city"].ToString();
        lbldeliveryregion.Text = dt.Rows[0]["delivery_state"].ToString();
      
        


        //billing address
        lblname3.Text = dt.Rows[0]["firstname"].ToString();
      
        Label8.Text = dt.Rows[0]["email"].ToString();
        Label9.Text = dt.Rows[0]["phone"].ToString();
        Label10.Text = dt.Rows[0]["mobile"].ToString();
        lbladdress3.Text = dt.Rows[0]["address"].ToString();
        lblcity3.Text = dt.Rows[0]["city"].ToString();
        lblregion3.Text = dt.Rows[0]["state"].ToString();
     
        

    }
    public void fillorderstatusgrid()
    {
        int id = Convert.ToInt32(Request.QueryString["orders_id"]);
        DataSet ds = ro.fillorderstatus(id);
        if (ds.Tables[0].Rows.Count == 0)
        {
            Label1.Visible = true;
            Label1.Text = "No summary added yet";
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

    protected void Button1_Click(object sender, EventArgs e)
    {
        string id = Request.QueryString["orders_id"].ToString();
        DataTable dt = ro.select_order_prod_by_order_id(id);

        string comment = txtcomment.Text;
        string status = ddlstatus.SelectedItem.Text.ToString();

        //updating status in orders table
        int i = Convert.ToInt32(id);
        ro.updateorderstatus(i, status);

        //updating status in order summary table

        DataTable dt1 = ro.fillorderbyid(i);
        string tempid = dt1.Rows[0]["id"].ToString();
        string cdate = dt1.Rows[0]["date"].ToString();
        string email = dt1.Rows[0]["email"].ToString();
        string mobile = dt1.Rows[0]["mobile"].ToString();

        string mobtemp = "Dear Customer your prawns order bearning no:" + tempid + " is in " + status + " status";

        s.SendSMS(mobile, mobtemp);


        //notify value
        if (CheckBox_notify.Checked == true)
        {

            ro.updateordersummary(i, cdate, status, comment);
            fillorderstatusgrid();
            txtcomment.Text = "";
          
            //append comment to mail                    
            if (Check_comment.Checked == true)
            {
                try
                {


                    string mto = email;
                    string mFrom = "sales@freshprawnsonline.com";

                    if (mto != "" && mFrom != "")
                    {

                        MailMessage message = new MailMessage();
                        message.From = new MailAddress(mFrom);
                        message.To.Add(mto);
                        message.IsBodyHtml = true;


                        string temp = "Dear Customer your prawn crunch order bearning no:" + tempid + " is in " + status + " status" + "<br>" + "Comments are as follows :" + comment;
                        message.Body = temp;
                        message.Subject = "Order Status";

                        SmtpClient smtp = new SmtpClient("localhost", 25);

                        smtp.Send(message);
                        message.Dispose();

                        MessageBox msg1 = new MessageBox();
                        msg1.Show("Mail has been sent successfully");


                    }

                    else
                    {
                        MessageBox msg2 = new MessageBox();
                        msg2.Show("Send feed back again after some time");

                    }

                }

                catch (Exception ex)
                {

                    MessageBox msg3 = new MessageBox();
                    msg3.Show(ex.ToString());

                }
            }


//dont append comment to mail

            else
            {
                try
                {


                    string mto = email;
                    string mFrom = "sales@freshprawnsonline.com";

                    if (mto != "" && mFrom != "")
                    {

                        MailMessage message = new MailMessage();
                        message.From = new MailAddress(mFrom);
                        message.To.Add(mto);
                        message.IsBodyHtml = true;


                        string temp = "Dear Customer your prawn crunch order bearning no:" + tempid + " is in " + status + " status";
                        message.Body = temp;
                        message.Subject = "Order Status";

                        SmtpClient smtp = new SmtpClient("localhost", 25);

                        smtp.Send(message);
                        message.Dispose();

                        MessageBox msg1 = new MessageBox();
                        msg1.Show("Mail has been sent successfully");


                    }

                    else
                    {
                        MessageBox msg2 = new MessageBox();
                        msg2.Show("Send feed back again after some time");

                    }

                }

                catch (Exception ex)
                {

                    MessageBox msg3 = new MessageBox();
                    msg3.Show(ex.ToString());

                }
            }

        }
        else
        {

            ro.updateordersummary(i, cdate, status, comment);
            fillorderstatusgrid();
            txtcomment.Text = "";
            msg.Show("Order Summary updated successfully");
        }
        fillorderstatusgrid();
    }
    protected void img_print_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("print-order.aspx?orders_id=" + Request.QueryString["orders_id"].ToString() + "");
    }
}

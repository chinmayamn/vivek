using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.Security;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Drawing.Text;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Data;
using System.Data.SqlClient;

using System.Web.Configuration;
using System.Configuration;

using System.Web.Profile;

public partial class myprofile : System.Web.UI.Page
{
    admin ad = new admin();
    MessageBox msg = new MessageBox();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            MembershipUser memb = Membership.GetUser(Profile.UserName);
            string userid = "";
            try
            {
                userid = memb.ProviderUserKey.ToString();
            }
            catch (Exception ex)
            {
                Response.Redirect("Login.aspx");
            }



            if (Request.QueryString["id"] != null)
            {
                ImageButton1.Visible = false;
                ImageButton2.Visible = true;

                TextBox3.ReadOnly = true;
                TextBox1.Visible = true;
             
                TextBox3.Visible = true;
                TextBox4.Visible = true;
                TextBox5.Visible = true;
                TextBox6.Visible = true;
                DropDownList1.Visible = true;
                TextBox8.Visible = true;
              
                Label1.Visible = false;
              
                Label3.Visible = false;
                Label4.Visible = false;
                Label5.Visible = false;
                Label6.Visible = false;
                Label7.Visible = false;
                Label8.Visible = false;
            
             
             



                MembershipUser mem = Membership.GetUser();

                string id = mem.UserName;
                MembershipUser u = Membership.GetUser(id);
                Guid a = new Guid(u.ProviderUserKey.ToString());
                string c = u.UserName.ToString();


               TextBox3.Text = u.Email.ToString();

                ProfileCommon comm = Profile.GetProfile(c);
                TextBox1.Text = comm.FirstName;
        
              TextBox6.Text = comm.Mobile;
               TextBox5.Text = comm.Phone;
                TextBox4.Text = comm.Address;
             string temper = comm.City;
             string tempers = comm.Place;
            
             for (int i = 0; i < DropDownList1.Items.Count; i++)
             {
                 if (DropDownList1.Items[i].Text == temper)
                 {
                     DropDownList1.Items[i].Selected = true;

                 }
             }
          

           
                TextBox8.Text = comm.State;
           
            }
            else
            {
                MembershipUser mem = Membership.GetUser();

                if (mem != null)
                {
                    ImageButton1.Visible = true;
                    ImageButton2.Visible = false;

                    TextBox1.Visible = false;
                  
                    TextBox3.Visible = false;
                    TextBox4.Visible = false;
                    TextBox5.Visible = false;
                    TextBox6.Visible = false;
                    DropDownList1.Visible = false;
                  
                  
                    TextBox8.Visible = false;
                 
                    Label1.Visible = true;
                 
                    Label3.Visible = true;
                    Label4.Visible = true;
                    Label5.Visible = true;
                    Label6.Visible = true;
                    Label7.Visible = true;
                    Label8.Visible = true;
              
                  



                    string id = mem.UserName;
                    MembershipUser u = Membership.GetUser(id);
                    Guid a = new Guid(u.ProviderUserKey.ToString());
                    string c = u.UserName.ToString();


                    Label3.Text = u.Email.ToString();

                    ProfileCommon comm = Profile.GetProfile(c);
                    Label1.Text = comm.FirstName;
                  
                    Label5.Text = comm.Mobile;
                    Label6.Text = comm.Phone;
                    Label4.Text = comm.Address;
                    Label7.Text = comm.City;
                    Label8.Text = comm.State;
                 
                    

                 

                 
                }
                else
                {
                    Response.Redirect("login.aspx");
                }

            }
        }
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
  MembershipUser mem = Membership.GetUser();

            string id = mem.UserName;
            Response.Redirect("myprofile.aspx?id=" + id);
    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
      


         
       
          Profile.FirstName = TextBox1.Text;
         
          Profile.Phone = TextBox5.Text;
          Profile.Mobile = TextBox6.Text;
          Profile.Address = TextBox4.Text;
          Profile.City = DropDownList1.SelectedItem.Text.ToString();
         
         
          Profile.State = TextBox8.Text;
          
          Profile.Save();
        

            Response.Redirect("myprofile.aspx");
    
    }
  
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Web;
using System.Data.SqlClient;
/// <summary>
/// Summary description for cms
/// </summary>
public class cms
{
    string str = ConfigurationManager.ConnectionStrings["prawncrunch"].ToString();
	public cms()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    //news cms
    public void addnews(string title, string content)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_addnews", con);
        cmd.CommandType = CommandType.StoredProcedure;
        con.Open();
        cmd.Parameters.AddWithValue("@title", title);
        cmd.Parameters.AddWithValue("@content", content);
        cmd.ExecuteNonQuery();
        con.Close();
    }
    public DataSet getnews()
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_getnews", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;

    }
    public void delnews(int id1)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_delnews", con);
        cmd.CommandType = CommandType.StoredProcedure;
        con.Open();
        cmd.Parameters.AddWithValue("@id1", id1);

        cmd.ExecuteNonQuery();
        con.Close();
    }
    public DataSet getnewsbyid(int id1)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_getnewsbyid", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id1", id1);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;

    }
    public void updatenews(int id1, string title1, string content1)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_updatenews", con);
        cmd.CommandType = CommandType.StoredProcedure;
        con.Open();
        cmd.Parameters.AddWithValue("@id1", id1);
        cmd.Parameters.AddWithValue("@title1", title1);
        cmd.Parameters.AddWithValue("@content1", content1);
        cmd.ExecuteNonQuery();
        con.Close();
    }

    //shipping information cms.


    public void addshippinginfo(string content)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_addshippinginfo", con);
        cmd.CommandType = CommandType.StoredProcedure;
        con.Open();
        cmd.Parameters.AddWithValue("@content", content);
        cmd.ExecuteNonQuery();
        con.Close();
    }
    public DataSet getshippinginfo()
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_getshippinginfo", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;

    }
    public void delshippinginfo(int id1)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_delshippinginfo", con);
        cmd.CommandType = CommandType.StoredProcedure;
        con.Open();
        cmd.Parameters.AddWithValue("@id1", id1);

        cmd.ExecuteNonQuery();
        con.Close();
    }
    public DataSet getshippinginfobyid(int id1)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_getshippinginfobyid", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id1", id1);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;

    }
    public void updateshippinginfo(int id1,string content)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_updateshippinginfo", con);
        cmd.CommandType = CommandType.StoredProcedure;
        con.Open();
        cmd.Parameters.AddWithValue("@id1", id1);
         cmd.Parameters.AddWithValue("@content", content);
        cmd.ExecuteNonQuery();
        con.Close();
    }

    //wish list cms


    public void addwishlist(string content)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_addwishlist", con);
        cmd.CommandType = CommandType.StoredProcedure;
        con.Open();
        cmd.Parameters.AddWithValue("@content", content);
        cmd.ExecuteNonQuery();
        con.Close();
    }
    public DataSet getwishlist()
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_getwishlist", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;

    }
    public void delwishlist(int id1)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_delwishlist", con);
        cmd.CommandType = CommandType.StoredProcedure;
        con.Open();
        cmd.Parameters.AddWithValue("@id1", id1);

        cmd.ExecuteNonQuery();
        con.Close();
    }
    public DataSet getwishlistbyid(int id1)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_getwishlistbyid", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id1", id1);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;

    }
    public void updatewishlist(int id1, string content)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_updatewishlist", con);
        cmd.CommandType = CommandType.StoredProcedure;
        con.Open();
        cmd.Parameters.AddWithValue("@id1", id1);
        cmd.Parameters.AddWithValue("@content", content);
        cmd.ExecuteNonQuery();
        con.Close();
    }

    //orderingsteps cms
    public void addorders(string contents)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_addorders", con);
        cmd.CommandType = CommandType.StoredProcedure;
        con.Open();
        cmd.Parameters.AddWithValue("@contents", contents);
        cmd.ExecuteNonQuery();
        con.Close();
    }
    public DataSet getorders()
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_getorders", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;

    }
    public void delorders(int id1)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_delorders", con);
        cmd.CommandType = CommandType.StoredProcedure;
        con.Open();
        cmd.Parameters.AddWithValue("@id1", id1);

        cmd.ExecuteNonQuery();
        con.Close();
    }
    public DataSet getordersbyid(int id1)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_getordersbyid", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id1", id1);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;

    }
    public void updateorders(int id1, string content)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_updateorders", con);
        cmd.CommandType = CommandType.StoredProcedure;
        con.Open();
        cmd.Parameters.AddWithValue("@id1", id1);
        cmd.Parameters.AddWithValue("@content", content);
        cmd.ExecuteNonQuery();
        con.Close();
    }

    //password recovery steps cms


    public void addrecoverpassword(string content)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_addrecoverpassword", con);
        cmd.CommandType = CommandType.StoredProcedure;
        con.Open();
        cmd.Parameters.AddWithValue("@content", content);
        cmd.ExecuteNonQuery();
        con.Close();
    }
    public DataSet getrecoverpassword()
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_getrecoverpassword", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;

    }
    public void delrecoverpassword(int id1)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_delrecoverpassword", con);
        cmd.CommandType = CommandType.StoredProcedure;
        con.Open();
        cmd.Parameters.AddWithValue("@id1", id1);

        cmd.ExecuteNonQuery();
        con.Close();
    }
    public DataSet getrecoverpasswordbyid(int id1)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_getrecoverpasswordbyid", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id1", id1);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;

    }
    public void updaterecoverpassword(int id1, string content)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_updaterecoverpassword", con);
        cmd.CommandType = CommandType.StoredProcedure;
        con.Open();
        cmd.Parameters.AddWithValue("@id1", id1);
        cmd.Parameters.AddWithValue("@content", content);
        cmd.ExecuteNonQuery();
        con.Close();
    }

    //privacy and security cms

    public void addsecurity(string content)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_addsecurity", con);
        cmd.CommandType = CommandType.StoredProcedure;
        con.Open();
        cmd.Parameters.AddWithValue("@content", content);
        cmd.ExecuteNonQuery();
        con.Close();
    }
    public DataSet getsecurity()
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_getsecurity", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;

    }
    public void delsecurity(int id1)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_delsecurity", con);
        cmd.CommandType = CommandType.StoredProcedure;
        con.Open();
        cmd.Parameters.AddWithValue("@id1", id1);

        cmd.ExecuteNonQuery();
        con.Close();
    }
    public DataSet getsecuritybyid(int id1)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_getsecuritybyid", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id1", id1);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;

    }
    public void updatesecurity(int id1, string content)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_updatesecurity", con);
        cmd.CommandType = CommandType.StoredProcedure;
        con.Open();
        cmd.Parameters.AddWithValue("@id1", id1);
        cmd.Parameters.AddWithValue("@content", content);
        cmd.ExecuteNonQuery();
        con.Close();
    }

    //payment method cms

    public void addpaymentmethod(string content)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_addpaymentmethod", con);
        cmd.CommandType = CommandType.StoredProcedure;
        con.Open();
        cmd.Parameters.AddWithValue("@content", content);
        cmd.ExecuteNonQuery();
        con.Close();
    }
    public DataSet getpaymentmethod()
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_getpaymentmethod", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;

    }
    public void delpaymentmethod(int id1)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_delpaymentmethod", con);
        cmd.CommandType = CommandType.StoredProcedure;
        con.Open();
        cmd.Parameters.AddWithValue("@id1", id1);

        cmd.ExecuteNonQuery();
        con.Close();
    }
    public DataSet getpaymentmethodbyid(int id1)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_getpaymentmethodbyid", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id1", id1);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;

    }
    public void updatepaymentmethod(int id1, string content)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_updatepaymentmethod", con);
        cmd.CommandType = CommandType.StoredProcedure;
        con.Open();
        cmd.Parameters.AddWithValue("@id1", id1);
        cmd.Parameters.AddWithValue("@content", content);
        cmd.ExecuteNonQuery();
        con.Close();
    }

    //tax information cms
    public void addtaxinformation(string content)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_addtaxinformation", con);
        cmd.CommandType = CommandType.StoredProcedure;
        con.Open();
        cmd.Parameters.AddWithValue("@content", content);
        cmd.ExecuteNonQuery();
        con.Close();
    }
    public DataSet gettaxinformation()
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_gettaxinformation", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;

    }
    public void deltaxinformation(int id1)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_deltaxinformation", con);
        cmd.CommandType = CommandType.StoredProcedure;
        con.Open();
        cmd.Parameters.AddWithValue("@id1", id1);

        cmd.ExecuteNonQuery();
        con.Close();
    }
    public DataSet gettaxinformationbyid(int id1)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_gettaxinformationbyid", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id1", id1);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;

    }
    public void updatetaxinformation(int id1, string content)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_updatetaxinformation", con);
        cmd.CommandType = CommandType.StoredProcedure;
        con.Open();
        cmd.Parameters.AddWithValue("@id1", id1);
        cmd.Parameters.AddWithValue("@content", content);
        cmd.ExecuteNonQuery();
        con.Close();
    }
    //about us cms

    public void addaboutus(string content)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_addaboutus", con);
        cmd.CommandType = CommandType.StoredProcedure;
        con.Open();
        cmd.Parameters.AddWithValue("@content", content);
        cmd.ExecuteNonQuery();
        con.Close();
    }
    public DataSet getaboutus()
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_getaboutus", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;

    }
    public void delaboutus(int param)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_delaboutus", con);
        cmd.CommandType = CommandType.StoredProcedure;
        con.Open();
        cmd.Parameters.AddWithValue("@param",param);

        cmd.ExecuteNonQuery();
        con.Close();
    }
    public DataSet getaboutusbyid(int param)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_getaboutusbyid", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@param", param);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;

    }
    public void updateaboutus(int param, string content)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_updateaboutus", con);
        cmd.CommandType = CommandType.StoredProcedure;
        con.Open();
        cmd.Parameters.AddWithValue("@param", param);
        cmd.Parameters.AddWithValue("@content", content);
        cmd.ExecuteNonQuery();
        con.Close();
    }

    //contact us cms
    public void addcontactus(string content)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_addcontactus", con);
        cmd.CommandType = CommandType.StoredProcedure;
        con.Open();
        cmd.Parameters.AddWithValue("@content", content);
        cmd.ExecuteNonQuery();
        con.Close();
    }
    public DataSet getcontactus()
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_getcontactus", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;

    }
    public void delcontactus(int param)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_delcontactus", con);
        cmd.CommandType = CommandType.StoredProcedure;
        con.Open();
        cmd.Parameters.AddWithValue("@param", param);

        cmd.ExecuteNonQuery();
        con.Close();
    }
    public DataSet getcontactusbyid(int param)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_getcontactusbyid", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@param",param);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;

    }
    public void updatecontactus(int param, string content)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_updatecontactus", con);
        cmd.CommandType = CommandType.StoredProcedure;
        con.Open();
        cmd.Parameters.AddWithValue("@param", param);
        cmd.Parameters.AddWithValue("@content", content);
        cmd.ExecuteNonQuery();
        con.Close();
    }
    //delivery
    public void adddelivery(string content)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_adddelivery", con);
        cmd.CommandType = CommandType.StoredProcedure;
        con.Open();
        cmd.Parameters.AddWithValue("@content", content);
        cmd.ExecuteNonQuery();
        con.Close();
    }
    public DataSet getdelivery()
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_getdelivery", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;

    }
    public void deldelivery(int param)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_deldelivery", con);
        cmd.CommandType = CommandType.StoredProcedure;
        con.Open();
        cmd.Parameters.AddWithValue("@param", param);

        cmd.ExecuteNonQuery();
        con.Close();
    }
    public DataSet getdeliverybyid(int param)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_getdeliverybyid", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@param", param);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;

    }
    public void updatedelivery(int param, string content)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_updatedelivery", con);
        cmd.CommandType = CommandType.StoredProcedure;
        con.Open();
        cmd.Parameters.AddWithValue("@param", param);
        cmd.Parameters.AddWithValue("@content", content);
        cmd.ExecuteNonQuery();
        con.Close();
    }
    public DataSet getdeliveryforuser()
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_getdeliveryforuser", con);
        cmd.CommandType = CommandType.StoredProcedure;
    
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
    //return policy
    public void addreturnpolicy(string content)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_addreturnpolicy", con);
        cmd.CommandType = CommandType.StoredProcedure;
        con.Open();
        cmd.Parameters.AddWithValue("@content", content);
        cmd.ExecuteNonQuery();
        con.Close();
    }
    public DataSet getreturnpolicy()
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_getreturnpolicy", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;

    }
    public void delreturnpolicy(int id1)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_delreturnpolicy", con);
        cmd.CommandType = CommandType.StoredProcedure;
        con.Open();
        cmd.Parameters.AddWithValue("@id1", id1);

        cmd.ExecuteNonQuery();
        con.Close();
    }
    public DataSet getreturnpolicybyid(int id1)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_getreturnpolicybyid", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id1", id1);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;

    }
    public void updatereturnpolicy(int id1, string content)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_updatereturnpolicy", con);
        cmd.CommandType = CommandType.StoredProcedure;
        con.Open();
        cmd.Parameters.AddWithValue("@id1", id1);
        cmd.Parameters.AddWithValue("@content", content);
        cmd.ExecuteNonQuery();
        con.Close();
    }
    // user shipping information
    public DataSet usershippinginfo()
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_usershippinginfo", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
   }
    //user wish list
    public DataSet userwishlist()
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_userwishlist", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
    //user ordering steps
    public DataSet userorderingsteps()
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_userorderingsteps", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
    //user recover password
    public DataSet userrecoverpassword()
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_userrecoverpassword", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
    //user privacy
    public DataSet userprivacy()
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_userprivacy", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
    //user payment methods
    public DataSet userpaymentmethod()
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_userpaymentmethod", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
    //user tax information
    public DataSet usertaxinformation()
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_usertaxinformation", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
    //user about us
    public DataSet useraboutus()
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_useraboutus", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter da = new SqlDataAdapter(cmd);
         DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
    //user contact us
    public DataSet usercontactus()
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_usercontactus", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
    //user return policy
    public DataSet userreturnpolicy()
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_userreturnpolicy", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }


    //user news 
    public DataSet usergetnews()
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_usergetnews", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
    public DataSet news_for_user(int id1)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_news_for_user", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id1", id1);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
    public DataSet user_all_news()
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_user_all_news", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }

    public DataSet user_all_news1(int id1)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_user_all_news1", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id1", id1);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }


    //check newsletters
    public DataSet checknewsletters(string email)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_checknewsletters", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@email",email);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
    //add newsletters
    public void addnewsletters(string email)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_addnewsletters", con);
        cmd.CommandType = CommandType.StoredProcedure;
        con.Open();
        cmd.Parameters.AddWithValue("@email", email);

        cmd.ExecuteNonQuery();
        con.Close();
    }
    //mail order catalogue
    public void addmailorder(string name, string email, string message)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_addmailorder", con);
        cmd.CommandType = CommandType.StoredProcedure;
        con.Open();
        cmd.Parameters.AddWithValue("@name1", name);
        cmd.Parameters.AddWithValue("@email1", email);
        cmd.Parameters.AddWithValue("@message1", message);
        cmd.ExecuteNonQuery();
        con.Close();
    }
}

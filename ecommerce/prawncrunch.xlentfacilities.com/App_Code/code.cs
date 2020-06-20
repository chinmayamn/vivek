using System;
using System.Collections.Generic;
//////using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
/// <summary>
/// Summary description for code
/// </summary>
public class code
{
    string str = ConfigurationManager.ConnectionStrings["conn"].ToString();
	public code()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public DataTable  fillgrid()
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("SP_selectcategory", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter ad = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        ad.Fill(dt);
        return dt;
    }

    public DataTable fillgrid2()
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("SP_selecttop8category", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter ad = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        ad.Fill(dt);
        return dt;
    }


    public DataTable fillproduct(int i)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("SP_selecttop9product", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter ad = new SqlDataAdapter(cmd);
        cmd.Parameters.AddWithValue("@cat", i);
        DataTable dt = new DataTable();
        ad.Fill(dt);
        return dt;
    }
    public DataTable searchproduct(int cat, string keywords)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_searchproducts", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@cat", cat);
        cmd.Parameters.AddWithValue("@key", keywords);
        SqlDataAdapter ad = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        ad.Fill(dt);
        return dt;
    }

    public DataTable searchproductbylatest()
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("searchproductbylatest", con);
        cmd.CommandType = CommandType.StoredProcedure;
        //cmd.Parameters.AddWithValue("@id", p);
        SqlDataAdapter ad = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        ad.Fill(dt);
        return dt;
    }

    public DataTable fillproductcat(string cat)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("SP_selecttop9productcat", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@cat1", cat);
        SqlDataAdapter ad = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        ad.Fill(dt);
        return dt;
    }

    public DataTable searchproductbyid(string p)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("searchproductbyid", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", p);
        SqlDataAdapter ad = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        ad.Fill(dt);
        return dt;
    }

    public DataTable getproductdetailbyid(int p,string c1)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("SP_getproductdetailbyid", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", p);
        cmd.Parameters.AddWithValue("@city1", c1);
      
        SqlDataAdapter ad = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        ad.Fill(dt);
        return dt;
    }

    public DataTable getcity(string  p)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("getcity", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", p);
        SqlDataAdapter ad = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        ad.Fill(dt);
        return dt;
    }

    public DataTable fillproductwishlist(int p)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_selectwishlist", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", p);
        SqlDataAdapter ad = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        ad.Fill(dt);
        return dt;
    }

    public DataTable getwishlist(string p)
    {
        throw new NotImplementedException();
    }

    public DataTable getuserwishlist(string username)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_selectuserwishlist", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", username);
        SqlDataAdapter ad = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        ad.Fill(dt);
        return dt;
    }

    public int deletewishlist(int p)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_deletewishlist", con);
        cmd.CommandType = CommandType.StoredProcedure;
       cmd.Parameters.AddWithValue("@id", p);
       con.Open();
       int i = cmd.ExecuteNonQuery();
       con.Close();
       return i;
    }

    public int deletewishlis(int p, string username)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_deletewishlist", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", username);
        cmd.Parameters.AddWithValue("@pid", p);
        con.Open();
        int i = cmd.ExecuteNonQuery();
        con.Close();
        return i;
    }
    public DataTable getcatname(int p)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_getcatname", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", p);
        SqlDataAdapter ad = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        ad.Fill(dt);
        return dt;
    }

    public DataTable getdefaultcatname()
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_getdefaultcatname", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter ad = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        ad.Fill(dt);
        return dt;
    }

    public int getcount(int i2)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_getcount", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id",i2);
        con.Open();
      int i=Convert.ToInt32(cmd.ExecuteScalar());

        return i;
    }


    public DataTable select_specialoffer()
    {
        SqlConnection con = new SqlConnection(str);
        // con.Open();
        SqlCommand cmd = new SqlCommand("select_specialoffer1", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable ds = new DataTable();
        da.Fill(ds);
        // cmd.ExecuteReader();
        return ds;
    }

    public int insertwishlist(int p, string userid)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_insertwishlist", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", p);
        cmd.Parameters.AddWithValue("@userid", userid);
        con.Open();
        int i =cmd.ExecuteNonQuery();

        return i;
    }

    public DataTable getorderhistory(string userid)
    {
        SqlConnection con = new SqlConnection(str);
        // con.Open();
        SqlCommand cmd = new SqlCommand("sp_getorderhistory", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@user_id", userid);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable ds = new DataTable();
        da.Fill(ds);
        // cmd.ExecuteReader();
        return ds;
    }

    public DataTable getvideo(int vid)
    {
        SqlConnection con = new SqlConnection(str);
      
        SqlCommand cmd = new SqlCommand("sp_getvideo", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", vid);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable ds = new DataTable();
        da.Fill(ds);
        // cmd.ExecuteReader();
        return ds;
    }

    public DataTable getallvideo()
    {
        SqlConnection con = new SqlConnection(str);

        SqlCommand cmd = new SqlCommand("sp_getallvideo", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable ds = new DataTable();
        da.Fill(ds);
        // cmd.ExecuteReader();
        return ds;
    }

    public void deletevideobyid(int id)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_deletevideobyid", con);
        cmd.CommandType=CommandType.StoredProcedure;
        con.Open();
        cmd.Parameters.AddWithValue("@id",id);
        cmd.ExecuteNonQuery();
        con.Close();

    }
    public int insertvideo(string p, string ImageFile, string p_3)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_insertvideo", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@title", p);
        cmd.Parameters.AddWithValue("@image", ImageFile);
        cmd.Parameters.AddWithValue("@vid",p_3);
        con.Open();
        int i = cmd.ExecuteNonQuery();

        return i;
    }

    public DataTable getwishlist()
    {
        SqlConnection con = new SqlConnection(str);

        SqlCommand cmd = new SqlCommand("select * from wishlists", con);
        cmd.CommandType = CommandType.Text;
     //   cmd.Parameters.AddWithValue("@id", vid);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable ds = new DataTable();
        da.Fill(ds);
        // cmd.ExecuteReader();
        return ds;
    }


    public DataTable searchcategory(string p)
    {
        SqlConnection con = new SqlConnection(str);

        SqlCommand cmd = new SqlCommand("sp_getcategories", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", p);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable ds = new DataTable();
        da.Fill(ds);

        return ds;
    }



    public DataTable searchproduct(string p, int p_2)
    {
        SqlConnection con = new SqlConnection(str);

        SqlCommand cmd = new SqlCommand("sp_getproducts", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", p);
        cmd.Parameters.AddWithValue("@id1", p_2);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable ds = new DataTable();
        da.Fill(ds);

        return ds;
    }
}

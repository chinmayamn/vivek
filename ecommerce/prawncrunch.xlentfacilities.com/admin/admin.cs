using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Data.SqlClient;
/// <summary>
/// Summary description for admin
/// </summary>
public class admin
{
    string str = ConfigurationManager.ConnectionStrings["conn"].ToString();
	public admin()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public DataSet getzones(string k, string p)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_getzones", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@k", k);
        cmd.Parameters.AddWithValue("@p", p);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }

    public DataSet getdata(string types)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_getdata", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@types", types);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
    public DataSet checkforzone(int id)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_checkforzone", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id",id);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
    public DataSet getzonebyid(string types)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_getzonebyid", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", types);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
    public DataSet getzone()
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_getzone", con);
        cmd.CommandType = CommandType.StoredProcedure;
       
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
    public void updatecontent(string type, string content)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_updatecontent", con);
        cmd.CommandType = CommandType.StoredProcedure;
        con.Open();
        cmd.Parameters.AddWithValue("@type", type);
        cmd.Parameters.AddWithValue("@content", content);
        cmd.ExecuteNonQuery();
        con.Close();
    }
    public void addzone(string city,string place,string zone)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_addzone", con);
        cmd.CommandType = CommandType.StoredProcedure;
        con.Open();
        cmd.Parameters.AddWithValue("@city", city);
        cmd.Parameters.AddWithValue("@place",place);
        cmd.Parameters.AddWithValue("@zone", zone);
            
        cmd.ExecuteNonQuery();
        con.Close();
    }
    public void updatezone(string id,string city, string place, string zone)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_updatedzone", con);
        cmd.CommandType = CommandType.StoredProcedure;
        con.Open();
        cmd.Parameters.AddWithValue("@id", id);
        cmd.Parameters.AddWithValue("@city", city);
        cmd.Parameters.AddWithValue("@place", place);
        cmd.Parameters.AddWithValue("@zone", zone);

        cmd.ExecuteNonQuery();
        con.Close();
    }
    public void insertcontent(string type, string content)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_insertcontent", con);
        cmd.CommandType = CommandType.StoredProcedure;
        con.Open();
        cmd.Parameters.AddWithValue("@type", type);
        cmd.Parameters.AddWithValue("@content", content);
        cmd.ExecuteNonQuery();
        con.Close();
    }
    public void delzone(int id)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_delzone", con);
        cmd.CommandType = CommandType.StoredProcedure;
        con.Open();
        cmd.Parameters.AddWithValue("@id",id);
       
        cmd.ExecuteNonQuery();
        con.Close();
    }
    public DataSet checkfortype(string name)
    {
        SqlConnection
            con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_checkfortype", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@name", name);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
    public DataSet getdiscountdates(string dates)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_getdiscountdates", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@dates", dates);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
    public DataSet getofferbyid(int id)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_getofferbyid", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", id);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
 
    public DataSet getoffers()
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_getoffers", con);
        cmd.CommandType = CommandType.StoredProcedure;
     
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
    public DataSet getdollar()
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_getdollar", con);
        cmd.CommandType = CommandType.StoredProcedure;

        SqlDataAdapter da = new SqlDataAdapter(cmd);


        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
    public void dollar(string cons)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_dollar", con);
        cmd.CommandType = CommandType.StoredProcedure;
        con.Open();
        cmd.Parameters.AddWithValue("@con", cons);

        cmd.ExecuteNonQuery();
        con.Close();
    }
    public DataSet getuserpassword(Guid user)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_getuserpassword", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@user",user);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
    public void deleteuser(string y)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_deleteuser", con);
        con.Open();
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@y", y);
     

        cmd.ExecuteNonQuery();
        con.Close();
    }
    public DataSet checkforproducts(int id)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_checkforproducts", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", id);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
    public DataSet getplacebyid(int id)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_getplacebyid", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", id);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
    public DataSet getlatestnews()
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_getlatestnews", con);
        cmd.CommandType = CommandType.StoredProcedure;
       
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
    public DataSet getprice(string city, string place, string prod)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_getprice", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@city", city);
        cmd.Parameters.AddWithValue("@place", place);
        cmd.Parameters.AddWithValue("@prod", prod);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
    public void addcms(string sub, string cont)
    {

        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_addcms", con);
        con.Open();
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@sub", sub);
        cmd.Parameters.AddWithValue("@con", cont);

     
        cmd.ExecuteNonQuery();
        con.Close();
    }
    public void addoffer(string sub, string cont)
    {

        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_addoffer", con);
        con.Open();
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@subject", sub);
        cmd.Parameters.AddWithValue("@description", cont);


        cmd.ExecuteNonQuery();
        con.Close();
    }
    public void deleteoffer(int id)
    {

        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_deleteoffer", con);
        con.Open();
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", id);


        cmd.ExecuteNonQuery();
        con.Close();
    }
    public void updateoffer(int id, string sub, string cont)
    {

        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_updateoffer", con);
        con.Open();
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", id);

        cmd.Parameters.AddWithValue("@subject", sub);
        cmd.Parameters.AddWithValue("@description", cont);


        cmd.ExecuteNonQuery();
        con.Close();
    }
    public void updatecms(int id, string sub, string cont)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_updatecms", con);
        con.Open();
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", id);
        cmd.Parameters.AddWithValue("@sub", sub);
        cmd.Parameters.AddWithValue("@con", cont);


        cmd.ExecuteNonQuery();
        con.Close();
    }
    public DataSet getnewsbyid(int id)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_getnewsbyid", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", id);
    
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
    public void deletenews(int id)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_deletenews", con);
        con.Open();
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", id);
      

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
    public DataSet getplacebycity(string city, string prod)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_getplacebycity", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", city);
        cmd.Parameters.AddWithValue("@prod", prod);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
    public DataSet getproductdetailsbyid(int data)
    {

        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_getproductdetailsbyid", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", data);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
    public DataSet getproductbyid(string id)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_getproductbyid", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id",id);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
    public DataSet getproductbycat(int id)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_getproductbycatuser", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", id);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }

    public DataSet getproductbycatnew(int id)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_getproductbycatnew", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", id);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
    public DataSet getproductbycatadmin(int id)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_getproductbycatadmin", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", id);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
    public void updateplace(int id, int cat, int product, string city, string place,string zone, string price)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_updateplace", con);
        con.Open();
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", id);
        cmd.Parameters.AddWithValue("@cat", cat);
        cmd.Parameters.AddWithValue("@product", product);

        cmd.Parameters.AddWithValue("@city", city);
        cmd.Parameters.AddWithValue("@place", place);
        cmd.Parameters.AddWithValue("@zone", zone);
        cmd.Parameters.AddWithValue("@price", price);
        cmd.ExecuteNonQuery();
        con.Close();
    }
    public void addproduct(int cat, string pname,  string ImageFile1,string desc)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_addproduct", con);
        con.Open();
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@cat",cat);
        cmd.Parameters.AddWithValue("@pname",pname);
      
        cmd.Parameters.AddWithValue("@pimage",ImageFile1);
        cmd.Parameters.AddWithValue("@desc", desc);
        cmd.ExecuteNonQuery();
        con.Close();
    }
    public void updateproduct(int id, int  cat, string pname, string ImageFile1, string desc)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_updateproduct", con);
        con.Open();
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", id);
        cmd.Parameters.AddWithValue("@cat", cat);
        cmd.Parameters.AddWithValue("@pname", pname);

        cmd.Parameters.AddWithValue("@pimage", ImageFile1);
        cmd.Parameters.AddWithValue("@desc", desc);
        cmd.ExecuteNonQuery();
        con.Close();
    }
    public void updateproductwithoutimage(int id, int cat, string pname, string desc)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_updateproductwithoutimage", con);
        con.Open();
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", id);
        cmd.Parameters.AddWithValue("@cat", cat);
        cmd.Parameters.AddWithValue("@pname", pname);

     
        cmd.Parameters.AddWithValue("@desc", desc);
        cmd.ExecuteNonQuery();
        con.Close();
    }

    public void delproduct(int id)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_delproduct", con);
        con.Open();
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", id);
     
        cmd.ExecuteNonQuery();
        con.Close();
    }

    public DataSet getcategory()
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_getcategory", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
    public DataSet checkplaces(int id)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_checkplaces", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", id);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
    public DataSet getproduct()
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_getproduct", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
    public DataSet getsubcategory()
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_getsubcategory", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
    public void delcategory(int id)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_delcategory", con);
        con.Open();
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", id);
        cmd.ExecuteNonQuery();
        con.Close();
    }
    public void delcity(int id)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_delcity", con);
        con.Open();
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", id);
        cmd.ExecuteNonQuery();
        con.Close();
    }
    public void delplace(int id)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_delplace", con);
        con.Open();
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", id);
        cmd.ExecuteNonQuery();
        con.Close();
    }

    public void addplace(string id,string name,string price, int cat, int prod, string zone)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_addplace", con);
        con.Open();
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", id);
        cmd.Parameters.AddWithValue("@name", name);
        cmd.Parameters.AddWithValue("@price", price);
        cmd.Parameters.AddWithValue("@cat", cat);
        cmd.Parameters.AddWithValue("@prod", prod);
        cmd.Parameters.AddWithValue("@zone", zone);
        cmd.ExecuteNonQuery();
        con.Close();
    }
    public void addcity(string name)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_addcity", con);
        con.Open();
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@name", name);
        cmd.ExecuteNonQuery();
        con.Close();
    }
    public DataSet getcity()
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_getcity", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
    public DataSet getplace()
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_getplace", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
    public void addcategory(string name,string image)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_addcategory", con);
        con.Open();
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@catname", name);
        cmd.Parameters.AddWithValue("@catimage", image);
        cmd.ExecuteNonQuery();
        con.Close();
    }
    public void updatecategory(string id, string name, string image)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_updatecategory", con);
        con.Open();
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@catid", id);
        cmd.Parameters.AddWithValue("@catname", name);
        cmd.Parameters.AddWithValue("@catimage", image);
        cmd.ExecuteNonQuery();
        con.Close();
    }
    public void updatecategorywithoutimage(string id,string name)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_updatecategorywithoutimage", con);
        con.Open();
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@catid", id);
        cmd.Parameters.AddWithValue("@catname", name);
      
        cmd.ExecuteNonQuery();
        con.Close();
    }
    public DataSet getcategorybyid(string id)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_getcategorybyid", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id1", id);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }

    public DataSet getsubcategorybyid(string id)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_getsubcategorybyid", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id1", id);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
    public void delsubcategory(string id1)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_delsubcategory", con);
        con.Open();
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id1", id1);
        cmd.ExecuteNonQuery();
        con.Close();
    }
    public void insertsubcategory(string UniqueName, string cat, string subcat, byte[] imgBinaryData)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_insertsubcategory", con);
        con.Open();
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@uniquename", UniqueName);
        cmd.Parameters.AddWithValue("@cat", cat);
        cmd.Parameters.AddWithValue("@subcat", subcat);
        cmd.Parameters.AddWithValue("@image1", imgBinaryData);
        cmd.ExecuteNonQuery();
        con.Close();
    }
    public void updatesubcategory(string id1, string cat, string subcat, byte[] imgBinaryData)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_updatesubcategory", con);
        con.Open();
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id1",id1);
        cmd.Parameters.AddWithValue("@cat", cat);
        cmd.Parameters.AddWithValue("@subcat", subcat);
        cmd.Parameters.AddWithValue("@image1", imgBinaryData);
        cmd.ExecuteNonQuery();
        con.Close();
    }
}

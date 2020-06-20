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
using System.Data;
using System.Configuration;
/// <summary>
/// Summary description for mynew
/// </summary>
public class mynew
{
    string str = ConfigurationManager.ConnectionStrings["conn"].ToString();
    public mynew()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public DataSet getmemdetails(string id)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_selectbymembershipid", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", id);
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds);
        return ds;
    }

    public DataSet getproductstoexport()
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_getproductstoexport", con);
        cmd.CommandType = CommandType.StoredProcedure;
      
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds);
        return ds;
    }
    public DataSet selectproduct(int id)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_selectproductfordiscount", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", id);
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds);
        return ds;
    }
    public void addcoupon(int pid, string couponkey, string to, int amount)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_addcouponkey", con);
        con.Open();
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@pid",pid);
        cmd.Parameters.AddWithValue("@couponkey", couponkey);
        cmd.Parameters.AddWithValue("@to", to);
        cmd.Parameters.AddWithValue("@amount", amount);
        cmd.ExecuteNonQuery();
        con.Close();
        
    }
    public void updatecouponcredential(string dis)

    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_updatecouponcredential", con);
        con.Open();
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@couponkey", dis);
      
        cmd.ExecuteNonQuery();
        con.Close();
    }
    public DataSet checkcoupon(string pid,string membname,string coupon)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_checkcoupon", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@pid", pid);
        cmd.Parameters.AddWithValue("@membname", membname);
        cmd.Parameters.AddWithValue("@coupon",coupon);
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds);
        return ds;
    }

    public DataSet getdiscountdetails()
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_getdiscountdetails", con);
        cmd.CommandType = CommandType.StoredProcedure;
     
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds);
        return ds;

    }
    public void deletecoupon(int id)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_deletecoupon", con);
        cmd.CommandType = CommandType.StoredProcedure;
        con.Open();
        cmd.Parameters.AddWithValue("@id", id);
        cmd.ExecuteNonQuery();
        con.Close();
    }

}

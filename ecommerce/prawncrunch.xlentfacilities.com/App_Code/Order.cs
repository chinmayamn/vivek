using System;
using System.Collections.Generic;
//////using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for Order
/// </summary>
public class Order
{
    string str = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
	public Order()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    
    public DataTable  Insertorder(string userid, string FirstName, string LastName, string Address, string City, string state, string Country, string mobile, string Phone, string Email,  string FirstName1, string LastName1,string email1, string Address1, string city1,  string state1, string country1, string mobile1, string phone1, string message)
    {
        SqlConnection con = new SqlConnection(str);
         SqlCommand cmd = new SqlCommand("sp_InsertOrder", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@User_Id",userid);
        cmd.Parameters.AddWithValue("@Name",FirstName);
        cmd.Parameters.AddWithValue("@LastName",LastName);
        cmd.Parameters.AddWithValue("@Address",Address);
        cmd.Parameters.AddWithValue("@City",City);
        cmd.Parameters.AddWithValue("@state",state);
     
        cmd.Parameters.AddWithValue("@Country",Country);
        cmd.Parameters.AddWithValue("@Email",Email);
        cmd.Parameters.AddWithValue("Phone",Phone);
        cmd.Parameters.AddWithValue("@mobile",mobile);
       
        cmd.Parameters.AddWithValue("@Delivery_name", FirstName1);
        cmd.Parameters.AddWithValue("@Delivery_lastname",LastName1);
        cmd.Parameters.AddWithValue("@delivery_email", email1);
        cmd.Parameters.AddWithValue("@Delivery_address", Address1);
        cmd.Parameters.AddWithValue("@Delivery_City", city1);
        cmd.Parameters.AddWithValue("@Delivery_state", state1);
       
        cmd.Parameters.AddWithValue("@Delivery_Country",country1);
        cmd.Parameters.AddWithValue("@Delivery_Phone",phone1 );
        cmd.Parameters.AddWithValue("@Delivery_mobile",mobile1);
        cmd.Parameters.AddWithValue("@Message",message);
        SqlDataAdapter ad = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        ad.Fill(dt);
        return dt;
    }

    public  DataTable Select_orderbyuserid(string userid)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_select_orderid_byuserid", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@userid", userid);
        SqlDataAdapter ad = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        ad.Fill(dt);

        return dt ;
    }

  

    public DataTable select_ordersid(string orders_id)
    {

        // selecting the order

        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_select_orders_id", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@orders_id", orders_id);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);
        return dt;


    }

    public void update_delivary_address(string orders_id, string delivery_firstname, string delivery_lastname, string delivery_email, string delivery_address,  string delivery_city, string delivery_state, string delivery_country, string delivery_phone, string delivery_mobile)
    {

        SqlConnection con = new SqlConnection(str);
        con.Open();
        SqlCommand cmd = new SqlCommand("sp_update_orders_delivery", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@orders_id", orders_id);
        cmd.Parameters.AddWithValue("@delivery_firstname", delivery_firstname);
        cmd.Parameters.AddWithValue("@delivery_lastname", delivery_lastname);
        cmd.Parameters.AddWithValue("@delivery_email", delivery_email);
        cmd.Parameters.AddWithValue("@delivery_address", delivery_address);
        
        cmd.Parameters.AddWithValue("@delivery_city", delivery_city);
     
        cmd.Parameters.AddWithValue("@delivery_state", delivery_state);
        cmd.Parameters.AddWithValue("@delivery_country", delivery_country);
        cmd.Parameters.AddWithValue("@delivery_phone", delivery_phone);
        cmd.Parameters.AddWithValue("@delivery_mobile", delivery_mobile);
        cmd.ExecuteNonQuery();
        con.Close();
    }

    public void update_paymentmethod(string orders_id, string payment_method)
    {

        SqlConnection con = new SqlConnection(str);
        con.Open();
        SqlCommand cmd = new SqlCommand("sp_upd_payment", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@orders_id", orders_id);
        cmd.Parameters.AddWithValue("@payment_method", payment_method);
        cmd.ExecuteNonQuery();
        con.Close();
    }

    public void updateorderstatusvisible(int id)
    {

        SqlConnection con = new SqlConnection(str);
        con.Open();
        SqlCommand cmd = new SqlCommand("sp_updateorderstatusvisible", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@orders_id", id);
      
        cmd.ExecuteNonQuery();
        con.Close();
    }

    public void Insertproduct_order(string orders_id, string products_id, string products_name, string products_price, string final_price, string city1, string products_quantity,string discount)
    {

        //inserting category

        SqlConnection con = new SqlConnection(str);
        con.Open();
        SqlCommand cmd = new SqlCommand("sp_insert_into_order_prod", con);

        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.AddWithValue("@orders_id", orders_id);
        cmd.Parameters.AddWithValue("@products_id", products_id);
        cmd.Parameters.AddWithValue("@products_name", products_name);
        cmd.Parameters.AddWithValue("@products_price", Convert.ToDecimal(products_price));
        cmd.Parameters.AddWithValue("@final_price", Convert.ToDecimal(final_price));
        cmd.Parameters.AddWithValue("@city1", city1);
        cmd.Parameters.AddWithValue("@products_quantity", Convert.ToInt32(products_quantity));
        cmd.Parameters.AddWithValue("@discount", discount);
        cmd.ExecuteNonQuery();
        con.Close();

    }


    public DataTable prod_disp_id(string products_id)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_select_prod_by_id",con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@products_id", products_id);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
      
        DataTable ds = new DataTable();
        da.Fill(ds);
        return ds;

    }

  

    public DataTable select_order_userid(string userid)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_select_orderid_byuserid", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@userid", userid);
        SqlDataAdapter ad = new SqlDataAdapter(cmd);
       
        DataTable dt = new DataTable();
        ad.Fill(dt);

        return dt;
    }

    public DataSet select_order(string userid)
    {
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand("sp_select_orderid", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@userid", userid);
        SqlDataAdapter ad = new SqlDataAdapter(cmd);

        DataSet dt = new DataSet();
        ad.Fill(dt);

        return dt;
    }


    public void Insertproduct_order(string orders_id, string products_id, string products_name, string products_price, string final_price, string products_quantity, string city1, string discount, string date)
    {

        //inserting category

        SqlConnection con = new SqlConnection(str);
        con.Open();
        SqlCommand cmd = new SqlCommand("sp_insert_into_order_prod", con);

        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.AddWithValue("@orders_id", orders_id);
        cmd.Parameters.AddWithValue("@products_id", products_id);
        cmd.Parameters.AddWithValue("@products_name", products_name);
        cmd.Parameters.AddWithValue("@products_price", Convert.ToDecimal(products_price));
        cmd.Parameters.AddWithValue("@final_price", Convert.ToDecimal(final_price));


        cmd.Parameters.AddWithValue("@products_quantity", Convert.ToInt32(products_quantity));
        cmd.Parameters.AddWithValue("@city1", city1);
      
        cmd.Parameters.AddWithValue("@discount", discount);
        cmd.Parameters.AddWithValue("@date", date);
        cmd.ExecuteNonQuery();
        con.Close();

    }
}

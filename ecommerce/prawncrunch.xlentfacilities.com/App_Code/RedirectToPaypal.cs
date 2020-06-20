using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// Summary description for RedirectToPaypal
/// </summary>
public class RedirectToPaypal
{
	public RedirectToPaypal()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public static string getItemNameAndCost(string orderid, double itemCost)
    {

        //Converting String Money Value Into Decimal

        
        decimal price = Convert.ToDecimal(itemCost);


        //declaring empty String


        string returnURL = "";


        returnURL += "https://www.paypal.com/xclick/business= hiks@gmail.com";


        //PassingItem Name as dynamic


       // returnURL += "&item_name=" + itemName;


        //AssigningName as Statically to Parameter


        //returnURL += "&first_name" + "Raghunadh Babu";


        //AssigningCity as Statically to Parameter


        //returnURL += "&city" + "Hyderabad";


        //Assigning State as Statically to Parameter


       // returnURL += "&state" + "Andhra Pradesh";


        //Assigning Country as Statically to Parameter


       // returnURL += "&country" + "India";


        //Passing Amount as Dynamic

        returnURL += "&orderid=" + orderid;
        returnURL += "&amount=" + price;


        //Passing Currency as your 


        returnURL += "&currency=USD";


        //retturn Url if Customer wants To return to Previous Page


        returnURL += "&return=http://krsfx.com/user/subscribtion.aspx";


        //retturn Url if Customer Wants To Cancel the Transaction


       // returnURL += "&cancel_return=http://bangarubabupureti.spaces.live.com";


        return returnURL;


    }

}

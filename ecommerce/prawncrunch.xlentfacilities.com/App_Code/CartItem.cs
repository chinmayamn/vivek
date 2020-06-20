using System;
using System.Collections.Generic;
//////using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CartItem
/// </summary>
namespace SBMartCartItem
{
    [Serializable]
    public class CartItem
    {
        private int _productID;
        private string _productName;
        private string _productImageUrl;
        private int _quantity;
        private double _price;
        private double _linetotal;
        private string _city1;
        private string _date;
        private double _discount;

        public void New()
        {

        }
        public void New(int productId, string productName, string productImage, double price,string city1,  int quantity, double discount)
        {
            _productID = ProductId;
            _productName = ProductName;
            _productImageUrl = productImage;
            _quantity = quantity;
            _price = price;
            _city1 = city1;
        
            _linetotal = quantity *( price * discount);
      
        }



        public int ProductId
        {
            get
            {
                return _productID;
            }
            set
            {
                _productID = value;
            }
        }

        public string ProductName
        {
            get
            {
                return _productName;
            }
            set
            {
                _productName = value;
            }
        }

        public string ProductImageUrl
        {
            get
            {
                return _productImageUrl;
            }
            set
            {
                _productImageUrl = value;
            }
        }


        public string Date
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
            }
        }


        public int quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
            }
        }
        public double discount
        {
            get
            {
                return _discount;
            }
            set
            {
               _discount = value;
            }
        }
        public double price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }

        public double Linetotal
        {
            get
            {
             
               // return (_quantity * _price) + (_tax * _quantity)+(_shipping*Quantity);

                if (_discount == 0)
                {
                    return (_quantity * _price);
                }
                else
                {
                    double temp=_quantity * _price;
                    double temp1=(temp * _discount)/100;
                    return temp - temp1;
                    
                }
            }
        }
        public double DisCal
        {
            get
            {

                // return (_quantity * _price) + (_tax * _quantity)+(_shipping*Quantity);

                    double temp = _quantity * _price;
                    return temp;

              
            }
        }


        public string city1
        {

            get
            {
                return _city1;
            }
            set
            {
                _city1 = value;
            }
        }

      
    }
}

using System;
using System.Collections.Generic;
//////using System.Linq;
using System.Web;
using SBMartCartItem;
/// <summary>
/// Summary description for ShoppingCart
/// </summary>
/// 
namespace prawncrunchShopping
{
    [Serializable]
    public class ShoppingCart
    {
        private DateTime _dateCreated;
        private DateTime _lastUpdated;
        private List<CartItem> _items;

        public ShoppingCart()
        {
            if (this._items == null)
            {
                this._items = new List<CartItem>();
                this._dateCreated = DateTime.Now;
            }
        }

        public List<CartItem> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
            }
        }

           public void discount( double d)
        {
            CartItem NewItem = new CartItem();
            if (d == 0)
            {
                NewItem.discount =1;
                _lastUpdated = DateTime.Now;
            }
            else
            {
                NewItem.discount = d;
                _lastUpdated = DateTime.Now;
            }
        }

        public void Insert(int ProductID, string name, string pimage, double price, string city1,  int quantity, double discount)
        {
            int ItemIndex = ItemIndexOfID(ProductID);
            if (ItemIndex == -1)
            {
                CartItem NewItem = new CartItem();
                NewItem.ProductId = ProductID;
                NewItem.quantity = quantity;
                NewItem.price = price;
                NewItem.ProductName = name;
                NewItem.ProductImageUrl = pimage;
                NewItem.city1 = city1;
           
                NewItem.discount = discount;
                _items.Add(NewItem);
            }
            else
            {
              
                _items[ItemIndex].quantity =_items[ItemIndex].quantity + quantity;
            }
            _lastUpdated = DateTime.Now;
        }
        

        public void updatetest(double tax,double shipping)
        {
            foreach (CartItem Item in _items)
            {
            }
        }
        public void Update(int RowID, int ProductID, int quantity, double price)
        {
            CartItem Item = _items[RowID];
            Item.ProductId = ProductID;
            Item.quantity = quantity;
            Item.price = price;
            _lastUpdated = DateTime.Now;
        }
        public void Update1(double discount)
        {
            foreach (CartItem item in _items)
            {
              item.discount = discount;
                
            }
            _lastUpdated = DateTime.Now;
        }

        public void UpdateDate(string date)
        {
            foreach (CartItem item in _items)
            {
                item.Date = date;

            }
            _lastUpdated = DateTime.Now;
        }


        public void DeleteItem(int rowID)
        {
            _items.RemoveAt(rowID);
            _lastUpdated = DateTime.Now;
        }

        private int ItemIndexOfID(int ProductID)
        {
            int index = 0;
            foreach (CartItem item in _items)
            {
                if (item.ProductId == ProductID)
                {
                    return index;
                }
                index += 1;
            }
            return -1;
        }

    
        public double Total
        {
            get
            {
                double t = 0;

                if (_items == null)
                {
                    return 0;
                }
                foreach (CartItem Item in _items)
                {
                    t += Item.Linetotal;
                }
                return t;
            }
        }



        public double discal
        {
            get
            {
                double t = 0;

                if (_items == null)
                {
                    return 0;
                }
                foreach (CartItem Item in _items)
                {
                    t += Item.DisCal;
                }
                return t;
            }
        }




        
    }
    }


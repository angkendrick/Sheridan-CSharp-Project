using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Project1
{
    class Product
    {
        private int _productId;
        private string _productName;
        private string _description;
        private double _price;
        private int _quantity;

        public Product()
        {
            ProductId = 0;
            ProductName = "";
            Description = "";
            Price = 0.0;
            Quantity = 0; 

        }

        public Product(int prodId, string name, string desc, double price, int quantity)
        {
            _productId = prodId;
            _productName = name;
            _description = desc;
            _price = price;
            _quantity = quantity;
        }

        public int ProductId
        {
            get
            {
                return _productId;
            }
            set
            {
                _productId = value;
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

        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value; 
            }
        }
        public double Price
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
        public int Quantity
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
    }
}

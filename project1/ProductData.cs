using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Project1
{
    class ProductData : Product
    {

        public ProductData()
            : base()
        {

        }

        public ProductData(int id, string name, string desc, double price, int quantity)
            : base(id, name, desc, price, quantity)
        {

        }


    }
}

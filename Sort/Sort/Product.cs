using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Sort
{
    public class Product : IComparable<Product>
    {

        public double price;
        public string name;
        public string id;

        public int CompareTo(Product other)
        {
            if (price > other.price) return 1;
            if (price < other.price) return -1;
            return 0;
        }


    }
}

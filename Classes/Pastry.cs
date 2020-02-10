using System;
using System.Collections.Generic;
using System.Numerics;

namespace Bakery 
{
    public class Pastry
    {
        private int _price;
        public Pastry()
        {
            Price = 5;
        }

        public int Price { get => _price; set => _price = value; }
    }
}
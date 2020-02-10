using System;
using System.Collections.Generic;
using System.Numerics;

namespace Bakery
{
    public class Bread
    {
        private int _price;
        public Bread()
        {
            Price = 5;
        }

        public int Price { get => _price; set => _price = value; }
    }

}
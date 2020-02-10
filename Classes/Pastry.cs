using System;
using System.Collections.Generic;
using System.Numerics;

namespace Bakery 
{
    public static class Pastry
    {
        private static int _price = 2;
        public static int Price { get => _price; set => _price = value; }
    }
}
using System;
using System.Collections.Generic;
using System.Numerics;

namespace Bakery
{
    class Order
    {
        private int _total;

        public Order()
        {
            Total = 0;
        }

        public int Total { get => _total; set => _total = value; }

        public void addTotal(int numBread, int numPastries)
        {   int total = 0;
            if(numBread == 1 || numBread == 2)
            {
                total += numBread * Bread.Price;
            }
            else if (numBread % 3 == 0 || numBread > 3)
            {
                total += (numBread - numBread / 3) * 5;
            }

            if (numPastries == 1 || numPastries == 2)
            {
                total += numPastries * Pastry.Price;
            }
            else if (numPastries % 3 == 0 || numPastries > 3)
            {
                int pastryDeal = numPastries / 3;
                total += ((numPastries - pastryDeal) * 2 + (pastryDeal * 5));
            }

        }
    }
}
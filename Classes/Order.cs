namespace Bakery
{
    public static class Order
    {
        private static int _total = 0;

        public static int Total { get => _total; set => _total = value; }

        public static void addTotal(int numBread, int numPastries)
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
                total += ((numPastries - numPastries / 3) * Pastry.Price + (numPastries / 3 * 5));
            }
            Total = total;
            

        }
    }
}
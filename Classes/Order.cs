namespace Bakery
{
    public static class Order
    {

        public static int Total { get; set; } = 0;

        public static void addTotal(int numBread, int numPastries)
        {   
            if(numBread == 1 || numBread == 2)
            {
                Total += numBread * Bread.Price;
            }
            else if (numBread % 3 == 0 || numBread > 3)
            {
                Total += (numBread - numBread / 3) * 5;
            }

            if (numPastries == 1 || numPastries == 2)
            {
                Total += numPastries * Pastry.Price;
            }
            else if (numPastries % 3 == 0 || numPastries > 3)
            {
                Total += ((numPastries / 3) * 5 + (numPastries % 3) * 2);
            }

        }
    }
}
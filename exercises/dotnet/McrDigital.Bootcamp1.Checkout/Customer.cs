using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace McrDigital.Bootcamp1.Checkout
{
    public class Customer
    {
        public const int PRODUCT_COST = 10;
        public const int ADVERT_DEALERS_COST = 50;
        public const int ADVERT_PRIVATESELLERS_COST = 20;

        public Customer()
        {
        }

        public static int GetBill(int numberOfAdverts, int numberOfProducts, string customer)
        {
            int totalCost = 0;

            if (customer == "dealer")
            {
                totalCost = (numberOfAdverts * ADVERT_DEALERS_COST) + (numberOfProducts * PRODUCT_COST);
            }
            else if (customer == "privateSeller")
            {
                totalCost = (numberOfAdverts * ADVERT_PRIVATESELLERS_COST) + (numberOfProducts * PRODUCT_COST);
            }

            return totalCost;
        }
    }
}
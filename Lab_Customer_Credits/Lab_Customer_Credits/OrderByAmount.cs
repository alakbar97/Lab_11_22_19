using System.Collections.Generic;

namespace Lab_Customer_Credits
{
    internal class OrderByAmount : IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {
            if (x.CalculateAmounts() > y.CalculateAmounts())
                return 1;
            else
                if (x.CalculateAmounts() < y.CalculateAmounts())
                return -1;
            else
                return 0;
        }
    }
}
using System;
using System.Collections.Generic;

namespace Lab_Customer_Credits
{
    public class Customer : Person,ICloneable
    {
        public int Id { get; set; }
        public List<Credit> Credit { get; set; }

        public decimal CalculateAmounts()
        {
            decimal amount = 0;
            foreach (Credit item in Credit)
            {
                amount += item.Amount;
            }
            return amount;
        }

        public object Clone()
        {
            Customer customer = (Customer)this.MemberwiseClone();
            customer.Credit = new List<Credit>();
            foreach (Credit item in this.Credit)
            {
                Credit credit = new Credit();
                credit.Date = item.Date;
                credit.Amount = item.Amount;
                customer.Credit.Add(credit);
               // customer.Credit.Add(new Credit {Amount=item.Amount,Date=item.Date });
            }

            return customer;
        }

        public override string ToString()
        {
            return $"{Name} {Surname} {CalculateAmounts()}";
        }
    }
}

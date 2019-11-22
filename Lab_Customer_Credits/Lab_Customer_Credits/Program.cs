using System;
using System.Collections.Generic;

namespace Lab_Customer_Credits
{
    class Program
    {
        static void Main(string[] args)
        {
            //Customer customer = new Customer() 
            //{ 
            //Name="Huseyn",
            //Surname="Mammadli",
            //Id=1,
            //Credit=new List<Credit> { new Credit {Amount=12,Date="12/12/13" }, new Credit { Amount = 12, Date = "12/12/16" } }
            //};


            //Customer clonedCustomer = (Customer)customer.Clone();
            //foreach (Credit item in customer.Credit)
            //{
            //    item.Amount = 0;
            //    Console.WriteLine(item.Amount);
            //}

            //foreach (Credit item in clonedCustomer.Credit)
            //{
            //    Console.WriteLine(item.Amount);
            //}


            //Console.WriteLine(clonedCustomer.Name);

            //------------------------------First Task Ends------------------------------------

            //AllCustomers allCustomers = new AllCustomers();

            //List<Customer> customers = allCustomers.GetAllCustomer();

            //customers.Sort(new OrderByAmount());

            //foreach (Customer item in customers)
            //{
            //    Console.WriteLine(item.CalculateAmounts());
            //}
            //------------------------------Second Task Ends------------------------------------

            AllCustomers allCustomers = new AllCustomers();
            foreach (Customer item in allCustomers)
            {
                Console.WriteLine(item);
            }
        }
    }
}

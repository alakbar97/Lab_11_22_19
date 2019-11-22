using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Customer_Credits
{
    public class AllCustomers:IEnumerable
    {
        private List<Customer> customers;
        public AllCustomers()
        {
            customers = new List<Customer>
            {
                new Customer
                {
                    Id = 1,
                    Name = "Huseyn",
                    Surname = "Gambarov",
                    Credit = new List<Credit>
                    {
                        new Credit { Amount = 502000, Date = "12/12/12" },
                        new Credit { Amount = 5000, Date = "12/12/12" },
                        new Credit { Amount = 500, Date = "12/12/12" }
                    }
                },
                new Customer
                {
                    Id = 2,
                    Name = "Hafiz",
                    Surname = "Gambarov",
                    Credit = new List<Credit>
                    {
                        new Credit { Amount = 856, Date = "12/12/12" },
                        new Credit { Amount = 456, Date = "12/12/12" },
                        new Credit { Amount = 425, Date = "12/12/12" }
                    }
                },
                new Customer
                {
                    Id = 3,
                    Name = "Tahir",
                    Surname = "Gambarov",
                    Credit = new List<Credit>
                    {
                        new Credit { Amount = 126, Date = "12/12/12" },
                        new Credit { Amount = 20, Date = "12/12/12" },
                        new Credit { Amount = 78, Date = "12/12/12" }
                    }
                },
            };
        }

        public IEnumerator GetEnumerator()
        {
            return customers.GetEnumerator();
        }
    }
}

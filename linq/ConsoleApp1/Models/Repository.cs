using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public static class Repository
    {
        public static IList<Customer> GetCustomers()
        {
            var customers = new List<Customer>
            {
                new Customer { Id = 1, Name = "Alice" },
                new Customer { Id = 2, Name = "Bob" },
                new Customer { Id = 3, Name = "John" }
            };
            return customers;
        }
        public static IList<Product> GetProducts()
        {
            var customers = new List<Product>
            {
                new Product { Id = 1, Name = "HP" },
                new Product { Id = 2, Name = "Dell" },
                new Product { Id = 3, Name = "Lonove" }
            };
            return customers;
        }
        public static IList<Order> GetOrders()
        {
            var orders = new List<Order>
            {
                new Order { Id = 101,OrderDate=DateTimeOffset.Now.AddHours(2), CustomerId = 1,ProductId=1 },
                new Order { Id = 102,OrderDate=DateTimeOffset.Now.AddHours(1), CustomerId = 2,ProductId=1 },
                new Order { Id = 103,OrderDate=DateTimeOffset.Now.AddHours(3), CustomerId = 1,ProductId=2 },
                new Order { Id = 103,OrderDate=DateTimeOffset.Now.AddHours(3), CustomerId = 1,ProductId=2 },
                new Order { Id = 104,OrderDate=DateTimeOffset.Now.AddHours(3), CustomerId = 1,ProductId=2 },
                new Order { Id = 105,OrderDate=DateTimeOffset.Now.AddHours(4), CustomerId = 3,ProductId=3 }
            };
            return orders;
        }
    }
}

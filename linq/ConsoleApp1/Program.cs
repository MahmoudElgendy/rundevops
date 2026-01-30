using ConsoleApp1.Models;
using ConsoleApp1.Dto;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var orders = from c in Repository.GetCustomers()
                         .Where (c=>c.Id==1)
                         join o in Repository.GetOrders()
                         on c.Id equals o.CustomerId
                         join p in Repository.GetProducts()
                         .Where(p => p.Id == 1)
                         on o.ProductId equals p.Id
                         select new OrderDto
                         {
                             CustomerId = c.Id,
                             CustomerName = c.Name,
                             OrderId = o.Id,
                             OrderDate = o.OrderDate,
                             ProductId = o.ProductId,
                             ProductName =p.Name
                         };
            var groupedByCustomerName = orders.GroupBy(o => o.CustomerName);

            foreach (var order in groupedByCustomerName)
            {
                Console.WriteLine($"{order.Key}");
                Console.WriteLine($"\t OrderId \t ProductName");
                foreach (var item in order)
                {
                    Console.WriteLine($"\t{item.OrderId}\t{item.ProductName}");
                }

            }
        }
    }
}

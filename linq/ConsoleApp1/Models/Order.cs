namespace ConsoleApp1.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTimeOffset OrderDate { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
    }
}

namespace InvoicingApplication.Models.Classes
{
    public class SalesMovement
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Amount { get; set; }
        public decimal TotalPrice { get; set; }

        public ICollection<Products> Products { get; set; } = null!;
        public ICollection<Employee> Employees { get; set; } = null!;
        public ICollection<Customers> Customers { get; set; } = null!;
    }
}

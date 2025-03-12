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
        public string InvoiceNumber { get; set; } = null!;
        public decimal InvoiceDate { get; set; }
        public string SuppilerId { get; set; } = null!;
        public string InvoiceTypeId { get; set; } = null!;
        public string IsEnabled { get; set; } = null!;
        public string IsDeleted { get; set; } = null!;
        public DateTime DateCreated { get; set; }
        public string UserCreated { get; set; } = null!;
        public ICollection<Products> Products { get; set; } = null!;
        public ICollection<Employee> Employees { get; set; } = null!;
        public ICollection<Customers> Customers { get; set; } = null!;
    }
}

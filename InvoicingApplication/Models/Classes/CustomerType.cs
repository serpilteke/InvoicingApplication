namespace InvoicingApplication.Models.Classes
{
    public class CustomerType
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string IsEnabled { get; set; } = null!;
        public string IsDeleted { get; set; } = null!;
        public DateTime DateCreated { get; set; }
        public ICollection<Customers> Customers { get; set; } = null!;//bir müşteri tipi birden fazla müşteriye ait olabilir.
    }
}

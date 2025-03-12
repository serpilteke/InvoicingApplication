namespace InvoicingApplication.Models.Classes
{
    public class InvoiceType
    {
        public int Id { get; set; }
        public string TypeName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string IsEnabled { get; set; } = null!;
        public string IsDeleted { get; set; } = null!;
        public DateTime DateCreated { get; set; }
        public string UserCreated { get; set; } = null!;

    }
}

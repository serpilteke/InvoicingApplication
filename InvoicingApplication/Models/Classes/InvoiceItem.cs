using System.ComponentModel.DataAnnotations;

namespace InvoicingApplication.Models.Classes
{
    public class InvoiceItem
    {
        [Key]
        public string Id { get; set; }
        public string Description { get; set; } = null!;
        public decimal Price { get; set; } 
        public decimal UnitPrice { get; set; }
        public decimal Amount { get; set; }

        public string IsEnabled { get; set; } = null!;
        public string IsDeleted { get; set; } = null!;
        public DateTime DateCreated { get; set; }
        public string UserCreated { get; set; } = null!;    
        public string DaateCreated { get; set; } = null!;
        public string DateModified { get; set; } = null!;
        public Invoices Invoices { get; set; } = null!; //bir fatura kalemi bir faturaya ait olabilir.
        public Customers Customers { get; set; } = null!; //bir fatura kalemi bir müşteriye ait olabilir.
    }
}

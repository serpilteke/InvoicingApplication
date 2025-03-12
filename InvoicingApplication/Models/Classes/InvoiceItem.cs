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
        public Invoices Invoices { get; set; } = null!; //bir fatura kalemi bir faturaya ait olabilir.
    }
}

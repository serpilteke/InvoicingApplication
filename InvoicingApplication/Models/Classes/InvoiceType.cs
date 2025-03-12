using System.ComponentModel.DataAnnotations;

namespace InvoicingApplication.Models.Classes
{
    public class InvoiceType
    {
        [Key]
        public int Id { get; set; }
        public string TypeName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string IsEnabled { get; set; } = null!;
        public string IsDeleted { get; set; } = null!;
        public DateTime DateCreated { get; set; }
        public string UserCreated { get; set; } = null!;

        public ICollection<Invoices> Invoices { get; set; } = null!; //bir fatura tipi birden fazla faturaya ait olabilir.
        public ICollection<SalesMovement> SalesMovement { get; set; } = null!; //bir fatura tipi birden fazla satış hareketine ait olabilir.
        public ICollection<InvoiceItem> InvoiceItem { get; set; } = null!; //bir fatura tipi birden fazla fatura kalemine ait olabilir.

    }
}

using System.ComponentModel.DataAnnotations;

namespace InvoicingApplication.Models.Classes
{
    public class Invoices
    {
        [Key]
        public string Id { get; set; }
        public string InvoiceNumber { get; set; } = null!;
        public string CustomerId { get; set; } = null!;
        public string InvoiceSerialNumber { get; set; } = null!;
        public DateTime InvoiceDate { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal Discount { get; set; }
        public decimal NetAmount { get; set; }
        public string TaxOffice { get; set; } = null!;
        public string TaxNumber { get; set; } = null!;
        public string Deliverer { get; set; } = null!;
        public string DelivererAddress { get; set; } = null!;
        public string DelivererCity { get; set; } = null!;
        public string DelivererCountry { get; set; } = null!;
        public string DelivererPhoneNumber { get; set; } = null!;
        public string DelivererEmail { get; set; } = null!;
        public string Receiver { get; set; } = null!;
        public string ReceiverAddress { get; set; } = null!;
        public string ReceiverCity { get; set; } = null!;
        public string ReceiverCountry { get; set; } = null!;
        public string ReceiverPhoneNumber { get; set; } = null!;
        public string ReceiverEmail { get; set; } = null!;
        public string PaymentMethod { get; set; } = null!;
        public ICollection<InvoiceItem> InvoiceItems { get; set; } = null!;//bir faturanın birden fazla fatura kalemi olabilir.
        public Customers Customers { get; set; } = null!;//bir fatura bir müşteriye ait olabilir.
        public Countrys Countrys { get; set; } = null!;//bir fatura bir ülkeye ait olabilir.
        public Citys Citys { get; set; } = null!;//bir fatura bir şehre ait olabilir.
        public Employee Employee { get; set; } = null!;//bir fatura bir çalışana ait olabilir.

    }
}

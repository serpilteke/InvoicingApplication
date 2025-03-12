using System.ComponentModel.DataAnnotations;

namespace InvoicingApplication.Models.Classes
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public string Brand { get; set; } = null!;
        public short Stock { get; set; } 
        public string ProductImage { get; set; } = null!;
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }
        public short StockNumber { get; set; }
        public bool StockStatus { get; set; }
        public Category Category { get; set; } = null!;

        public ICollection<SalesMovement> SalesMovements { get; set; } = null!;// her bir ürünün birden fazla satışı olabilir.
    }
}

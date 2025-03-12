using System.ComponentModel.DataAnnotations;

namespace InvoicingApplication.Models.Classes
{
    public class Category //DB'ye bir tablo oluşturacağımı belirtmek için 
    {
        //EF temel CRUD işlemlerini gerçekleştirirken mutlaka bir KEY'e ihtiyaç duyar.
        [Key]//Primary Key olduğunu belirtmek için
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;
        public ICollection<Products> Products { get; set; }//her bir kategoride birden fazla ürün olabilir anlamına gelir.

    }
}

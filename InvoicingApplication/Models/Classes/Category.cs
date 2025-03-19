using System.ComponentModel.DataAnnotations;

namespace InvoicingApplication.Models.Classes
{
    public class ProductCategories //DB'ye bir tablo oluşturacağımı belirtmek için 
    {
        //EF temel CRUD işlemlerini gerçekleştirirken mutlaka bir KEY'e ihtiyaç duyar.
        [Key]//Primary Key olduğunu belirtmek için
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description {get; set;} = null!;
        public ICollection<Products> Products { get; set; }//her bir kategoride birden fazla ürün olabilir anlamına gelir.

    }
}

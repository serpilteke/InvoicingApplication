namespace InvoicingApplication.Models.Classes
{
    public class PriceTypes
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string IsEnabled { get; set; } = null!;
        public string IsDeleted { get; set; } = null!;
        public DateTime DateCreated { get; set; }
        public ICollection<Products> Products { get; set; } = null!; //bir fiyat tipi birden fazla ürüne ait olabilir.
    }
}

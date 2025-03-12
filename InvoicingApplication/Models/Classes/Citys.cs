using System.ComponentModel.DataAnnotations;

namespace InvoicingApplication.Models.Classes
{
    public class Citys
    {
        [Key]
        public int Id { get; set; }
        public string CountrysId { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string IsEnabled { get; set; } = null!;
        public string IsDeleted { get; set; } = null!;
        public DateTime DateCreated { get; set; }
        public ICollection<Customers> Customers { get; set; } = null!; //her bir şehrin birden fazla müşterisi olabilir.
        public ICollection<Countrys> Countrys { get; set; } = null!; //her bir şehir bir ülkeye ait olabilir.

    }
}

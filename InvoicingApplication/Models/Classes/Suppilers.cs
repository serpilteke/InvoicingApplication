using System.ComponentModel.DataAnnotations;

namespace InvoicingApplication.Models.Classes
{
    public class Suppilers
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string Address { get; set; } = null!;

        public ICollection<Citys> Citys { get; set; } = null!; //her bir tedarikçi bir şehre ait olabilir.??
        public ICollection<Countrys> Countrys { get; set; } = null!;//her bir tedarikçi bir ülkeye ait olabilir.??


    }
}

using System.ComponentModel.DataAnnotations;

namespace InvoicingApplication.Models.Classes
{
    //Müşteri de dahil olmak üzere üyelik işlemi yapılmış tüm kullanıcıların bilgilerini tutan sınıf.
    public class Users 
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Role { get; set; } = null!;

        public string IsEnabled { get; set; } = null!;
        public string IsDeleted { get; set; } = null!;
        public DateTime DateCreated { get; set; }
        public string UserCreated { get; set; } = null!;

        public ICollection<Citys> Citys { get; set; } = null!; //her bir kullanıcının bir şehri olabilir.
        public ICollection<Countrys> Countrys { get; set; } = null!; //her bir kullanıcının bir ülkesi olabilir.

    }
}

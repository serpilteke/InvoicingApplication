using System.ComponentModel.DataAnnotations;

namespace InvoicingApplication.Models.Classes
{
    public class UserRoles
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;


        public string IsEnabled { get; set; } = null!;
        public string IsDeleted { get; set; } = null!;
        public DateTime DateCreated { get; set; }
        public string UserCreated { get; set; } = null!;


        public ICollection<Users> Users { get; set; } = null!; //bir kullanıcı rolü birden fazla kullanıcıya ait olabilir.

    }
}

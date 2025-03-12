using System.ComponentModel.DataAnnotations;

namespace InvoicingApplication.Models.Classes
{
    public class Countrys
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string InternationalName { get; set; } = null!;
        public string NameCode { get; set; } = null!;
        public string AreaCode { get; set; } = null!;
        public string IsEnabled { get; set; } = null!;
        public string IsDeleted { get; set; } = null!;
        public DateTime DateCreated { get; set; }
        public ICollection<Customers> Customers { get; set; } = null!; //bir ülke birden fazla müşteriye ait olabilir.
        public ICollection<Employee> Employees { get; set; } = null!; //bir ülke birden fazla çalışana ait olabilir.
        public ICollection<SalesMovement> SalesMovement { get; set; } = null!; //bir ülke birden fazla satış hareketine ait olabilir.
    }
}

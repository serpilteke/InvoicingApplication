using System.ComponentModel.DataAnnotations;

namespace InvoicingApplication.Models.Classes
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;

        public string IdentificationNumber { get; set; } = null!;
        public string BloodGroup { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public DateTime EmploymentDate { get; set; }
        public DateTime DismissalDate { get; set; }
        public string Address { get; set; } = null!;
        public string Photograph { get; set; } = null!;

        public ICollection<SalesMovement> SalesMovements { get; set; } = null!; // her bir çalışanın birden fazla satışı olabilir.
        public ICollection<Departments> Departments { get; set; } = null!; // her bir çalışanın bir departmanı olabilir.
        public ICollection<Customers> Customers { get; set; } = null!; // her bir çalışanın birden fazla müşterisi olabilir.
        public ICollection<Citys> Citys { get; set; } = null!; // her bir çalışanın bir şehri olabilir.
        public ICollection<Countrys> Countrys { get; set; } = null!; // her bir çalışanın bir ülkesi olabilir.
    }
}

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
        public string Position { get; set; } = null!;
        public string DepartmentsId { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string City { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string Photograph { get; set; } = null!;

        public ICollection<SalesMovement> SalesMovements { get; set; } = null!; // her bir çalışanın birden fazla satışı olabilir.
        public ICollection<Departments> Departments { get; set; } = null!; // her bir çalışanın bir departmanı olabilir.
    }
}

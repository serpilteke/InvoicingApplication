using System.ComponentModel.DataAnnotations;

namespace InvoicingApplication.Models.Classes
{
    public class Departments
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; } = null!;

        public ICollection<Employee> Employees { get; set; } = null!;// her bir departmanın birden fazla çalışanı olabilir.


    }
}

using System.ComponentModel.DataAnnotations;

namespace Crud_3.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Salary { get; set; }
    }
}

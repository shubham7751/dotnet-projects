using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CURD_First_Ex.Models
{

    public class Employee
    {
        [Key]
        public int Emp_Id { get; set; }
        [Required]
        public String? Name { get; set; }
        [Required]
        public String? Address { get; set; }
        [Required]
        public String? Age { get; set; }
        [Required]
        public String? City { get; set; }
        [Required]
        public decimal Salary { get; set; }

      
        public int Dept_Id { get; set; }

        [ForeignKey("Dept_Id")]
        public virtual Department? Department { get; set; }

    }
}

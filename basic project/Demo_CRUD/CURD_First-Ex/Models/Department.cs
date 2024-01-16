using System.ComponentModel.DataAnnotations;

namespace CURD_First_Ex.Models
{

    public class Department
    {
        [Key]
        public int Dept_Id { get; set; }
        [Required]
        public String? Name { get; set; }
        public virtual List<Employee>? Employees { get; set; }
    }
}

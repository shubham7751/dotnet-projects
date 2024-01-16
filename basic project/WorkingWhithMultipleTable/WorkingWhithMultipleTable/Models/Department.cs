using System.ComponentModel.DataAnnotations;

namespace WorkingWhithMultipleTable.Models
{
    public class Department
    {
        [Key] 
        public int DepartmentId { get; set; }
        public String DepartmentName { get; set; } = default!;
        public String DepartmentCode { get; set; }=default!;
    }
}

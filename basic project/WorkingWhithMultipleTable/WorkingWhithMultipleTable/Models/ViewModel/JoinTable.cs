namespace WorkingWhithMultipleTable.Models.ViewModel
{
    public class JoinTable
    {
        public int EmployeeId { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Gender { get; set; }


        public String DepartmentName { get; set; } = default!;
        public String DepartmentCode { get; set; } = default!;
    }
}

using System.ComponentModel.DataAnnotations;

namespace ADO_dotnet.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string StudentName { get; set; }= string.Empty;
        public string EmailAddress { get; set; } = string.Empty;

    }
}

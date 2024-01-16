using System.ComponentModel.DataAnnotations;

namespace WebApplication2_My4.Models
{
    public class Employee
    {
        [Required(ErrorMessage ="please write your name")]
        public string? Firstname { get; set; }
        
        [Required]
        public string? Lastname { get; set; }
        [Required(ErrorMessage ="Enter valid email")]
        [EmailAddress]
        public string? Email { get; set; }
        [Required]
        [Range(18, 100)]
        public int Age { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShopingCart.Models
{
    [Table("General")]
    public class General
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(40)]
        public string? GeneralName { get; set; }
        public string GeneralId { get; set; }
        public List<Book> Books { get; set; }
    }
}

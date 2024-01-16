using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShopingCart.Models
{
    [Table("Book")]
    public class Book
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(40)]
        public string BookName { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        [Required]
        public string GeneralId { get; set; }
        public General General;
    }
}

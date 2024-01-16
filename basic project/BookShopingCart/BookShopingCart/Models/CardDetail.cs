using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShopingCart.Models
{
    [Table("CartDetail")]
    public class CardDetail
    {
        public int Id { get; set; }
        [Required]
        public int ShopingCartId { get; set; }
        [Required]
        public int BookId { get; set; }
        [Required]
        public int Quantity { get; set; }
        public Book Book { get; set; }
        public ShopingCart ShopingCart { get; set; }
    }
}

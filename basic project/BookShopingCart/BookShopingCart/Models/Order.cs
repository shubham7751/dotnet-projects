﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShopingCart.Models
{
    [Table("Order")]
    public class Order
    {
        public int Id { get; set; }
        [Required]
        public string UserId { get; set; }
        public DateTime CreateDate { get; set; }= DateTime.Now;
        public int OrderStatus { get; set; }
        public bool IsDeleates { get; set; }= false;
        
        public OrderStatus orderStatus { get; set; }
        public List<OrderDetail> Details { get; set; }

    }
}

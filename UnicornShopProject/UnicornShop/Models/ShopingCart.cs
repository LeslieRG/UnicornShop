using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Index = System.Index;

namespace UnicornShop.Models
{
    public class ShopingCart
    {
        [Key]
        public int Id { get; set; }
        public string SessionId { get; set; }
        public virtual ICollection<CartItem> CartItems { get; set; }
    }
}

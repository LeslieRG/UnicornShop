using System.ComponentModel.DataAnnotations;

namespace UnicornShop.Models
{
    public class CartItem
    {
        [Key]
        public int Id { get; set; }
        public int CartId { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public virtual ShopingCart ShopingCart { get; set; }
    }
}
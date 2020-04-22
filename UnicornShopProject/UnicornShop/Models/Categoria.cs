using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UnicornShop.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }
        public string  Nombre { get; set; }
        public ICollection<Producto> Productos { get; set; }
    }
}
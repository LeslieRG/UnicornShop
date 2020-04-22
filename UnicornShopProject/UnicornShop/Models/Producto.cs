using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UnicornShop.Models
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }

        [Column("Descripcion")]
        public string Descripción { get; set; }
        public decimal Precio { get; set; }
        public string UrlImagen { get; set; }

        public virtual Categoria Category { get; set; }
    }
}

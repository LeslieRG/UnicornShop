using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnicornShop.Models;

namespace UnicornShop.DAL
{
    public static class DbInitializer
    {
       public static void Initialize(UnicornShopContext context)
        {
            context.Database.EnsureCreated();
            
            if (context.Producto.Any())
            {
                return;   // DB has been seeded
            }
            var categorias = new List<Categoria>
            {
                new Categoria
                {
                    Nombre="Ropa Mujeres"
                },
                  new Categoria
                {
                    Nombre="Accesorios"
                },
                      new Categoria
                {
                    Nombre="Ropa Niñas"
                },
            };

            categorias.ForEach(c => context.Categoria.Add(c));
            context.SaveChanges();
            var productos = new List<Producto>
            {
                 new Producto
                {
                    Nombre="T-shirt Blanco",
                    Descripción="T-shirt blanco con logo de Unicornio One Size",
                    Precio= 250.00M,
                    Category=categorias[0],
                    UrlImagen="https://ae01.alicdn.com/kf/HTB1EyLYKNjaK1RjSZKzq6xVwXXa4.jpg"

                },

                   new Producto
                {
                    Nombre="Aretes",
                    Descripción="Bonitos aretes",
                    Precio= 150.00M,
                    Category=categorias[2],
                    UrlImagen="https://www.greentreejewelry.com/images/detailed/14/1515_-_Unicorn.jpg"

                },
            };
            productos.ForEach(c => context.Producto.Add(c));
            context.SaveChanges();
        }
    }
}

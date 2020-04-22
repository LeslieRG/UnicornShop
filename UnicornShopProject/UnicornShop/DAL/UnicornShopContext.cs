using Microsoft.EntityFrameworkCore;
using System.Linq;
using UnicornShop.Models;
using UnicornShop.Utility;

namespace UnicornShop.DAL
{
    public class UnicornShopContext  : DbContext
    {
        public DbSet <CartItem> CartItems { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<ShopingCart> ShopingCarts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // equivalent of modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.EntityTypes()
                        .Configure(et => et.Relational().TableName = et.DisplayName());

            // Put the table name on the primary key
            modelBuilder.Properties()
                        .Where(x => x.Name == "Id")
                        .Configure(p => p.Relational().ColumnName = p.DeclaringEntityType.Name + "Id");
        }
    }
}

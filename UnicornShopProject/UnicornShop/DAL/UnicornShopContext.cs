using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UnicornShop.Models;

namespace UnicornShop.DAL
{
    public class UnicornShopContext : DbContext
    {
        public UnicornShopContext (DbContextOptions<UnicornShopContext> options)
            : base(options)
        {
        }

        public DbSet<UnicornShop.Models.Producto> Producto { get; set; }
        public DbSet<UnicornShop.Models.Categoria> Categoria { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>().ToTable("Categoria");
            modelBuilder.Entity<Producto>().ToTable("Producto");
        }
    }
}

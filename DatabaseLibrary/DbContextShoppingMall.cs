using Database_Connection.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLibrary
{
    public class DbContextShoppingMall:DbContext
    {
        public DbSet<ShoppingMallDetails>? ShoppingMallDetails { get; set; }
        public DbContextShoppingMall() { }
        public DbContextShoppingMall(DbContextOptions options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-QQUJ36KT;Database= ShoppingMall;Trusted_Connection=True;");
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ShoppingMallDetails>()
                .HasIndex(u => u.ShoppingMallName)
                .IsUnique();
        }
    }
}

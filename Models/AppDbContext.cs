using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondCharliesTechShop.Models
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }

        public DbSet<Tech> Tech { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Laptops" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Computer Mice" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Mouse Pads" });

            modelBuilder.Entity<Tech>().HasData(new Tech
            {
                TechId = 1,
                Name = "Acer Laptop",
                Price = 799.99M,
                CategoryId = 1,
                ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/81H9y1pPW6L._AC_SL1500_.jpg",
                InStock = true,
                PopularTech = true
            });

            modelBuilder.Entity<Tech>().HasData(new Tech
            {
                TechId = 2,
                Name = "PICTEK Gaming Mouse",
                Price = 15.29M,
                CategoryId = 2,
                ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/61d9C4yCB2L._AC_SL1000_.jpg",
                InStock = true,
                PopularTech = false
            });

            modelBuilder.Entity<Tech>().HasData(new Tech
            {
                TechId = 3,
                Name = "Teemo Mouse Pad",
                Price = 10.99M,
                CategoryId = 3,
                ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/51Wf5oBCB1L._AC_SL1000_.jpg",
                InStock = true,
                PopularTech = false
            });

            modelBuilder.Entity<Tech>().HasData(new Tech
            {
                TechId = 4,
                Name = "Logitech G602 Mouse",
                Price = 24.99M,
                CategoryId = 2,
                ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/81ZQgWwuVzL._AC_SL1500_.jpg",
                InStock = true,
                PopularTech = false
            });
        }
    }
}

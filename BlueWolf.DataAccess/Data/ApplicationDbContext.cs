using BlueWolf.Models;
using BlueWolf.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace BlueWolf.Data
{
    public class ApplicationDbContext :DbContext

    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", Displayorder = 1 },
                new Category { Id = 2, Name = "Science Fiction", Displayorder = 2 },
                new Category { Id = 3, Name = "History", Displayorder = 3 }
                );

            modelBuilder.Entity<Product>().HasData(
                    new Product
                    {
                        Id = 1,
                        Title = "Looking Into The Past",
                        Description = "The Native American Chief Recaling his life",
                        Type = 1,
                        ImageSize = 1,
                        Price = 20.00,
                        ImageRating = 1,
                        Matting = false,
                        Framing = false
                    },
                    new Product
                    {
                        Id = 2,
                        Title = "Mosaic Sunset",
                        Description = "Sunset of Chips of Glass",
                        Type = 1,
                        ImageSize = 1,
                        Price = 20.00,
                        ImageRating = 1,
                        Matting = false,
                        Framing = false
                    },

                    new Product
                    {
                        Id = 3,
                        Title = "Eggplant",
                        Description = "Illustration of an Eggplant",
                        Type = 1,
                        ImageSize = 1,
                        Price = 20.00,
                        ImageRating = 1,
                        Matting = false,
                        Framing = false
                    }


                );
        }
    }
}

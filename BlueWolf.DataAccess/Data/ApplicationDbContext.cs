﻿using BlueWolf.Models;
using Microsoft.EntityFrameworkCore;

namespace BlueWolf.Data
{
    public class ApplicationDbContext :DbContext

    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", Displayorder = 1 },
                new Category { Id = 2, Name = "Science Fiction", Displayorder = 2 },
                new Category { Id = 3, Name = "History", Displayorder = 3 }
                );
        }
    }
}

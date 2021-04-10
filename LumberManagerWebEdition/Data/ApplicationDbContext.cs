﻿using LumberManagerWebEdition.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LumberManagerWebEdition.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderLineItems> OrderLineItems { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<OrderLineItems>().HasKey(OrderLineItems => new { OrderLineItems.OrderID, OrderLineItems.ProductID });
            builder.Entity<IdentityUserRole<string>>().HasNoKey();
            builder.Entity<IdentityUserLogin<string>>().HasNoKey();
            builder.Entity<IdentityUserToken<string>>().HasNoKey();

            builder.Entity<Category>().HasData(new Category { CategoryID = 1, CategoryName = "WW" });
            builder.Entity<Category>().HasData(new Category { CategoryID = 2, CategoryName = ".25" });
            builder.Entity<Category>().HasData(new Category { CategoryID = 3, CategoryName = ".40" });
            builder.Entity<Category>().HasData(new Category { CategoryID = 4, CategoryName = ".60" });
            builder.Entity<Category>().HasData(new Category { CategoryID = 5, CategoryName = "ACQ" });
            builder.Entity<Category>().HasData(new Category { CategoryID = 6, CategoryName = "CCA" });

        }
        public virtual DbSet<Customer> Customers { get; set; }
    }
}
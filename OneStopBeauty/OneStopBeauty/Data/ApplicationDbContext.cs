using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OneStopBeauty.Models;

namespace OneStopBeauty.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<BillingStatement> BillingStatements { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<ItemOrdered> ItemsOrdered { get; set; }
        public DbSet<ItemSold> ItemsSold { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<Service> Services { get; set; }
        

    }
}


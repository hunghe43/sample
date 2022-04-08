using Microsoft.EntityFrameworkCore;
using System;

namespace Sample.Entities.Data
{
    public partial class NorthwindContext : DbContext
    {
        public NorthwindContext(DbContextOptions<NorthwindContext> options)
            : base(options)
        {
        }

        #region Generated Properties
        public virtual DbSet<Sample.Entities.Data.Entities.Categories> Categories { get; set; }

        public virtual DbSet<Sample.Entities.Data.Entities.CustomerCustomerDemo> CustomerCustomerDemos { get; set; }

        public virtual DbSet<Sample.Entities.Data.Entities.CustomerDemographics> CustomerDemographics { get; set; }

        public virtual DbSet<Sample.Entities.Data.Entities.Customers> Customers { get; set; }

        public virtual DbSet<Sample.Entities.Data.Entities.Employees> Employees { get; set; }

        public virtual DbSet<Sample.Entities.Data.Entities.EmployeeTerritories> EmployeeTerritories { get; set; }

        public virtual DbSet<Sample.Entities.Data.Entities.OrderDetails> OrderDetails { get; set; }

        public virtual DbSet<Sample.Entities.Data.Entities.Orders> Orders { get; set; }

        public virtual DbSet<Sample.Entities.Data.Entities.Products> Products { get; set; }

        public virtual DbSet<Sample.Entities.Data.Entities.Region> Regions { get; set; }

        public virtual DbSet<Sample.Entities.Data.Entities.Shippers> Shippers { get; set; }

        public virtual DbSet<Sample.Entities.Data.Entities.Suppliers> Suppliers { get; set; }

        public virtual DbSet<Sample.Entities.Data.Entities.Territories> Territories { get; set; }

        public virtual DbSet<Sample.Entities.Data.Entities.UsStates> UsStates { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Generated Configuration
            modelBuilder.ApplyConfiguration(new Sample.Entities.Data.Mapping.CategoriesMap());
            modelBuilder.ApplyConfiguration(new Sample.Entities.Data.Mapping.CustomerCustomerDemoMap());
            modelBuilder.ApplyConfiguration(new Sample.Entities.Data.Mapping.CustomerDemographicsMap());
            modelBuilder.ApplyConfiguration(new Sample.Entities.Data.Mapping.CustomersMap());
            modelBuilder.ApplyConfiguration(new Sample.Entities.Data.Mapping.EmployeesMap());
            modelBuilder.ApplyConfiguration(new Sample.Entities.Data.Mapping.EmployeeTerritoriesMap());
            modelBuilder.ApplyConfiguration(new Sample.Entities.Data.Mapping.OrderDetailsMap());
            modelBuilder.ApplyConfiguration(new Sample.Entities.Data.Mapping.OrdersMap());
            modelBuilder.ApplyConfiguration(new Sample.Entities.Data.Mapping.ProductsMap());
            modelBuilder.ApplyConfiguration(new Sample.Entities.Data.Mapping.RegionMap());
            modelBuilder.ApplyConfiguration(new Sample.Entities.Data.Mapping.ShippersMap());
            modelBuilder.ApplyConfiguration(new Sample.Entities.Data.Mapping.SuppliersMap());
            modelBuilder.ApplyConfiguration(new Sample.Entities.Data.Mapping.TerritoriesMap());
            modelBuilder.ApplyConfiguration(new Sample.Entities.Data.Mapping.UsStatesMap());
            #endregion
        }
    }
}

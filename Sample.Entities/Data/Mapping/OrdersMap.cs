using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sample.Entities.Data.Mapping
{
    public partial class OrdersMap
        : IEntityTypeConfiguration<Sample.Entities.Data.Entities.Orders>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sample.Entities.Data.Entities.Orders> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("orders", "public");

            // key
            builder.HasKey(t => t.OrderId);

            // properties
            builder.Property(t => t.OrderId)
                .IsRequired()
                .HasColumnName("order_id")
                .HasColumnType("smallint");

            builder.Property(t => t.CustomerId)
                .HasColumnName("customer_id")
                .HasColumnType("character");

            builder.Property(t => t.EmployeeId)
                .HasColumnName("employee_id")
                .HasColumnType("smallint");

            builder.Property(t => t.OrderDate)
                .HasColumnName("order_date")
                .HasColumnType("date");

            builder.Property(t => t.RequiredDate)
                .HasColumnName("required_date")
                .HasColumnType("date");

            builder.Property(t => t.ShippedDate)
                .HasColumnName("shipped_date")
                .HasColumnType("date");

            builder.Property(t => t.ShipVia)
                .HasColumnName("ship_via")
                .HasColumnType("smallint");

            builder.Property(t => t.Freight)
                .HasColumnName("freight")
                .HasColumnType("real");

            builder.Property(t => t.ShipName)
                .HasColumnName("ship_name")
                .HasColumnType("character varying(40)")
                .HasMaxLength(40);

            builder.Property(t => t.ShipAddress)
                .HasColumnName("ship_address")
                .HasColumnType("character varying(60)")
                .HasMaxLength(60);

            builder.Property(t => t.ShipCity)
                .HasColumnName("ship_city")
                .HasColumnType("character varying(15)")
                .HasMaxLength(15);

            builder.Property(t => t.ShipRegion)
                .HasColumnName("ship_region")
                .HasColumnType("character varying(15)")
                .HasMaxLength(15);

            builder.Property(t => t.ShipPostalCode)
                .HasColumnName("ship_postal_code")
                .HasColumnType("character varying(10)")
                .HasMaxLength(10);

            builder.Property(t => t.ShipCountry)
                .HasColumnName("ship_country")
                .HasColumnType("character varying(15)")
                .HasMaxLength(15);

            // relationships
            builder.HasOne(t => t.Customers)
                .WithMany(t => t.Orders)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("fk_orders_customers");

            builder.HasOne(t => t.Employees)
                .WithMany(t => t.Orders)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("fk_orders_employees");

            builder.HasOne(t => t.ShipViaShippers)
                .WithMany(t => t.ShipViaOrders)
                .HasForeignKey(d => d.ShipVia)
                .HasConstraintName("fk_orders_shippers");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "public";
            public const string Name = "orders";
        }

        public struct Columns
        {
            public const string OrderId = "order_id";
            public const string CustomerId = "customer_id";
            public const string EmployeeId = "employee_id";
            public const string OrderDate = "order_date";
            public const string RequiredDate = "required_date";
            public const string ShippedDate = "shipped_date";
            public const string ShipVia = "ship_via";
            public const string Freight = "freight";
            public const string ShipName = "ship_name";
            public const string ShipAddress = "ship_address";
            public const string ShipCity = "ship_city";
            public const string ShipRegion = "ship_region";
            public const string ShipPostalCode = "ship_postal_code";
            public const string ShipCountry = "ship_country";
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sample.Entities.Data.Mapping
{
    public partial class OrderDetailsMap
        : IEntityTypeConfiguration<Sample.Entities.Data.Entities.OrderDetails>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sample.Entities.Data.Entities.OrderDetails> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("order_details", "public");

            // key
            builder.HasKey(t => new { t.OrderId, t.ProductId });

            // properties
            builder.Property(t => t.OrderId)
                .IsRequired()
                .HasColumnName("order_id")
                .HasColumnType("smallint");

            builder.Property(t => t.ProductId)
                .IsRequired()
                .HasColumnName("product_id")
                .HasColumnType("smallint");

            builder.Property(t => t.UnitPrice)
                .IsRequired()
                .HasColumnName("unit_price")
                .HasColumnType("real");

            builder.Property(t => t.Quantity)
                .IsRequired()
                .HasColumnName("quantity")
                .HasColumnType("smallint");

            builder.Property(t => t.Discount)
                .IsRequired()
                .HasColumnName("discount")
                .HasColumnType("real");

            // relationships
            builder.HasOne(t => t.Products)
                .WithMany(t => t.OrderDetails)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("fk_order_details_products");

            builder.HasOne(t => t.Orders)
                .WithMany(t => t.OrderDetails)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("fk_order_details_orders");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "public";
            public const string Name = "order_details";
        }

        public struct Columns
        {
            public const string OrderId = "order_id";
            public const string ProductId = "product_id";
            public const string UnitPrice = "unit_price";
            public const string Quantity = "quantity";
            public const string Discount = "discount";
        }
        #endregion
    }
}

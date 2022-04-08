using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sample.Entities.Data.Mapping
{
    public partial class ProductsMap
        : IEntityTypeConfiguration<Sample.Entities.Data.Entities.Products>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sample.Entities.Data.Entities.Products> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("products", "public");

            // key
            builder.HasKey(t => t.ProductId);

            // properties
            builder.Property(t => t.ProductId)
                .IsRequired()
                .HasColumnName("product_id")
                .HasColumnType("smallint");

            builder.Property(t => t.ProductName)
                .IsRequired()
                .HasColumnName("product_name")
                .HasColumnType("character varying(40)")
                .HasMaxLength(40);

            builder.Property(t => t.SupplierId)
                .HasColumnName("supplier_id")
                .HasColumnType("smallint");

            builder.Property(t => t.CategoryId)
                .HasColumnName("category_id")
                .HasColumnType("smallint");

            builder.Property(t => t.QuantityPerUnit)
                .HasColumnName("quantity_per_unit")
                .HasColumnType("character varying(20)")
                .HasMaxLength(20);

            builder.Property(t => t.UnitPrice)
                .HasColumnName("unit_price")
                .HasColumnType("real");

            builder.Property(t => t.UnitsInStock)
                .HasColumnName("units_in_stock")
                .HasColumnType("smallint");

            builder.Property(t => t.UnitsOnOrder)
                .HasColumnName("units_on_order")
                .HasColumnType("smallint");

            builder.Property(t => t.ReorderLevel)
                .HasColumnName("reorder_level")
                .HasColumnType("smallint");

            builder.Property(t => t.Discontinued)
                .IsRequired()
                .HasColumnName("discontinued")
                .HasColumnType("integer");

            // relationships
            builder.HasOne(t => t.Categories)
                .WithMany(t => t.Products)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("fk_products_categories");

            builder.HasOne(t => t.Suppliers)
                .WithMany(t => t.Products)
                .HasForeignKey(d => d.SupplierId)
                .HasConstraintName("fk_products_suppliers");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "public";
            public const string Name = "products";
        }

        public struct Columns
        {
            public const string ProductId = "product_id";
            public const string ProductName = "product_name";
            public const string SupplierId = "supplier_id";
            public const string CategoryId = "category_id";
            public const string QuantityPerUnit = "quantity_per_unit";
            public const string UnitPrice = "unit_price";
            public const string UnitsInStock = "units_in_stock";
            public const string UnitsOnOrder = "units_on_order";
            public const string ReorderLevel = "reorder_level";
            public const string Discontinued = "discontinued";
        }
        #endregion
    }
}

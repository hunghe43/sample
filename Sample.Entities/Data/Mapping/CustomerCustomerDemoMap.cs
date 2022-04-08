using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sample.Entities.Data.Mapping
{
    public partial class CustomerCustomerDemoMap
        : IEntityTypeConfiguration<Sample.Entities.Data.Entities.CustomerCustomerDemo>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sample.Entities.Data.Entities.CustomerCustomerDemo> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("customer_customer_demo", "public");

            // key
            builder.HasKey(t => new { t.CustomerId, t.CustomerTypeId });

            // properties
            builder.Property(t => t.CustomerId)
                .IsRequired()
                .HasColumnName("customer_id")
                .HasColumnType("character");

            builder.Property(t => t.CustomerTypeId)
                .IsRequired()
                .HasColumnName("customer_type_id")
                .HasColumnType("character");

            // relationships
            builder.HasOne(t => t.CustomerDemographics)
                .WithMany(t => t.CustomerCustomerDemos)
                .HasForeignKey(d => d.CustomerTypeId)
                .HasConstraintName("fk_customer_customer_demo_customer_demographics");

            builder.HasOne(t => t.Customers)
                .WithMany(t => t.CustomerCustomerDemos)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("fk_customer_customer_demo_customers");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "public";
            public const string Name = "customer_customer_demo";
        }

        public struct Columns
        {
            public const string CustomerId = "customer_id";
            public const string CustomerTypeId = "customer_type_id";
        }
        #endregion
    }
}

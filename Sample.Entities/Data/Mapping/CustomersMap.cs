using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sample.Entities.Data.Mapping
{
    public partial class CustomersMap
        : IEntityTypeConfiguration<Sample.Entities.Data.Entities.Customers>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sample.Entities.Data.Entities.Customers> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("customers", "public");

            // key
            builder.HasKey(t => t.CustomerId);

            // properties
            builder.Property(t => t.CustomerId)
                .IsRequired()
                .HasColumnName("customer_id")
                .HasColumnType("character");

            builder.Property(t => t.CompanyName)
                .IsRequired()
                .HasColumnName("company_name")
                .HasColumnType("character varying(40)")
                .HasMaxLength(40);

            builder.Property(t => t.ContactName)
                .HasColumnName("contact_name")
                .HasColumnType("character varying(30)")
                .HasMaxLength(30);

            builder.Property(t => t.ContactTitle)
                .HasColumnName("contact_title")
                .HasColumnType("character varying(30)")
                .HasMaxLength(30);

            builder.Property(t => t.Address)
                .HasColumnName("address")
                .HasColumnType("character varying(60)")
                .HasMaxLength(60);

            builder.Property(t => t.City)
                .HasColumnName("city")
                .HasColumnType("character varying(15)")
                .HasMaxLength(15);

            builder.Property(t => t.Region)
                .HasColumnName("region")
                .HasColumnType("character varying(15)")
                .HasMaxLength(15);

            builder.Property(t => t.PostalCode)
                .HasColumnName("postal_code")
                .HasColumnType("character varying(10)")
                .HasMaxLength(10);

            builder.Property(t => t.Country)
                .HasColumnName("country")
                .HasColumnType("character varying(15)")
                .HasMaxLength(15);

            builder.Property(t => t.Phone)
                .HasColumnName("phone")
                .HasColumnType("character varying(24)")
                .HasMaxLength(24);

            builder.Property(t => t.Fax)
                .HasColumnName("fax")
                .HasColumnType("character varying(24)")
                .HasMaxLength(24);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "public";
            public const string Name = "customers";
        }

        public struct Columns
        {
            public const string CustomerId = "customer_id";
            public const string CompanyName = "company_name";
            public const string ContactName = "contact_name";
            public const string ContactTitle = "contact_title";
            public const string Address = "address";
            public const string City = "city";
            public const string Region = "region";
            public const string PostalCode = "postal_code";
            public const string Country = "country";
            public const string Phone = "phone";
            public const string Fax = "fax";
        }
        #endregion
    }
}

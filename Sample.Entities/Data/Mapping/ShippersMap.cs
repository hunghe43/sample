using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sample.Entities.Data.Mapping
{
    public partial class ShippersMap
        : IEntityTypeConfiguration<Sample.Entities.Data.Entities.Shippers>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sample.Entities.Data.Entities.Shippers> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("shippers", "public");

            // key
            builder.HasKey(t => t.ShipperId);

            // properties
            builder.Property(t => t.ShipperId)
                .IsRequired()
                .HasColumnName("shipper_id")
                .HasColumnType("smallint");

            builder.Property(t => t.CompanyName)
                .IsRequired()
                .HasColumnName("company_name")
                .HasColumnType("character varying(40)")
                .HasMaxLength(40);

            builder.Property(t => t.Phone)
                .HasColumnName("phone")
                .HasColumnType("character varying(24)")
                .HasMaxLength(24);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "public";
            public const string Name = "shippers";
        }

        public struct Columns
        {
            public const string ShipperId = "shipper_id";
            public const string CompanyName = "company_name";
            public const string Phone = "phone";
        }
        #endregion
    }
}

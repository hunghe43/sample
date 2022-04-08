using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sample.Entities.Data.Mapping
{
    public partial class CustomerDemographicsMap
        : IEntityTypeConfiguration<Sample.Entities.Data.Entities.CustomerDemographics>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sample.Entities.Data.Entities.CustomerDemographics> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("customer_demographics", "public");

            // key
            builder.HasKey(t => t.CustomerTypeId);

            // properties
            builder.Property(t => t.CustomerTypeId)
                .IsRequired()
                .HasColumnName("customer_type_id")
                .HasColumnType("character");

            builder.Property(t => t.CustomerDesc)
                .HasColumnName("customer_desc")
                .HasColumnType("text");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "public";
            public const string Name = "customer_demographics";
        }

        public struct Columns
        {
            public const string CustomerTypeId = "customer_type_id";
            public const string CustomerDesc = "customer_desc";
        }
        #endregion
    }
}

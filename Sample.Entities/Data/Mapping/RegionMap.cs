using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sample.Entities.Data.Mapping
{
    public partial class RegionMap
        : IEntityTypeConfiguration<Sample.Entities.Data.Entities.Region>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sample.Entities.Data.Entities.Region> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("region", "public");

            // key
            builder.HasKey(t => t.RegionId);

            // properties
            builder.Property(t => t.RegionId)
                .IsRequired()
                .HasColumnName("region_id")
                .HasColumnType("smallint");

            builder.Property(t => t.RegionDescription)
                .IsRequired()
                .HasColumnName("region_description")
                .HasColumnType("character");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "public";
            public const string Name = "region";
        }

        public struct Columns
        {
            public const string RegionId = "region_id";
            public const string RegionDescription = "region_description";
        }
        #endregion
    }
}

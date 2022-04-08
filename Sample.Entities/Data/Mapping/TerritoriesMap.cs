using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sample.Entities.Data.Mapping
{
    public partial class TerritoriesMap
        : IEntityTypeConfiguration<Sample.Entities.Data.Entities.Territories>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sample.Entities.Data.Entities.Territories> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("territories", "public");

            // key
            builder.HasKey(t => t.TerritoryId);

            // properties
            builder.Property(t => t.TerritoryId)
                .IsRequired()
                .HasColumnName("territory_id")
                .HasColumnType("character varying(20)")
                .HasMaxLength(20);

            builder.Property(t => t.TerritoryDescription)
                .IsRequired()
                .HasColumnName("territory_description")
                .HasColumnType("character");

            builder.Property(t => t.RegionId)
                .IsRequired()
                .HasColumnName("region_id")
                .HasColumnType("smallint");

            // relationships
            builder.HasOne(t => t.Region)
                .WithMany(t => t.Territories)
                .HasForeignKey(d => d.RegionId)
                .HasConstraintName("fk_territories_region");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "public";
            public const string Name = "territories";
        }

        public struct Columns
        {
            public const string TerritoryId = "territory_id";
            public const string TerritoryDescription = "territory_description";
            public const string RegionId = "region_id";
        }
        #endregion
    }
}

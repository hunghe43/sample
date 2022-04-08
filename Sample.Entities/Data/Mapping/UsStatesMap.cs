using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sample.Entities.Data.Mapping
{
    public partial class UsStatesMap
        : IEntityTypeConfiguration<Sample.Entities.Data.Entities.UsStates>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sample.Entities.Data.Entities.UsStates> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("us_states", "public");

            // key
            builder.HasKey(t => t.StateId);

            // properties
            builder.Property(t => t.StateId)
                .IsRequired()
                .HasColumnName("state_id")
                .HasColumnType("smallint");

            builder.Property(t => t.StateName)
                .HasColumnName("state_name")
                .HasColumnType("character varying(100)")
                .HasMaxLength(100);

            builder.Property(t => t.StateAbbr)
                .HasColumnName("state_abbr")
                .HasColumnType("character varying(2)")
                .HasMaxLength(2);

            builder.Property(t => t.StateRegion)
                .HasColumnName("state_region")
                .HasColumnType("character varying(50)")
                .HasMaxLength(50);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "public";
            public const string Name = "us_states";
        }

        public struct Columns
        {
            public const string StateId = "state_id";
            public const string StateName = "state_name";
            public const string StateAbbr = "state_abbr";
            public const string StateRegion = "state_region";
        }
        #endregion
    }
}

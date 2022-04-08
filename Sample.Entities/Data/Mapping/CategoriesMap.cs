using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sample.Entities.Data.Mapping
{
    public partial class CategoriesMap
        : IEntityTypeConfiguration<Sample.Entities.Data.Entities.Categories>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sample.Entities.Data.Entities.Categories> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("categories", "public");

            // key
            builder.HasKey(t => t.CategoryId);

            // properties
            builder.Property(t => t.CategoryId)
                .IsRequired()
                .HasColumnName("category_id")
                .HasColumnType("smallint");

            builder.Property(t => t.CategoryName)
                .IsRequired()
                .HasColumnName("category_name")
                .HasColumnType("character varying(15)")
                .HasMaxLength(15);

            builder.Property(t => t.Description)
                .HasColumnName("description")
                .HasColumnType("text");

            builder.Property(t => t.Picture)
                .HasColumnName("picture")
                .HasColumnType("bytea");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "public";
            public const string Name = "categories";
        }

        public struct Columns
        {
            public const string CategoryId = "category_id";
            public const string CategoryName = "category_name";
            public const string Description = "description";
            public const string Picture = "picture";
        }
        #endregion
    }
}

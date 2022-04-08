using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sample.Entities.Data.Mapping
{
    public partial class EmployeeTerritoriesMap
        : IEntityTypeConfiguration<Sample.Entities.Data.Entities.EmployeeTerritories>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sample.Entities.Data.Entities.EmployeeTerritories> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("employee_territories", "public");

            // key
            builder.HasKey(t => new { t.EmployeeId, t.TerritoryId });

            // properties
            builder.Property(t => t.EmployeeId)
                .IsRequired()
                .HasColumnName("employee_id")
                .HasColumnType("smallint");

            builder.Property(t => t.TerritoryId)
                .IsRequired()
                .HasColumnName("territory_id")
                .HasColumnType("character varying(20)")
                .HasMaxLength(20);

            // relationships
            builder.HasOne(t => t.Territories)
                .WithMany(t => t.EmployeeTerritories)
                .HasForeignKey(d => d.TerritoryId)
                .HasConstraintName("fk_employee_territories_territories");

            builder.HasOne(t => t.Employees)
                .WithMany(t => t.EmployeeTerritories)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("fk_employee_territories_employees");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "public";
            public const string Name = "employee_territories";
        }

        public struct Columns
        {
            public const string EmployeeId = "employee_id";
            public const string TerritoryId = "territory_id";
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sample.Entities.Data.Mapping
{
    public partial class EmployeesMap
        : IEntityTypeConfiguration<Sample.Entities.Data.Entities.Employees>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sample.Entities.Data.Entities.Employees> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("employees", "public");

            // key
            builder.HasKey(t => t.EmployeeId);

            // properties
            builder.Property(t => t.EmployeeId)
                .IsRequired()
                .HasColumnName("employee_id")
                .HasColumnType("smallint");

            builder.Property(t => t.LastName)
                .IsRequired()
                .HasColumnName("last_name")
                .HasColumnType("character varying(20)")
                .HasMaxLength(20);

            builder.Property(t => t.FirstName)
                .IsRequired()
                .HasColumnName("first_name")
                .HasColumnType("character varying(10)")
                .HasMaxLength(10);

            builder.Property(t => t.Title)
                .HasColumnName("title")
                .HasColumnType("character varying(30)")
                .HasMaxLength(30);

            builder.Property(t => t.TitleOfCourtesy)
                .HasColumnName("title_of_courtesy")
                .HasColumnType("character varying(25)")
                .HasMaxLength(25);

            builder.Property(t => t.BirthDate)
                .HasColumnName("birth_date")
                .HasColumnType("date");

            builder.Property(t => t.HireDate)
                .HasColumnName("hire_date")
                .HasColumnType("date");

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

            builder.Property(t => t.HomePhone)
                .HasColumnName("home_phone")
                .HasColumnType("character varying(24)")
                .HasMaxLength(24);

            builder.Property(t => t.Extension)
                .HasColumnName("extension")
                .HasColumnType("character varying(4)")
                .HasMaxLength(4);

            builder.Property(t => t.Photo)
                .HasColumnName("photo")
                .HasColumnType("bytea");

            builder.Property(t => t.Notes)
                .HasColumnName("notes")
                .HasColumnType("text");

            builder.Property(t => t.ReportsTo)
                .HasColumnName("reports_to")
                .HasColumnType("smallint");

            builder.Property(t => t.PhotoPath)
                .HasColumnName("photo_path")
                .HasColumnType("character varying(255)")
                .HasMaxLength(255);

            // relationships
            builder.HasOne(t => t.ReportsToEmployees)
                .WithMany(t => t.ReportsToEmployees1)
                .HasForeignKey(d => d.ReportsTo)
                .HasConstraintName("fk_employees_employees");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "public";
            public const string Name = "employees";
        }

        public struct Columns
        {
            public const string EmployeeId = "employee_id";
            public const string LastName = "last_name";
            public const string FirstName = "first_name";
            public const string Title = "title";
            public const string TitleOfCourtesy = "title_of_courtesy";
            public const string BirthDate = "birth_date";
            public const string HireDate = "hire_date";
            public const string Address = "address";
            public const string City = "city";
            public const string Region = "region";
            public const string PostalCode = "postal_code";
            public const string Country = "country";
            public const string HomePhone = "home_phone";
            public const string Extension = "extension";
            public const string Photo = "photo";
            public const string Notes = "notes";
            public const string ReportsTo = "reports_to";
            public const string PhotoPath = "photo_path";
        }
        #endregion
    }
}

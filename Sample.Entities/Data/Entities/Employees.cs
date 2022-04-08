using System;
using System.Collections.Generic;

namespace Sample.Entities.Data.Entities
{
    public partial class Employees
        : Sample.Core.Entities.BaseEntity
    {
        public Employees()
        {
            #region Generated Constructor
            EmployeeTerritories = new HashSet<EmployeeTerritories>();
            Orders = new HashSet<Orders>();
            ReportsToEmployees1 = new HashSet<Employees>();
            #endregion
        }

        #region Generated Properties
        public short EmployeeId { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string Title { get; set; }

        public string TitleOfCourtesy { get; set; }

        public DateTime? BirthDate { get; set; }

        public DateTime? HireDate { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string Region { get; set; }

        public string PostalCode { get; set; }

        public string Country { get; set; }

        public string HomePhone { get; set; }

        public string Extension { get; set; }

        public Byte[] Photo { get; set; }

        public string Notes { get; set; }

        public short? ReportsTo { get; set; }

        public string PhotoPath { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<EmployeeTerritories> EmployeeTerritories { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }

        public virtual Employees ReportsToEmployees { get; set; }

        public virtual ICollection<Employees> ReportsToEmployees1 { get; set; }

        #endregion

    }
}

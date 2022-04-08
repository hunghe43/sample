using System;
using System.Collections.Generic;

namespace Sample.Entities.Data.Entities
{
    public partial class Customers
        : Sample.Core.Entities.BaseEntity
    {
        public Customers()
        {
            #region Generated Constructor
            CustomerCustomerDemos = new HashSet<CustomerCustomerDemo>();
            Orders = new HashSet<Orders>();
            #endregion
        }

        #region Generated Properties
        public string CustomerId { get; set; }

        public string CompanyName { get; set; }

        public string ContactName { get; set; }

        public string ContactTitle { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string Region { get; set; }

        public string PostalCode { get; set; }

        public string Country { get; set; }

        public string Phone { get; set; }

        public string Fax { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<CustomerCustomerDemo> CustomerCustomerDemos { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }

        #endregion

    }
}

using System;
using System.Collections.Generic;

namespace Sample.Entities.Data.Entities
{
    public partial class Suppliers
        : Sample.Core.Entities.BaseEntity
    {
        public Suppliers()
        {
            #region Generated Constructor
            Products = new HashSet<Products>();
            #endregion
        }

        #region Generated Properties
        public short SupplierId { get; set; }

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

        public string Homepage { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<Products> Products { get; set; }

        #endregion

    }
}

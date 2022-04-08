using System;
using System.Collections.Generic;

namespace Sample.Entities.Data.Entities
{
    public partial class CustomerCustomerDemo
        : Sample.Core.Entities.BaseEntity
    {
        public CustomerCustomerDemo()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public string CustomerId { get; set; }

        public string CustomerTypeId { get; set; }

        #endregion

        #region Generated Relationships
        public virtual CustomerDemographics CustomerDemographics { get; set; }

        public virtual Customers Customers { get; set; }

        #endregion

    }
}

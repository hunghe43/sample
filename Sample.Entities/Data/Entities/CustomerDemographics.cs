using System;
using System.Collections.Generic;

namespace Sample.Entities.Data.Entities
{
    public partial class CustomerDemographics
        : Sample.Core.Entities.BaseEntity
    {
        public CustomerDemographics()
        {
            #region Generated Constructor
            CustomerCustomerDemos = new HashSet<CustomerCustomerDemo>();
            #endregion
        }

        #region Generated Properties
        public string CustomerTypeId { get; set; }

        public string CustomerDesc { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<CustomerCustomerDemo> CustomerCustomerDemos { get; set; }

        #endregion

    }
}

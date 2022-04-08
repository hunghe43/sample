using System;
using System.Collections.Generic;

namespace Sample.Entities.Data.Entities
{
    public partial class Shippers
        : Sample.Core.Entities.BaseEntity
    {
        public Shippers()
        {
            #region Generated Constructor
            ShipViaOrders = new HashSet<Orders>();
            #endregion
        }

        #region Generated Properties
        public short ShipperId { get; set; }

        public string CompanyName { get; set; }

        public string Phone { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<Orders> ShipViaOrders { get; set; }

        #endregion

    }
}

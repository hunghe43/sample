using System;
using System.Collections.Generic;

namespace Sample.Entities.Data.Entities
{
    public partial class OrderDetails
        : Sample.Core.Entities.BaseEntity
    {
        public OrderDetails()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public short OrderId { get; set; }

        public short ProductId { get; set; }

        public float UnitPrice { get; set; }

        public short Quantity { get; set; }

        public float Discount { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Orders Orders { get; set; }

        public virtual Products Products { get; set; }

        #endregion

    }
}

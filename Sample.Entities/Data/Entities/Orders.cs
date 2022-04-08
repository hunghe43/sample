using System;
using System.Collections.Generic;

namespace Sample.Entities.Data.Entities
{
    public partial class Orders
        : Sample.Core.Entities.BaseEntity
    {
        public Orders()
        {
            #region Generated Constructor
            OrderDetails = new HashSet<OrderDetails>();
            #endregion
        }

        #region Generated Properties
        public short OrderId { get; set; }

        public string CustomerId { get; set; }

        public short? EmployeeId { get; set; }

        public DateTime? OrderDate { get; set; }

        public DateTime? RequiredDate { get; set; }

        public DateTime? ShippedDate { get; set; }

        public short? ShipVia { get; set; }

        public float? Freight { get; set; }

        public string ShipName { get; set; }

        public string ShipAddress { get; set; }

        public string ShipCity { get; set; }

        public string ShipRegion { get; set; }

        public string ShipPostalCode { get; set; }

        public string ShipCountry { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Customers Customers { get; set; }

        public virtual Employees Employees { get; set; }

        public virtual ICollection<OrderDetails> OrderDetails { get; set; }

        public virtual Shippers ShipViaShippers { get; set; }

        #endregion

    }
}

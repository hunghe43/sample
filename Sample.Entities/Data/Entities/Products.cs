using System;
using System.Collections.Generic;

namespace Sample.Entities.Data.Entities
{
    public partial class Products
        : Sample.Core.Entities.BaseEntity
    {
        public Products()
        {
            #region Generated Constructor
            OrderDetails = new HashSet<OrderDetails>();
            #endregion
        }

        #region Generated Properties
        public short ProductId { get; set; }

        public string ProductName { get; set; }

        public short? SupplierId { get; set; }

        public short? CategoryId { get; set; }

        public string QuantityPerUnit { get; set; }

        public float? UnitPrice { get; set; }

        public short? UnitsInStock { get; set; }

        public short? UnitsOnOrder { get; set; }

        public short? ReorderLevel { get; set; }

        public int Discontinued { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Categories Categories { get; set; }

        public virtual ICollection<OrderDetails> OrderDetails { get; set; }

        public virtual Suppliers Suppliers { get; set; }

        #endregion

    }
}

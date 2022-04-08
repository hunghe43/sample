using System;
using System.Collections.Generic;

namespace Sample.Entities.Data.Entities
{
    public partial class Categories
        : Sample.Core.Entities.BaseEntity
    {
        public Categories()
        {
            #region Generated Constructor
            Products = new HashSet<Products>();
            #endregion
        }

        #region Generated Properties
        public short CategoryId { get; set; }

        public string CategoryName { get; set; }

        public string Description { get; set; }

        public Byte[] Picture { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<Products> Products { get; set; }

        #endregion

    }
}

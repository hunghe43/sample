using System;
using System.Collections.Generic;

namespace Sample.Entities.Data.Entities
{
    public partial class Region
        : Sample.Core.Entities.BaseEntity
    {
        public Region()
        {
            #region Generated Constructor
            Territories = new HashSet<Territories>();
            #endregion
        }

        #region Generated Properties
        public short RegionId { get; set; }

        public string RegionDescription { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<Territories> Territories { get; set; }

        #endregion

    }
}

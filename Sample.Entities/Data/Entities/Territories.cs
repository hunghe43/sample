using System;
using System.Collections.Generic;

namespace Sample.Entities.Data.Entities
{
    public partial class Territories
        : Sample.Core.Entities.BaseEntity
    {
        public Territories()
        {
            #region Generated Constructor
            EmployeeTerritories = new HashSet<EmployeeTerritories>();
            #endregion
        }

        #region Generated Properties
        public string TerritoryId { get; set; }

        public string TerritoryDescription { get; set; }

        public short RegionId { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<EmployeeTerritories> EmployeeTerritories { get; set; }

        public virtual Region Region { get; set; }

        #endregion

    }
}

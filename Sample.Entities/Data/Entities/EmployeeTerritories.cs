using System;
using System.Collections.Generic;

namespace Sample.Entities.Data.Entities
{
    public partial class EmployeeTerritories
        : Sample.Core.Entities.BaseEntity
    {
        public EmployeeTerritories()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public short EmployeeId { get; set; }

        public string TerritoryId { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Employees Employees { get; set; }

        public virtual Territories Territories { get; set; }

        #endregion

    }
}

using System;
using System.Collections.Generic;

namespace Sample.Entities.Data.Entities
{
    public partial class UsStates
        : Sample.Core.Entities.BaseEntity
    {
        public UsStates()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public short StateId { get; set; }

        public string StateName { get; set; }

        public string StateAbbr { get; set; }

        public string StateRegion { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}

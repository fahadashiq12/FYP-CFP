using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstApproachPrac.DbContext.DbModels
{
    public class EntranceTestVenue : BaseDbModels.BaseDbClass
    {
        public string VenueName { get; set; }

        public DateTime VenueTime { get; set; }

        
    }
}
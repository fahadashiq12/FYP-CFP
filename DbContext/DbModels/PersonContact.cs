using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstApproachPrac.DbContext.DbModels
{
    public class PersonContact :BaseDbModels.BaseDbClass
    {
        public string GuardianName { get; set; }

        public string GuardianAddress { get; set; }

        public string GuardianContact { get; set; }

        public string EmergencyContact { get; set; }



    }
}
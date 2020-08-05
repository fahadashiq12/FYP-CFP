using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstApproachPrac.DbContext.DbModels
{
    public class Section : BaseDbModels.BaseDbClass
    {
        public string SectionName { get; set; }

        public string TotalSectionAllocation { get; set; }

        public int TotalStrength { get; set; }

    }
}
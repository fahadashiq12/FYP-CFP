using System;

using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstApproachPrac.DbContext.DbModels
{
    public class AcademicCredential : BaseDbModels.BaseDbClass
    {
        public string InstituteName { get; set; }
        public DateTime Year { get; set; }

        public string Comments { get; set; }

        public virtual Person Person { get; set; }

    }
}
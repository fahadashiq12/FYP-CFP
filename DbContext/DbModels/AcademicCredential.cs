using System;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirstApproachPrac.DbContext.DbModels
{
    public class AcademicCredential : BaseDbModels.BaseDbClass
    {
        public string InstituteName { get; set; }
        public DateTime Year { get; set; }
        public string Comments { get; set; }
        [ForeignKey("PersonId")] public virtual Person Person { get; set; }

    }
}
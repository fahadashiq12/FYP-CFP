using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstApproachPrac.DbContext.DbModels
{
    public class CBTEntranceResult : BaseDbModels.BaseDbClass
    {
        public string Score { get; set; }

        public string Comment { get; set; }

        public long StudentId { get; set; }
        [ForeignKey("StudentId")] public virtual Student Student { get; set; }
    }
}
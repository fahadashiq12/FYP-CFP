using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirstApproachPrac.DbContext.DbModels
{
    public class TestSchedule : BaseDbModels.BaseDbClass
    {
        public DateTime ExamDate { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        [ForeignKey("EntranceTestVenue")] public virtual EntranceTestVenue EntranceTestVenue { get; set; }

    }
}
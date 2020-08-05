using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstApproachPrac.DbContext.DbModels
{
    public class CBTExamSchedule : BaseDbModels.BaseDbClass
    {
        public DateTime ExamDay { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
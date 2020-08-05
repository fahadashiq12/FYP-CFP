using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstApproachPrac.DbContext.DbModels
{
    public class TestGrade : BaseDbModels.BaseDbClass
    {
        public string Grade { get; set; }
        public string Section { get; set; }
        [ForeignKey("StudentId")] public virtual Student Student { get; set; }
    }
}
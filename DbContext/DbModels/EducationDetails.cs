using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirstApproachPrac.DbContext.DbModels
{
    public class EducationDetails : BaseDbModels.BaseDbClass
    {
        public string DegreeName { get; set; }

        public int MarksObtained { get; set; }

        public DateTime  GraduationYear { get; set; }

        public string Status { get; set; }


        [ForeignKey("StudentId")] public virtual Student Student { get; set; }

    }
}
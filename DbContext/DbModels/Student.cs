using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.DynamicData;

namespace CodeFirstApproachPrac.DbContext.DbModels
{
    [TableName("Students")]
    public class Student : Person
    {
        public DateTime EnrollmentDate { get; set; }

        [ForeignKey("ProgramId")] public virtual Program Program { get; set; }

        [ForeignKey("SectionId")] public virtual Section Section { get; set; }

        [ForeignKey("PersonId")] public virtual Person Person { get; set; }
    }
}
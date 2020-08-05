using System;
using System.Web.DynamicData;

namespace CodeFirstApproachPrac.DbContext.DbModels
{
    [TableName("Students")]
    public class Student : Person
    {
        public DateTime EnrollmentDate { get; set; }
    }
}
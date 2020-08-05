using System.Collections.Generic;

namespace CodeFirstApproachPrac.DbContext.DbModels
{
    public class Grade : BaseDbModels.BaseDbClass
    {
        public string GradeName { get; set; }
        public string Section { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
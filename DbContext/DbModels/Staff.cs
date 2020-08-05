using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.DynamicData;

namespace CodeFirstApproachPrac.DbContext.DbModels
{
    [TableName("Staff")]
    public class Staff : Person
    {
        public string Designation { get; set; }

        [ForeignKey("PersonId")] public virtual Person Person { get; set; }
    }
}
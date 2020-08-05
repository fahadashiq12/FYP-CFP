using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.DynamicData;

namespace CodeFirstApproachPrac.DbContext.DbModels
{
    [TableName("Persons")]
    public class Person : BaseDbModels.BaseDbClass
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public byte[] Photo { get; set; }
        public int DateOfBirth { get; set; }
        public string CNIC { get; set; }
        public long? ApplicationUserId { get; set; }
        [ForeignKey("ApplicationUserId")] public virtual ApplicationUser ApplicationUser { get; set; }
        public long? AddressId { get; set; }
        [ForeignKey("AddressId")] public virtual Address Address { get; set; }
        public long? PersonId { get; set; }
        [ForeignKey("PersonContactId")] public virtual PersonContact PersonContact { get; set; }

    }
}
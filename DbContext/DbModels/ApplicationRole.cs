using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirstApproachPrac.DbContext.DbModels
{
    public class ApplicationRole : BaseDbModels.BaseDbClass
    {
        public string RoleName { get; set; }
        
        public string RoleDescription { get; set; }

        public string RoleValue { get; set; }

       [ForeignKey("ApplicationUserId" )] public virtual ApplicationUser ApplicationUser { get; set; }

       // [ForeignKey("ApplicationRoleId")] public virtual ApplicationRole ApplicationRoles { get; set; }
    }
}
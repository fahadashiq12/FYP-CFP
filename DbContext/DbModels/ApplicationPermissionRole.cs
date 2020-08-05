using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirstApproachPrac.DbContext.DbModels
{
    public class ApplicationPermissionRole : BaseDbModels.BaseDbClass
    {

        [ForeignKey("ApplicationPermissionId")] public virtual ApplicationPermission ApplicationPermission { get; set; }

        [ForeignKey("ApplicationRoleId")] public virtual ApplicationRole ApplicationRole { get; set; }

    }
}
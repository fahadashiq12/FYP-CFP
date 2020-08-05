using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirstApproachPrac.DbContext.DbModels
{
    public class ApplicationPermission : BaseDbModels.BaseDbClass
    {
        public string PermissionName { get; set; }

        public string PermissionDescription { get; set; }

    }
}
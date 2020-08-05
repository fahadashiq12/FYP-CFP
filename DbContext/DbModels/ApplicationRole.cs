using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstApproachPrac.DbContext.DbModels
{
    public class ApplicationRole : BaseDbModels.BaseDbClass
    {
        public string RoleName { get; set; }
        
        public string RoleValue { get; set; }

        public string RoleDescription { get; set; }


    }
}
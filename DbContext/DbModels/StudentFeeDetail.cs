using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.SqlServer.Server;

namespace CodeFirstApproachPrac.DbContext.DbModels
{
    public class StudentFeeDetail : BaseDbModels.BaseDbClass
    {
        public string FeeChallanImage { get; set; }

        public string StudentName { get; set; }
    }
}
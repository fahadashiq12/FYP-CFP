using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using Microsoft.SqlServer.Server;

namespace CodeFirstApproachPrac.DbContext.DbModels
{
    public class ChallanForm : BaseDbModels.BaseDbClass
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public int CNIC { get; set; }
        public int RegistNumber { get; set; }
        public string Dist { get; set; }
        public string Challanfor { get; set; }
        public string Branch { get; set; }
        public int SecurityCode { get; set; }
    }
}
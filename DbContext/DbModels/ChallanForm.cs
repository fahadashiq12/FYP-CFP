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
        public string Refnumber { get; set; }
        public DateTime CreationDate { get; set; }
        public int Amount { get; set; }
        public int RegistNumber { get; set; }
        public string Dist { get; set; }
        public string Challanfor { get; set; }
     
    }
}
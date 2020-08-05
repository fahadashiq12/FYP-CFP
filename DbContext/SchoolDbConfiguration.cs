using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirstApproachPrac.DbContext
{
    public class SchoolDbConfiguration : CreateDatabaseIfNotExists<SchoolDbContext>
    {
        protected override void Seed(SchoolDbContext context)
        {
            base.Seed(context);
        }
    }
}
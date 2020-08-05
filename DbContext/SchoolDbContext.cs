using System.Data.Entity;
using CodeFirstApproachPrac.DbContext.DbModels;

namespace CodeFirstApproachPrac.DbContext
{
    public class SchoolDbContext : System.Data.Entity.DbContext
    {
        public SchoolDbContext() : base("name=SchoolDBConnectionString")
        {
            Database.SetInitializer<SchoolDbContext>(new SchoolDbConfiguration());
        }
        public DbSet<DbModels.Person> Persons { get; set; }
        public DbSet<DbModels.Student> Students { get; set; }
        public DbSet<DbModels.Staff> Staffs { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
         
            // modelBuilder.Entity<Student>()
            //     .HasRequired(f => f.Grade)
            //     .WithMany(f => f.Students)
            //     .HasForeignKey(f => f.GradeId)
            //     .WillCascadeOnDelete(false);
        }
    }
}
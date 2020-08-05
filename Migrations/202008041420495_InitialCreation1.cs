namespace CodeFirstApproachPrac.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreation1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Candidates",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        PersonId = c.Long(nullable: false),
                        CreatedBy = c.Long(),
                        CreatedDate = c.DateTime(),
                        UpdatedBy = c.Long(),
                        UpdatedDate = c.DateTime(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.PersonId, cascadeDelete: true)
                .Index(t => t.PersonId);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        FirstName = c.String(),
                        MiddleName = c.String(),
                        LastName = c.String(),
                        EnrollmentDate = c.DateTime(nullable: false),
                        Photo = c.Binary(),
                        Height = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Weight = c.Single(nullable: false),
                        GradeId = c.Long(nullable: false),
                        TestMark = c.Int(nullable: false),
                        CreatedBy = c.Long(),
                        CreatedDate = c.DateTime(),
                        UpdatedBy = c.Long(),
                        UpdatedDate = c.DateTime(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Grades", t => t.GradeId, cascadeDelete: true)
                .Index(t => t.GradeId);
            
            CreateTable(
                "dbo.Staffs",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Photo = c.Binary(),
                        Height = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Weight = c.Single(nullable: false),
                        Role = c.String(),
                        CreatedBy = c.Long(),
                        CreatedDate = c.DateTime(),
                        UpdatedBy = c.Long(),
                        UpdatedDate = c.DateTime(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Students", "Age", c => c.Int(nullable: false));
            AddColumn("dbo.Students", "EnrollmentDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Students", "TestMark", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.People", "GradeId", "dbo.Grades");
            DropForeignKey("dbo.Candidates", "PersonId", "dbo.People");
            DropIndex("dbo.People", new[] { "GradeId" });
            DropIndex("dbo.Candidates", new[] { "PersonId" });
            DropColumn("dbo.Students", "TestMark");
            DropColumn("dbo.Students", "EnrollmentDate");
            DropColumn("dbo.Students", "Age");
            DropTable("dbo.Staffs");
            DropTable("dbo.People");
            DropTable("dbo.Candidates");
        }
    }
}

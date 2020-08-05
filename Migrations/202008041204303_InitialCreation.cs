namespace CodeFirstApproachPrac.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Grades",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        GradeName = c.String(),
                        Section = c.String(),
                        CreatedBy = c.Long(),
                        CreatedDate = c.DateTime(),
                        UpdatedBy = c.Long(),
                        UpdatedDate = c.DateTime(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        DateOfBirth = c.DateTime(),
                        Photo = c.Binary(),
                        Height = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Weight = c.Single(nullable: false),
                        GradeId = c.Long(nullable: false),
                        CreatedBy = c.Long(),
                        CreatedDate = c.DateTime(),
                        UpdatedBy = c.Long(),
                        UpdatedDate = c.DateTime(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Grades", t => t.GradeId)
                .Index(t => t.GradeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "GradeId", "dbo.Grades");
            DropIndex("dbo.Students", new[] { "GradeId" });
            DropTable("dbo.Students");
            DropTable("dbo.Grades");
        }
    }
}

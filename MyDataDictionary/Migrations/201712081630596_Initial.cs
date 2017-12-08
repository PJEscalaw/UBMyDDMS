namespace MyDataDictionary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Problems",
                c => new
                    {
                        ProblemsID = c.Int(nullable: false, identity: true),
                        ProblemName = c.String(),
                        Description = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                        Severity = c.String(),
                        DateResolved = c.DateTime(nullable: false),
                        StatusID = c.Int(nullable: false),
                        Flag = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProblemsID)
                .ForeignKey("dbo.Status", t => t.StatusID, cascadeDelete: true)
                .Index(t => t.StatusID);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        StatusID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Flag = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StatusID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Problems", "StatusID", "dbo.Status");
            DropIndex("dbo.Problems", new[] { "StatusID" });
            DropTable("dbo.Status");
            DropTable("dbo.Problems");
        }
    }
}

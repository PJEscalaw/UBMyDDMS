namespace MyDataDictionary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reports",
                c => new
                    {
                        ReportsID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ReporterFor = c.String(),
                        Navigation = c.String(),
                        FieldName = c.String(),
                        Path = c.String(),
                        Calculation = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                        Flag = c.Int(nullable: false),
                        UsersID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ReportsID)
                .ForeignKey("dbo.Users", t => t.UsersID, cascadeDelete: true)
                .Index(t => t.UsersID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UsersID = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                        Flag = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UsersID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reports", "UsersID", "dbo.Users");
            DropIndex("dbo.Reports", new[] { "UsersID" });
            DropTable("dbo.Users");
            DropTable("dbo.Reports");
        }
    }
}

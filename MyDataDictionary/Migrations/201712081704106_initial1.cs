namespace MyDataDictionary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Letters",
                c => new
                    {
                        LettersID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Navigation = c.String(),
                        FieldName = c.String(),
                        Path = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                        Flag = c.Int(nullable: false),
                        UsersID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LettersID)
                .ForeignKey("dbo.Users", t => t.UsersID, cascadeDelete: true)
                .Index(t => t.UsersID);
            
            CreateTable(
                "dbo.Severities",
                c => new
                    {
                        SeveritiesID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Flag = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SeveritiesID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Letters", "UsersID", "dbo.Users");
            DropIndex("dbo.Letters", new[] { "UsersID" });
            DropTable("dbo.Severities");
            DropTable("dbo.Letters");
        }
    }
}

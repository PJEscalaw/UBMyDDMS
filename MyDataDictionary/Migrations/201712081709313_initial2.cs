namespace MyDataDictionary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Problems", "UsersID", c => c.Int(nullable: false));
            AddColumn("dbo.Problems", "SeveritiesID", c => c.Int(nullable: false));
            CreateIndex("dbo.Problems", "UsersID");
            CreateIndex("dbo.Problems", "SeveritiesID");
            AddForeignKey("dbo.Problems", "SeveritiesID", "dbo.Severities", "SeveritiesID", cascadeDelete: true);
            AddForeignKey("dbo.Problems", "UsersID", "dbo.Users", "UsersID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Problems", "UsersID", "dbo.Users");
            DropForeignKey("dbo.Problems", "SeveritiesID", "dbo.Severities");
            DropIndex("dbo.Problems", new[] { "SeveritiesID" });
            DropIndex("dbo.Problems", new[] { "UsersID" });
            DropColumn("dbo.Problems", "SeveritiesID");
            DropColumn("dbo.Problems", "UsersID");
        }
    }
}

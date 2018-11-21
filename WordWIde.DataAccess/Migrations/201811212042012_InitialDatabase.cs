namespace WordWIde.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Words",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EnglishWord = c.String(nullable: false, maxLength: 50),
                        TranslateWord = c.String(maxLength: 50),
                        IsKnown = c.Boolean(nullable: false),
                        Progress = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Words");
        }
    }
}
